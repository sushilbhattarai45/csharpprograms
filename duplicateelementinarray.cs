//sushil's code
using System;

public class HelloWorld
{
    public static void Main(String[] args)
    {
        int count = 0;
        int[] arr = { 1, 2, 3, 4, 1, 2, 3 };
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = arr.Length - 1; j > i; j--)
            {

                if (i != j)
                {
                    if (arr[i] == arr[j])
                    {
                        count = count + 1;

                    }
                }


            }




        }
        Console.WriteLine(count);
    }
}
