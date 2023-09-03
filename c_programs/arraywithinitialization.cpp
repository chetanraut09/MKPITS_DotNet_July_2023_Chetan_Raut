#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[3]={80,90,100};
	for(i=0;i<3;i++)
	{
		printf("\n marks=%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\n total marks=%d",sum);
}
