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
    public partial class CadPessoas : Form
    {
        public string id, Nome;
        public bool PesquisaViaConta;

        private void PreencheGrid(string filtro)
        {
            if (filtro=="")
            {
                foreach (var Pessoa in Servicos.PessoasServico.SelecionarTodos())
                {
                    bsPessoas.Add(Pessoa);
                }
            }            
        }

        private void LimpaGrid()
        {
            bsPessoas.Clear();
        }

        public CadPessoas()
        {
            InitializeComponent();
            PreencheGrid("");
            btnCancelar_Click(null, null);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno;

            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.PessoasServico.Salvar(new Pessoas()
            {
                Id = Int16.Parse(txtId.Text),
                CPFCNPJ  = txtCPFCNPJ.Text,
                Nome     = txtNome.Text,
                Telefone = txtTelefone.Text,
                Rua      = txtRua.Text,
                Complemento = txtComplemento.Text,
                Numero   = txtNumero.Text,
                Bairro   = txtBairro.Text,
                Cep      = txtCep.Text,
                Cidade   = txtCidade.Text,
                Estado   = txtEstado.Text                
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                btnCancelar_Click(null, null);              
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            gbInfo.Enabled = false;
            pcPessoas.SelectedTab = tabInfo;


            txtId.Clear();
            txtCPFCNPJ.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtComplemento.Clear();

            LimpaGrid();
            PreencheGrid("");
            txtCPFCNPJ.Mask = "";

            btnNovo.Focus();
        }

       

      

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            if (bsPessoas.Count == 0)
                return;
            
            
            DialogResult Question = MessageBox.Show("Deseja realmente excluir este registro?", "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Question == DialogResult.Yes)
            {
                retorno = Servicos.PessoasServico.Excluir(new Pessoas()
                {
                    Id = Int32.Parse(((Pessoas)bsPessoas.Current).Id.ToString()),
                });

                if (!string.IsNullOrWhiteSpace(retorno))
                    MessageBox.Show(retorno);
                else
                    btnCancelar_Click(null, null);
            }
        }

        private void btnPesquisaCusto_Click(object sender, EventArgs e)
        {
            LimpaGrid();
            foreach (var Pessoa in Servicos.PessoasServico.SelecionarPessoa("Nome.Contains(\"" + txtPesquisaNome.Text + "\")"))
                bsPessoas.Add(Pessoa);    
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            txtId.Text = "0";
            gbInfo.Enabled = true;
            pcPessoas.SelectedTab = tabInfo;
            txtNome.Focus();


            LimpaGrid();
        }

        private void gridPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PesquisaViaConta)
            {
                id = ((Pessoas)bsPessoas.Current).Id.ToString();
                Nome = ((Pessoas)bsPessoas.Current).Nome;
                this.Close();
            }
            else // editando
            {
               txtId.Text = ((Pessoas)bsPessoas.Current).Id.ToString(); 
               txtCPFCNPJ.Text = ((Pessoas)bsPessoas.Current).CPFCNPJ;
               txtNome.Text =  ((Pessoas)bsPessoas.Current).Nome; 
               txtTelefone.Text = ((Pessoas)bsPessoas.Current).Telefone; 
               txtRua.Text = ((Pessoas)bsPessoas.Current).Rua;
               txtNumero.Text = ((Pessoas)bsPessoas.Current).Numero; 
               txtBairro.Text = ((Pessoas)bsPessoas.Current).Bairro; 
               txtCep.Text = ((Pessoas)bsPessoas.Current).Cep;      
               txtCidade.Text = ((Pessoas)bsPessoas.Current).Cidade;  
               txtEstado.Text = ((Pessoas)bsPessoas.Current).Estado;
               txtComplemento.Text = ((Pessoas)bsPessoas.Current).Complemento;


               btnCancelar.Enabled = true;
               btnExcluir.Enabled = false;
               btnNovo.Enabled = false;
               btnSalvar.Enabled = true;
              
               if  (txtCPFCNPJ.TextLength > 11)
                   txtCPFCNPJ.Mask = "00.000.000/0000-00";
               else
                    txtCPFCNPJ.Mask = "000.000.000-00";
               


               gbInfo.Enabled = true;
               pcPessoas.SelectedTab = tabInfo;
               txtNome.Focus();
            }
        }

        private void txtCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCpfCnp_Leave(object sender, EventArgs e)
        {
            if ((txtCPFCNPJ.Text).Length <= 11)
                txtCPFCNPJ.Mask = "000.000.000-00";
            else
                txtCPFCNPJ.Mask = "00.000.000/0000-00";
        }

        private void txtCPFCNPJ_Enter(object sender, EventArgs e)
        {
            txtCPFCNPJ.Mask = "";
        }

        
    }
}
