#include"game.h"
#pragma warning (disable:4996)
void show(char arr[][3])
{
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
			printf("%c|", arr[i][j]);
	printf("\n\r");}
}
void play(char arr[][3])
{
	int x, y;
	while (1)
	{
		printf("请选择你要下的行数：");
		scanf("%d", &x);
		printf("请选择你你要下的列数：");
		scanf("%d", &y);
		if (x > 3 || y > 3)
		{
			printf("你输入的数超过棋盘大小！");
			continue;
		}
		else
			if (arr[x - 1][y - 1] != ' ')
			{
				printf("该格已被占用");
				continue;
			}
			else
				arr[x - 1][y - 1] =player;
		break;
	}
}
void pc(char arr[][3])
{
	void srand(unsigned int seed);
	int x, y;
	
	while (1)
	{
		x = rand() % 4;
		y = rand() % 4;

		if (arr[x - 1][y - 1] != ' ')
		{
			continue;
		}
		else
			arr[x - 1][y - 1] = computer;
		break;
	}
}
char judge(char arr[][3])
{
	char flag = 0;
	for(int i=0;i<3;i++)
{
		if (arr[0][i] == arr[1][i] && \
			arr[1][i] == arr[2][i] && \
			arr[1][i] != ' ')
		{
			flag = arr[1][i];
			break;

		}
	}
	for (int j = 0; j < 3; j++)
	{
		if(arr[j][0]==arr[j][1]&&\
			arr[j][2] == arr[j][1] && \
			arr[j][0] !=' ')
		{
			flag = arr[j][0];
			break;
		}
		
	}if(arr[0][0]==arr[1][1]&&\
			arr[2][2] == arr[1][1] && \
			arr[0][0] !=' ')
	{
		flag = arr[0][0];
	
	}
		if (arr[0][2] == arr[1][1] && \
			arr[1][1] == arr[2][0] && \
			arr[1][1] !=' ')
		{
			flag = arr[0][2];
		}
		if(flag==0)
		{
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
				{
					if (arr[i][j] == ' ')
					{
						flag = 2;
						break;
					}
				}
			 
		}
		return flag;
}

void game()
{
	char arr[3][3];
	for (int i = 0; i < 3; i++)
		for (int j = 0; j < 3; j++)
			arr[i][j] = ' ';
	while (1)
	{
		play(arr);
		printf("*******************************\n");
		show(arr);
		char i=judge(arr);
		if (i != 2 && i != 'o' && i != 'x')
		{
			printf("和棋");
			break;
		}
		if (i == 'o')
		{
			printf("你胜了！");
			break;
		}
		if(i=='x')
		{
			printf("你输了！");
			break;
		}
		
		pc(arr);
		printf("*******************************\n");
		show(arr);
		 i=judge(arr);
		if (i !=2&&i!='o'&&i!='x')
		{
			printf("和棋");
			break;
		}
		if (i == 'o')
		{
			printf("你胜了！");
			break;
		}
		if (i == 'x')
		{
			printf("你输了！");
			break;
		}
	}
}