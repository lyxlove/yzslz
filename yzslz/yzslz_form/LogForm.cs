using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yzslz.yzslz_form
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }


        private StreamWriter streamWriter;


        public void WriteTxtLog(string msg)
        {
            StreamWriter sw = null;
            try
            {
                string txtLogPath = string.Format(@"{0}\log_{1}.txt", System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), DateTime.Now.ToString("yyyy-MM-dd"));
                if (sw == null)
                {
                    sw = !File.Exists(txtLogPath) ? File.CreateText(txtLogPath) : File.AppendText(txtLogPath);
                }
                if (msg != null)
                {
                    sw.Write(msg);
                }
            }
            finally
            {
                if (sw != null)
                {          
                    sw.Flush();
                    sw.Dispose();
                    sw = null;
                }
            }
        }


        private void WriteLog(string msg)
        {
            try
            {

                string txtLogPath = string.Format(@"{0}\log_{1}.txt", System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), DateTime.Now.ToString("yyyy-MM-dd"));
                if (streamWriter == null)
                {
                    streamWriter = !File.Exists(txtLogPath) ? File.CreateText(txtLogPath) : File.AppendText(txtLogPath);
                }
                if (msg != null)
                {
                    streamWriter.WriteLine(msg);
                }


            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Flush();
                    streamWriter.Dispose();
                    streamWriter = null;
                }
            }
        }


        private void btnWriteLog_Click(object sender, EventArgs e)
        {

            try
            {
                WriteTxtLog("1");
               // WriteLog("打开数据");
                ShowLogOnTxtBox("添加日志成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                DialogResult result = fileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtFilePath.Text = fileDialog.FileName;
                    txtReadTxt.Text = File.ReadAllText(fileDialog.FileName);
                }

            }
            catch (Exception ex)
            {
                ShowLogOnTxtBox(ex.Message);
            }

        }

        private void ShowLogOnTxtBox(string str)
        {
            LogEntity entity = new LogEntity();
            entity.LogMsg = str;
            txtLogMsg.AppendText(entity.ToString() + "\r\n");
        }

        class LogEntity
        {
            private DateTime _logTime;
            public DateTime LogTime
            {
                get
                {
                    return DateTime.Now;
                }

            }

            public string LogTimeStr
            {
                get
                {
                    return LogTime.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }

            public string LogMsg
            {
                get;
                set;
            }

            public override string ToString()
            {
                return string.Format("{0} ==> {1}", LogTime.ToString("yyyy-MM-dd HH:mm:ss"), LogMsg);
            }
        }


    }


}
