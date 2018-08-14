using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            WebRequestTest();
        }

        public async Task ConnectNetAsync()
        {
            HttpClient httpClient = new HttpClient();
            string strResult =  await httpClient.GetStringAsync(txtUrl.Text.Trim());
            txtResult.Text = strResult;

        }

        public void WebRequestTest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://www.baidu.com/");
            webRequest.Method = "GET";
            webRequest.ContentType = "text/html";

            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)webRequest.GetResponse();
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);
            string s = reader.ReadToEnd();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectNetAsync();
        }


    }
}
