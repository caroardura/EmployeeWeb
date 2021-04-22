using AutoMapper;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class EmployeeFactory 
    {
        private IMapper _mapper;

        public EmployeeFactory(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Employee GetEmployee(EmployeeRaw employee)
        {
            switch (employee.contractTypeName)
            {
                case "HourlySalaryEmployee":
                    return _mapper.Map<EmployeeHourly>(employee);
                default: // "MonthlySalaryEmployee"
                    return _mapper.Map<EmployeeMonthly>(employee);
            }
        }
    }
}
