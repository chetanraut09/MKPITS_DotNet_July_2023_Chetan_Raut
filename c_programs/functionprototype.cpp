#include<stdio.h>
int deposit(int amt, int bal);
int withdrawl(int amt, int bal);
int main()
{
int amt, bal=1000;
printf("enter amt");
scanf("%d",&amt);
deposit(amt,bal);
withdrawl(amt, bal);
}
int deposit(int amt, int bal)
{
	bal=bal+amt;
	printf("amt deposited,bal is=%d",bal);
}
int withdrawl(int amt, int bal)
{
	bal=bal-amt;
	printf("amount withdrawl bal is =%d",bal);
}
