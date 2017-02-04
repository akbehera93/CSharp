using System;
class ArrayVal
{
static void Main()
{
int x=0;
int [] a=new int [15];
for(int i=0;i<=14;i++)
{
x=x+5;
a[i]=x;
Console.WriteLine(a[i]);
}
}
}