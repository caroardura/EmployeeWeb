using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public async Task<EmployeeRaw> GetEmployeeAsync(int employeeId)
        {
            var employeeList = await ConsumeEmployeesAPI();
            return employeeList.Find(x => x.id == employeeId);
        }
        public Task<List<EmployeeRaw>> GetEmployeesAsync()
        {
            return ConsumeEmployeesAPI();
        }

        private async Task<List<EmployeeRaw>> ConsumeEmployeesAPI()
        {
            List<EmployeeRaw> employeeList = new List<EmployeeRaw>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://masglobaltestapi.azurewebsites.net/api/Employees"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employeeList = JsonConvert.DeserializeObject<List<EmployeeRaw>>(apiResponse);
                }
            }

            return employeeList;
        }
    }
}
