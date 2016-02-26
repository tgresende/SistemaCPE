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
    public partial class CadastroRisco : Form
    {
        public int idRisco;            // valor utilizado para ser acessado pelo outro form
        public string nome, descricao, contingencia, preventiva; // valor utilizado para ser acessado pelo outro form
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


                bsRiscos.Clear();                

                foreach (var risco in Servicos.riscosServico.SelecionarTodos())
                {
                    bsRiscos.Add(risco);
                }

                if (bsRiscos.Count > 0)
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
                    bsRiscos.Clear();
                    txtId.Text = "0";
                }
            }
        }
    



        public CadastroRisco()
        {
            InitializeComponent();
            ModoForm("Navegar");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ModoForm("Inserir");
            txtNome.Focus();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            ModoForm("Navegar");
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string retorno;           

            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.riscosServico.Salvar(new Riscos()
            {
                Id = Int16.Parse(txtId.Text),
                Descricao = txtDescricao.Text,
                MedidaPreventiva = txtPrevencao.Text,
                Nome = txtNome.Text,
                PlanoContigencia = txtContingencia.Text,               
            });



            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                ModoForm("Navegar");
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            string retorno;

            retorno = Servicos.riscosServico.Excluir(new Riscos()
            {
                Id = Int16.Parse(txtId.Text),
            });
            ModoForm("Navegar");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModoForm("Editar");
            txtNome.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            idRisco = Int16.Parse(txtId.Text);
            nome = txtNome.Text;
            descricao = txtDescricao.Text;
            preventiva = txtPrevencao.Text;
            contingencia = txtContingencia.Text;
            this.Dispose();


        }
    }
}
