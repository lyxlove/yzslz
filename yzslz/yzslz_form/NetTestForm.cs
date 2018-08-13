using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yzslz.yzslz_form
{
    public partial class NetTestForm : Form
    {
        public NetTestForm()
        {
            InitializeComponent();
        }

        public async Task ConnectNetAsync()
        {
            HttpClient httpClient = new HttpClient();
            string strResult =  await httpClient.GetStringAsync(txtUrl.Text.Trim());
            txtResult.Text = strResult;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectNetAsync();
        }


    }
}
