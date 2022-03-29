using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollServiceADO.NET
{
    public class EmployeeRepo
    {
        public static string connectionString= "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = payroll_service; Integrated Security = True; MultipleActiveResultSets=True";
        SqlConnection connection = new SqlConnection(connectionString);
        
        public DataTable GetAllEmployees()
        {
            try
            {
                DataTable dataset = new DataTable();
                using(this.connection)
                {
                    this.connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("getEmployees",this.connection);
                    adapter.Fill(dataset);
                    this.connection.Close();
                    return dataset;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.connection.Close ();
            }
        }
    }
}
