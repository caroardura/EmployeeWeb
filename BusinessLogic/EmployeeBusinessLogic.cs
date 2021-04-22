using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmployeeBusinessLogic : IEmployeeBusinessLogic
    {
        private IEmployeeDataAccess _employeeDataAccess;
        private EmployeeFactory _employeeFactory;

        public EmployeeBusinessLogic(IEmployeeDataAccess employeeDataAccess, EmployeeFactory employeeFactory)
        {
            _employeeDataAccess = employeeDataAccess;
            _employeeFactory = employeeFactory;
        }
        public Task<List<EmployeeRaw>> GetEmployees()
        {
            return _employeeDataAccess.GetEmployeesAsync();
        }

        public Employee GetEmployee(int employeeId)
        {
            Task<EmployeeRaw> e = _employeeDataAccess.GetEmployeeAsync(employeeId);
            var eResult = e.Result;
            var employee = _employeeFactory.GetEmployee(eResult.contractTypeName);
            return employee;
        }
    }
}
