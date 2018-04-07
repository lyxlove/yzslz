using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yzslz.Tools
{
    public partial class TxtWithLab : UserControl
    {
        public TxtWithLab()
        {
            InitializeComponent();
        }

        private string HeadValue = string.Empty;
        [Description("文字描述"),Category("自定义属性")]
        private string HeadTxt
        {
            set
            {
                labHead.Text =  value;
            }
        }
    }
}
