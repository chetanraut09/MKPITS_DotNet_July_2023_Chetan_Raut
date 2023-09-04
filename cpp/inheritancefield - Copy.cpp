#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string city;
		
};
class student:public person
{
	public:
		int rno;
		int marks;
		
};
int main()
{
	student s1;
	s1.name="chetan";
	s1.city="nagpur";
	s1.rno=32;
	s1.marks=99;
	cout<<s1.name<<endl<<endl<<s1.city<<endl<<s1.rno<<endl<<s1.marks<<endl;
	return 0;
}
