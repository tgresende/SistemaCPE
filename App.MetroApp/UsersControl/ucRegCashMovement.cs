using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using App.Comunicacao;
using App.Dominio;
using DevExpress.Utils.Animation;

namespace App.MetroApp.UsersControl
{
    public partial class ucRegCashMovement : DevExpress.XtraEditors.XtraUserControl
    {
        public int Id;


        public ucRegCashMovement(int Id)
        {
            InitializeComponent();

            bsCashMov.Add(Servicos.MovimentoCaixaServico.Selecionar(Id));
            
            txtId.Text = Id.ToString();
            txtDescription.Text = ((MovimentoCaixa)bsCashMov.Current).Descricao;
            dateData.DateTime = ((MovimentoCaixa)bsCashMov.Current).Data;
            calcBaseValue.Value = Convert.ToDecimal(((MovimentoCaixa)bsCashMov.Current).Valor);
            calcDiscount.Value = Convert.ToDecimal(((MovimentoCaixa)bsCashMov.Current).Desconto);
            calcAddition.Value = Convert.ToDecimal(((MovimentoCaixa)bsCashMov.Current).Acrescimo);
            calcTotalValue.Value = calcBaseValue.Value - calcDiscount.Value + calcAddition.Value;

            if (((MovimentoCaixa)bsCashMov.Current).CreditoDebito == CreditoDebito.Debito)
                cmbDebitCredit.SelectedItem = "Débito"; //
            else
                cmbDebitCredit.SelectedItem = "Crédito"; // credito

    






        }

        

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

     

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string retorno;


            CreditoDebito debcred;
            if (cmbDebitCredit.Text == "Débito")
                debcred = CreditoDebito.Debito;
            else if (cmbDebitCredit.Text == "Crédito")
                debcred = CreditoDebito.Credito;
            else
                debcred = CreditoDebito.Nulo;


            retorno = Servicos.MovimentoCaixaServico.Salvar(new MovimentoCaixa()
            {
                Id = Int16.Parse(txtId.Text),
                Data = dateData.DateTime,
                Valor = Convert.ToDouble(calcBaseValue.Text),
                Acrescimo = Convert.ToDouble(calcAddition.Text),
                Desconto = Convert.ToDouble(calcDiscount.Text),
                Descricao = txtDescription.Text,
                CreditoDebito = debcred
            });


            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
            {
                MessageBox.Show("Registro salvo com sucesso!");
                btnCancel_Click(null, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TransitionManager transacao = UserControlController.UserControl.CreateTransition(new SlideTransition());
            transacao.StartTransition(this.Parent);

            XtraUserControl uc = UserControlController.UserControl.GetUserControl(UserControlType.ucMovimentoCaixa);

            transacao.EndTransition();
        }
    }
}
