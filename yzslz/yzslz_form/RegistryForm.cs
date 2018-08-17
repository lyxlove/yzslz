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
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            FRehistry.RunForm runForm = new FRehistry.RunForm();
            runForm.ShowDialog(this);
        }
    }
}
