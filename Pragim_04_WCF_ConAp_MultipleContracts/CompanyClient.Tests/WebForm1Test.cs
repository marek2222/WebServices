using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompanyClient.Tests
{
  [TestClass]
  public class WebForm1Test
  {
    [TestMethod]
    public void PublicServiceTest()
    {
      // Arrange 
      WebForm1 client = new WebForm1();
      string message = "This is public information and available over HTTP to all general public outside the FireWall";
      // Act
      string result = client.GetPublicServiceClient();
      // Assert
      Assert.AreEqual(message, result, "Pełna zgodność.");
    }

    [TestMethod]
    public void PublicConfidentialTest()
    {
      WebForm1 client = new WebForm1();
      string message = "This is confidential information and only available over TCP behind the company FireWall";
      string result = client.GetConfidentialServiceClient();
      Assert.AreEqual(message, result, "Pełna zgodność.");
    }
  }
}
