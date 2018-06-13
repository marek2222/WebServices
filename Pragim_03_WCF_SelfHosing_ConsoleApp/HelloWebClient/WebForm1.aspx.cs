using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWebClient
{
  public partial class WebForm1 : System.Web.UI.Page
  {
    private HelloService.HelloServiceClient client = null;
    
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        client = new HelloService.HelloServiceClient("BasicHttpBinding_IHelloService");
      }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      Label1.Text = CallGetMessage(TextBox1.Text);
    }

    public string CallGetMessage(string message)
    {
      return client.GetMessage(message);
    }
  }
}