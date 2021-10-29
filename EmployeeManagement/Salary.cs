using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeeManagement
{
    public class Salary
    {
        private  static SqlConnection ConnectionSetup()
        {
            return new SqlConnection("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = Payroll_service; Integrated Security = True");

        }
         public int UpdateEmployeeSalary(SalaryUpdateModel model)
        {
            SqlConnection salaryconnection = ConnectionSetup();

            int Salary = 0;
            try
            {
                using (salaryconnection)
                {
                    SalaryDetailsModel displayModel = new SalaryDetailsModel();
                    SqlCommand command = new SqlCommand("SpUpdateEmployeeSalary",salaryconnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", model.SalaryId);
                    command.Parameters.AddWithValue("@month", model.Month);
                    command.Parameters.AddWithValue("@salary", model.EmployeeSalary);
                    command.Parameters.AddWithValue("@EmpId", model.EmployeeId);

                    salaryconnection.Open();

                    SqlDataReader dr = command.ExecuteReader();

                    if(dr.HasRows)
                    {
                        while(dr.Read())
                        {
                            displayModel.EmployeeId = (int)dr["EmployeeID"];
                            displayModel.EmployeeName = dr["EmployeeName"].ToString();
                            displayModel.EmployeeSalary = (int)dr["EmpSalary"];
                            displayModel.Month = dr["SalaryMonth"].ToString();
                            displayModel.SalaryID = (int)dr["SalaryId"];

                            Console.WriteLine("{0},{1},{2},{3}", displayModel.EmployeeId, displayModel.EmployeeName, displayModel.EmployeeSalary, displayModel.Month);

                            Salary = displayModel.EmployeeSalary;
                        }
                    }


                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
         
            }
            finally
            {
                salaryconnection.Close();
            }

            return Salary;
        }
    }
}
