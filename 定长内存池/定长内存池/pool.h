#pragma once
#include<iostream>
using std::cout;
using std::endl;
template<class T>
class pool
{
public:
	T* New()
	{//����п��еĿ�
		T * obj = nullptr;
		if (_freelist)
		{
			void* next = *(void**)_freelist;
			obj = (T*)_freelist;
			_freelist = next;
			return obj;
		}
		//ʣ���ڴ治�����ʱ�������¿����ռ�
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
		obj->~T();//�����������string vector���;ͱ���Ҫ����
		*(void**)obj = _freelist;
		_freelist = obj;
	}
private:
	char* _memory=nullptr;//��Ϊcharһ���ֽڣ�����С��λ��
	size_t _remainbytes = 0;//ʣ���ֽڵ�����
	void* _freelist=nullptr;//�����ڴ������ָ��
};