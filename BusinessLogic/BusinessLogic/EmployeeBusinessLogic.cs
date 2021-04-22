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

        public async Task<List<Employee>> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            var rawEmployees = await _employeeDataAccess.GetEmployeesAsync();

            foreach (var item in rawEmployees)
            {
                employeeList.Add(_employeeFactory.GetEmployee(item));
            }

            return employeeList;
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            var employeeRaw = await _employeeDataAccess.GetEmployeeAsync(employeeId);
            var employee = employeeRaw != null ? _employeeFactory.GetEmployee(employeeRaw) : null;
            return employee;
        }
    }
}
