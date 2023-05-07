#pragma once
#include<iostream>
#include<vector>
#include<time.h>
#include <cassert>
static const size_t MAX_BYTES = 256 * 1024;
static const size_t NFREELISTS = 208;
static const size_t NPAGES = 129;
using std::cout;
using std::endl;
void*& nextobj(void* obj)
{
	return *(void**)obj;
}
class freelist//�����зֺõ���������
{
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
	}
private:
	void* _freelist;
};
