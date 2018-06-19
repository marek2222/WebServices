using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeService
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
  public class EmployeeService : IEmployeeService
  {

    public Employee GetEmployee(int Id)
    {
      Employee employee = null;
      string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
      using (SqlConnection con = new SqlConnection(cs))
      {
        SqlCommand cmd = new SqlCommand("spGetEmployee", con);
        cmd.CommandType = CommandType.StoredProcedure;
        AddParameter(cmd, "@Id", (object)Id);
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
          if ((EmployeeType)reader["EmployeeType"] == EmployeeType.FullTimeEmployee)
          {
            employee = new FullTimeEmployee
            {
              Id = Convert.ToInt32(reader["Id"]),
              Name = reader["Name"].ToString(),
              Gender = reader["Gender"].ToString(),
              DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
              Type = EmployeeType.FullTimeEmployee,
              AnnualSalary = Convert.ToInt32(reader["AnnualSalary"])
              //@HourlyPay int = null,
              //@HoursWorked int = null
            };
          }
          else
          {
            employee = new PartTimeEmployee
            {
              Id = Convert.ToInt32(reader["Id"]),
              Name = reader["Name"].ToString(),
              Gender = reader["Gender"].ToString(),
              DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
              Type = EmployeeType.PartTimeEmployee,
              //AnnualSalary = Convert.ToInt32(reader["AnnualSalary"])
              HourlyPay = Convert.ToInt32(reader["HourlyPay"]),
              HoursWorked = Convert.ToInt32(reader["HoursWorked"])
            };
          }
        }
      }
      return employee;
    }


    public void SaveEmployee(Employee employee)
    {
      string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
      using (SqlConnection con = new SqlConnection(cs))
      { 
        SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
        cmd.CommandType = CommandType.StoredProcedure;

        AddParameter(cmd, "@Id",          (object)employee.Id);
        AddParameter(cmd, "@Name",        (object)employee.Name);
        AddParameter(cmd, "@Gender",      (object)employee.Gender);
        AddParameter(cmd, "@DateOfBirth", (object)employee.DateOfBirth);
        AddParameter(cmd, "@EmployeeType",(object)employee.Type);
        
        if (employee.GetType() == typeof(FullTimeEmployee)) {
          AddParameter(cmd, "@AnnualSalary",((FullTimeEmployee)employee).AnnualSalary);
        }
        else {
          AddParameter(cmd, "@HourlyPay",   ((PartTimeEmployee)employee).HourlyPay);
          AddParameter(cmd, "@HoursWorked", ((PartTimeEmployee)employee).HoursWorked);
        }

        con.Open();
        cmd.ExecuteNonQuery();
      }
    }


    public void AddParameter(SqlCommand cmd, string name, object value)
    {
      SqlParameter parameter = new SqlParameter();
      parameter.ParameterName = name;
      parameter.Value = value;
      cmd.Parameters.Add(parameter);
    }

  }
}
