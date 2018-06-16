using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeService.Tests
{
  [TestClass]
  public class EmployeeServiceTest
  {
    private EmployeeService1.EmployeeServiceClient client = null;

    [TestInitialize]
    public void TestInit()  //Arrange test
    {
      client = new EmployeeService1.EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
    }
    [TestCleanup]
    public void TestClean()
    {
      client = null;
    }


    //Insert into tblEmployee values(1, 'Mark', 'Male', '10/10/1980')
    [TestMethod]
    public void GetEmployee_1_Name()
    {
      string message = "Mark";
      string result = client.GetEmployee(1).Name;
      Assert.AreEqual(message, result);
      //Assert.AreEqual("Mark", client.GetEmployee(1).Name); //string message = "23"; string result = "23";
    }
    [TestMethod]    public void GetEmployee_1_Gender()    {      Assert.AreEqual("Male", client.GetEmployee(1).Gender);    }
    [TestMethod]    public void GetEmployee_1_DateOfBirth()    {      Assert.AreEqual(DateTime.Parse("10/10/1980"), client.GetEmployee(1).DateOfBirth);    }


    //Insert into tblEmployee values(2, 'Mary', 'Female', '11/10/1981')
    [TestMethod]    public void GetEmployee_2_Name()        { Assert.AreEqual("Mary",                       client.GetEmployee(2).Name  );    }
    [TestMethod]    public void GetEmployee_2_Gender()      { Assert.AreEqual("Female",                     client.GetEmployee(2).Gender);    }
    [TestMethod]    public void GetEmployee_2_DateOfBirth() { Assert.AreEqual(DateTime.Parse("11/10/1981"), client.GetEmployee(2).DateOfBirth);}


    //Insert into tblEmployee values(3, 'John', 'Male', '8/10/1979')
    [TestMethod]    public void GetEmployee_3_Name()        { Assert.AreEqual("John",                       client.GetEmployee(3).Name  );    }
    [TestMethod]    public void GetEmployee_3_Gender()      { Assert.AreEqual("Male",                       client.GetEmployee(3).Gender);    }
    [TestMethod]    public void GetEmployee_3_DateOfBirth() { Assert.AreEqual(DateTime.Parse("08/10/1979"), client.GetEmployee(3).DateOfBirth);}


    //Insert into tblEmployee values(3, 'John', 'Male', '8/10/1979')
    [TestMethod]
    public void SaveEmployee_4_Name()
    {
      SaveEmployee_4();
      Assert.AreEqual("John Porter", client.GetEmployee(4).Name);
    }
    [TestMethod]
    public void SaveEmployee_4_Gender()
    {
      SaveEmployee_4();
      Assert.AreEqual("Male", client.GetEmployee(4).Gender);
    }
    [TestMethod]
    public void SaveEmployee_4_DateOfBirth()
    {
      SaveEmployee_4();
      Assert.AreEqual(DateTime.Parse("01/01/1980"), client.GetEmployee(4).DateOfBirth);
    }
    private void SaveEmployee_4()
    {
      EmployeeService1.Employee employee = new EmployeeService1.Employee();
      employee.Id = 4;
      employee.Name = "John Porter";
      employee.Gender = "Male";
      employee.DateOfBirth = DateTime.Parse("01/01/1980");
      client.SaveEmployee(employee);
    }

  }
}
