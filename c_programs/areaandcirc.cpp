#include<stdio.h>
int calculate(int r, float *a, float *c)
{
	*a=3.14f*r*r;
	*c=2*3.14*r;
}
int main()
{
	int radius;
	float area,circ;
	printf("enter radius");
	scanf("%d",&radius);
	calculate(radius,&area,&circ);
	printf("\narea=%f",area);
	printf("\ncirc=%f",circ);
}
