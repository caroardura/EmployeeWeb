using System.Collections.Generic;
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
        public EmployeeDTO GetEmployee(int employeeId)
        {
            var employee = _employeeBusinessLogic.GetEmployee(employeeId);
            return _mapper.Map<EmployeeDTO>(employee);
        }

        [HttpGet("")]
        public List<EmployeeDTO> GetEmployees()
        {
            List<Employee> employeeList = _employeeBusinessLogic.GetEmployees();
            return _mapper.Map<List<EmployeeDTO>>(employeeList);
        }
    }
}
