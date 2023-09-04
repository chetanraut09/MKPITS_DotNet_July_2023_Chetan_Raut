#include<iostream>
using namespace std;
int main()
{
    int arr[5];
    int i,j,cnt=0;
    for(i=0;i<5;i++)
    
	cout<<"enterv num";
	cin>>arr[i];
	
    for(i=0;i<5;i++)
  {
	for(j=i+1;j<5;j++)
	{
		if (arr[i]==arr[j])
		{
			
			cnt++;
			break;
		}
		cout<<"arry:"<<arr[i]<<endl;
	}
	
  }
  return 0;
}
