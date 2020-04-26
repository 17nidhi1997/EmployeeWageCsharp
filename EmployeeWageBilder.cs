using System;

namespace empwage
{
    class Program
    {
        //constants
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;

        public static int empHrs;
        public static int empWage;
        public static int montlysalary;
        public static void calcEmployeeWageForCompany(String companyName, int empRate, int WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            //variables
            int totalWorkingDays = 0;
            while (totalWorkingDays <= MAX_HRS_IN_MONTH && totalWorkingDays <= WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empType = (random.Next() % 2);
                switch (empType)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                   default : empHrs =0;
                          break;
                }
            }
            empWage = empHrs * empRate;
            montlysalary = empWage * WORKING_DAYS;
            Console.WriteLine("COMPANY NAME:"+ companyName + "----EMPWAGE:" +empWage+"------MONTLY WAGE:" +montlysalary);
        }
        static void Main(string[] args)
        {
            //USECASE 8:Compute Employee Wage for multiple companies
            calcEmployeeWageForCompany("BridgeLabz", 20, 20, 100);
            calcEmployeeWageForCompany("Wipro", 30, 10, 55);
            calcEmployeeWageForCompany("D-Mart", 20, 30, 150);
        }
    }
}


