
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("enter first  digit  number");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter Second  digit  number");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter first  third  number");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Middle num is number");

        if (a > b && a < c || a < b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c || b < a && b < c)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b || c < a && c < b)
        {
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine("Error: Some numbers are equal");
        }

    }
}