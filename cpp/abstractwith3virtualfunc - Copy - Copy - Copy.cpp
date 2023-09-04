#include<iostream>
using namespace std;
class mediaplayer
{
	public:
		virtual void media()=0;
		void play()
		{
			cout<<"media play"<<endl;
		}
		void pause()
		{
			cout<<"media pause"<<endl;
		}
		void stop()
		{
			cout<<"media stop"<<endl;
		}
};
class audioplayer:public mediaplayer
{
	public:
		void media()
		{
			cout<<"----audia player----"<<endl;
		}
};
class videoplayer:public mediaplayer
{
	public:
		void media()
		{
			cout<<"------video player-----"<<endl;
		}
};
int main()
{
	audioplayer a;
	a.media();
	a.play();
	a.pause();
	a.stop();
	videoplayer v;
	v.media();
	v.play();
	v.pause();
	v.stop();
	
}
