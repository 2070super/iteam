#pragma once
#include"common.h"
#include"centralcache.h"
class Threadcache
{
public:
	void* allocate(size_t size);
	void deallocate(void* ptr, size_t size);
	void* fetchfromcentralcache(size_t index, size_t size);
private:
	freelist _freelists[NFREELISTS];
};
//计算对象大小的对齐映射规则
//tls thread local storage
static _declspec(thread) Threadcache* pTLSThreadcache = nullptr;