#pragma once
#include<iostream>
#include<vector>
#include<time.h>
#include <cassert>
using std::cout;
using std::endl;
void*& nextobj(void* obj)
{
	return *(void**)obj;
}
class freelist//管理切分好的自由链表
{
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
	}
private:
	void* _freelist;
};