import { Component, Inject } from '@angular/core';
import { EmployeeService } from '../../services/employee/employee.service';
import { Employee } from '../../models/employee/Employee';
import { isNumeric } from 'rxjs/util/isNumeric';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent {
  public employees: Employee[];

  constructor(public employeeService: EmployeeService) {
  }

  getEmployees(id: string) {
    if (id == "")
      this.employeeService.getEmployees().subscribe(
        data => {
          this.employees = data;
        },
        err => console.error(err));
    else if (!isNumeric(id)) 
      alert("Please enter a number or leave it empty to get all the employees.");
    else // User entered an id
      this.employeeService.getEmployee(id).subscribe(
        data => {
          this.employees = [data];
        },
        err => console.error(err));
  }
}


