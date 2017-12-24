﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yzslz.yzslz_form;

namespace yzslz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
