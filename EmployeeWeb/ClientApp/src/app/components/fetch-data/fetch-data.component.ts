import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { EmployeeService } from '../../services/employee/employee.service';
import { Employee } from '../../models/employee/Employee';


@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  public employeeList;

  constructor(public employeeService: EmployeeService,
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));

    this.getEmployees();
  }

  getEmployees() {
    this.employeeService.employeeService().subscribe(
      data => { this.employeeList = data;
        console.log(this.employeeList);
},
      err => console.error(err));

  }
}


interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}


