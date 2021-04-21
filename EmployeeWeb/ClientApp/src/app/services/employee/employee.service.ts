import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Employee } from '../../models/employee/Employee';

@Injectable()
export class EmployeeService {
  apiURL: string;
  constructor(public http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiURL = baseUrl + 'api/Employee/';
  }

  getEmployees() {
    return this.http.get<Employee[]>(this.apiURL);
  }

  getEmployee(id: number) {
    return this.http.get<Employee>(this.apiURL + id);
  }
}
