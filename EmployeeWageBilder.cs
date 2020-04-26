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
        static void Main(string[] args)
        {
            //variables
            int empHrs;
            int salary;
            int employeeType;
            int monthlySalary = 0;
            int day;
            //USECASE 5: Calculating Wages for a month   
            for (day = 1; day <= WORKING_DAYS; day++)
            {
                attendance = random.Next(1, 3);
                switch (attendance)
                {
                    case IS_PARTTIME:
                        empHrs = 80;
                        break;
                    case IS_FULLTIME:
                        empHrs = 160;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
            }
            salary = WORKING_DAYS * empHrs;
            monthlySalary = (monthlySalary + salary);
            Console.WriteLine("Employee monthly wage:{0}", monthlySalary);
        }
    }
}

