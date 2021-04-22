
namespace BusinessLogic
{
    public class EmployeeMonthly : Employee
    {
        public override decimal CalculateAnnualSalary()
        {
            return MonthlySalary * 12;
        }
    }
}