using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    class EmployeeHourly : Employee
    {
        public override decimal CalculateAnnualSalary(decimal hourlySalary)
        {
            return 120 * hourlySalary * 12;
        }
    }
}
