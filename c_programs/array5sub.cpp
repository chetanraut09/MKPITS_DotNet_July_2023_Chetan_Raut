#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[5];
	for(i=0;i<5;i++)
	{
		printf("enter a marks");
		scanf("%d",&marks[i]);
	}
	for(i=0;i<5;i++)
	{
		printf("\n marks=%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\n total marks=%d",sum);
}
