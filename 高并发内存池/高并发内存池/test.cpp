#include"Concurrentalloc.h"
void alloc1()
{
	for (size_t i = 0; i < 5; i++)
	{
		void*ptr=concurrentalloc(6);
	}
}
void alloc2()
{
	for (size_t i = 0; i < 5; i++)
	{
		void* ptr = concurrentalloc(7);
	}
}
void tlstest()
{
	std::thread t1(alloc1);
	std::thread t2(alloc2);
	t1.join();
	t2.join();
}
int main()
{
	tlstest();
}