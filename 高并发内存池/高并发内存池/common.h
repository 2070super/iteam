#pragma once
#include<iostream>
#include<vector>
#include<time.h>
#include <cassert>
#include <thread>
#ifdef _WIN32
typedef size_t PAGE_ID;
#elif _WIN64
typedef unsigned long long	PAGE_ID;
#endif
static const size_t MAX_BYTES = 256 * 1024;
static const size_t NFREELISTS = 208;
static const size_t NPAGES = 129;
using std::cout;
using std::endl;
static void*& nextobj(void* obj)
{
	return *(void**)obj;
}
class freelist//管理切分好的自由链表
{
public:
	void push(void *obj)//头插
	{
		assert(obj);
		nextobj(obj) = _freelist;
		_freelist = obj;
	}
	void* pop()//头删
	{
		void* obj = _freelist;
		_freelist = nextobj(obj);
		return obj;
	}
	bool Empty()
	{
		return _freelist == nullptr;

	}
private:
	void* _freelist=nullptr;
};
class sizeclass
{
	// 控制在12%左右的内碎片浪费
	// [1,128] 8byte对齐 freelist[0,16)
	// [129,1024] 16byte对齐 freelist[16,72)
	// [1025,8*1024] 128byte对齐 freelist[72,128)
	// [8*1024+1,64*1024] 1024byte对齐 freelist[128,184)
public:
	size_t _roundup(size_t size, size_t alignnum);
	size_t roundup(size_t size);
	static inline size_t _Index(size_t bytes, size_t align_shift)
	{
		return ((bytes + (1 << align_shift) - 1) >> align_shift) - 1;
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
//管理内存页的跨度
struct span
{
	size_t _pageid;

};