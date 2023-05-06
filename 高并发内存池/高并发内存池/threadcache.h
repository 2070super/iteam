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
//计算对象大小的对齐映射规则
class sizeclass
{
// 控制在12%左右的内碎片浪费
// [1,128] 8byte对齐 freelist[0,16)
// [129,1024] 16byte对齐 freelist[16,72)
// [1025,8*1024] 128byte对齐 freelist[72,128)
// [8*1024+1,64*1024] 1024byte对齐 freelist[128,184)
public:
	size_t _roundup(size_t size,size_t alignnum);
	size_t roundup(size_t size);

private:

};