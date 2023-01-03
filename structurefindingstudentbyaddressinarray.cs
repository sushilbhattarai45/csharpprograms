using System;
namespace abc
{
    struct student
    {
        public string name;
        public string address;
    }
    class structure
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter no of people");
            int n = Convert.ToInt32(Console.ReadLine());

            student[] s1 = new student[n];

            Console.WriteLine("Enter follwoing data");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter name");
                s1[i].name = Console.ReadLine();
                Console.WriteLine("Enter address");
                s1[i].address = Console.ReadLine();

            }

            Console.WriteLine("Enter Your Address");
            string add = Console.ReadLine();


            Console.WriteLine("-----------------------------------------------");

            for (int i = 0; i < n; i++)
            {
                if (add == s1[i].address)
                {
                    Console.Write(s1[i].name + " Lives in : " + s1[i].address);
                }
            }


        }
    }
}
