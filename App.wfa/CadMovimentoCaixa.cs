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
    public partial class CadMovimentoCaixa : Form
    {
        private double ValorTotalCaixa;

        private void PreencheGrid(string filtro)
        {
            ValorTotalCaixa = 0;
            foreach (var MovCaixa in Servicos.MovimentoCaixaServico.Filtrar(filtro))
            {
                bsMovimentoCaixa.Add(MovCaixa);

                if (MovCaixa.CreditoDebito == Dominio.CreditoDebito.Credito)
                    ValorTotalCaixa = ValorTotalCaixa + MovCaixa.Valor + MovCaixa.Acrescimo - MovCaixa.Desconto;
                else
                    ValorTotalCaixa = ValorTotalCaixa - MovCaixa.Valor + MovCaixa.Desconto - MovCaixa.Acrescimo; // sinais invertidos pq eh saida
            }

            txtTotalCaixa.Text = ValorTotalCaixa.ToString();
        }

        public CadMovimentoCaixa()
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

            txtIdMovImentoCaixa.Text = "0";
            txtValorMovimento.Text = "0";
            txtAcrescimo.Text = "0";
            txtDesconto.Text = "0";
            txtValorTotal.Text = "0";
            txtDescricao.Focus();

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
            txtDescricao.Clear();
            txtAcrescimo.Clear();
            txtDesconto.Clear();
            txtValorTotal.Clear();
            cmbDebitoCredito.SelectedIndex = -1;



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
                    Id = Int16.Parse(((MovimentoCaixa)bsMovimentoCaixa.Current).Id.ToString()),
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

            CreditoDebito debcred;
            if (cmbDebitoCredito.Text == "Débito")
                debcred = CreditoDebito.Debito;
            else if (cmbDebitoCredito.Text == "Crédito")
                debcred = CreditoDebito.Credito;
            else
                debcred = CreditoDebito.Nulo;
           

            retorno = Servicos.MovimentoCaixaServico.Salvar(new MovimentoCaixa()
            {
                Id = Int16.Parse(txtIdMovImentoCaixa.Text),
                Data = txtDataMovimento.Value,
                Valor = Convert.ToDouble(txtValorMovimento.Text),
                Acrescimo = Convert.ToDouble(txtAcrescimo.Text),
                Desconto = Convert.ToDouble(txtDesconto.Text),
                Descricao = txtDescricao.Text,
                CreditoDebito = debcred
            });

            if (!string.IsNullOrWhiteSpace(retorno))
            {
                MessageBox.Show(retorno);
                return;
            }



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
        }

        private void txtValorMovimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }    
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void txtValorMovimento_Leave(object sender, EventArgs e)
        {
            double i;
            if (!double.TryParse(txtValorMovimento.Text, out i))
                txtValorMovimento.Text = "0";

            txtValorTotal.Text = (Library.Rotinas.CalculaValorDescAcres(Convert.ToDouble(txtValorMovimento.Text), Convert.ToDouble(txtAcrescimo.Text), Convert.ToDouble(txtDesconto.Text))).ToString();
        }

        private void gridMovimentoCaixa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (((MovimentoCaixa)bsMovimentoCaixa.Current).CreditoDebito == CreditoDebito.Debito)
                cmbDebitoCredito.SelectedItem = "Débito"; //
            else
                cmbDebitoCredito.SelectedItem = "Crédito"; // credito

            txtIdMovImentoCaixa.Text = ((MovimentoCaixa)bsMovimentoCaixa.Current).Id.ToString();
            txtDataMovimento.Value = ((MovimentoCaixa)bsMovimentoCaixa.Current).Data;
            txtValorMovimento.Text = ((MovimentoCaixa)bsMovimentoCaixa.Current).Valor.ToString();
            txtAcrescimo.Text  = ((MovimentoCaixa)bsMovimentoCaixa.Current).Acrescimo.ToString();
            txtDesconto.Text = ((MovimentoCaixa)bsMovimentoCaixa.Current).Desconto.ToString();
            txtDescricao.Text = ((MovimentoCaixa)bsMovimentoCaixa.Current).Descricao;
     

            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            gbInfo.Enabled = true;
            gridMovimentoCaixa.Enabled = false;
            txtValorMovimento_Leave(null, null);
            txtValorMovimento.Focus();


        }

        private void fMovimentoCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtAcrescimo_Leave(object sender, EventArgs e)
        {
           txtValorTotal.Text = (Library.Rotinas.CalculaValorDescAcres(Convert.ToDouble(txtValorMovimento.Text), Convert.ToDouble(txtAcrescimo.Text), Convert.ToDouble(txtDesconto.Text))).ToString();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            txtValorTotal.Text = (Library.Rotinas.CalculaValorDescAcres(Convert.ToDouble(txtValorMovimento.Text), Convert.ToDouble(txtAcrescimo.Text), Convert.ToDouble(txtDesconto.Text))).ToString();
        }

        private void gridMovimentoCaixa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = gridMovimentoCaixa.Rows[e.RowIndex];
            double valor = Convert.ToDouble(row.Cells[ColunaValor.Index].Value);
            double desconto = Convert.ToDouble(row.Cells[ColunaDesconto.Index].Value);
            double acrescimo = Convert.ToDouble(row.Cells[ColunaAcrescimo.Index].Value);


            row.Cells[ColunaValorTotal.Index].Value = valor - desconto + acrescimo;
        }
    }
}
