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
{
	return nullptr;
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


