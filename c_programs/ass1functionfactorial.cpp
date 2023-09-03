#include<stdio.h>
void fact(int n, int fact, int sum)
{
	int result=n+fact;
	printf("factorial of no=%d\n",fact);
}
int main()
{
	int num,fact=1;
	printf("\n enter a no");
	scanf("\n%d",&num);
	do
	{
		fact=fact*num;
		num=num-1;
	}
	while(num>0);
	printf("fact=%d",fact);
}
