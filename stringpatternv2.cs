using System;
namespace abc
{
    class abc
    {
        public static void Main(String[] args)
        {
            char[] ch = { 'B', 'U', 'T', 'W', 'A', 'L' };
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(ch[j]);
                }
                Console.WriteLine();
            }
        }
    }
}