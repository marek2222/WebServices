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
      EmployeeService1.IEmployeeService client =
          new EmployeeService1.EmployeeServiceClient();
      EmployeeService1.EmployeeRequest request = new EmployeeService1.EmployeeRequest("XYZ120FABC", Convert.ToInt32(txtID.Text));

      EmployeeService1.EmployeeInfo employee = client.GetEmployee(request);

      if (employee.Type == EmployeeService1.EmployeeType.FullTimeEmployee)
      {
        txtAnnualSalary.Text = employee.AnnualSalary.ToString();
        trAnnualSalary.Visible = true;
        trHourlPay.Visible = false;
        trHoursWorked.Visible = false;
      }
      else
      {
        txtHourlyPay.Text = employee.HourlyPay.ToString();
        txtHoursWorked.Text = employee.HoursWorked.ToString();
        trAnnualSalary.Visible = false;
        trHourlPay.Visible = true;
        trHoursWorked.Visible = true;
      }
      ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();

      txtName.Text = employee.Name;
      txtGender.Text = employee.Gender;
      txtDateOfBirth.Text = employee.DOB.ToShortDateString();
      lblMessage.Text = "Employee retrieved";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
      EmployeeService1.IEmployeeService client = new
          EmployeeService1.EmployeeServiceClient();
      EmployeeService1.EmployeeInfo employee = new EmployeeService1.EmployeeInfo();

      if (ddlEmployeeType.SelectedValue == "-1")
      {
        lblMessage.Text = "Please select Employee Type";
      }
      else
      {
        if (((EmployeeService1.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue))
            == EmployeeService1.EmployeeType.FullTimeEmployee)
        {
          employee.AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text);
          employee.Type = EmployeeService1.EmployeeType.FullTimeEmployee;
        }
        else if (((EmployeeService1.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue))
            == EmployeeService1.EmployeeType.PartTimeEmployee)
        {
          employee.HourlyPay = Convert.ToInt32(txtHourlyPay.Text);
          employee.HoursWorked = Convert.ToInt32(txtHoursWorked.Text);
          employee.Type = EmployeeService1.EmployeeType.PartTimeEmployee;
        }

        employee.ID = Convert.ToInt32(txtID.Text);
        employee.Name = txtName.Text;
        employee.Gender = txtGender.Text;
        employee.DOB = Convert.ToDateTime(txtDateOfBirth.Text);

        client.SaveEmployee(employee);
        lblMessage.Text = "Employee saved";
      }
    }

    protected void ddlEmployeeType_SelectedIndexChanged
        (object sender, EventArgs e)
    {
      if (ddlEmployeeType.SelectedValue == "-1")
      {
        trAnnualSalary.Visible = false;
        trHourlPay.Visible = false;
        trHoursWorked.Visible = false;
      }
      else if (ddlEmployeeType.SelectedValue == "1")
      {
        trAnnualSalary.Visible = true;
        trHourlPay.Visible = false;
        trHoursWorked.Visible = false;
      }
      else
      {
        trAnnualSalary.Visible = false;
        trHourlPay.Visible = true;
        trHoursWorked.Visible = true;
      }
    }

  }
}