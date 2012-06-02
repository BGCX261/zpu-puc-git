#include <stdio.h>

int main()
{
	int i=10;
	int* p=&i;
	//should not write code in this way following
	//the book
	*p=NULL;
	return 0;
}
