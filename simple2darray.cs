using System;
namespace abc
{
    class array2d
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
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
}
