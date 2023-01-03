using System;
namespace abc
{
    class abc
    {
        public static void Main(String[] args)
        {
            char[] ch = { 'B', 'U', 'T', 'W', 'A', 'L' };
            for (int i = 0; i < ch.Length; i++)
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