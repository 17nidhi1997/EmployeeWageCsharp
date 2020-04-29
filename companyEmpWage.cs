using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class companyEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        //variable
        public string companyName;
        public int empRate;
        public int WORKING_DAYS;
        public int MAX_WORKING_HRS;
        public int empWage;
        public int totalWage = 0;
        int empWages;
        int empHrs;
        public companyEmpWage(String companyName, int empRate, int WORKING_DAYS, int MAX_WORKING_HRS)
        {
            this.companyName = companyName;
            this.empRate = empRate;
            this.WORKING_DAYS = WORKING_DAYS;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;

        }
        public string calcEmployeeWageForCompany()
        {
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Random randam = new Random();
            int empType = (randam.Next() % 3);
            empHrs = getEmployeeHours(empType);
             for (int totalEmp=1; totalEmp <= WORKING_DAYS; totalEmp++)
            {
                totalWorkingDays++;
                totalEmpHrs += empHrs;
                empWage = empHrs * empRate;
                totalWage += empWage;
            }
            return "Day" + totalWorkingDays + "company Name :" + companyName + " Montly Wage " + totalWage + " Dialy wage " +empWage;

        }

        public int getEmployeeHours(int empType)
        {
            switch (empType)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    empWages = empRate * empHrs;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    empWages = empRate * empHrs;
                    break;
                default:
                    empHrs = 0;
                    break;

            }
            return empHrs;
        }
    }
}

