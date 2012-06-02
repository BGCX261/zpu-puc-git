#include <stdio.h>

int main()
{
	/*
	unsigned int a=65535;
	int b=-2;
	printf("a=%d,%u\n",a,a);
	printf("b=%d,%u\n",b,b);
*/
	unsigned i;
	//attention here!
	//for i is an unsigned integer
	//when u excute i-- to i=-1
	//i turns to 2.^32-1 still greater than 0
	//BUMA!
	for(i=9;i>=0;i--)
	{
		printf("%u\n",i);
		if(i>11)
			break;
	}
	return 0;
}
