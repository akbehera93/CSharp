using System;
class Arrays
{
static void Main()
{
int [] a=new int [9];
for(int i=0;i<9;i++)
{
Console.WriteLine(a[i]);
a[i]=i;
Console.WriteLine(a[i]);
}
for(int i=0;i<9;i++)
{
//a[i]=i;
//Console.WriteLine(a[i]);
}
}
}