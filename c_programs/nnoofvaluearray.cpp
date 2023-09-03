#include<stdio.h>
int main()
{
	int i, n, nums[1000];
	printf("enter n");
	scanf("%d",&n);
	for (i=0;i<n;i++)
	{
		printf("enter marks");
		scanf("%d",&nums[i]);
    }
			for(i=n-1; i>0;i--)
			{
				printf("\n num=%d",nums[i]);
			}
}
