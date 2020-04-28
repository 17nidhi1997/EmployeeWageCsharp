using System;

namespace EmployeeWage
{
    class EmployeeWageBuilder
    {
         static void Main(string[] args)
        {
            companyEmpWage[] comp_obj = new companyEmpWage[5];
            for (int index = 0; index < comp_obj.Length; index++)
            {
                Console.WriteLine("Enter the company name");
                String companyName = Console.ReadLine();
                Console.WriteLine("Enter the Employee wage per hour");
                int empRate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the working days in a month");
                int WorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the maximun working hrs in a month");
                int max_Working_Hrs = Convert.ToInt32(Console.ReadLine());
                comp_obj[index] = new companyEmpWage(companyName, empRate, WorkingDays, max_Working_Hrs);
            }
            foreach (var item in comp_obj)
            {
                Console.WriteLine(item.calcEmployeeWageForCompany());
            }
        }
    }
}
