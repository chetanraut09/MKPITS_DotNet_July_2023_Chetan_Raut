#include<iostream>
using namespace std;
int main()
{
	int i;
	int sum=0;
	int marks[5];
	for(i=0;i<5;i++)
	{
		cout<<"enter marks";
		cin>>marks[i];
	}
	for(i=0;i<5;i++)
	{
		cout<<"\n marks="<<marks[i];
		sum=sum+marks[i];
	}
	cout<<"total marks="<<sum;
	return 0;
	
}
