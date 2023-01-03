using System;
namespace abc
{
    class jagged
    {
        public static void Main(String[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3] { 0, 4, 2 };
            arr[1] = new int[2] { 3, 5 };
            arr[2] = new int[3] { 2, 4, 6 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }
        }


    }
}