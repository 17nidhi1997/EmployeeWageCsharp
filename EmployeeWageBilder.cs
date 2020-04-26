using System;

namespace empwage
{
    class Program
    {
        public const int IS_PRESENT = 1;
        public const int WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //USECASE 2: Calculate Daily employee wage
            int empHrs;
            int salary;
            attendance = random.Next(1, 2);
            if (attendance == IS_PRESENT)
            {

                empHrs = 8;
                salary = (WORKING_DAYS * empHrs);
            }
            else
            {
                salary = 0;
            }
            Console.WriteLine("Employee dialy wage is :{0}", salary);
        }
    }
}

