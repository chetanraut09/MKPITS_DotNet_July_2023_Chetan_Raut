#include<iostream>
using namespace std;
int main()
{
	int i,sum=0;
	int marks[3];
	char op;
	marks[0]=99;
	marks[1]=88;
	marks[2]=77;
	for(i=0;i<3;i++)
	{
		cout<<"\n marks="<<marks[i];
		sum=sum+marks[i];
	}
        cout<<"\n total marks="<<sum;
	return 0;
}
