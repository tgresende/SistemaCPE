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
        public Form1()
        {
            InitializeComponent();

            bindingSource1.Clear();

            //salvar e validar dados
            //string retorno = Servicos.projetosServico.Salvar(new Projetos() { NomeProjeto = "teste", DataInicio = DateTime.Now });
            //if (!string.IsNullOrWhiteSpace(retorno))
            //    MessageBox.Show(retorno);



            //criar varios itens
            int i,j=800;
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

            //foreach e sair gravando feliz
            Label l = labelPos.Last();
            MessageBox.Show(l.Location.X.ToString());



            foreach (var projeto in Servicos.projetosServico.SelecionarTodos())
            {
                bindingSource1.Add(projeto);
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmcadProjetos = new CadProjetos();
            frmcadProjetos.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Servicos.projetosServico.Salvar((Projetos)bindingSource1.Current);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Servicos.projetosServico.Excluir((Projetos)bindingSource1.Current);
            bindingSource1.Remove(bindingSource1.Current);
        }
    }
}
