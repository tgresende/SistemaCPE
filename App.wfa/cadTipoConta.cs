using App.Comunicacao;
using App.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.wfa
{
    public partial class CadTipoConta : Form
    {
        private void PreencheGrid(string filtro)
        {
            if (filtro == "")
            {
                foreach (var tipoconta in Comunicacao.Servicos.TipoContaServico.SelecionarTodos())
                {
                    bsTipoConta.Add(tipoconta);
                }
            }
        }

        public CadTipoConta()
        {
            InitializeComponent();
            PreencheGrid("");
            btnCancelar_Click(null, null);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            gridTipoConta.Enabled = false;
            gbTipoConta.Enabled = true;


            txtId.Text = "0";
            txtDescricao.Focus();


            bsTipoConta.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno;

            PagarReceber pagRec;

            if (cmbPagarReceber.Text == "Pagar")
                pagRec = PagarReceber.Pagar;
            else if (cmbPagarReceber.Text == "Receber")
                pagRec = PagarReceber.Receber;
            else
                pagRec = PagarReceber.Nulo;


                retorno = Servicos.TipoContaServico.Salvar(new Dominio.TipoConta()
            {
                Id = Int16.Parse(txtId.Text),
                Descricao = txtDescricao.Text,
                PagarReceber = pagRec
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                btnCancelar_Click(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            cmbPagarReceber.SelectedIndex = -1;
            txtDescricao.Text = "";



            bsTipoConta.Clear();

            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            gbTipoConta.Enabled = false;

            gridTipoConta.Enabled = true;
            PreencheGrid("");

            btnNovo.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            if (bsTipoConta.Count == 0)
                return;


            DialogResult Question = MessageBox.Show("Deseja realmente excluir este registro?", "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Question == DialogResult.Yes)
            {
                retorno = Servicos.TipoContaServico.Excluir(new Dominio.TipoConta()
                {
                    Id = Int32.Parse(((TipoConta)bsTipoConta.Current).Id.ToString()),
                });

                if (!string.IsNullOrWhiteSpace(retorno))
                    MessageBox.Show(retorno);
                else
                    btnCancelar_Click(null, null);
            }
        }

        private void gridTipoConta_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridTipoConta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtId.Text = ((TipoConta)bsTipoConta.Current).Id.ToString();
            txtDescricao.Text = ((TipoConta)bsTipoConta.Current).Descricao;

            if (((TipoConta)bsTipoConta.Current).PagarReceber == PagarReceber.Pagar)
                cmbPagarReceber.SelectedItem = "Pagar";
            else if (((TipoConta)bsTipoConta.Current).PagarReceber == PagarReceber.Receber)
                cmbPagarReceber.SelectedItem = "Receber";
            else
                cmbPagarReceber.SelectedIndex = -1;


            


            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            gridTipoConta.Enabled = true;
            gbTipoConta.Enabled = true;
            txtDescricao.Focus();
        }

        private void CadTipoConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
