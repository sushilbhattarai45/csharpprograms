using System;
namespace abc
{
    struct employee
    {
        public string emp_name;
        public string emp_address;
        public int emp_salary;
    }

    class structure
    {
        public static void Main(String[] args)
        {
            employee s1;
            Console.WriteLine("eNTER NAME ");
            s1.emp_name = Console.ReadLine();
            Console.WriteLine("eNTER Address ");
            s1.emp_address = Console.ReadLine();
            Console.WriteLine("Your name is :" + s1.emp_name);

            Console.WriteLine("Your address is :" + s1.emp_address);

        }
    }
}