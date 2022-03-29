using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollServiceADO.NET
{
    internal class Program
    {
        public static void Display(List<EmployeePayroll> employees)
        {
            foreach (var data in employees)
            {
                Console.WriteLine(data.name + " " + data.phone);
            }
        }
        static void Main(string[] args)
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            DataTable data=employeeRepo.GetAllEmployees();
            List<EmployeePayroll> EmpList = new List<EmployeePayroll>();
            foreach (DataRow dr in data.Rows)
            {

                EmpList.Add(

                    new EmployeePayroll
                    {

                        employeeId = Convert.ToInt32(dr["employeeId"]),
                        name = Convert.ToString(dr["name"]),
                        phone = Convert.ToString(dr["phone"]),
                        address = Convert.ToString(dr["address"]),
                        gender = Convert.ToChar(dr["gender"]),
                        basic_pay = Convert.ToInt32(dr["basic_pay"]),

                        deduction = Convert.ToInt32(dr["deduction"]),

                        taxable_pay = Convert.ToInt32(dr["taxable_pay"]),

                        income_tax = Convert.ToInt32(dr["income_tax"]),

                        net_pay = Convert.ToInt32(dr["net_pay"]),
                        start_Date = Convert.ToDateTime(dr["starting_Date"])
                    }

                    ); ;
            }
              Display(EmpList);

        }

    }
    }

