using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompanyService.Tests
{
  [TestClass]
  public class UnitTestWCF
  {
    [TestInitialize]
    public void TestInitialize()    {    }

    [TestCleanup]
    public void TestCleanup()       {    }

    [TestMethod]
    public void Test_EqualPublicInformation()
    {
      ServiceReference1.IMyCompanyPublicService client = new 
        ServiceReference1.MyCompanyPublicServiceClient(
          "BasicHttpBinding_IMyCompanyPublicService");
      
      string message = "This is public information and available over HTTP to all general public outside the FireWall";
      string result = client.GetPublicInformation();
      Assert.AreEqual(message, result, "Poprawny  tekst");
    }

    [TestMethod]
    public void Test_EqualConfidentialInformation()
    {
      ServiceReference1.MyCompanyConfidentialServiceClient client2 = new
          ServiceReference1.MyCompanyConfidentialServiceClient(
            "NetTcpBinding_IMyCompanyConfidentialService");

      string message = "This is confidential information and only available over TCP behind the company FireWall";
      string result = client2.GetCofidentialInformation();
      Assert.AreEqual(message, result, "Poprawny  tekst");
    }


  }
}
