#include <stdio.h>

struct student
{
	char * name;
	int score;
}stu,*Pstu;

int main()
{
	Pstu pstu=(Pstu)malloc(sizeof(stu));
	strcpy(pstu->name,"Jimmy");
	pstu->score=99;
	free(pstu);
	return 0;
}
