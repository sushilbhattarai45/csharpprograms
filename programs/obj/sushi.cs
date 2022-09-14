// salary >=10000 bonus 5% tax 10%
// salary < 10000 bonus 10% tax 20%

using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the salary");
        int salary = Convert.ToInt32(Console.ReadLine());
        int bonus, withBonus, tax, newSalary;
        if(salary <=10000){
            bonus = (5* salary)/ 100;
            withBonus = bonus + salary;
            tax = (10*withBonus) / 100;
            newSalary = withBonus - tax;
            Console.WriteLine(newSalary);
           
        }else{
            bonus = (salary*10) / 100;
            withBonus = bonus + salary;
            tax = (20*withBonus)/100 ;
            newSalary = withBonus - tax;
           Console.WriteLine(newSalary);
        }
    }
}