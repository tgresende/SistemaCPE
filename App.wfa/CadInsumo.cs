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
    public partial class CadInsumo : Form
    {
        public string id;
        public bool PesquisaViaProduto;
        private void PreencheGrid(string filtro)
        {
            if (filtro == "")
            {
                foreach (var Insumo in Servicos.InsumosServico.SelecionarTodos())
                {
                    bsInsumo.Add(Insumo);
                }
            }
        }

        public CadInsumo()
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

            txtId.Text = "0";
            gbInfo.Enabled = true;
            pcInsumos.SelectedTab = tabInfo;
            txtNome.Focus();


            bsInsumo.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno;

            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.InsumosServico.Salvar(new Insumos()
            {
                Id = Int16.Parse(txtId.Text),
                Descricao = txtDescricao.Text,
                Nome = txtNome.Text,
                Valor = Convert.ToDouble(txtValor.Text),
                Unidade = cmbUnidade.Text
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
            btnExcluir.Enabled = true;
            gbInfo.Enabled = false;
            pcInsumos.SelectedTab = tabInfo;


            txtId.Clear();
            txtDescricao.Clear();
            txtNome.Clear();
            txtValor.Clear();
            cmbUnidade.SelectedIndex = 0;


            bsInsumo.Clear();
            PreencheGrid("");

            btnNovo.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            if (bsInsumo.Count == 0)
                return;


            DialogResult Question = MessageBox.Show("Deseja realmente excluir este registro?", "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Question == DialogResult.Yes)
            {
                retorno = Servicos.InsumosServico.Excluir(new Insumos()
                {
                    Id = Int32.Parse(((Insumos)bsInsumo.Current).Id.ToString()),
                });

                if (!string.IsNullOrWhiteSpace(retorno))
                    MessageBox.Show(retorno);
                else
                    btnCancelar_Click(null, null);
            }
        }

        private void btnPesquisaCusto_Click(object sender, EventArgs e)
        {
            bsInsumo.Clear();
            foreach (var Pessoa in Servicos.InsumosServico.SelecionarInsumo("Nome.Contains(\"" + txtPesquisaNome.Text + "\")"))
                bsInsumo.Add(Pessoa);    
        }

        private void gridInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PesquisaViaProduto)
            {
                id = ((Insumos)bsInsumo.Current).Id.ToString();
                this.Close();
            }
            else // editando
            {
                txtId.Text = ((Insumos)bsInsumo.Current).Id.ToString();
                txtDescricao.Text = ((Insumos)bsInsumo.Current).Descricao;
                txtNome.Text = ((Insumos)bsInsumo.Current).Nome;
                txtValor.Text = ((Insumos)bsInsumo.Current).Valor.ToString();
                cmbUnidade.SelectedIndex = cmbUnidade.FindString(((Insumos)bsInsumo.Current).Unidade, 0);


                btnCancelar.Enabled = true;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;

              


                gbInfo.Enabled = true;
                pcInsumos.SelectedTab = tabInfo;
                txtNome.Focus();
            }
        }

        private void CadInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            double i;
            if (!double.TryParse(txtValor.Text, out i))
                txtValor.Text = "0";
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }      
        }
    }
}


