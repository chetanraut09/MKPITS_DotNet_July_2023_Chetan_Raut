#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
		employee(int eno, string en)
		{
			empno=eno;
			empname=en;
		}
		void display()
		{
			cout<<"empno"<<empno<<endl;
			cout<<"empname"<<empname;
		}
};
int main()
{
	int eno;
	string en;
	cout<<"enter empno and name";
	cin>>eno>>en;
	employee emp1(eno,en);
	emp1.display();
	return 0;
	
}
