using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IEmployeeDataAccess
    {
        Task<EmployeeRaw> GetEmployeeAsync(int employeeId);
        Task<List<EmployeeRaw>> GetEmployeesAsync();
    }
}
