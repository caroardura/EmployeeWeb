﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    class EmployeeMonthly : Employee
    {
        public override decimal CalculateAnnualSalary(decimal monthlySalary)
        {
            return monthlySalary * 12;
        }
    }
}