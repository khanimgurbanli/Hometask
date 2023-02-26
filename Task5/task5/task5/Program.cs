int number = 236;
int a=0;
int sum=0;
for(int i=0; i<3;i++)
{
    a = number % 10;
    sum = sum + a;
    number=number/10;
}
Console.WriteLine(sum);
