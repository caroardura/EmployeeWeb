using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public async Task<object> GetEmployeesAsync()
        {
            var aa = await ConsumeEmployeesAPI();
            return "hello world";
        }

        public async Task<bool> ConsumeEmployeesAPI()
            //public async Task<IActionResult> Index()
        {
            //List<Reservation> reservationList = new List<Reservation>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://masglobaltestapi.azurewebsites.net/api/Employees"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //reservationList = JsonConvert.DeserializeObject<List<Reservation>>(apiResponse);
                }
            }
            return true;
        }
    }
}
