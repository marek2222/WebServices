using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemo
{
  /// <summary>
  /// Summary description for HelloWebService
  /// </summary>
  [WebService(Namespace = "http://marek2222.com/WebServices")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
  // [System.Web.Script.Services.ScriptService]
  public class HelloWebService : System.Web.Services.WebService
  {

    [WebMethod]
    public string Powitanie(string nazwa)
    {
      return "Cześć " + nazwa;
    }
  }
}
