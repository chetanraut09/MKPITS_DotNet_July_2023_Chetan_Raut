#include<iostream>
using namespace std;
class account
{
	public:
		int actno;
		int bal;
		int intrest;
void getdata(int a, int b, int c)
{
	actno=a;
	bal=b;
	intrest=c;
}
};
class saving:public account
{
	public:
		int deposit(int amt)
		{
			bal=bal+intrest+amt;
			return bal;
			
		}
};
class current:public account
{
	public:
    int deposite(int amt)
	{
		 bal=bal+amt;
		 return bal;
		 
    }
};
int main()
{
	saving s1;
	current c1;
	int result;
	int actno,bal,intrest,amt;
	cout<<"enter act details"<<endl;
	cin>>actno>>bal>>intrest>>amt;
	s1.getdata(actno,bal,intrest);
	result=s1.deposit(amt);
	cout<<"saving bal="<<result<<endl;
	c1.getdata(actno,bal,amt);
	result=c1.deposite(amt);
	cout<<"current bal,without interest"<<result<<endl;
	return 0;
	
}
