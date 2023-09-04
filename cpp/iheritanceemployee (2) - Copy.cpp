#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string designation;
};
class employee:public person
{
	public:
		
			int eno;
			int salary;		
};
		int main()
		{
			employee e1;
			e1.name="chetan";
			e1.designation="hr";
			e1.eno=2222;
			e1.salary=60000;
			cout<<e1.name<<endl<<e1.designation<<endl<<e1.eno<<endl<<e1.salary<<endl;
			return 0;
		}

