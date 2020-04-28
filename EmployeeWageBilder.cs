using System;

namespace EmployeeWage
{
    class EmployeeWageBuilder
    {   //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

            private string companyName;
            private int empRate;
            private int WORKING_DAYS;
            private int MAX_WORKING_HRS;
            public int empWage;
        int empHrs;
        int totalWage = 0;
        public EmployeeWageBuilder(String companyName,int empRate,int WORKING_DAYS,int MAX_WORKING_HRS)
            {
                this.companyName = companyName;
                this.empRate = empRate;
                this.WORKING_DAYS = WORKING_DAYS;
                this.MAX_WORKING_HRS = MAX_WORKING_HRS;

            }
            public void calcEmployeeWageForCompany()
            {
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;
                while (totalEmpHrs <= MAX_WORKING_HRS && totalEmpHrs <= WORKING_DAYS )
                {
                    totalWorkingDays++;
                    Random randam = new Random();
                    int empType = (randam.Next() % 3);
                    empHrs = getEmployeeHours(empType);
                totalEmpHrs += empHrs;
                empWage = empHrs * empRate;
                totalWage += empWage;
                Console.WriteLine("Day " + totalWorkingDays + " employee wage for company :" + companyName + "is = " + empWage);              
            }
            Console.WriteLine("Totaly employee wage for company: " +companyName+ "is = " +totalWage);
        }

            private int getEmployeeHours(int empType)
            {
             switch(empType)
            {
                case IS_FULL_TIME: empHrs = 8;
                    break;
                case IS_PART_TIME: empHrs = 4;
                    break;
                default: empHrs = 0;
                    break;

            }
            return empHrs;
            }
        static void Main(string[] args)
        {    //uasecase 9:ability to save the total wage for each company
            EmployeeWageBuilder builder = new EmployeeWageBuilder("BridgeLabs",20,20,20);
            builder.calcEmployeeWageForCompany();
            Console.WriteLine("-----------------------");
            EmployeeWageBuilder builderS = new EmployeeWageBuilder("IBM", 40, 20, 50);
            builderS.calcEmployeeWageForCompany();
        }
            
        }
}

