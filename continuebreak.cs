
using System;
class HelloWorld
{
    static void Main()
    {

        for (int i = 0; i < 100; i++)
        {

            if (i % 2 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
            if (i == 9)
            {
                break;
            }

        }


    }
}