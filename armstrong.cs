
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("enter first  digit  number");
        int n = Convert.ToInt32(Console.ReadLine());
        int original = n;
        int result = 0;
        while (n != 0)
        {
            int rem = n % 10;
            result = result + rem * rem * rem;

            n = n / 10;
        }
        if (result == original)
        {
            Console.WriteLine("Armstrong");

        }
        else
        {
            Console.WriteLine("nOT Armstrong");

        }
    }
}