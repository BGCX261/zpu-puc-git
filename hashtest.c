#include <stdio.h>
#include <ctype.h>

unsigned long cryptTable[0x500];

void prepareCryptTable()
{
	unsigned long seed=0x00100001,index1=0,index2=0,i;

	for(index1=0;index1 < 0x100;index1++)
	{
		for(index2=index1,i=0;i<5;i++,index2+=0x100)
		{
			unsigned long temp1,temp2;

			seed=(seed*125+3)% 0x2AAAAB;//0x2AAAAB=12143553
			temp1=(seed&0xFFFF)<<0x10;

			seed=(seed*125+3)%0x2AAAAB;
			temp2=(seed&0xFFFF); //to decrese the unsigned bit

			cryptTable[index2]=(temp1|temp2);
		}
	}
}

unsigned long HashString(char* lpszFileName, unsigned long dwHashType)
{
	unsigned char* key=(unsigned char*)lpszFileName;
	unsigned long seed1=0x7FED7FED;
	unsigned long seed2=0xEEEEEEEE;
	int ch;

	while(*key!=0)
	{
		ch=toupper(*key++);
		seed1=cryptTable[(dwHashType<<8)+ch]^(seed1+seed2);
		seed2=ch+seed1+seed2+(seed2<<5)+3;
	}
	return seed1;
}

int main(int argc,char* argv[])
{
	unsigned long ulHashValue;
	int i=0;

	if(argc!=2)
	{
		printf("Please input two arguments\n");
		return -1;
	}
	prepareCryptTable();

	for(;i<0x500;i++)
	{
		if(i%10==0)
		{
			printf("\n");
		}
		printf("%-12X",cryptTable[i]);
	}
	ulHashValue=HashString(argv[1],0);
	//printf("%---%X---\n",ulHashValue);

	ulHashValue=HashString(argv[1],1);
	//printf("%---%X---\n",ulHashValue);
	
	ulHashValue=HashString(argv[1],2);
	//printf("%---%X---\n",ulHashValue);

	return 0;
}
