#include<stdio.h>
int additinon(int n1, int n2)
{
	int result=n1+n2;
	return result;
 }
 int main()
 {
 char ch='y';
 do
{
	int num1, num2, result;
	printf("enter 2 no");
	scanf("%d%d",&num1,&num2);
	result=addition(num1,num2);
	printf("result=%d",result);
	printf("do you want to contenue,press y");
	fflush(stdin);
	scanf("%c",&ch);
}
while(ch=='y');
}

