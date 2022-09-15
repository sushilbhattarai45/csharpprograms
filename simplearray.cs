

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        int[] arr = new int[5];
        Console.WriteLine("Enter numbers for array");
        for (int i = 0; i < 5; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Your array");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(arr[i]);

        }
    }

}