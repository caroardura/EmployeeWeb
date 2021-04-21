import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';

@Injectable()
export class EmployeeService {
  apiURL: string;
  constructor(public http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiURL = baseUrl;
  }

  employeeService() {
    return this.http.get(this.apiURL + 'api/Employee');
  }
}
