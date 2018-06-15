using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyClient
{
  public partial class WebForm1 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      Label1.Text = GetPublicServiceClient();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      Label2.Text = GetConfidentialServiceClient();
    }

    public string GetPublicServiceClient()
    {
      CompanyService.MyCompanyPublicServiceClient client1
        = new CompanyService.MyCompanyPublicServiceClient(
          "BasicHttpBinding_IMyCompanyPublicService");
      return client1.GetPublicInformation();
    }

    public string GetConfidentialServiceClient()
    {
      CompanyService.MyCompanyConfidentialServiceClient client2
        = new CompanyService.MyCompanyConfidentialServiceClient(
          "NetTcpBinding_IMyCompanyConfidentialService");
      return client2.GetCofidentialInformation();
    }

  }
}