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

            btnNovo.Focus();
        }

       

      

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            retorno = Servicos.PessoasServico.Excluir(new Pessoas()
            {
                Id = Int32.Parse(gridPessoas.CurrentRow.Cells[0].Value.ToString()),
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                btnCancelar_Click(null, null);
        }

        private void btnPesquisaCusto_Click(object sender, EventArgs e)
        {
            LimpaGrid();
            foreach (var Pessoa in Servicos.PessoasServico.SelecionarPessoa("Nome like '" + txtPesquisaNome.Text + "'"))
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

        
    }
}
