#include<stdio.h>
int main()
{
int arr[3][3];
int row,col;
for(row=0;row<3;row++)
{
	for(col=0;col<3;col++)
	{
		printf("enter num");
		scanf("%d",&arr[row][col]);
	}
}
		for(row=0;row<3;row++)
		{
			for(col=0;col<3;col++)
			{
				printf("\n arr[%d][%d]=%d",row,col,arr[row][col]);
			}
		}
	}
