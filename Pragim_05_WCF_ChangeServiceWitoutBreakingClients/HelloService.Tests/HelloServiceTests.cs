using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloService.Tests
{
  [TestClass]
  public class HelloServiceTests
  {
    private HelloService1.HelloServiceClient client = null;

    [TestInitialize]
    public void TestInit()
    {
      //Arrange test
      client = new HelloService1.HelloServiceClient("BasicHttpBinding_IHelloService");
    }

    [TestCleanup]
    public void TestClean()
    {
      client = null;
    }


    [TestMethod]
    public void Test_EqualMessageIsEmpty()
    {
      string message = "";
      string result = client.GetMessage(message);
      Assert.AreEqual("Hello " + message, result, "Pusty tekst");
    }

    [TestMethod]
    public void Test_EqualMessage()
    {
      string message = "message";
      string result = client.GetMessage(message);
      Assert.AreEqual("Hello " + message, result, "Poprawny tekst");
    }

  }
}
