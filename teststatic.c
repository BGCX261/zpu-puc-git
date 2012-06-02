#include <stdio.h>

static int j;

void fun1(void)
{
	static int i=0;
	i++;
	printf("%d\n",i);
}

void fun2(void)
{
	j=0;
	j++;
	printf("%d\n",j);
}

int main()
{
	int k;
	for(k=0;k<10;k++)
	{
		fun1();
		fun2();
	}
	printf("%d\n",j);
	return 0;
}
