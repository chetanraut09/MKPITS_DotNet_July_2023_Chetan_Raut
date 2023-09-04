 #include<stdio.h>
void addition(int n1, int n2)
{
	int result=n1+n2;
	printf("addition of 2 number=%d",result);
}
int main()
{
	int num1, num2;
	printf("enter 2 number");
	scanf("%d%d",&num1,&num2);
	addition(num1, num2);
	printf("\n bye");
}
