using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yzslz.yzslz_form.ChildForm;

namespace yzslz.yzslz_form
{
    public partial class PortForm : Form
    {
        public PortForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestPortForm form = new TestPortForm();
            form.ShowDialog(this);
        }
    }
}
