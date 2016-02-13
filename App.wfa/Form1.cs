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

            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmcadProjetos = new CadProjetos();
            frmcadProjetos.Show();
        }
    }
}
