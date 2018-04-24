using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MathService_Host
{
  class Program
  {
    static void Main(string[] args)
    {
      using (ServiceHost host = new ServiceHost(typeof(MathService.MathService)))
      {
        host.Open();
        Console.WriteLine("Service Hosted Sucessfully");
        Console.Read();
      }
      
    }
  }
}
