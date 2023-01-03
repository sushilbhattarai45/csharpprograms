
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        string n1 = "Sushil";
        string n2 = "Pujan";

        //  Console.WriteLine("Enter Your name");
        //  string name = Console.ReadLine();

        //Length of string
        Console.WriteLine(n1.Length);
        //Compare To

        Console.WriteLine(n1.CompareTo(n2));
        //Equals

        Console.WriteLine(n1.Equals(n2));
        //Concat

        Console.WriteLine(string.Concat(n1, n2));

        //UpperCase

        Console.WriteLine(n1.ToUpper());
        //UpperCase

        Console.WriteLine(n1.ToLower());
        //Contains

        Console.WriteLine(n1.Contains("a"));

        //StartsWith
        Console.WriteLine(n1.StartsWith("S"));

        //EndsWith
        Console.WriteLine(n1.EndsWith("S"));


        //IndexOf
        Console.WriteLine(n1.IndexOf("h"));




    }
}