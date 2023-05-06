#pragma once
#include<iostream>
using std::cout;
using std::endl;
template<class T>
class pool
{
public:
	T* New()
	{//如果有空闲的块
		T * obj = nullptr;
		if (_freelist)
		{
			void* next = *(void**)_freelist;
			obj = (T*)_freelist;
			_freelist = next;
			return obj;
		}
		//剩余内存不够大的时候，则重新开大块空间
		else if (_remainbytes < sizeof(T))
		{
			if (_memory == nullptr)
			{
				_memory = (char*)malloc(128 * 1024);
				if (_memory == nullptr)
				{
					throw std::bad_alloc();
				}
				_remainbytes = 128 * 1024;
			}
			obj = (T*)_memory;
			size_t objsize = sizeof(T) < sizeof(void*) ? sizeof(void*) : sizeof(T);
			_memory += objsize;
			_remainbytes -= objsize;
		}
		new(obj)T;
		return obj;
	}
	void Delete(T* obj)
	{
		obj->~T();//如果遇到类如string vector类型就必须要调用
		*(void**)obj = _freelist;
		_freelist = obj;
	}
private:
	char* _memory=nullptr;//因为char一个字节，是最小单位。
	size_t _remainbytes = 0;//剩余字节的数量
	void* _freelist=nullptr;//还回内存链表的指针
};