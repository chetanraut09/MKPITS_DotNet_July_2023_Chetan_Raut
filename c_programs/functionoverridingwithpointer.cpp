#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		virtual void deposit(int amt)
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
	Account *A;
	saving s;
	A= &s;
	A->actno=123;
	A->bal=200;
	A->deposit(100);
	current c;
	A=&c;
	
	A->actno=333;
	A->bal=100;
	A->deposit(500);
	return 0;
}
