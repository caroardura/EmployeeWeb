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
        public Task<List<EmployeeRaw>> GetEmployees()
        {
            return _employeeDataAccess.GetEmployeesAsync();
        }

        public Employee GetEmployee(int employeeId)
        {
            Task<EmployeeRaw> e = _employeeDataAccess.GetEmployeeAsync(employeeId);
            var eResult = e.Result;
            var employee = EmployeeFactory.GetEmployee(eResult.contractTypeName);
            return employee;
        }
    }
}
