#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<math.h>
#include<time.h>
//×Ö·û´®²éÕÒ×Ö·û´®
char* my__strstr(char* str, char* dest)
{
	char* front = str;
	char* slow = str;
	char* tdest = dest;
	while (*front)
	{
		slow = front;
		while (*front == *tdest)
		{
			*front++;
			*tdest++;
		}
		if (*tdest == '\0')
		{
			return slow;
		}
		front = slow;
		tdest = dest;
		front++;
	}
	return NULL;
}
int main()
{
	char str[] = "helloworld";
	char dest[] = "llo";
	char* p = my__strstr(str, dest);
	printf("%s\n", p);
	return EXIT_SUCCESS;

}