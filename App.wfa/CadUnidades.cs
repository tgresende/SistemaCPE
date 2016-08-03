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
    public partial class CadUnidades : Form
    {
        private void PreencheGrid(string filtro)
        {
            if (filtro == "")
            {
                foreach (var Unid in Comunicacao.Servicos.UnidadesServico.SelecionarTodos())
                {
                    bsUnidades.Add(Unid);
                }
            }
        }

        public CadUnidades()
        {
            InitializeComponent();
            PreencheGrid("");
            btnCancelar_Click(null, null);
        }

        private void CadUnidades_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            gridUnidade.Enabled = false;
            gbUnidade.Enabled = true;
            

            txtId.Text = "0";
            txtNome.Focus();


            bsUnidades.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno;

            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.UnidadesServico.Salvar(new Dominio.Unidades()
            {
                Id = Int16.Parse(txtId.Text),
                Sigla = txtSigla.Text,
                Nome = txtNome.Text
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                btnCancelar_Click(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtId.Text = "";
            txtNome.Text = "";
            txtSigla.Text = "";

           

            bsUnidades.Clear();

            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            gbUnidade.Enabled = false;

            gridUnidade.Enabled = true;
            PreencheGrid("");

            btnNovo.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            if (bsUnidades.Count == 0)
                return;


            DialogResult Question = MessageBox.Show("Deseja realmente excluir este registro?", "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Question == DialogResult.Yes)
            {
                retorno = Servicos.UnidadesServico.Excluir(new Dominio.Unidades()
                {
                    Id = Int32.Parse(((Unidades)bsUnidades.Current).Id.ToString()),
                });

                if (!string.IsNullOrWhiteSpace(retorno))
                    MessageBox.Show(retorno);
                else
                    btnCancelar_Click(null, null);
            }
        }

        private void gridUnidade_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtId.Text = ((Unidades)bsUnidades.Current).Id.ToString();
            txtSigla.Text = ((Unidades)bsUnidades.Current).Sigla;
            txtNome.Text = ((Unidades)bsUnidades.Current).Nome;
      

    

            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            gridUnidade.Enabled = true;
            gbUnidade.Enabled = true;
            txtNome.Focus();
        }

        private void CadUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
