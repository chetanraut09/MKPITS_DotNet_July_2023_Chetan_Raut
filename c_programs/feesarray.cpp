#include<stdio.h>
struct student
{
	char name[50];int fees;
};
int main()
{
	struct student s;
	float amount,day=150;
	printf("\n enter a student name");
	scanf("%s,s.name");
	printf("\n enter student fees for 5 month :");
	scanf("%d",&s.fees);
	amount=s.fees/day;
	printf("\n the amount per day=%f",amount);
}
