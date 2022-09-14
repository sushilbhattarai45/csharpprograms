
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("enter   number");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (n != 0)
        {
            int rem = n % 10;
            if (rem % 2 == 0)
            {
                sum = sum + rem;
            }
            n = n / 10;
        }
        Console.WriteLine(sum);

    }
}