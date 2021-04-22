using DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IEmployeeBusinessLogic
    {
        Employee GetEmployee(int employeeId);
        Task<List<EmployeeRaw>> GetEmployees();
    }
}
