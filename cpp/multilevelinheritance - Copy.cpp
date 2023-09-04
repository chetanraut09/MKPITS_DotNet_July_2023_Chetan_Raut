#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobileno;
		
};
class employee:public person
{
	public:
		int empno;
		int salary;
		
};
class parttimeemployee:public employee
{
	public:
		int noofhours;
};
int main()
{
	employee e1;
	e1.name="srti";
	e1.mobileno=123;
	e1.empno=223;
	e1.salary=60000;
	cout<<"emp details"<<endl;
	cout<<e1.name<<endl<<e1.mobileno<<endl<<e1.empno<<endl<<e1.salary<<endl;
	parttimeemployee p1;
	p1.name="manoj";
	p1.mobileno=234;
	p1.empno=222;
	p1.salary=30000;
	p1.noofhours=4;
	cout<<"parttimeemployee details details"<<endl;
	cout<<p1.name<<endl<<p1.mobileno<<endl<<p1.empno<<endl<<p1.salary<<endl<<p1.noofhours<<endl;
	return 0;
	
}
