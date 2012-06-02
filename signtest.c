#include <stdio.h>

int main()
{
	int i=-20;
	unsigned j=10;
	unsigned int k=i+j;
	signed int p=i+j;
	printf("%u\n",k);
	printf("%d\n",p);
	return 0;
}
