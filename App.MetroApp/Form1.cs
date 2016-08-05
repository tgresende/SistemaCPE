using DevExpress.Utils.Animation;
using DevExpress.XtraEditors;
using App.MetroApp.UsersControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;

namespace App.MetroApp
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();

            tileBarMovimentoCaixa.Tag = UserControlType.ucMovimentoCaixa;
            tileBarCadastroCliente.Tag = UserControlType.ucCadCliente;
            UserControlController.UserControl.UserControlParent = ucContainer;


            // montando o container 

            TileBarItem itemA1 = new TileBarItem() { Text = "cadastro de clientes" };
            TileBarItem itemA2 = new TileBarItem() { Text = "cadastro de fornecedores" };


            TileBarDropDownContainer ddContainer = new TileBarDropDownContainer();
            ddContainer.Size = new System.Drawing.Size(595, 185);

            TileBar innerBar = new TileBar() { Parent = ddContainer, Dock = DockStyle.Fill };
            innerBar.Groups.Add(new TileGroup());
            innerBar.Groups[0].Items.Add(itemA1);
            innerBar.Groups[0].Items.Add(itemA2);

            ddContainer.Controls.Add(innerBar);
            tileBarCadastroCliente.DropDownControl = ddContainer;




        }

        private void tileBarItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            TransitionManager transacao = UserControlController.UserControl.CreateTransition(new SlideTransition());
            transacao.StartTransition(ucContainer);

            XtraUserControl uc = UserControlController.UserControl.GetUserControl((UserControlType)(sender as TileItem).Tag);

            transacao.EndTransition();
    
        }

        private void navButton4_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }


      
    }
}
