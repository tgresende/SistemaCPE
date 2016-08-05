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

namespace App.MetroApp.UsersControl
{
    public partial class ucLockCashMovement : DevExpress.XtraEditors.XtraUserControl
    {
        public ucLockCashMovement()
        {
            InitializeComponent();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void txtId_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateData_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbDebitCredit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calcBaseValue_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void calcEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tileBarItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            string retorno;


            retorno = Servicos.SaldoCaixaServico.Salvar(new Dominio.SaldoCaixa()
            {
                Id = Int16.Parse(txtId.Text),
                Data = dateData.DateTime,
                Valor = Convert.ToDouble(calcEndValue.Text),
                ValorAbertura = Convert.ToDouble(calcOpenValue.Text),
                Fechado = false
            });


            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
            {
                MessageBox.Show("Registro salvo com sucesso!");
            }
        }
    }
}
