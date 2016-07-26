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
    public partial class fMovimentoCaixa : Form
    {
        public fMovimentoCaixa()
        {
            InitializeComponent();
            string filtro = "1=1";
            foreach (var MovCaixa in Servicos.MovimentoCaixaServico.SelecionarMovimento(filtro))
            {
                bsMovimentoCaixa.Add(MovCaixa);
            }
        }

        private void btnNovoCusto_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = true;
            txtValorMovimento.Focus();
            txtIdMovImentoCaixa.Text = "0";

            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            retorno = Servicos.MovimentoCaixaServico.Excluir(new MovimentoCaixa()
            {
                Id = Int16.Parse(txtIdMovImentoCaixa.Text),
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
            {
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;


                txtIdMovImentoCaixa.Clear();
                txtDataMovimento.Value = DateTime.Now;
                txtValorMovimento.Clear();
                txtContaId.Clear();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno;

            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.MovimentoCaixaServico.Salvar(new MovimentoCaixa()
            {
                Id = Int16.Parse(txtIdMovImentoCaixa.Text),
                Data = txtDataMovimento.Value,
                Valor = Convert.ToDouble(txtValorMovimento.Text),
                ContaId = Int16.Parse(txtContaId.Text)
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
            {
                gbInfo.Enabled = false;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;

                txtIdMovImentoCaixa.Clear();
                txtDataMovimento.Value = DateTime.Now;
                txtValorMovimento.Clear();
                txtContaId.Clear();
            }




        }

      
    }
}
