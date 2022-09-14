using System;
namespace reverse
{
    class rev

    {
        static void Main(String[] args)

        {
            Console.WriteLine("Enter a  3            Digit Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int rev = 0;
            while (n != 0)
            {
                rem = n % 10;
                n = n / 10;

                rev = rev * 10 + rem;
            }

            Console.Write(rev);

        }
    }
}