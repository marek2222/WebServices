using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MachService_Client
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Aby aplikacja zadziałała przez NetTcpBinding_IMathService 
      // należy uruchomić usługę na hoście MathService_Host przez VS 
      // w trybie Administratora. 
      // W oddzielnej instancji VS także w trybie Aministratora 
      // uruchom tego klienta 
      MathService.MathServiceClient client = new MathService.MathServiceClient("NetTcpBinding_IMathService");
      label2.Text = client.Addition(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
    }

  }
}
