using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IEmployeeBusinessLogic
    {
        Employee GetEmployee(int employeeId);
        Task<List<EmployeeRaw>> GetEmployees();
    }
}
