#include<iostream>
using namespace std;
class game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
	};
	
class tick_tac_toe:public game
{
	public:
		void start()
		{
			cout<<"start tick tack toe"<<endl;
		}
		void play()
		{
			cout<<"play tick tack toe"<<endl;
		}
		void end()
		{
			cout<<"end tick tack toe"<<endl;
		}
};
class chess:public game
{
	public:

	void start()
		{
			cout<<"start chess"<<endl;
		}
		void play()
		{
			cout<<"play chess"<<endl;
		}
		void end()
		{
			cout<<"end chess"<<endl;
		}
};
int main()
{
	 tick_tac_toe t;
	t.start();
	t.play();
	t.end();
	cout<<"---------------------------------------"<<endl; 
	chess c;
	c.start();
	c.play();
	c.end();
return 0;	
}
