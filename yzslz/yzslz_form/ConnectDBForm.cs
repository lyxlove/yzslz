using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yzslz.yzslz_form
{
    public partial class ConnectDBForm : Form
    {
        public ConnectDBForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                string ConnetionStr = "server=.\\SQLEXPRESS;" +
                                      "integrated security=SSPI;" +
                                      "database=IVS30";
          
                conn.ConnectionString = ConnetionStr;
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
                        
                                  

        }
    }
}
