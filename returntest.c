#include <stdio.h>

int* test()
{
	int p=3;
	int *i=&p;
	return i;
}
int main()
{
	int a,b;
	//b=test();
	//printf("%d\n",b);
	printf("%d\n",*(test()));
	return 0;
}
