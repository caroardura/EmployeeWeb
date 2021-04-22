using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic;
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

        [HttpGet("{employeeId}")]
        public async Task<EmployeeDTO> GetEmployee(int employeeId)
        {
            var employee = await _employeeBusinessLogic.GetEmployee(employeeId);
            return _mapper.Map<EmployeeDTO>(employee);
        }

        [HttpGet("")]
        public async Task<List<EmployeeDTO>> GetEmployees()
        {
            List<Employee> employeeList = await _employeeBusinessLogic.GetEmployees();
            return _mapper.Map<List<EmployeeDTO>>(employeeList);
        }
    }
}
