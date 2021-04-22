using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic;
using DataAccess;
using EmployeeWeb.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private IEmployeeBusinessLogic _employeeBusinessLogic;
        private IMapper _mapper;

        public EmployeeController(IEmployeeBusinessLogic employeeBusinessLogic, IMapper mapper)
        {
            _employeeBusinessLogic = employeeBusinessLogic;
            _mapper = mapper;
        }

        [HttpGet("")]
        public Task<List<EmployeeRaw>> GetEmployees()
        {
            return _employeeBusinessLogic.GetEmployees();
        }

        [HttpGet("{employeeId}")]
        public EmployeeDTO GetEmployee(int employeeId)
        {
            var employee = _employeeBusinessLogic.GetEmployee(employeeId);
            return _mapper.Map<EmployeeDTO>(employee);
        }
    }
}
