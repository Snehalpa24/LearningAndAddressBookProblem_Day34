using System;
using System.Collections.Generic;
using System.Text;

namespace DBConnection
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public DateTime startDate { get; set; }
        public string gender { get; set; }
        public int basicPay { get; set; }
        public int deduction { get; set; }
        public int netPay { get; set; }
    }
}
