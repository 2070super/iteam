#include"game.h"
void menu()
{
	printf("#####################################\n");
	printf("####1.play             2.exit########\n");
	printf("#####################################\n");

}
void setmine(char mine_board[][COL], int row, int col)
{
	int count = nums;
	while (count)
	{
		int x = rand() % 10 + 1;
		int y = rand() % 10 + 1;
		if (mine_board[x][y] == '0')
		{
			mine_board[x][y] = '1';
			count--;
		}
	}
}
int getmine(char mine_board[][COL], int row, int col, int x, int y)
{
	return mine_board[x - 1][y - 1] + mine_board[x - 1][y] + mine_board[x - 1][y + 1] + \
		mine_board[x][y - 1] + mine_board[x][y + 1] + mine_board[x + 1][y - 1] + \
		mine_board[x + 1][y] + mine_board[x + 1][y + 1]-8*'0';
}
void showboard(char board[][COL],int row,int col)
{
	printf(" ");
	for (int i = 1; i < row-1; i++)
	{
		printf("%2d", i);
	}
	printf("\n");
	for (int i = 1; i < row; i++)
	{
		printf("%2d|", i);
		for (int j = 1; j < col - 1; j++)
		{
			printf("%c|", board[i][j]);
		}
		printf("\n");
	}
}
void game()
{
	char show_board[ROW][COL];
	char mine_board[ROW][COL];
	memset(show_board, '*', sizeof(show_board));
	memset(mine_board, '0',sizeof(mine_board));
	setmine(mine_board,ROW,COL);
	int count = (ROW - 2) * (COL - 2)-nums;
	do
	{	
		int x = 0, y = 0;
		showboard(show_board,ROW,COL);
		printf("请输入选择的位置:\n");
		scanf("%d %d", &x, &y);
		if (x < 1 || x>10||y<1||y>10)
		{
			printf("输入越界，请重新输入\n");
			continue;
		}
		if (show_board[x][y] != '*')
		{
			printf("您已选择过该位置，请重新输入\n");
			continue;
		}
		if (mine_board[x][y] == '1')
		{
			printf("game over\n");
			showboard(mine_board, ROW, COL);
			printf("\n");
			break;
		}
		int num = getmine(mine_board,ROW,COL,x, y);
		printf("num=%d", num);
		show_board[x][y] = num + '0';
		count--;
	} while (count >0);
	if(count==0)
	{
		printf("你赢了！\n");
		showboard(mine_board, ROW, COL);
		printf("\n");
	}
	
}	