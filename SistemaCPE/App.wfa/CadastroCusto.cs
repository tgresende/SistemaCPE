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
    public partial class CadastroCusto : Form
    {
        public int idGasto;            // valor utilizado para ser acessado pelo outro form
        public string descricao;       // valor utilizado para ser acessado pelo outro form
        void ModoForm(string tipo)
        {
            if (tipo == "Navegar")
            {
                //botões
                btnNovo.Enabled = true;
                btnSalva.Enabled = false;
                btnCancela.Enabled = false;
                btnConfirma.Enabled = true;

                //paineis
                panelInfo.Enabled = false;
                panelGrid.Enabled = true;


                bsGastos.Clear();

                foreach (var risco in Servicos.gastosServico.SelecionarTodos())
                {
                    bsGastos.Add(risco);
                }

                if (bsGastos.Count > 0)
                    btnExclui.Enabled = true;
                else
                    btnExclui.Enabled = false;
            }
            else
            {
                //botões
                btnNovo.Enabled = false;
                btnSalva.Enabled = true;
                btnExclui.Enabled = false;
                btnCancela.Enabled = true;
                btnConfirma.Enabled = false;

                //paineis
                panelInfo.Enabled = true;
                panelGrid.Enabled = false;
                if (tipo == "Inserir")
                {
                    bsGastos.Clear();
                    txtId.Text = "0";
                }
            }
        }


        public CadastroCusto()
        {
            InitializeComponent();
            ModoForm("Navegar");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ModoForm("Inserir");
            txtDescricao.Focus();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string retorno;

            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.gastosServico.Salvar(new Gastos()
            {
                Id = Int16.Parse(txtId.Text),
                Descricao = txtDescricao.Text,                
            });



            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                ModoForm("Navegar");
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            ModoForm("Navegar");
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            string retorno;

            retorno = Servicos.gastosServico.Excluir(new Gastos()
            {
                Id = Int16.Parse(txtId.Text),
            });
            ModoForm("Navegar");
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            idGasto = Int16.Parse(txtId.Text);
            descricao = txtDescricao.Text;
            this.Dispose();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModoForm("Editar");
            txtDescricao.Focus();
        }

        
    }
}
