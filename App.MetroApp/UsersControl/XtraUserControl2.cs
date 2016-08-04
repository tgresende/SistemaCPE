using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Animation;

namespace App.MetroApp.UsersControl
{
    public partial class XtraUserControl2 : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControl2()
        {
            InitializeComponent();
            //simpleButton1.Tag = UserControlType.XtraUserControl3;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TransitionManager transacao = UserControlController.UserControl.CreateTransition(new SlideTransition());
            transacao.StartTransition(UserControlController.UserControl.UserControlParent);

            XtraUserControl uc = UserControlController.UserControl.GetUserControl((UserControlType)(sender as SimpleButton).Tag);

            transacao.EndTransition();
        }
    }
}
