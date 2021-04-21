import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Employee } from '../../models/employee/Employee';

@Injectable()
export class EmployeeService {
  apiURL: string;
  constructor(public http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiURL = baseUrl;
  }

  getEmployees() {
    return this.http.get<Employee[]>(this.apiURL + 'api/Employee');
  }

  getEmployee(id: number) {
    return this.http.get<Employee>(this.apiURL + 'api/Employee/' + id);
  }
}
