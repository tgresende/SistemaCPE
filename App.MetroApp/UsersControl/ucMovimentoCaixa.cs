using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using App.Comunicacao;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.Utils.Animation;
using App.Dominio;

namespace App.MetroApp.UsersControl
{
    public partial class ucMovimentoCaixa : DevExpress.XtraEditors.XtraUserControl
    {
        public decimal customSum;

        private void PreencheGrid(string filtro)
        {
            bsMovimentoCaixa.Clear();
            foreach (var MovCaixa in Servicos.MovimentoCaixaServico.SelecionarTodos())
                bsMovimentoCaixa.Add(MovCaixa);

        }

        public ucMovimentoCaixa()
        {
            InitializeComponent();
            PreencheGrid("1==1");

        }

        private void gridControl1_Load(object sender, EventArgs e)
        {

            gridView1.BestFitColumns();
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {

            int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            GridView View = sender as GridView;

            // Initialization 
            if (e.SummaryProcess == CustomSummaryProcess.Start)
                customSum = 0;

            // Calculation 
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                string DebCred = (View.GetRowCellValue(e.RowHandle, "CreditoDebito")).ToString();
                switch (DebCred)
                {
                    case "Debito":
                        customSum -= Convert.ToDecimal(e.FieldValue);
                        break;
                    case "Credito":
                        customSum += Convert.ToDecimal(e.FieldValue);
                        break;
                }
            }
            // Finalization 
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
                e.TotalValue = customSum;



        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["CreditoDebito"]);
                if (category == "Debito")
                {
                    e.Appearance.BackColor = Color.Salmon; //Salmon
                    e.Appearance.BackColor2 = Color.SeaShell; //SeaShell
                }
                else
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.BackColor2 = Color.MediumSpringGreen;

                }
            }
        }

        private void gridCashMovement_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TransitionManager transacao = UserControlController.UserControl.CreateTransition(new SlideTransition());
            transacao.StartTransition(this.Parent);

            XtraUserControl uc = UserControlController.UserControl.GetUserControl(UserControlType.ucRegCashMovement, new object[] { bsMovimentoCaixa.Current });

            transacao.EndTransition();
        }

        private void ucMovimentoCaixa_Enter(object sender, EventArgs e)
        {

        }

        private void ucMovimentoCaixa_Load(object sender, EventArgs e)
        {

        }

        private void ucMovimentoCaixa_Validated(object sender, EventArgs e)
        {

        }

        private void ucMovimentoCaixa_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && !Disposing)
                PreencheGrid("1==1");

        }

        private void tileBarItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            TransitionManager transacao = UserControlController.UserControl.CreateTransition(new SlideTransition());
            transacao.StartTransition(this.Parent);

            XtraUserControl uc = UserControlController.UserControl.GetUserControl(UserControlType.ucRegCashMovement, new object[] { new MovimentoCaixa()});

            transacao.EndTransition();
            
        }
    }
}
