using System;

namespace empwage
{
    class Program
    {
        //constants
        public const int IS_PRESENT = 1;
        public const int WORKING_DAYS = 20;
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        public const int WAGE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            //variables
            int empHrs;
            int salary;
            int employeeType;
            int monthlySalary = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            //USECASE 6:Calculate wage till a condition of total working hrs or days is reached for a month           
            employeeType = (random.Next() % 3);
               while (totalEmpHrs < MAX_HRS_IN_MONTH && totalEmpHrs < WORKING_DAYS)
                {
                    totalWorkingDays++;
                    Random random=new Random();
                    employeeType = (random.Next() % 3);
                    switch (employeeType)
                    {

                        case IS_FULLTIME:
                            empHrs = 8;
                            break;
                        case IS_PARTTIME:
                            empHrs = 4;
                            break;

                        default:
                            empHrs = 0;
                            break;
                    }

                    salary = WAGE_PER_HOUR * empHrs;
                    totalEmpHrs = totalEmpHrs + empHrs;                   
                }
                monthlySalary = WORKING_DAYS * salary;
                Console.WriteLine("Calculate wage till working hrs or days is reached for a month: {0} ", monthlySalary);
        }
    }
}
