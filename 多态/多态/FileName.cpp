#include<iostream>
using namespace std;
class person
{
public:
	virtual void buyticket()
	{
		cout << "��Ʊȫ��" << endl;
	}
};
class person1
{
public:
	virtual void buyticket()
	{
		cout << "��Ʊȫ��" << endl;
	}
};
class student :public person
{
public:
	virtual void buyticket()//�����Ϊ��̬
	{
		cout << "��Ʊ���" << endl;
	}
};
class student1 :public person
{
public:
	void buyticket()//�����Ϊ��̬,�̳л�����麯��
	{
		cout << "��Ʊ���" << endl;
	}
};
class student2 :public person1
{
public:
	void buyticket()//���ػ���ĺ�����
	{
		cout << "��Ʊ���" << endl;
	}
};
void func(person& people)//(person *people)
//������(person people)������ֱ��ǿת��person
{
	people.buyticket();
}
int main()
{
	person people1;
	student people2;
	func(people1);
	func(people2);
	return 0;
}