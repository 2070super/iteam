#pragma once
#include<iostream>
#include<vector>
#include<time.h>
#include <cassert>
#include <thread>
#include<mutex>
#ifdef _WIN64
typedef unsigned long long	PAGE_ID;
#elif _WIN32
typedef size_t PAGE_ID;
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
class freelist//�����зֺõ���������
{
public:
	void push(void *obj)//ͷ��
	{
		assert(obj);
		nextobj(obj) = _freelist;
		_freelist = obj;
	}
	void* pop()//ͷɾ
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
	// ������12%���ҵ�����Ƭ�˷�
	// [1,128] 8byte���� freelist[0,16)
	// [129,1024] 16byte���� freelist[16,72)
	// [1025,8*1024] 128byte���� freelist[72,128)
	// [8*1024+1,64*1024] 1024byte���� freelist[128,184)
public:
	size_t _roundup(size_t size, size_t alignnum);
	size_t roundup(size_t size);
	static inline size_t _Index(size_t bytes, size_t align_shift)
	{
		return ((bytes + (1 << align_shift) - 1) >> align_shift) - 1;
	}

	static inline size_t Index(size_t bytes)
	{

		// ÿ�������ж��ٸ���
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
//�����ڴ�ҳ�Ŀ��
struct span
{
	size_t _pageid=0;//ҳ��
	size_t _n=0;//ҳ������
	span* _next=nullptr;//˫������Ľṹ
	span* _prev=nullptr;
	size_t _usecount=0;//�кõ��ڴ�
	void* _freelist=nullptr;//�кõ�С���ڴ������
};
//˫��ѭ������
class spanlist
{
public:
	spanlist()
	{
		_head = new span;
		_head->_next = _head;
		_head->_prev = _head;
	}
	void insert(span* pos, span* newspan)
	{
		assert(pos);
		assert(newspan);
		span* prev = pos->_prev;
		prev->_next = newspan;
		newspan->_prev = prev;
		newspan->_next = pos;
		pos->_prev = newspan;
	}
	void erase(span* pos)
	{
		assert(pos && pos != _head);
			span* prev = pos->_prev;
			span* next = pos->_next;
			prev->_next = next;
			next->_prev = prev;
			pos->_next = nullptr;
			pos->_prev = nullptr;

	}
private:
	span* _head = nullptr;
	std::mutex _mtx;//��
};
static size_t nummovesize(size_t size)//����ʼ���������㷨
{
	assert(size > 0);//С������Ķ࣬����������
	int num = MAX_BYTES / size;
	if (num < 2)
	{
		num = 2;
	}
	if (num > 512)
	{
		num = 2;
	}
	return num;
}