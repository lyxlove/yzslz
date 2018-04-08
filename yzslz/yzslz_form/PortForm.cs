using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

using System.Windows.Forms;
using yzslz.yzslz_form.ChildForm;

namespace yzslz.yzslz_form
{
    public partial class PortForm : Form
    {
        public PortForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestPortForm form = new TestPortForm();
            form.ShowDialog(this);
        }

        private void btnStartOne_Click(object sender, EventArgs e)
        {
            string strIp = txtIPOne.Text;
            string strPort = txtPortOne.Text;

            IPAddress iPAddress = IPAddress.Parse(strIp);
            TcpListener tcpListener = new TcpListener(iPAddress,Convert.ToInt32(strPort));
            tcpListener.Start();
            while (true)

            {

                TcpClient tcpClient = tcpListener.AcceptTcpClient();//接受挂起的tcp请求

                NetworkStream ns = tcpClient.GetStream();

                StreamReader sr = new StreamReader(ns);

                string result = sr.ReadToEnd();

                //显示读取的字符串

               // Invoke(new UpdateDisplayDelegate(UpdateDisplay), new object[] { result });

            }
        }
    }
}
