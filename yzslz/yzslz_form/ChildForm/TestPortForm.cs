using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

using System.Windows.Forms;

namespace yzslz.yzslz_form.ChildForm
{
    public partial class TestPortForm : Form
    {
        public TestPortForm()
        {
            InitializeComponent();
        }

        private void btnIsUse_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(txtPort.Text);
            bool succ = PortInUse(port);
            if (!succ)
            {
                MessageBox.Show("端口被占用");
            }
            else
            {
                MessageBox.Show("端口可以使用");
            }
        }

        private bool PortInUse(int port)
        {

            IPGlobalProperties iPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] iPEndPoints = iPGlobalProperties.GetActiveTcpListeners();

            foreach (IPEndPoint endPoint in iPEndPoints)
            {
                if (endPoint.Port == port)
                {
                    return false;
                }
            }

            return true;

        }

        private void btnGetIP_Click(object sender, EventArgs e)
        {
            GetIPv4();
        }

        private void GetLocalIp()
        {
            richTextBox1.Text = string.Empty;
            string name = Dns.GetHostName();
            IPAddress[] iPAddress = Dns.GetHostAddresses(name);
            foreach (var item in iPAddress)
            {
                richTextBox1.AppendText(item.ToString()+"\r\n");
            }

        }

        private void GetIPv4()
        {
            richTextBox1.Text = string.Empty;
            string HostName = Dns.GetHostName(); //得到主机名
            IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
            for (int i = 0; i < IpEntry.AddressList.Length; i++)
            {
                //从IP地址列表中筛选出IPv4类型的IP地址
                //AddressFamily.InterNetwork表示此IP为IPv4,
                //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                     IpEntry.AddressList[i].ToString();
                    richTextBox1.AppendText(IpEntry.AddressList[i].ToString() + "\r\n");
                }
            }
        }
    }
}
