#pragma once
#include<assert.h>
#include <utility>
namespace bit
{
	template<class T>
	class vector
	{
		
	public:
		typedef T* iterator;
		vector();
		~vector();
		vector(size_t a, const T& x);
		void push_back(const T& x);
		void check_vector();
		size_t capacity();
		size_t size();
		void reserve(size_t s);
		iterator begin()
		{
			return _start;
		}
		iterator end()
		{
			return _finish;
		}
		T& operator[](size_t pos);
		void pop_back();
		void insert(iterator& pos, const T& x);//insert���ݾͻᵼ��itʧЧ��
		//����취�������²�������λ�õĵ�������return pos;
		void erase(iterator pos);//erase���itҲ��ʧЧ��it��������һ�����ݣ���ôɾ����it��ʧЧ�ˡ�
		void resize(size_t n,const T& val=T());//T()���ÿյĹ��캯������Ϊȱʡֵ
	private:
		iterator _start;
		iterator _finish;
		iterator _endofstorage;
	};
}