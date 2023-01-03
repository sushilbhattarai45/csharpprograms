using System;
namespace abc
{
    class sumofdiagonal
    {
        public static void Main(String[] args)
        {

            int[,] arr = new int[2, 2];
            int[,] sum = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = arr[i, j] + arr2[i, j];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sum[i, j]);
                }
                Console.WriteLine();
            }

        }


    }
}
