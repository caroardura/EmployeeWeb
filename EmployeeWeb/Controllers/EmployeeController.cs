using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
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
        public object GetEmployees()
        {
            return _employeeBusinessLogic.GetEmployees();
            //return "hello world";
        }
    }
}
