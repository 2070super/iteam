#pragma once
#include"common.h"
class Threadcache
{
public:
	void* allocate(size_t size);
	void deallocaate(void* ptr, size_t size);
private:
	freelist _freelists[NFREELISTS];
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
	size_t _Index(size_t size)
	{
		if (size % 8 == 0)
		{
			return size / 8 - 1;
		}
		else
		{
			return size / 8;
		}
	}

	static inline size_t Index(size_t bytes)
	{

		// 每个区间有多少个链
		static int group_array[4] = { 16, 56, 56, 56 };
		if (bytes <= 128) {
			return _Index(bytes, 3);
		}
		else if (bytes <= 1024) {
			return _Index(bytes - 128, 4) + group_array[0];
		}
		else if (bytes <= 8192) {
			return _Index(bytes - 1024, 7) + group_array[1] + group_array[0];
		}
		else if (bytes <= 65536) {
			return _Index(bytes - 8192, 10) + group_array[2] + group_array[1] + group_array[0];
		}
		assert(false);
		return -1;
	}

};