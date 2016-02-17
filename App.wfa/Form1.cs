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
    public partial class Form1 : Form
    {
        int id, idCusto;  // controlador para inserção ou edição de registros


        void ModoNavegacao(bool estado, string tipo)
        {
            // estado = true se estiver em navegação
            // estado = false se estiver em edição
            // tipo = "inserir" ou "editar" de acordo com a situação
            if (estado)
            {
                TabProjetos.SelectTab(pcVisaoGeral);

                //preenche o grid
                bsProjetos.Clear();
                foreach (var projeto in Servicos.projetosServico.SelecionarTodos())
                {
                    bsProjetos.Add(projeto);
                }
            }
            else
            {
                if (tipo == "inserir")
                    bsProjetos.Clear();
                TabProjetos.SelectTab(pcInfoProjeto);
            }

            //componentes liberados em modo navegação recebe "estado";
            //componentes bloqueados em modo navegação recebe "!estado";
            //modo navegação = modo que nao se pode alterar dados

            //painéis
            panelInfo.Enabled = !estado;
            panelCustos.Enabled = !estado;

            //botões
            btnCancela.Enabled = !estado;
            btnSalva.Enabled = !estado;
            btnNovo.Enabled = estado;


            // outro metodo de fazer select
            //List<GastosProjetosGastos> lista = Servicos.gastosServico.SelecionarGastos("0==0").ToList();
        }



        void ModoNavegacaoCustos(bool estado, string tipo)
        {
            // estado = true se estiver em navegação
            // estado = false se estiver em edição
            // tipo = "inserir" ou "editar" de acordo com a situação
            if (estado)
            {   
                //preenche o grid
                bsGastos.Clear();
                foreach (var gasto in Servicos.gastosServico.SelecionarGastos("0==0"))
                {
                    bsGastos.Add(gasto);
                }
            }
            else
            {
                if (tipo == "inserir")
                    bsProjetos.Clear();                
            }


            //botões
            btnNovoCusto.Enabled = estado;
            btnSalvaCusto.Enabled = !estado;
            btnExcluiCusto.Enabled = estado;
            btnCancelaCusto.Enabled = !estado;

            //paineis
            panelInfoCustos.Enabled = !estado;
        }

       

        public Form1()
        {
            InitializeComponent();
            ModoNavegacao(true, "");

            //criar varios itens
            /* int i,j=800;
             List<Label> labelPos = new List<Label>();

             for (i = 0; i < 10; i++)
             {
                 j = j + 40;
                 Label labelteste = new Label();
                 labelteste.AutoSize = true;
                 labelteste.Location = new System.Drawing.Point(j, 456);
                 labelteste.Name = "labelteste" + i.ToString();
                 labelteste.Size = new System.Drawing.Size(35, 13);
                 labelteste.TabIndex = 11+i;
                 labelteste.Text = "labelteste" + i.ToString();
                 this.Controls.Add(labelteste);
                 Mover.Init(labelteste);
                 labelPos.Add(labelteste);
                
             }
              */

            //foreach e sair gravando feliz
            //   Label l = labelPos.Last();
            //   MessageBox.Show(l.Location.X.ToString());





            // Move your controls
            Mover.Init(this.button1);
            Mover.Init(this.button2);
            Mover.Init(this.button3);
            Mover.Init(this.button4);
            Mover.Init(this.button5);


            //formas de salvar 
            /*
            Servicos.consultorprojetosServico.Salvar(new ConsultorProjetos()
            {
                ConsultorId = 1,
                ValorHora = 0,
                QuantidadeSemanas = 0,
                ProjetoId = 1,
                HorasSemanais = 1
            });

            ConsultorProjetos objeto = new ConsultorProjetos();
            objeto.ProjetoId = 1;
            */



        }


        private void button8_Click(object sender, EventArgs e)
        {
            string retorno;
            if (id == 0)
            {
                //salvar e validar dados      
                retorno = Servicos.projetosServico.Salvar(new Projetos()
                {
                    Id = 0,
                    NomeProjeto = txtNomeProjeto.Text,
                    ResponsavelId = Int16.Parse(txtResponsavelId.Text),
                    DataInicio = dateInicioProjeto.Value,
                    DataFim = dateInicioProjeto.Value

                });
            }
            else
                retorno = Servicos.projetosServico.Salvar((Projetos)bsProjetos.Current);

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                ModoNavegacao(true, "");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ModoNavegacao(true, "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ModoNavegacao(false, "inserir");
            txtNomeProjeto.Focus();

            //recebe zero para confirmar que é um registro novo
            id = 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModoNavegacao(false, "editar");
            //recebe um para confirmar que é uma edição de registro
            id = 1;
        }

        private void txtNomeProjeto_TextChanged(object sender, EventArgs e)
        {
            lblNomeProjeto.Text = txtNomeProjeto.Text;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            ModoNavegacaoCustos(false, "inserir");
            txtDescricaoCusto.Focus();

            //recebe zero para confirmar que é um registro novo
            idCusto = 0;
        }

        private void btnSalvaCusto_Click(object sender, EventArgs e)
        {
            string retorno;
            if (idCusto == 0)
            {
                //salvar e validar dados      
                retorno = Servicos.gastosprojetosServico.Salvar(new GastosProjetos()
                {
                    Id = 0,
                    GastoId = Int16.Parse(txtidGastoOrigem.Text),
                    Observacao= txtObservacaoCusto.Text,
                    ProjetosId = Int16.Parse(txtIdprojetoCusto.Text),
                    QuantidadePrevista = Int16.Parse(txtQtdPrevCusto.Text),
                    QuantidadeReal = Int16.Parse(txtQtdRealCusto.Text),
                    ValorUnitarioPrevisto = Int16.Parse(txtVlrPrevCusto.Text),
                    ValorUnitarioReal = Int16.Parse(txtVlrRealCusto.Text),       
                });
            }
            else
                retorno = Servicos.gastosprojetosServico.Salvar((GastosProjetos)bsGastos.Current);

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                ModoNavegacaoCustos(true, "");
        }

        private void pcCustos_Enter(object sender, EventArgs e)
        {
            //preenche o grid
            bsGastos.Clear();
            foreach (var gasto in Servicos.gastosServico.SelecionarGastos("0==0"))
            {
                bsGastos.Add(gasto);
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            ModoNavegacaoCustos(false, "editar");
            //recebe um para confirmar que é uma edição de registro
            idCusto = 1;        
        }

    }
}
