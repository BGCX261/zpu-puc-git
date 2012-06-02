#include <stdio.h>

//void fun(char a[10])
void fun(char *p)
{
	//char c=p[3];
	char c=*(p+3);
	printf("%c\n",c);
}

int main()
{
	/*
	int a[4]={1,2,3,4};
	int *ptr1=(int *)(&a+1);
	int *ptr2=(int *)((int)a+1);
	printf("%x,%x,%x\n",ptr1[-1],*ptr2,*(a+1));
	*/

//	char b[100]="abcdefg";
	char *b2="abcdefg";
	fun(b2);
	return 0;
}
