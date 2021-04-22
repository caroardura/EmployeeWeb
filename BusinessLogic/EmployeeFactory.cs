using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public static class EmployeeFactory 
    {
        public static Employee GetEmployee(string contractTypeName)
        {
            switch (contractTypeName)
            {
                case "HourlySalaryEmployee":
                    return new EmployeeHourly();
                default: // "MonthlySalaryEmployee"
                    return new EmployeeMonthly();
            }
        }
    }
}
