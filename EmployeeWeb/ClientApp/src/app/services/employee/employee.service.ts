import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from '../../models/employee/Employee';

@Injectable()
export class EmployeeService {
  apiURL: string;
  constructor(public http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiURL = baseUrl;
  }

  getCustomers(): Employee[]{
    var employeeList: Employee[];
    this.http.get<Employee[]>(this.apiURL + 'api/Employee').subscribe(result => {
      employeeList = result;
    }, error => console.error(error));

    return employeeList;
  }
}
