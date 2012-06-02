#include <stdio.h>

int main()
{
	int a[5]={1,2,3,4,5};
	int *ptr1=(int *)(&a+1);
	int *ptr2=(int *)(a+1);
	//if a[0] is saved as
	//0x00 0x00 0x00 0x01
	//(int)a+1 will starts from 2nd 0x11
	//depens on big endian or little endian
	int *ptr2=(int *)((int)a+1);
	printf("%x,%x",ptr1[-1],*ptr2);
	return 0;
}
