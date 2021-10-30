using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
    public class SalaryDetailModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string JobDeacription { get; set; }

        public string Month { get; set; }

        public int EmployeeSalary { get; set; }

        public int SalaryId { get; set; }
    }
}