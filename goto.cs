
using System;
class HelloWorld
{
    static void Main()
    {
    ineligible:
        Console.WriteLine("You cant Vote");
        Console.WriteLine("enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            goto ineligible;
        }
    }
}