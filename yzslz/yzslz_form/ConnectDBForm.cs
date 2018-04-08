using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Text;

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
                string ConnetionStr = "server=.;" +
                                      "integrated security=SSPI;" +
                                      "database=IVS_BJXY";

                conn.ConnectionString = ConnetionStr;
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("", conn);
                NewMethod(sqlCommand);
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

        private static void NewMethod(SqlCommand sqlCommand)
        {
            sqlCommand.ExecuteNonQuery();
        }
    }
}
