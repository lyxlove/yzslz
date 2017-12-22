using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnWriteLog_Click(object sender, EventArgs e)
        {

            ShowLogOnTxtBox("添加日志成功！");
        }

        private void ShowLogOnTxtBox(string str)
        {
            LogEntity entity = new LogEntity();
            entity.LogMsg = str;
            txtLogMsg.AppendText(entity.ToString()+"\r\n");
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
                return string.Format("{0} ==> {1}",LogTime.ToString("yyyy-MM-dd HH:mm:ss"),LogMsg);
            }
        }

        
    }

   
}
