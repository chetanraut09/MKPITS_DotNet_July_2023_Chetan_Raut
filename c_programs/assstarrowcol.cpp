#include<stdio.h>
int main()
{
	int row, col, spc,k;
	for(row=1;row<=3;row++)
	{
		for(k=spc;k>=1;k--)
		{
			printf(" ");
		}
		for(col=1;col<=row;col++)
		{
			printf("* ",col);
		}
		spc--;
		printf("\n");
	}
}
