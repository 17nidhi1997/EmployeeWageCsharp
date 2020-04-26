using System;

namespace empwage
{
    class Program
    {
        public const int IS_PRESENT = 1;
        static void Main(string[] args)
        {
            //USECASE 1: check Employee is present or absent            
            Random random = new Random();
            int attendance =(random.Next() % 2);
            if (attendance == IS_PRESENT)
            {
                Console.WriteLine("Employee is present ");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
}
