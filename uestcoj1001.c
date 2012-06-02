#include <stdio.h>
#include <string.h>

int main()
{
	int b,T,i;
	char a[51],ch;
	scanf("%d",&T);
	scanf("%c",&ch);
	while(T--)
	{
		int p=0;
		gets(a);
		b=strlen(a);
		if(a[0]<'0'||a[0]>'9')
			p=1;
		else if(a[b-1]<'0'||a[b-1]>'9')
			p=1;
		else
		{
			for(i=1;i<b;i++)
			{
				if(a[i]>'0'&&a[i]<'9')
					p=p-1;
				else if(a[i]=='+'||a[i]=='-'||a[i]=='*'||a[i]=='/')
					p=p+1;
				else if(a[i]!='.')
				{
					p=1;
					break;
				}
			}
			if(a[0]>='0'&&a[0]<='9'&&p==0)
				printf("Yes\n");
			else 
				printf("No\n");
		}
	}
}
