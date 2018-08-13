using System;
using System.Threading;
using System.Net.WebSockets;
using System.Windows.Forms;

namespace yzslz.yzslz_form
{
    public partial class ThreadForm : Form
    {
        private Thread t1 = null;
        private Thread t2 = null;
        private Thread t3 = null;
        public ThreadForm()
        {
            Label.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //AsyncStatics();
        }

        private void btnMulitRead_Click(object sender, EventArgs e)
        {
            ChildForm.MulitThreadRead form1 = new ChildForm.MulitThreadRead();
            form1.ShowDialog(this);
        }

        public void AsyncStatics()
        {
             t1 = new Thread(()=> {
                while (true)
                {
                    YDLL.YDBTools yDBTools = new YDLL.YDBTools();
                    string strSql = "SELECT COUNT(*) FROM(SELECT HPHM FROM RESULT_VEHICLE_INFO WHERE CONVERT(VARCHAR(10),CLXXSJ,120) = CONVERT(VARCHAR(10),GETDATE(),120) GROUP BY HPHM) AS A";
                    object o = yDBTools.GetSearchVal(strSql);
                    label1.Text = string.Format("总检车辆数量:{0}", o);
                    Thread.Sleep(3000);
                }
            });
            t1.Start();

             t2 = new Thread(() => {
                while (true)
                {
                    YDLL.YDBTools yDBTools = new YDLL.YDBTools();
                    string strSql = "SELECT COUNT(*) FROM(SELECT HPHM FROM RESULT_VEHICLE_INFO WHERE CONVERT(VARCHAR(10),CLXXSJ,120) = CONVERT(VARCHAR(10),GETDATE(),120) AND JCXH <> 5 GROUP BY HPHM) AS A";
                    object o = yDBTools.GetSearchVal(strSql);
                    label2.Text = string.Format("总检小车辆数量:{0}", o);
                    Thread.Sleep(3000);
                }
            });
            t2.Start();

             t3 = new Thread(() => {
                while (true)
                {
                    YDLL.YDBTools yDBTools = new YDLL.YDBTools();
                    string strSql = "SELECT COUNT(*) FROM(SELECT HPHM FROM RESULT_VEHICLE_INFO WHERE CONVERT(VARCHAR(10),CLXXSJ,120) = CONVERT(VARCHAR(10),GETDATE(),120) AND JCXH = 5 GROUP BY HPHM) AS A";
                    object o = yDBTools.GetSearchVal(strSql);
                    label3.Text = string.Format("总检摩托车辆数量:{0}", o);
                    Thread.Sleep(3000);
                }
            });
            t3.Start();
        }

        private void ThreadForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
            t1.Join();
            t2.Abort();
            t2.Join();
            t3.Abort();
            t3.Join();        
        }

        private void N()
        {

        }


    }
}
