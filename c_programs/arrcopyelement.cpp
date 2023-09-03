#include<stdio.h>
int main()
{
	int i, arr1[5],arr2[5];
	for(i=0;i<5;i++)
	{
		printf("enter a num");
		scanf("%d",&arr1[i]);
	}
	for(i=0;i<5;i++)
	{
		arr2[i]= arr1[i];
		printf("\n ellement of arr1");
		for(i=0;i<5;i++)
		{
		printf("\n%d",arr1[i]);
		}
		printf("\n element of arr2");
		for(i=0;i<5;i++)
		{
			printf("\n %d",arr2[i]);
		}
	}
}
