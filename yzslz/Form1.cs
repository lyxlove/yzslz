using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yzslz.yzslz_form;
using YDLL;
using System.Data.SqlClient;
using yzslz.Model;
using YZSLZ.SQLDataServer;
using System.Threading;
using System.Reflection;

namespace yzslz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           // Assembly assembly = Assembly.Load("");
            //Type type =  assembly.GetType("", false, true);
            InitializeComponent();
            //SQLHelper sqlHelper = new SQLHelper();
            //int t = sqlHelper.ExcuteSql("SELECT * FROM  VEHICLE_DISPATCH");
            //MessageBox.Show(t.ToString());
           

        }

        public void CatchText( int i = 0)
        {
            string k = "";
            int j = 0;
            try
            {
                j = Convert.ToInt32(k);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message},时间：{DateTime.Now.ToString("hh:MM:ss")}");
                Thread.Sleep(3000);
                if (i < 5)
                {
                    
                    CatchText(++i);
                }
            }
            Console.WriteLine($"{i}的错误");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            CatchText();
            return;
               LogForm form1 = new LogForm();
            form1.ShowDialog(this);
        }

        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            ConnectDBForm form1 = new ConnectDBForm();
            form1.ShowDialog(this);
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            ThreadForm form1 = new ThreadForm();
            form1.ShowDialog(this);
        }

        private void btnPort_Click(object sender, EventArgs e)
        {
            PortForm form = new PortForm();
            form.ShowDialog(this);
        }

        private void btnSerialPort_Click(object sender, EventArgs e)
        {
            SerialPortForm form = new SerialPortForm();
            form.ShowDialog(this);
        }

        private void btnDBTest_Click(object sender, EventArgs e)
        {
           // DBTestForm form = new DBTestForm();
           // form.ShowDialog(this);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            FileForm fileForm = new FileForm();
            fileForm.ShowDialog(this);
        }

        private void btnNet_Click(object sender, EventArgs e)
        {
            NetTestForm form = new NetTestForm();
            form.ShowDialog(this);
        }

        private void txtRegx_Click(object sender, EventArgs e)
        {
            RegxForm form = new RegxForm();
            form.ShowDialog(this);
        }

        private void btnRegistry_Click(object sender, EventArgs e)
        {
            RegistryForm registryForm = new RegistryForm();
            registryForm.ShowDialog(this);
        }
    }
}
