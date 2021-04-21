using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWeb.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        IEmployeeBusinessLogic _employeeBusinessLogic;

        public EmployeeController(IEmployeeBusinessLogic employeeBusinessLogic)
        {
            _employeeBusinessLogic = employeeBusinessLogic;
        }

        [HttpGet("")]
        //public IEnumerable<WeatherForecast> WeatherForecasts()
        public Task<List<Employee>> GetEmployees()
        {
            return _employeeBusinessLogic.GetEmployees();
        }
    }
}
