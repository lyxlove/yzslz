using Microsoft.Win32;
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
    public partial class SerialPortForm : Form
    {
        public SerialPortForm()
        {
            InitializeComponent();
        }


        public void InitComb()
        {
            try
            {
                RegistryKey keycomm = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
                if (keycomm != null)
                {
                    string[] ssubkeycomm = keycomm.GetValueNames();
                    combSerialPort.Items.Clear();
                    foreach (string skey in ssubkeycomm)
                    {
                        string svalue = Convert.ToString(keycomm.GetValue(skey));
                        combSerialPort.Items.Add(svalue);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (btnOpen.Text.Equals("打开串口"))
            {
                if (serialPort1.IsOpen) serialPort1.Close();
                serialPort1.PortName = combSerialPort.Text.Trim();
                try
                {
                    serialPort1.Open();
                    //toolStripStatusLabel1.Text = combSerialPort.Text + "串口打开";
                    btnOpen.Text = "关闭串口";

                }
                catch
                {
                   // toolStripStatusLabel1.Text = "端口打开时出现错误";
                }
            }
            else
            {
                serialPort1.Close();
                //toolStripStatusLabel1.Text = "当前串口关闭";
                btnOpen.Text = "打开串口";
            }
        }

    }
}
