#include "threadcache.h"

size_t sizeclass::roundup(size_t size)
{
	if (size <= 128)
	{
		return _roundup(size, 8);
	}
	else if (size <= 1024)
	{
		return _roundup(size, 16);
	}
	else if (size <= 8 * 1024)
	{
		return _roundup(size, 128);
	}
	else if (size <= 64 * 1024)
	{
		return _roundup(size, 1024);
	}
	else if (size <= 256 * 1024)
	{
		return _roundup(size, 8 * 1024);
	}
	else
	{
		assert(false);
		return -1;
	}
}

void* Threadcache::allocate(size_t size)
{
	assert(size <= 256 * 1024);
	sizeclass a;
	size_t alignsize = a.roundup(size);
	size_t index = sizeclass::Index(size);
	if (!_freelists[index].Empty())
	{
		return _freelists[index].pop();
	}
	else
	{
		return fetchfromcentralcache(index, alignsize);
	}
}
void Threadcache::deallocate(void* ptr, size_t size)
{
	assert(size <= MAX_BYTES);
	assert(ptr);
	size_t index = sizeclass::Index(size);
	_freelists[index].push(ptr);
}
void* Threadcache::fetchfromcentralcache(size_t index, size_t size)
/*慢开始算法
 1.第一次申请central cache不会给的太多，因为可能用不完。
 2.如果不断地申请，那么batchnum就会不断地增长，直到上限。
 3.size越大，一次向central cache要的batchnum就越小
 4.size越小，一次向central cache要的batchnum就越大
 */
{
	size_t batchnum = std::min(sizeclass::nummovesize(size),_freelists[index].maxsize());
	if (_freelists[index].maxsize() == batchnum)
	{
		_freelists[index].maxsize() += 1;
	}
	void* start = nullptr;
	void* end = nullptr;
	size_t actualnum=centralcache::getinstance()->FetchRangeObj(start,end,batchnum,size);
	assert(actualnum > 1);
	if (actualnum == 1)
	{
		assert(start == end);

	}
}
size_t sizeclass::_roundup(size_t size, size_t alignnum)
{
	size_t alignsize;
	if (size % alignnum!=0)
	{
		alignsize = (size / alignnum + 1) * alignnum;
	}
	else
	{
		alignsize = size;
	}
	return alignsize;
}


