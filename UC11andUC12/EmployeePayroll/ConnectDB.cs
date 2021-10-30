using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DBConnection
{
    public class ConnectDB
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PayrollService;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        public void getData()
        {
            try
            {
                Employee emp = new Employee();
                using(this.conn)
                {
                    string query = @"select * from employee_payroll";
                    SqlCommand cmd = new SqlCommand(query, this.conn);
                    this.conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.HasRows)
                    {
                        while(dr.Read())
                        {
                            emp.id = dr.GetInt32(0);
                            emp.name = dr.GetString(1);
                            emp.salary = dr.GetInt32(2);
                            emp.startDate = dr.GetDateTime(3);
                            emp.gender = dr.GetString(4);
                            emp.basicPay = dr.GetInt32(5);
                            emp.deduction = dr.GetInt32(6);
                            emp.netPay = dr.GetInt32(7);
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",emp.id, emp.name,emp.salary,emp.startDate,emp.gender,emp.basicPay,emp.deduction,emp.netPay);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    dr.Close();
                    this.conn.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
