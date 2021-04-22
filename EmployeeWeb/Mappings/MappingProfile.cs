using AutoMapper;
using BusinessLogic;
using DataAccess;

namespace EmployeeWeb.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeRaw, EmployeeHourly>();
            CreateMap<EmployeeRaw, EmployeeMonthly>();

        }
    }
}
