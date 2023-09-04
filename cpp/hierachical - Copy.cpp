#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;
		void getdata(int a, int b)
		{
			x=a;
			y=b;
		}
};
class rectangle:public shape
{
	public:
	int carear(int l,int b)
	{
		int ra;
		ra=l*b;
		return ra;
	}
};
class traingle:public shape
{
	public:
		float careat(int b, int h)
		{
			float ta;
			ta=0.5f*b*h;
			return ta;
		}
};
int main()
{
	rectangle r;
	traingle t;
	int length, breadth, base,height;
	int ra;
	float ta;
	cout<<"enter lenght and breadth";
	cin>>length>>breadth;
	ra=r.carear(length, breadth);
	cout<<"area of reactangle"<<ra;
	cout<<"enter base and hieght";
	cin>>base>>height;
	ta=t.careat(base,height);
	cout<<"area of triengl"<<ta;
	return 0;
}
