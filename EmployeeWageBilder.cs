using System;

namespace empwage
{
    class Program
    {
        //constants
        public const int IS_PRESENT = 1;
        public const int WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //variables
            int empHrs;
            int salary;
             //USECASE 3: Add part time employee and wage
            int attendance = random.Next(1, 3);

            if (attendance == IS_PARTTIME)
            {
                empHrs = 4;
            }
            else if (attendance == IS_FULLTIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;

            }
            salary = (WORKING_DAYS * empHrs);
            Console.WriteLine("Employee dialy wage:{0}", salary);
        }
    }
}

