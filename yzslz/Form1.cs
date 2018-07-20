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

namespace yzslz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SQLHelper sqlHelper = new SQLHelper();
            int t = sqlHelper.ExcuteSql("SELECT * FROM  VEHICLE_DISPATCH");
            MessageBox.Show(t.ToString());
           

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
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
    }
}
