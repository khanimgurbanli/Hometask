
int number = 2435;
int a = 0;
int b = 0;
for(int i=0; i < 4; i++)
{
    a = number % 10;
    b = b * 10 + a;
    number = number / 10;
}
Console.WriteLine(b);