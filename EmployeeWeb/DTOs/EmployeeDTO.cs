
namespace EmployeeWeb.DTOs
{
    public class EmployeeDTO
    {
        public int Id
        { get; set; }
        public string Name
        { get; set; }
        public string ContractTypeName
        { get; set; }
        public string RoleName
        { get; set; }
        public decimal HourlySalary
        { get; set; }
        public decimal MonthlySalary
        { get; set; }
        public decimal AnnualSalary { get; set; }
    }
}
