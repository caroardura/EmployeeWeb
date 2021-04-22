
namespace BusinessLogic
{
    public class EmployeeHourly : Employee
    {
        public override decimal CalculateAnnualSalary()
        {
            return 120 * HourlySalary * 12;
        }
    }
}
