using AutoMapper;
using BusinessLogic;
using DataAccess;
using EmployeeWeb.DTOs;

namespace EmployeeWeb.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeRaw, EmployeeHourly>();
            CreateMap<EmployeeRaw, EmployeeMonthly>();

            CreateMap<EmployeeHourly, EmployeeDTO>();
            CreateMap<EmployeeMonthly, EmployeeDTO>();
        }
    }
}
