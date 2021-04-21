using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public object GetEmployees()
        {
            return "hello world";
        }
    }
}
