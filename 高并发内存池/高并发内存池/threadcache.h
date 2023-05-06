#pragma once
#include"common.h"
class Threadcache
{
public:
	void* allocate(size_t size);
	void deallocaate(void* ptr, size_t size);
private:
	freelist _freelists[];
};
//��������С�Ķ���ӳ�����
class sizeclass
{
// ������12%���ҵ�����Ƭ�˷�
// [1,128] 8byte���� freelist[0,16)
// [129,1024] 16byte���� freelist[16,72)
// [1025,8*1024] 128byte���� freelist[72,128)
// [8*1024+1,64*1024] 1024byte���� freelist[128,184)
public:
	size_t _roundup(size_t size,size_t alignnum);
	size_t roundup(size_t size);

private:

};