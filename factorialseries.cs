
using System;
class HelloWorld
{
    static void Main()
    {

        Console.WriteLine(1);
        Console.WriteLine(2);
        int num = 2;
        int mul = 1;
        for (int i = 0; i < 10; i++)
        {
            num = num * mul;
            Console.WriteLine(num);
            mul = num;

        }

    }
}