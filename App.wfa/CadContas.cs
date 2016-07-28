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
        public string id, descricao, valor;
        public bool pesquisaViaMovCaixa;
        
        private void LimpaGrid()
        {
            bsContas.Clear();
        }

        public void PreencheGrid(string filtro)
        {
            bsContas.Clear();
            if (filtro == "")
            {                
                foreach (var Conta in Servicos.ContasServico.SelecionarTodos())
                    bsContas.Add(Conta);
            }
            else
            {
                if (pesquisaViaMovCaixa)
                    filtro = filtro + " and Quitado = \"N\"" ;
                foreach (var Conta in Servicos.ContasServico.SelecionarConta(filtro))
                    bsContas.Add(Conta);
            }
        }

        public CadContas()
        {
            InitializeComponent();
            PreencheGrid("");

            gbInfo.Enabled = false;

            btnNovo.Enabled = true;
            btnNovo.Focus();
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            pcContas.SelectedTab = tabInfo;
            gbInfo.Enabled = true;
            txtDescricao.Focus();
            txtId.Text = "0";
            txtDescricao.Focus();
            LimpaGrid();

            txtValor.Text = "0";
            txtJuros.Text = "0";
            txtPessoaId.Text = "0";
            cmbPagarReceber.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            gbInfo.Enabled = false;

            txtId.Clear();
            txtDataEmissao.Value = DateTime.Now;
            txtDataPgto.Value = DateTime.Now;
            txtDataVencimento.Value = DateTime.Now;
            txtJuros.Clear();
            txtPessoaId.Clear();
            txtValor.Clear();
            txtDescricao.Clear();
            lblPessoa.Text = "-";

            btnNovo.Focus();
            LimpaGrid();
            PreencheGrid("");

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno, quit;
            DateTime datapag;
            if (txtDataPgto.CustomFormat == " ")
            {
                datapag = DateTime.MinValue;
                quit = "N";
            }
            else
            {
                datapag = txtDataPgto.Value;
                quit = "S";
            }


            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.ContasServico.Salvar(new Contas()
            {
                Id = Int16.Parse(txtId.Text),
                DataEmissao = txtDataEmissao.Value,
                DataPagamento = datapag,
                DataVencimento = txtDataVencimento.Value,
                Juros = Convert.ToDouble(txtJuros.Text),
                PagarReceber =  cmbPagarReceber.Text[0].ToString(),
                PessoaId = Int16.Parse(txtPessoaId.Text),
                Valor = Convert.ToDouble(txtValor.Text),
                Descricao = txtDescricao.Text,
                Quitado   = quit
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                btnCancelar_Click(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            if (bsContas.Count == 0)
                return;

            DialogResult Question = MessageBox.Show("Deseja realmente excluir este registro?", "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Question == DialogResult.Yes)
            {
                retorno = Servicos.ContasServico.Excluir(new Contas()
                {
                    Id = Int16.Parse(((Contas)bsContas.Current).Id.ToString()),
                });

                if (!string.IsNullOrWhiteSpace(retorno))
                    MessageBox.Show(retorno);
                else
                    btnCancelar_Click(null, null);                
            }

           
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            CadPessoas fcadpessoas = new CadPessoas();
            fcadpessoas.PesquisaViaConta = true;
            fcadpessoas.pcPessoas.SelectedTab = fcadpessoas.tabPesquisa;
            fcadpessoas.ShowDialog();
            txtPessoaId.Text = fcadpessoas.id;
            lblPessoa.Text = fcadpessoas.Nome;
        }

        private void gridContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             if (pesquisaViaMovCaixa)
            {
                id = ((Contas)bsContas.Current).Id.ToString();
                descricao = ((Contas)bsContas.Current).Descricao;
                valor = ((Contas)bsContas.Current).Valor.ToString();
                this.Close();
            }
            else // editando
            {
                txtId.Text = ((Contas)bsContas.Current).Id.ToString();
                txtDataEmissao.Value = ((Contas)bsContas.Current).DataEmissao;

                if (((Contas)bsContas.Current).DataPagamento == DateTime.MinValue)
                {
                    txtDataPgto.Format = DateTimePickerFormat.Custom;
                    txtDataPgto.CustomFormat = " ";
                }
                else
                    txtDataPgto.Value = ((Contas)bsContas.Current).DataPagamento;


                txtDataVencimento.Value = ((Contas)bsContas.Current).DataVencimento;
                txtJuros.Text = ((Contas)bsContas.Current).Juros.ToString();
                
                 if (((Contas)bsContas.Current).PagarReceber == "P")
                    cmbPagarReceber.SelectedIndex = 0;
                else
                    cmbPagarReceber.SelectedIndex = 1;

                txtPessoaId.Text = ((Contas)bsContas.Current).PessoaId.ToString();
                txtValor.Text = ((Contas)bsContas.Current).Valor.ToString();
                txtDescricao.Text = ((Contas)bsContas.Current).Descricao;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;

                gbInfo.Enabled = true;
                pcContas.SelectedTab = tabInfo;
                txtDescricao.Focus();


             }


        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            double i;
            if (!double.TryParse(txtValor.Text, out i))
                txtValor.Text = "0";
        }

        private void txtJuros_Leave(object sender, EventArgs e)
        {
            double i;
            if (!double.TryParse(txtJuros.Text, out i))
                txtJuros.Text = "0";
        }

        private void txtPessoaId_Leave(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(txtPessoaId.Text, out i))
            {
                txtPessoaId.Text = "0";
                lblPessoa.Text = "-";
            }

            bsPessoa.Clear();
            bsPessoa.Add(Servicos.PessoasServico.Selecionar(Int16.Parse(txtPessoaId.Text)));
            if (((Pessoas)bsPessoa.Current) != null)
            {
                txtPessoaId.Text = ((Pessoas)bsPessoa.Current).Id.ToString();
                lblPessoa.Text = ((Pessoas)bsPessoa.Current).Nome;
            }
            else
            {
                txtPessoaId.Text = "0";
                lblPessoa.Text = "-";
            }


        }

        private void btnPesquisaCusto_Click(object sender, EventArgs e)
        {
            PreencheGrid("Descricao.Contains(\"" + txtPesquisaDescricao.Text + "\")");
            
        }

        private void txtDataPgto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                this.txtDataPgto.Format = DateTimePickerFormat.Custom;
                this.txtDataPgto.CustomFormat = " "; 
            }            
        }

        private void txtDataPgto_ValueChanged(object sender, EventArgs e)
        {
            this.txtDataPgto.Format = DateTimePickerFormat.Custom;
            this.txtDataPgto.CustomFormat = "dd/MM/yyyy";
                  
        }

        private void CadContas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }    
        }

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }    
        }

       
    }
}
