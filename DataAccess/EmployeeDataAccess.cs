using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Task<List<Employee>> GetEmployeesAsync()
        {
            return ConsumeEmployeesAPI();
        }

        public async Task<Employee> GetEmployeeAsync(int employeeId)
        {
            var employeeList = await ConsumeEmployeesAPI();
            return employeeList.Find(x => x.id == employeeId);
        }

        private async Task<List<Employee>> ConsumeEmployeesAPI()
        {
            List<Employee> employeeList = new List<Employee>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://masglobaltestapi.azurewebsites.net/api/Employees"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employeeList = JsonConvert.DeserializeObject<List<Employee>>(apiResponse);
                }
            }

            return employeeList;
        }
    }
}
