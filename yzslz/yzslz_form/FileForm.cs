using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace yzslz.yzslz_form
{
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string strPath = fileDialog.FileName;
                FileStream fs = File.Open(strPath, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                int i = 0;
                string s;
                while ( (s=sr.ReadLine()) != null)
                {
                    i++;
                    rtbContent.AppendText(s+Environment.NewLine);
                }
                fs.Close();
                sr.Close();
                MessageBox.Show(i.ToString());

            }
        }

    
    }
}
