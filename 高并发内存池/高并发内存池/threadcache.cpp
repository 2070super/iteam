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
	assert(size<=256 * 1024);
	sizeclass a;
	size_t alignsize = a.roundup(size);
	size_t index=a.
}

void Threadcache::deallocaate(void* ptr, size_t size)
{

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


