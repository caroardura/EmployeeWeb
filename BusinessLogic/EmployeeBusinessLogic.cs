using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class EmployeeBusinessLogic : IEmployeeBusinessLogic
    {
        IEmployeeDataAccess _employeeDataAccess;

        public EmployeeBusinessLogic(IEmployeeDataAccess employeeDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
        }
        public object GetEmployees()
        {
            return _employeeDataAccess.GetEmployeesAsync();
        }
    }
}
