using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Mvvm;
using DevExpress.XtraBars.Docking2010.Customization;

namespace WindowsFormsApplication1
{
    public partial class XtraUserControl1 : XtraUserControl
    {
        public FlyoutDialog dialog { get; set; }

        public XtraUserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialog.Close();
        }
    }
}
