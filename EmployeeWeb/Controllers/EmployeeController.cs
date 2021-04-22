using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        IEmployeeBusinessLogic _employeeBusinessLogic;

        public EmployeeController(IEmployeeBusinessLogic employeeBusinessLogic)
        {
            _employeeBusinessLogic = employeeBusinessLogic;
        }

        [HttpGet("")]
        //public IEnumerable<WeatherForecast> WeatherForecasts()
        public Task<List<EmployeeRaw>> GetEmployees()
        {
            return _employeeBusinessLogic.GetEmployees();
        }

        [HttpGet("{employeeId}")]
        public Employee GetEmployee(int employeeId)
        {
            return _employeeBusinessLogic.GetEmployee(employeeId);
        }
    }
}
