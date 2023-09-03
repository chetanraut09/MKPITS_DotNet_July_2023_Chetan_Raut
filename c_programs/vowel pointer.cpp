#include<stdio.h>
int main()
{
	int cnt=0;
	char name[10];
	char *ptr;
	printf("enter name");
	gets(name);
	ptr=name;
	while(*ptr !='\n')
	{
		if(*ptr=='a' || *ptr=='e' || *ptr=='o' || *ptr=='i' || *ptr=='u')
		{
			cnt=cnt+1;
		}
		ptr++;
	}

printf("no of vowel in a string=%d",cnt);
}
