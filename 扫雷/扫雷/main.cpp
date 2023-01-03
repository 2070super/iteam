#include"game.h"

int main(){
	int select = 0;
	while (1)
	{
		menu();
		scanf("%d", &select);
		if (select == 1)
			game();
		if (select == 2)
			break;
	}
	system("pause");

}