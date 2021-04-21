using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmployeeBusinessLogic : IEmployeeBusinessLogic
    {
        IEmployeeDataAccess _employeeDataAccess;

        public EmployeeBusinessLogic(IEmployeeDataAccess employeeDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
        }
        public Task<List<Employee>> GetEmployees()
        {
            return _employeeDataAccess.GetEmployeesAsync();
        }
    }
}
