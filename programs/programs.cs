using System;
namespace prog
{
    class program
    {
        static void Main(String[] args)

        {
            Console.WriteLine("Enter a  3 Digit Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int count = 0;
            while (n != 0)
            {
                rem = n % 10;
                n = n / 10;
                if (count == 2)
                {
                    int m = rem;
                    Console.WriteLine(m);
                }
                count++;
                n = n / 10;

            }


        }
    }
}