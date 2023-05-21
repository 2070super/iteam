#include"centralcache.h"

centralcache* centralcache::getinstance()
{
	return &_sinst;
}

size_t centralcache::FetchRangeObj(void*& start, void*& end, size_t n, size_t byte_size)
{
	return size_t();
}
