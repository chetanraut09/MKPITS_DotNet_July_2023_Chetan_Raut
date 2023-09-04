#include<iostream>
using namespace std;
class employee
{
public:
	employee()
{
		cout<<"constructer called"<<endl;
}
	~enmployee()
{
		cout<<"distructer called"<<endl;
}
};
int main()
{
	employee el;
	employee e2;
	return 0;
	
}
