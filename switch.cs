
using System;
class HelloWorld
{
    static void Main()
    {

        Console.WriteLine("Enter Choice");
        int ch = Convert.ToInt32(Console.ReadLine());


        switch (ch)
        {
            case 1:

                Console.WriteLine(5 - 2);
                break;

            case 2:

                Console.WriteLine(5 + 2);
                break;

            default:

                Console.WriteLine("No Options");
                break;


        }

    }
}