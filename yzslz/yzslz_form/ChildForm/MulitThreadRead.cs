using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yzslz.yzslz_form.ChildForm
{
    public partial class MulitThreadRead : Form
    {
        private Queue<int> mQueue = null;
        private static object lockObj = new object();
        private static object lockObj1 = new object();
        private static Thread t2 = null;
        private static Thread t1 = null;
        private static Thread t3 = null;
        public MulitThreadRead()
        {
            InitializeComponent();
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
            FillQueue();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
             t1 = new Thread(()=> {
                while (true)
                {
                    ShowValue(richTextBox2,1);
                    Thread.Sleep(1000);
                }
            });
            t2 = new Thread(() => {
                while (true)
                {
                    ShowValue(richTextBox3,2);
                    Thread.Sleep(1000);
                }
            });
             t3 = new Thread(() =>
            {
                while (true)
                {
                    ShowValue(richTextBox4,3);
                    Thread.Sleep(1000);
                }
            });
            //Thread t4 = new Thread(() => {
            //    while (true)
            //    {
            //        richTextBox5.AppendText(GetQueue() + ",");
            //        Thread.Sleep(3000);
            //    }
            //});

            t1.Start();
            //Thread.Sleep(1000);
            t2.Start();
            //Thread.Sleep(1000);
            t3.Start();
            //Thread.Sleep(1000);
            //t4.Start();
        }

        private void ShowValue(RichTextBox ric,int id)
        {
            if (Monitor.TryEnter(lockObj1, 5000))
            {
                ric.AppendText(string.Format("{0}->{1},", id, GetQueue()));
                Thread.Sleep(2000);
                ric.AppendText(string.Format("{0}->{1},", id, GetQueue()));
                Thread.Sleep(2000);
                Monitor.Exit(lockObj1);
            }
            else
            {
                Monitor.Exit(lockObj1);
            }
           


        }

        private void FillQueue()
        {
            mQueue = new Queue<int>();
            for (int i = 0; i < 1000; i++)
            {
                mQueue.Enqueue(i);
            }
        }

        private string GetQueue()
        {
            lock (lockObj)
            {
                int i = -1;
                if (mQueue.Count > 0)
                {
                    i = mQueue.Dequeue();
                }
                return i.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t2 != null)
            {

                t2.Suspend();
                t2 = null;
            
                //t2 = null;
            }
        }


    }
}
