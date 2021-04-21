import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { EmployeeService } from '../../services/employee/employee.service';
import { Employee } from '../../models/employee/Employee';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent {
  public employees: Employee[];

  constructor(public employeeService: EmployeeService) {

  }

  getEmployees() {
    this.employeeService.employeeService().subscribe(
      data => {
        this.employees = data;
      },
      err => console.error(err));
  }
}


