#include<stdio.h>
int area(int a, int b)
{
	int result=a*a;
	printf("area of sqr=%d",result);
}
int main()
{
int a,b,result;
printf("enter a no");
scanf("&d&d",&a,&b);
result=area(a,b);
printf("area of sqr=%d",result);
}
