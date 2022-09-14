
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("enter multi  digit  number");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter Second  digit  number");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter first  third  number");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("greatest num is number");

        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b)
        {
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine("2 numbers are equals error");
        }

    }
}