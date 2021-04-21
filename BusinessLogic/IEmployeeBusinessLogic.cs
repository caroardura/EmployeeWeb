using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IEmployeeBusinessLogic
    {
        Task<List<Employee>> GetEmployees();
    }
}
