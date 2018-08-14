using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace yzslz.yzslz_form
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        public void ReadConfig()
        {
            string sVal = ConfigurationSettings.AppSettings["NKey"].ToString();
            txtSetValue.Text = sVal;


           
        }
    }
}
