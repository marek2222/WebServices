using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EmployeeService.Tests
{
  //[TestClass]
  //public class EmployeeServiceTest
  //{
  //  private EmployeeService1.EmployeeServiceClient client = null;
  //  public bool IsSaveFullTimeEmployee { get; set; }
  //  public bool IsSavePartTimeEmployee { get; set; }

  //  [TestInitialize]
  //  public void TestInit()  //Arrange test
  //  {
  //    client = new EmployeeService1.EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
  //  }
  //  [TestCleanup]
  //  public void TestClean()
  //  {
  //    client = null;
  //  }

  //  //Insert into tblEmployee values(1, 'Mark', 'Male', '10/10/1982', FullTimeEmployee, 5000)
  //  private void SaveFullTimeEmployee()
  //  {
  //    if (IsSaveFullTimeEmployee) // zapisz tylko raz
  //      return;
  //    IsSaveFullTimeEmployee = true;

  //    client.GetEmployee(1);
  //    EmployeeService1.Employee employee = new EmployeeService1.FullTimeEmployee
  //    {
  //      Id = 1,
  //      Name = "Mark",
  //      Gender = "Male",
  //      DateOfBirth = DateTime.Parse("10/10/1982"),
  //      Type = EmployeeService1.EmployeeType.FullTimeEmployee,
  //      AnnualSalary = 6000
  //    };
  //    client.SaveEmployee(employee);
  //  }

  //  [TestMethod]
  //  public void SaveFullTimeEmployee_Name()
  //  {
  //    SaveFullTimeEmployee();
  //    Assert.AreEqual("Mark", client.GetEmployee(1).Name);
  //  }
  //  [TestMethod]
  //  public void SaveFullTimeEmployee_Gender()
  //  {
  //    SaveFullTimeEmployee();
  //    Assert.AreEqual("Male", client.GetEmployee(1).Gender);
  //  }
  //  [TestMethod]
  //  public void SaveFullTimeEmployee_DateOfBirth()
  //  {
  //    SaveFullTimeEmployee();
  //    Assert.AreEqual(DateTime.Parse("10/10/1982"), client.GetEmployee(1).DateOfBirth);
  //  }
  //  [TestMethod]
  //  public void SaveFullTimeEmployee_Type()
  //  {
  //    SaveFullTimeEmployee();
  //    Assert.AreEqual(EmployeeService1.EmployeeType.FullTimeEmployee, client.GetEmployee(1).Type);
  //  }
  //  [TestMethod]
  //  public void SaveFullTimeEmployee_AnnualSalary()
  //  {
  //    SaveFullTimeEmployee(); Assert.AreEqual(6000, ((EmployeeService1.FullTimeEmployee)client.GetEmployee(1)).AnnualSalary);
  //  }

  //}
}
