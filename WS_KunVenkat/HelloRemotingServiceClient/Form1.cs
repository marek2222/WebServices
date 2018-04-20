using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace HelloRemotingServiceClient
{
  public partial class Form1 : Form
  {
    IHelloRemotingService.IHelloRemtingService client;
    public Form1()
    {
      InitializeComponent();
      TcpChannel channel = new TcpChannel();
      ChannelServices.RegisterChannel(channel);
      client = (IHelloRemotingService.IHelloRemtingService)Activator.GetObject(
        typeof(IHelloRemotingService.IHelloRemtingService),
        "tcp://localhost:8080/PokazPowitanie");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      label1.Text = client.PokazPowitanie(textBox1.Text);
    }
  }
}
