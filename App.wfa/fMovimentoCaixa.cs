using App.Comunicacao;
using App.Dominio;
using App.DTO;
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
        private double ValorTotalCaixa;

        private void PreencheGrid(string filtro)
        {
            ValorTotalCaixa = 0;
            foreach (var MovCaixa in Servicos.MovimentoCaixaServico.SelecionarMovimento(filtro))
            {
                bsMovimentoCaixa.Add(MovCaixa);

                if (MovCaixa.PagarReceber == "R")
                    ValorTotalCaixa = ValorTotalCaixa + MovCaixa.Valor;
                else
                    ValorTotalCaixa = ValorTotalCaixa - MovCaixa.Valor;
            }

            txtTotalCaixa.Text = ValorTotalCaixa.ToString();
        }

        public fMovimentoCaixa()
        {
            InitializeComponent();
            PreencheGrid("1==1"); // sem argumento, seleciona todos

            gbInfo.Enabled = false;
            gridMovimentoCaixa.Enabled = true;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;


            btnNovo.Focus();
        }

       

        private void btnNovoCusto_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            gridMovimentoCaixa.Enabled = false;

            txtContaId.Focus();
            txtIdMovImentoCaixa.Text = "0";
            txtValorMovimento.Text = "0";
            txtContaId.Text = "0";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            gridMovimentoCaixa.Enabled = true;

            bsMovimentoCaixa.Clear();
            PreencheGrid("1==1");

            txtIdMovImentoCaixa.Clear();
            txtValorMovimento.Clear();
            txtContaId.Clear();
            lblConta.Text = "-";



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            if (bsMovimentoCaixa.Count == 0)
                return;

            DialogResult Question = MessageBox.Show("Deseja realmente excluir este registro?", "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Question == DialogResult.Yes)
            {
                retorno = Servicos.MovimentoCaixaServico.Excluir(new MovimentoCaixa()
                {
                    Id = Int16.Parse(((MovimentoCaixaContasPessoas)bsMovimentoCaixa.Current).Id.ToString()),
                });

                if (!string.IsNullOrWhiteSpace(retorno))
                    MessageBox.Show(retorno);
                else
                    btnCancelar_Click(null, null);
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
            {
                MessageBox.Show(retorno);
                return;
            }

           
            retorno = Servicos.ContasServico.Salvar(new Contas()
            {
                Valor = ((Contas)bsConta.Current).Valor,
                Juros = Convert.ToDouble(txtValorMovimento.Text) - ((Contas)bsConta.Current).Valor,

                Id = ((Contas)bsConta.Current).Id,
                Descricao = ((Contas)bsConta.Current).Descricao,         
                DataEmissao = ((Contas)bsConta.Current).DataEmissao,
                DataPagamento = DateTime.Now,
                DataVencimento = ((Contas)bsConta.Current).DataVencimento,
                PagarReceber = ((Contas)bsConta.Current).PagarReceber,
                PessoaId = ((Contas)bsConta.Current).PessoaId,
                Quitado = "S"
            });
            



            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                btnCancelar_Click(null, null);
        }

        private void btnPesquisaCusto_Click(object sender, EventArgs e)
        {
            CadContas fcadcontas = new CadContas();
            fcadcontas.pesquisaViaMovCaixa = true;
            fcadcontas.pcContas.SelectedTab = fcadcontas.tabPesquisa;
            fcadcontas.PreencheGrid("1==1");
            fcadcontas.ShowDialog();
            txtContaId.Text = fcadcontas.id;
            txtContaId_Leave(null, null);
        }

        private void txtValorMovimento_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void txtValorMovimento_Leave(object sender, EventArgs e)
        {
            double i;
            if (!double.TryParse(txtValorMovimento.Text, out i))
                txtValorMovimento.Text = "0";
        }

        private void txtContaId_Leave(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(txtContaId.Text, out i))
            {
                txtContaId.Text = "0";
                lblConta.Text = "-";
            }
            

            bsConta.Clear();
            bsConta.Add(Servicos.ContasServico.Selecionar(Int16.Parse(txtContaId.Text)));
            if (((Contas)bsConta.Current) != null)
            {
                txtContaId.Text = ((Contas)bsConta.Current).Id.ToString();
                lblConta.Text = ((Contas)bsConta.Current).Descricao;
                txtValorMovimento.Text = ((Contas)bsConta.Current).Valor.ToString();
            }
            else
            {
                txtContaId.Text = "0";
                lblConta.Text = "-";
            }


        }

        private void gridMovimentoCaixa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMovImentoCaixa.Text = ((MovimentoCaixaContasPessoas)bsMovimentoCaixa.Current).Id.ToString();
            txtDataMovimento.Value = ((MovimentoCaixaContasPessoas)bsMovimentoCaixa.Current).Data;
            txtContaId.Text = ((MovimentoCaixaContasPessoas)bsMovimentoCaixa.Current).ContaId.ToString();
            txtValorMovimento.Text = ((MovimentoCaixaContasPessoas)bsMovimentoCaixa.Current).Valor.ToString();
            txtContaId_Leave(null, null);

            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            gbInfo.Enabled = true;
            txtValorMovimento.Focus();


        }

      
    }
}
