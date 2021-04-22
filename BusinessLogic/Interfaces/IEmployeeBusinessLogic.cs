using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IEmployeeBusinessLogic
    {
        Task<Employee> GetEmployee(int employeeId);
        Task<List<Employee>> GetEmployees();
    }
}
