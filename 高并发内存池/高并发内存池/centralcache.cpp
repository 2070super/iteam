#include"centralcache.h"

centralcache* centralcache::getinstance()
{
	return &_sinst;
}
