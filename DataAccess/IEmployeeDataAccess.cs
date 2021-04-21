using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IEmployeeDataAccess
    {
        Task<object> GetEmployeesAsync();
    }
}
