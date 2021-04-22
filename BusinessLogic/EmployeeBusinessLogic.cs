using AutoMapper;
using DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmployeeBusinessLogic : IEmployeeBusinessLogic
    {
        private IEmployeeDataAccess _employeeDataAccess;
        private EmployeeFactory _employeeFactory;

        public EmployeeBusinessLogic(IEmployeeDataAccess employeeDataAccess,
            EmployeeFactory employeeFactory)
        {
            _employeeDataAccess = employeeDataAccess;
            _employeeFactory = employeeFactory;
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            Task<List<EmployeeRaw>> e = _employeeDataAccess.GetEmployeesAsync();
            var eResult = e.Result;

            foreach (var item in eResult)
            {
                employeeList.Add(_employeeFactory.GetEmployee(item));
            }

            return employeeList;
        }

        public Employee GetEmployee(int employeeId)
        {
            Task<EmployeeRaw> e = _employeeDataAccess.GetEmployeeAsync(employeeId);
            var eResult = e.Result;
            var employee = _employeeFactory.GetEmployee(eResult);
            return employee;
        }
    }
}
