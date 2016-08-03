using App.Comunicacao;
using App.Dominio;
using App.DTO;
using DevExpress.XtraEditors;
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
    public partial class Principal : Form
    {
        public int idProjetoCorrente;
        public string estadoAtual; //controle para saber se o usuario está navegando ou editando o projeto

        List<Label> labelPos = new List<Label>(); // fica aqui para outras funçoes acessarem
        List<Label> labelNome = new List<Label>(); // fica aqui para outras funçoes acessarem

       
        public Principal()
        {
            InitializeComponent();
          

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
   
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{TAB}");
        }

        private void btnMovimentoCaixa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCadContas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCadPessoas_Click(object sender, EventArgs e)
        {
            CadPessoas frmCadPessoas = new CadPessoas();
            frmCadPessoas.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            VisualizaRelContas fVisualizaRelCustos = new VisualizaRelContas();
            fVisualizaRelCustos.titulo = "Contas à Pagar e Receber";
            fVisualizaRelCustos.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CadMovimentoCaixa frmMovimentoCaixa = new CadMovimentoCaixa();
            frmMovimentoCaixa.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CadContas frmCadContas = new CadContas();
            frmCadContas.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            CadProduto fCadproduto = new CadProduto();
            fCadproduto.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            CadVenda fCadVenda = new CadVenda();
            fCadVenda.ShowDialog();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            CadUnidades fCadUnidades = new CadUnidades();
            fCadUnidades.ShowDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            CadTipoConta fCadTipoConta = new CadTipoConta();
            fCadTipoConta.ShowDialog();
        }
    }
}
