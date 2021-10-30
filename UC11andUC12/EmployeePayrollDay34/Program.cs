using System;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryUpdateModel model;
            Salary.ConnectionSetup();
            Salary obj = new Salary();
            obj.UpdateEmployeeSalary(model);
        }
    }
}
