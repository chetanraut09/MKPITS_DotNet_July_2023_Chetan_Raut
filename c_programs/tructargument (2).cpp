#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void printbook(struct book b1);
int main()
{
	struct book b1;
	printf("enter title,author and bookid");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.bookid);
    printbook (b1);
}
	void printbook(struct book b1)
	{
		printf("\n title=%s",b1.title);
		printf("\n author=%s",b1.author);
		printf("\n bookid=%d",b1.bookid);
	}
