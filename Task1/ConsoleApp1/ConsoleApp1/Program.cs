int n = 2332;
int b;
int c=0;
int d = n;
for (int i=0;i < 4; i++){
    b = n % 10;
    c = c * 10 + b;
    n=n/10;
}
if (c == d)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
