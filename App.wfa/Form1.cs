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
    public partial class Form1 : Form
    {
        int id;  // controlador para inserção ou edição de registros


        void ModoNavegacao()
        {
            TabProjetos.SelectTab(pcVisaoGeral);
            //painéis
            panelInfo.Enabled = false;



            //botões
            btnCancela.Enabled = false;
            btnSalva.Enabled = false;
            btnNovo.Enabled = true;

            //preenche o grid
            bsProjetos.Clear();
            foreach (var projeto in Servicos.projetosServico.SelecionarTodos())
            {
                bsProjetos.Add(projeto);
            }
        }

        void ModoEdicao(string tipo)
        {
            if (tipo == "inserir")
                bsProjetos.Clear();

            



            TabProjetos.SelectTab(pcInfoProjeto);
            //painéis
            panelInfo.Enabled = true;



            //botões
            btnCancela.Enabled = true;
            btnSalva.Enabled = true;
            btnNovo.Enabled = false;

        }

        public Form1()
        {
            InitializeComponent();

            
            ModoNavegacao();





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
            if (id==0)
            {
                //salvar e validar dados      
                retorno = Servicos.projetosServico.Salvar(new Projetos()
                {
                    Id = 0,
                    NomeProjeto = txtNomeProjeto.Text, 
                    ResponsavelId= Int16.Parse(txtResponsavelId.Text),
                    DataInicio = dateInicioProjeto.Value,
                    DataFim = dateInicioProjeto.Value
           
                });
            }
            else
                retorno = Servicos.projetosServico.Salvar((Projetos)bsProjetos.Current);

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                ModoNavegacao();



        }

        private void button9_Click(object sender, EventArgs e)
        {
            ModoNavegacao();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ModoEdicao("inserir");
            txtNomeProjeto.Focus();

            //recebe zero para confirmar que é um registro novo
            id = 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModoEdicao("editar");
            //recebe um para confirmar que é uma edição de registro
            id = 1;
        }

    }
}
