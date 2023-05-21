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
//��������С�Ķ���ӳ�����
//tls thread local storage
static _declspec(thread) Threadcache* pTLSThreadcache = nullptr;