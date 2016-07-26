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
        public CadPessoas()
        {
            InitializeComponent();
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
            {
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;

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
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;

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
        }

        private void btnPesquisaCusto_Click(object sender, EventArgs e)
        {         
            foreach (var Pessoas in Servicos.PessoasServico.SelecionarTodos())
            {
                bsPessoas.Add(Pessoas);
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            txtId.Text = "0";
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            retorno = Servicos.PessoasServico.Excluir(new Pessoas()
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
                txtCPFCNPJ.Clear();
                txtNome.Clear();
                txtTelefone.Clear();
                txtRua.Clear();
                txtNumero.Clear();
                txtBairro.Clear();
                txtCep.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
            }
        }
    }
}
