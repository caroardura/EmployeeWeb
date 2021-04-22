import { Component } from '@angular/core';
import { EmployeeService } from '../../services/employee/employee.service';
import { Employee } from '../../models/employee/Employee';
import { isNumeric } from 'rxjs/util/isNumeric';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.scss']
})
export class EmployeeComponent {
  public employees: Employee[];

  constructor(public employeeService: EmployeeService) {
    this.getEmployees("");
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
          if (data == null)
            alert("Employee not found");
          else
            this.employees = [data];
        },
        err => console.error(err));
  }
}


