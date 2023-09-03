#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		void deposit(int amt)
		{
			cout<<"hello from account deposit"<<endl;
			
		}
};
class saving:public Account
{
	public:
		void deposit(int amt)
		{
			int interest=500;
			bal=bal+amt+interest;
			cout<<"bal with interest= "<<bal<<endl;
		}
};
class current:public Account
{
	public:
		void deposit(int amt)
		{
			bal=bal+amt;
			cout<<"bal without interest= "<<bal<<endl;
		}
};
int main()
{
	saving s;
	
	s.actno=123;
	s.bal=200;
	s.deposit(100);
	current c;
	c.actno=333;
	c.bal=100;
	c.deposit(500);
	return 0;
}
