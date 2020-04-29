using System;
using System.Collections;
namespace EmployeeWage
{
    class EmployeeWageBuilder
    {
         static void Main(string[] args)
        {
            ArrayList comp_obj = new ArrayList();
            Console.WriteLine("num of company");
            int num_of_company = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < num_of_company; index++)
                {
                Console.WriteLine("Enter the company name");
                String companyName = Console.ReadLine();
                Console.WriteLine("Enter the Employee wage per hour");
                int empRate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the working days in a month");
                int WorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the maximun working hrs in a month");
                int max_Working_Hrs = Convert.ToInt32(Console.ReadLine());
                comp_obj.Add(new companyEmpWage(companyName, empRate, WorkingDays, max_Working_Hrs));
            }
            foreach (companyEmpWage item in comp_obj)
            {
                Console.WriteLine(item.calcEmployeeWageForCompany());
            }
        }
    }
}

