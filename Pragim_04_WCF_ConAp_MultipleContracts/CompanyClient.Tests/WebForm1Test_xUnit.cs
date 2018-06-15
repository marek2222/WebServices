////using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Xunit;

//namespace CompanyClient.Tests
//{
//  public class WebForm1Test_xUnit
//  {
//    public WebForm1Test_xUnit()
//    {
//    }

//    [Fact]
//    public void PublicServiceTest()
//    {
//      // Arrange 
//      WebForm1 client = new WebForm1();
//      string message = "This is public information and available over HTTP to all general public outside the FireWall";
//      // Act
//      string result = client.GetPublicServiceClient();
//      // Assert
//      Assert.Equal(message, result);
//    }


//    [Fact]
//    public void PublicConfidentialTest()
//    {
//      WebForm1 client = new WebForm1();
//      string message = "This is confidential information and only available over TCP behind the company FireWall";
//      string result = client.GetConfidentialServiceClient();
//      Assert.Equal(message, result);
//    }

//  }

//}
