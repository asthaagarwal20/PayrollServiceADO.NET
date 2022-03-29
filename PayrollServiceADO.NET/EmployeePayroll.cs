using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollServiceADO.NET
{
    internal class EmployeePayroll
    {
        public int employeeId { get; set; }
        public string name { get; set;}
        public string phone { get; set;}
        public string address { get; set; }
        public char gender { get; set; }
        public double basic_pay { get; set; }
        public double taxable_pay { get; set; }
        public double net_pay { get; set; }
        public double income_tax     { get; set; }
        public double deduction { get; set; }
        public DateTime start_Date { get; set; }
         

    }
}
