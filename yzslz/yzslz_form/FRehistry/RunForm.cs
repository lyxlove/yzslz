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

namespace yzslz.yzslz_form.FRehistry
{
    public partial class RunForm : Form
    {
       // private string _path01 = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
       // private string _path02 = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        private string _path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private RegistryKey registryKey = null;
        private RegistryKey registryKey0 = null;
        public RunForm()
        {
            InitializeComponent();
            lvItem.Columns.Add("", 40, HorizontalAlignment.Left);
            lvItem.Columns.Add("名称", 240, HorizontalAlignment.Left);
            lvItem.Columns.Add("路径", 540, HorizontalAlignment.Left);
            LoadRunApp();
        }



        private void LoadRunApp()
        {
           
            lvItem.View = View.Details;

            registryKey = Registry.LocalMachine;
            registryKey0 = registryKey.OpenSubKey(_path);
            for (int i= 0;i< registryKey0.GetValueNames().Length;i++)
            {
                int no = lvItem.Items.Count;
                lvItem.Items.Add(Convert.ToString(no+1));
                lvItem.Items[no].SubItems.Add(registryKey0.GetValueNames()[i]);
                object obj = registryKey0.GetValue(registryKey0.GetValueNames()[i]);
                lvItem.Items[no].SubItems.Add(obj == null ? "" : obj.ToString());
                lvItem.Items[no].EnsureVisible();

            }
            registryKey0.Close();
            registryKey.Close();
          
            registryKey = Registry.CurrentUser;
            registryKey0 = registryKey.OpenSubKey(_path);
            for (int i = 0; i < registryKey0.GetValueNames().Length; i++)
            {
                int no = lvItem.Items.Count;
                lvItem.Items.Add(Convert.ToString(no+1));
                lvItem.Items[no].SubItems.Add(registryKey0.GetValueNames()[i]);
                object obj = registryKey0.GetValue(registryKey0.GetValueNames()[i]);
                lvItem.Items[no].SubItems.Add(obj == null ? "" : obj.ToString());
                lvItem.Items[no].EnsureVisible();
            }
            registryKey0.Close();
            registryKey.Close();
            registryKey0.Dispose();
            registryKey.Dispose();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string path = Application.ExecutablePath;
            registryKey = Registry.LocalMachine;
            registryKey0 = registryKey.OpenSubKey(_path,true);
            registryKey0.SetValue("PrintShutdown", path);
            registryKey0.Close();
            registryKey.Close();
            lvItem.Items.Clear();
            LoadRunApp();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.LocalMachine;
            RegistryKey rk2 = rk.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            rk2.DeleteValue("PrintShutdown",false);
            rk2.Close();
            rk.Close();
            lvItem.Items.Clear();
            LoadRunApp();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.LocalMachine;
            RegistryKey rk2 = rk.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (rk2.GetValueNames().Contains("PrintShutdown"))
            {
                MessageBox.Show("包含启动项");
            }
            else
            {
                MessageBox.Show("不是启动项");
            }
        }
    }
}
