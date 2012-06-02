#include <stdio.h>

int addarray(int rgArray[],int nSize)
{
	int nIndex=0;
	int nTotal=0;

	if (rgArray==NULL)
		return 0;
	while(nIndex!=nSize)
	{
		nTotal=nTotal+rgArray[nIndex];
		nIndex++;
	}
	return nTotal;
}

int main(){
	int A[10]={1,2,3,4,5,6,7,8,9,10};
	int x=addarray(A,6);
	printf("%d",x);
}
