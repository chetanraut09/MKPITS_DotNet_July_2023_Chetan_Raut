#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobno;
		void getpersondata(string n, int m)
		{
			name=n;
			mobno=m;		
		}
};
class employee:public person
{
	public:
		int empno;
		int salary;
		void getemployeedata(int e, int s)
		{
			empno=e;
			salary=s;
		}
		void displaydata()
		{
			cout<<"NAME:"<<name<<endl;
			cout<<"MOBILE NO:"<<mobno<<endl;
			cout<<"EMPLOYEE ID:"<<empno<<endl;
			cout<<"SALARY:"<<salary<<endl;		
	    }
};
int main()
{
	string name;
	int mn,eno,sal;
	cout<<"ENTER EMPLOYEE DETAILS:"<<endl;
	cin>>name>>mn>>eno>>sal;
	cout<<endl;
	employee emp;
	emp.getpersondata(name,mn);
	emp.getemployeedata(eno,sal);
	emp.displaydata();
	return 0;
}
