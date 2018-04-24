using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace WCF_SelfHosing_Console_Host
{
  class Program
  {
    static void Main(string[] args)
    {
      ServiceHost studentServiceHost = null;
      try
      {
        //Base Address for StudentService
        Uri httpBaseAddress = new Uri("http://localhost:4321/StudentService");

        //Instantiate ServiceHost
        studentServiceHost = new ServiceHost(typeof(WCF_SelfHosing_Console.StudentService),
            httpBaseAddress);

        //Add Endpoint to Host
        studentServiceHost.AddServiceEndpoint(typeof(WCF_SelfHosing_Console.IStudentService),
                                                new WSHttpBinding(), "");

        //Metadata Exchange
        ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
        serviceBehavior.HttpGetEnabled = true;
        studentServiceHost.Description.Behaviors.Add(serviceBehavior);

        //Open
        studentServiceHost.Open();
        Console.WriteLine("Service is live now at : {0}", httpBaseAddress);
        Console.ReadKey();
      }

      catch (Exception ex)
      {
        studentServiceHost = null;
        Console.WriteLine("There is an issue with StudentService" + ex.Message);
      }
    }
  }
}
