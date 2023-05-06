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