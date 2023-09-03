#include<stdio.h>
void sayhellow()
{
	printf("hellow");
}
int main()
{
	printf("calling function\n");
	sayhellow();
	printf("back in main function\n");
	sayhellow();
	printf("bye\n");
}
