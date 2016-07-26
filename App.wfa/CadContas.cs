using App.Comunicacao;
using App.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.wfa
{
    public partial class CadContas : Form
    {
        public CadContas()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            txtId.Text = "0";
            txtValor.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno;

            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.ContasServico.Salvar(new Contas()
            {
                Id = Int16.Parse(txtId.Text),
                DataEmissao = txtDataEmissao.Value,
                DataPagamento = txtDataPgto.Value,
                DataVencimento = txtDataVencimento.Value,
                Juros = Int16.Parse(txtJuros.Text),
                PagarReceber = txtPagarReceber.Text,
                PessoaId = Int16.Parse(txtPessoaId.Text),
                Valor = Convert.ToDouble(txtValor.Text)
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
            {
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;

                txtId.Clear();
                txtDataEmissao.Value = DateTime.Now;
                txtDataPgto.Value = DateTime.Now;
                txtDataVencimento.Value = DateTime.Now;
                txtJuros.Clear();
                txtPagarReceber.Clear();
                txtPessoaId.Clear();
                txtValor.Clear();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            retorno = Servicos.ContasServico.Excluir(new Contas()
            {
                Id = Int16.Parse(txtId.Text),
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
            {
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;


                txtId.Clear();
                txtDataEmissao.Value = DateTime.Now;
                txtDataPgto.Value = DateTime.Now;
                txtDataVencimento.Value = DateTime.Now;
                txtJuros.Clear();
                txtPagarReceber.Clear();
                txtPessoaId.Clear();
                txtValor.Clear();
            }
        }
    }
}
