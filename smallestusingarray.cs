
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        Console.WriteLine("enter data for array");
        for (int i = 0; i < 5; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int smallest = arr[0];

        for (int i = 0; i < 5; i++)
        {
            if (smallest > arr[i])

            {
                smallest = arr[i];
            }
        }
        Console.WriteLine(smallest);

    }
}
