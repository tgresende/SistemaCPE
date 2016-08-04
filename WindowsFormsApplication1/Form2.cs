using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        FlyoutDialog d;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlyoutAction action = new FlyoutAction();
            action.Caption = "Confirm";
            //action.Commands.Add(FlyoutCommand.OK);
            //action.Commands.Add(FlyoutCommand.Cancel);
            XtraUserControl1 c = new XtraUserControl1();
            d = new FlyoutDialog(this, action, c);
            c.dialog = d;
            // MyFlyoutDialog dialog = new MyFlyoutDialog(this, action, new UserControl1());
            //dialog.

            d.ShowDialog();
        }
    }

    public class MyFlyoutDialog : FlyoutDialog
    {
        public MyFlyoutDialog(Form owner, FlyoutAction action, Control control)
            : base(owner, action)
        {
            FlyoutControl = control;
            
        }
    }
}
