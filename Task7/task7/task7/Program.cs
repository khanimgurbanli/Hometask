internal class Program
{
    private static void Main(string[] args)
    {
        char a = '-';
        int b = 0;
        int num1 = 12;
        int num2 = 10;
        if (a == '+')
        {
            b = 1;
        }
        if (a == '-')
        {
            b = 2;
        }
        if (a == '*')
        {
            b = 3;
        }
        if (a == '/')
        {
            b = 4;
        }
        switch (b)
        {
            case 0:
                Console.WriteLine("invalid input");
                    break;
            case 1:
                Console.WriteLine(num1 + num2);
                break;
            case 2:
                Console.WriteLine(num1 - num2);
                break;
            case 3:
                Console.WriteLine(num1 * num2);
                break;
            case 4:
                Console.WriteLine(num1 / num2);
                break;
            
        }
    }
}