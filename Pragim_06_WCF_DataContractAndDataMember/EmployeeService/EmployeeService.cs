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
      Employee employee = new Employee();
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
          employee.Id = Convert.ToInt32(reader["Id"]);
          employee.Name = reader["Name"].ToString();
          employee.Gender = reader["Gender"].ToString();
          employee.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
        }
      }
      return employee;
    }

    public void AddParameter(SqlCommand cmd, string name, object value)
    {
      SqlParameter parameter = new SqlParameter();
      parameter.ParameterName = name;
      parameter.Value = value;
      cmd.Parameters.Add(parameter);
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

        con.Open();
        cmd.ExecuteNonQuery();
      }
    }
  }
}
