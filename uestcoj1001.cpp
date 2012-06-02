#include <stdio.h>
#include <string.h>

using namespace std;

int main()
{
	int T,i;
	scanf("%d",&T);
	char tmp[T][51];
	for(i=0;i<=T;i++)
	{
		gets(tmp[i]);
	}
	for(i=0;i<T;i++)
	{
		int a,b,flag;
		a=strlen(tmp[i]);
		flag=0;
		if((tmp[i][0]<'0'||tmp[i][0]>'9')&&(tmp[i][a-1]<'0'||tmp[i][a-1]>'9'))
			flag=1;
		for(b=1;b<a;b++)
		{
			/*
			if(tmp[i][b]<'0'||tmp[i][b]>'9')
				flag=1;
			else if(tmp[i][b]=='+'||tmp[i][b]=='-'||tmp[i][b]=='*'||tmp[i][b]=='/')
				flag=0;
			else if(tmp[i][b]=='.')
			{
				flag=0;
				if(tmp[i][b+1]>'0'&&tmp[i][b+1]<'9')
				{
					flag=1;
					break;
				}
			}
			*/
			if(tmp[i][b]=='.')
			{
				if(tmp[i][b+1]>'0'&&tmp[i][b+1]<'9')
					flag=1;
				flag=0;
			}
			else
			{ 
				if(tmp[i][b]<'0'||tmp[i][b]>'9')
					flag=1;
				flag=0;
			}
		}
		if(flag==1)
			printf("NO\n");
		else 
			printf("Yes\n");
	}	
	return 0;
}
