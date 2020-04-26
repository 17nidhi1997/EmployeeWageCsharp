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

        public static int getWorksHrs()
        {
            Random random = new Random();
            int emphrs = 0;
            int Empvalue = (random.Next() % 3);
            switch(Empvalue)   
            {
                case IS_PARTTIME: emphrs = 4;
                    break;
                case IS_FULLTIME:emphrs = 8;
                    break;
                default:emphrs = 0;
                    break;
            }
            return emphrs;
        }
        static void Main(string[] args)
        {
            //variable
            int monthlySalary = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            //USECASE 7: Rector the code to write a function to get work hours
            while(totalWorkingDays < MAX_HRS_IN_MONTH && totalWorkingDays < WORKING_DAYS)
            {
                totalWorkingDays++;
                int Hrs = getWorksHrs();
                totalEmpHrs = totalEmpHrs * Hrs;
            }
            monthlySalary = WAGE_PER_HOUR * totalEmpHrs;
            Console.WriteLine("Calculate wage till working hrs or days is reached for a month: {0} ", monthlySalary);
        }
    }
}
