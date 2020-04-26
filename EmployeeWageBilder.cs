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
            //USECASE 4: solve using case statment
            employeeType = (random.Next() % 3);
            switch (attendance)
            {
                case IS_PARTTIME:
                    empHrs = 4;
                    break;
                case IS_FULLTIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;

            }
            salary = (WORKING_DAYS * empHrs);
            Console.WriteLine("Employee dialy wage:{0}", salary);
        }
    }
}

