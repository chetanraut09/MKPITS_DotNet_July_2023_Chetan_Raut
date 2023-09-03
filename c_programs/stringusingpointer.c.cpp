#include<stdio.h>
int main()
{
	char name[10];
	char*ptr;
	printf("enter name");
	gets(name);
	ptr=name;
	while(*ptr !='\0')
	{
		printf("%c",*ptr);
		ptr++;
	}
}
