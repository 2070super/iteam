#include"game.h"
#pragma warning (disable:4996)
void menu()
{
	while (1)
	{
		printf("��ӭ����\n");
		printf("1.play    2.exit\n");
		printf("��ѡ��");
		int i;
		scanf("%d", &i);
		if (i == 1)
			game();
		if (i == 2)
			break;

}
	

	

}