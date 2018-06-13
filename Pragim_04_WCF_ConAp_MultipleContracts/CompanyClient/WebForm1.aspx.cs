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
      CompanyService.MyCompanyPublicServiceClient client1
        = new CompanyService.MyCompanyPublicServiceClient(
          "BasicHttpBinding_IMyCompanyPublicService");
      Label1.Text = client1.GetPublicInformation();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      CompanyService.MyCompanyConfidentialServiceClient client2
        = new CompanyService.MyCompanyConfidentialServiceClient(
          "NetTcpBinding_IMyCompanyConfidentialService");
      Label2.Text = client2.GetCofidentialInformation();
    }

  }
}