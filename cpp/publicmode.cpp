#include<iostream>
using namespace std;
class student
{
	private:
		int rno;
		
	public:
		int display()
		{
		    cout<<"rno= "<<rno;
		}
		int setdata(int r)
		{
		    rno=r;
		}			
};
int main()
{
	student s1;
	int rn;
	cout<<"enter rno";
	cin>>rn;
	s1.setdata(rn);
	s1.display();
	
	
	
}
