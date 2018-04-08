using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;

using System.Windows.Forms;

namespace yzslz.yzslz_form
{
    public partial class SerialPortForm : Form
    {
        public SerialPortForm()
        {
            InitializeComponent();
            InitComb();
        }


        public void InitComb()
        {
            try
            {
                RegistryKey keycomm = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
                if (keycomm != null)
                {
                    string[] ssubkeycomm = keycomm.GetValueNames();
                    combSerialPortOne.Items.Clear();
                    foreach (string skey in ssubkeycomm)
                    {
                        string svalue = Convert.ToString(keycomm.GetValue(skey));
                        combSerialPortOne.Items.Add(svalue);
                        combSerialPortTwo.Items.Add(svalue);

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
            if (btnOpenPortOne.Text.Equals("打开串口"))
            {
                if (serialPort1.IsOpen) serialPort1.Close();
                serialPort1.PortName = combSerialPortOne.Text.Trim();
                try
                {
                    serialPort1.Open();
                    btnOpenPortOne.Text = "关闭串口";

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                serialPort1.Close();
                btnOpenPortOne.Text = "打开串口";
            }
        }

        private void btnOpenPortTwo_Click(object sender, EventArgs e)
        {
            if (btnOpenPortTwo.Text.Equals("打开串口"))
            {
                if (serialPort2.IsOpen) serialPort2.Close();
                serialPort2.PortName = combSerialPortTwo.Text.Trim();
                try
                {
                    serialPort2.Open();
                    btnOpenPortTwo.Text = "关闭串口";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                serialPort2.Close();
                btnOpenPortTwo.Text = "打开串口";
            }
        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort obj = (SerialPort)sender;
            string strData = obj.ReadExisting();
            txtReceiveContent.Text = strData;

        }

        private void btnProtOneSend_Click(object sender, EventArgs e)
        {
            serialPort1.Write(txtSendContent.Text.Trim());
        }
    }
}
