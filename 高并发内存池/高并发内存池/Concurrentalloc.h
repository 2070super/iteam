#pragma once
#include"common.h"
#include"threadcache.h"
static void* concurrentalloc(size_t size)
{
	if (pTLSThreadcache == nullptr)
	{
		pTLSThreadcache = new Threadcache;
	}
	return pTLSThreadcache->allocate(size);
}
static void* concurrentfree(void* ptr)
{
	assert(pTLSThreadcache);
	pTLSThreadcache->deallocate(ptr,);
}
