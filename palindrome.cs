
using System;
class HelloWorld

{

    static void Main()
    {
        Console.WriteLine("enter   number");
        int n = Convert.ToInt32(Console.ReadLine());
        int original = n;
        int rev = 0;
        while (n != 0)
        {
            int rem = n % 10;
            rev = rev * 10 + rem;
            n = n / 10;
        }
        Console.WriteLine(rev);
        if (rev == original)
        {
            Console.WriteLine("Palindrome");

        }
        else
        {
            Console.WriteLine("Not PALINDROME");

        }
    }
}