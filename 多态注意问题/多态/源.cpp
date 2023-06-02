#include<iostream>
using namespace std;
class base1
{
public:
	base1()
	{
		a = 0;
	}
	virtual void func1() { cout << "base::func1" << endl; }
	virtual void func2() { cout << "base::func2" << endl; }
private:
	int a;
};
class base2
{
public:
	base2()
	{
		b = 0;
	}
	virtual void func1() { cout << "base::func1" << endl; }
	virtual void func2() { cout << "base::func2" << endl; }
private:
	int b;
};
class derive :public base1,public base2
{
public:
	virtual void func1(){cout << "derive::func1" << endl;}
	virtual void func3(){ cout << "derive::func3" << endl; }
	void func4() { cout << "derive::func4" << endl; }
	
};
typedef void(*VF_PTR)();//������ָ��
void print(VF_PTR* table)
{
	for (int i = 0; table[i] != nullptr; i++)
	{
		printf("vft[%d]:%p->", i, table[i]);
		VF_PTR f = table[i];
		f();

	}
	cout << endl << endl;
}
int man()
{
	derive c;
	print((VF_PTR*)*((void**)&c));//64λ�����һ�а��ֽڣ�32λ�������һ���ĸ��ֽ�
	//print((VF_PTR*)*((void**)(&c + sizeof(base1))));���ʹ�ø��лᵼ��Խ�磬��32λ�£�����sizeof��base1����8��c��derive���ͣ�ռ�˸��ֽڣ�����ֱ�ӻᵼ�¼�derive*8���ֽڡ�
	print((VF_PTR*)*((void**)((char*) & c + sizeof(base1))));
	base2 *p = &c;
	print((VF_PTR*)*((void**)p));
	return 0;
}