#include<iostream>
using namespace std;
int main()
{
	int i, arr1[2], arr2[2];
	for(i=0;i<2;i++)
	{
		cout<<"enter num";
		cin>>arr1[i];
	}
	for(i=0;i<2;i++)
	{
		arr2[i]=arr1[i];
		cout<<"\n element of arr1: ";
		for(i=0;i<2;i++)
		{
			cout<<""<<arr1[i];
		}
		cout<<"\n element of arr2: ";
		for(i=0;i<2;i++)
		{
		cout<<"arr2:"<<arr2[i];
		}
	}
	return 0;
}
