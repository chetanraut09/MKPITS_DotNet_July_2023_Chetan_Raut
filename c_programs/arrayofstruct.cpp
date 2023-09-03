#include<stdio.h>
#include<string.h>
struct student
{
	int rno;
	char name[20];
};
int main()
{
	struct student stud[5];
	int counter;
	for (counter=0;counter<5;counter++)
	{
		printf("enter rno and name");
		scanf("%d",&stud[counter].rno);
		scanf("%s",&stud[counter].name);
	}
	
	printf("\n student details");
	for (counter=0;counter<5;counter++)
	{
		printf("\n rno=%d",stud[counter].rno);
		printf("\n name=%s",stud[counter].name);
	}
}

