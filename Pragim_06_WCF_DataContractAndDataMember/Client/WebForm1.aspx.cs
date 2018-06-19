﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
  public partial class WebForm1 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetEmployee_Click(object sender, EventArgs e)
    {
      EmployeeService1.EmployeeServiceClient client = new EmployeeService1.EmployeeServiceClient();
      EmployeeService1.Employee employee = client.GetEmployee(Convert.ToInt32(txtID.Text));

      if (employee.Type == EmployeeService1.EmployeeType.FullTimeEmployee)
      {
        txtAnnualSalary.Text = ((EmployeeService1.FullTimeEmployee)employee).AnnualSalary.ToString();
        trAnnualSalary.Visible = true;
        trHourlPay.Visible = false;
        trHoursWorked.Visible = false;
      }
      else
      {
        txtHourlyPay.Text = ((EmployeeService1.PartTimeEmployee)employee).HourlyPay.ToString();
        txtHoursWorked.Text = ((EmployeeService1.PartTimeEmployee)employee).HoursWorked.ToString();
        trAnnualSalary.Visible = false;
        trHourlPay.Visible = true;
        trHoursWorked.Visible = true;
      }
      ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();

      txtName.Text = employee.Name;
      txtGender.Text = employee.Gender;
      txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
      lblMessage.Text = "Employee retrieved";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
      EmployeeService1.EmployeeServiceClient client = new EmployeeService1.EmployeeServiceClient();
      EmployeeService1.Employee employee = null;

      if (((EmployeeService1.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue))
             == EmployeeService1.EmployeeType.FullTimeEmployee)
      {
        employee = new EmployeeService1.FullTimeEmployee
        {
          Id = Convert.ToInt32(txtID.Text),
          Name = txtName.Text,
          Gender = txtGender.Text,
          DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
          Type = EmployeeService1.EmployeeType.FullTimeEmployee,
          AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text),
        };
        client.SaveEmployee(employee);
        lblMessage.Text = "Employee saved";
      }
      else if (((EmployeeService1.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue))
          == EmployeeService1.EmployeeType.PartTimeEmployee)
      {
        employee = new EmployeeService1.PartTimeEmployee
        {
          Id = Convert.ToInt32(txtID.Text),
          Name = txtName.Text,
          Gender = txtGender.Text,
          DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
          Type = EmployeeService1.EmployeeType.PartTimeEmployee,
          HourlyPay = Convert.ToInt32(txtHourlyPay.Text),
          HoursWorked = Convert.ToInt32(txtHoursWorked.Text),
        };
        client.SaveEmployee(employee);
        lblMessage.Text = "Employee saved";
      }
      else
      {
        lblMessage.Text = "Please select Employee Type";
      }
    }

    protected void ddlEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (ddlEmployeeType.SelectedValue == "-1")
      {
        trAnnualSalary.Visible  = false;
        trHourlPay.Visible      = false;
        trHoursWorked.Visible   = false;
      }
      else if (ddlEmployeeType.SelectedValue == "1")
      {
        trAnnualSalary.Visible  = true;
        trHourlPay.Visible      = false;
        trHoursWorked.Visible   = false;
      }
      else
      {
        trAnnualSalary.Visible  = false;
        trHourlPay.Visible      = true;
        trHoursWorked.Visible   = true;
      }
    }
  }
}