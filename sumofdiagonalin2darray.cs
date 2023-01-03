using System;
namespace abc
{
    class sumofdiagonal
    {
        public static void Main(String[] args)
        {

            int[,] arr = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int sum = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == i)
                    {
                        sum = sum + arr[i, j];
                    }
                }
            }
            Console.Write("sum is " + sum);



        }


    }
}
