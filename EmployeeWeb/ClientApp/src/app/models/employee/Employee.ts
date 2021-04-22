import { IEmployee } from "./IEmployee";

export class Employee implements IEmployee {
  public id: number;
  public name: string;
  public contractTypeName: string;
  public roleName: string;
  public hourlySalary: number;
  public monthlySalary: number;
  public annualSalary: number;
}
