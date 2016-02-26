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
        public int idProjetoCorrente;
        public string estadoAtual; //controle para saber se o usuario está navegando ou editando o projeto

        List<Label> labelPos = new List<Label>(); // fica aqui para outras funçoes acessarem
        List<Label> labelNome = new List<Label>(); // fica aqui para outras funçoes acessarem

        void ModoNavegacao(string tipo)
        {
            // tipo = "navegar", "inserir", ou "editar" de acordo com a situação


            estadoAtual = tipo;

            if (tipo == "navegar")
            {
                TabProjetos.SelectTab(pcVisaoGeral);

                //limpa os grids
                bsGastos.Clear();
                bsRiscos.Clear();
                bsProjetos.Clear();

                //painéis
                panelInfo.Enabled = false;
                panelCustos.Enabled = false;

                //grid
                gridProjetos.Enabled = true;

                //botões
                btnCancela.Enabled = false;
                btnSalva.Enabled = false;
                btnNovo.Enabled = true;

                foreach (var projeto in Servicos.projetosServico.SelecionarTodos())
                {
                    bsProjetos.Add(projeto);
                }
            }
            else
            {
                if (tipo == "inserir")
                    bsProjetos.Clear();



                //painéis
                panelInfo.Enabled = true;
                panelCustos.Enabled = true;

                //grid
                gridProjetos.Enabled = false;

                //botões
                btnCancela.Enabled = true;
                btnSalva.Enabled = true;
                btnNovo.Enabled = false;

                TabProjetos.SelectTab(pcInfoProjeto);
                txtNomeProjeto.Focus();
            }


            // outro metodo de fazer select
            //List<GastosProjetosGastos> lista = Servicos.gastosServico.SelecionarGastos("0==0").ToList();
        }



        void ModoNavegacaoCustos(string tipo)
        {
            string filtro;


            // tipo = "navegar","inserir" ou "editar" de acordo com a situação
            if (tipo == "navegar")
            {
                //botões
                btnNovoCusto.Enabled = true;
                btnSalvaCusto.Enabled = false;
                btnCancelaCusto.Enabled = false;

                //paineis
                panelInfoCustos.Enabled = false;

                gridCustos.Enabled = true;

                bsGastos.Clear();

                if (estadoAtual == "editar")
                    filtro = " projetosid == " + txtIdProjeto.Text;
                else
                    filtro = "1==0";

                foreach (var gasto in Servicos.gastosServico.SelecionarGastos(filtro))
                {
                    bsGastos.Add(gasto);
                }

                if (bsGastos.Count > 0)
                    btnExcluiCusto.Enabled = true;
                else
                    btnExcluiCusto.Enabled = false;
            }
            else
            {
                //botões
                btnNovoCusto.Enabled = false;
                btnSalvaCusto.Enabled = true;
                btnExcluiCusto.Enabled = false;
                btnCancelaCusto.Enabled = true;

                //paineis
                panelInfoCustos.Enabled = true;

                //grid
                gridCustos.Enabled = false;

                if (tipo == "inserir")
                {
                    bsGastos.Clear();
                    if (estadoAtual == "editar")
                    {
                        txtIdprojetoCusto.Text = txtIdProjeto.Text;
                    }
                    else
                        filtro = "1==0";
                }
                btnPesquisaCusto.Focus();



            }



        }

        void ModoNavegacaoRiscos(string tipo)
        {
            string filtro;

            // tipo = "navegar","inserir" ou "editar" de acordo com a situação
            if (tipo == "navegar")
            {
                //botões
                btnNovoRisco.Enabled = true;
                btnSalvaRisco.Enabled = false;
                btnCancelaRisco.Enabled = false;

                //paineis
                panelInfoRisco.Enabled = false;

                bsRiscos.Clear();

                if (estadoAtual == "editar")
                    filtro = " projetosid == " + txtIdProjeto.Text;
                else
                    filtro = "1==0";

                foreach (var risco in Servicos.riscosServico.SelecionarRiscos(filtro))
                {
                    bsRiscos.Add(risco);
                }

                if (bsRiscos.Count > 0)
                    btnExcluiRisco.Enabled = true;
                else
                    btnExcluiRisco.Enabled = false;

                tabRiscos.SelectTab(pcListaRiscos);
            }
            else
            {
                //botões
                btnNovoRisco.Enabled = false;
                btnSalvaRisco.Enabled = true;
                btnExcluiRisco.Enabled = false;
                btnCancelaRisco.Enabled = true;

                //paineis
                panelInfoRisco.Enabled = true;

                if (tipo == "inserir")
                {
                    bsRiscos.Clear();
                    if (estadoAtual == "editar")
                        txtIdprojetoRisco.Text = txtIdProjeto.Text;
                }

                btnPesquisaRisco.Focus();

            }
        }

        public Form1()
        {
            InitializeComponent();
            this.txtResponsavelId.TextChanged += new System.EventHandler(this.txtResponsavelId_TextChanged);

            ModoNavegacao("navegar");



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

            
            //salvar e validar dados      
            retorno = Servicos.projetosServico.Salvar(new Projetos()
            {
                Id = Int16.Parse(txtIdProjeto.Text),
                NomeProjeto = txtNomeProjeto.Text,
                ResponsavelId = Convert.ToInt32(txtResponsavelId.Text),
                DataInicio = dateInicioProjeto.Value,
                DataFim = dateInicioProjeto.Value
            });



            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                ModoNavegacao("navegar");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ModoNavegacao("navegar");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ModoNavegacao("inserir");
            txtNomeProjeto.Focus();

            //recebe zero para confirmar que é um registro novo
            txtIdProjeto.Text = "0";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModoNavegacao("editar");
        }

        private void txtNomeProjeto_TextChanged(object sender, EventArgs e)
        {
            lblNomeProjeto.Text = txtNomeProjeto.Text;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            ModoNavegacaoCustos("inserir");
            //recebe zero para confirmar que é um registro novo
            txtIdCusto.Text = "0";
        }

        private void btnSalvaCusto_Click(object sender, EventArgs e)
        {
            string retorno;

            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.gastosprojetosServico.Salvar(new GastosProjetos()
            {
                Id = Int16.Parse(txtIdCusto.Text),
                GastoId = Int16.Parse(txtidGastoOrigem.Text),
                Observacao = txtObservacaoCusto.Text,
                ProjetosId = Int16.Parse(txtIdprojetoCusto.Text),
                QuantidadePrevista = Int16.Parse(txtQtdPrevCusto.Text),
                QuantidadeReal = Int16.Parse(txtQtdRealCusto.Text),
                ValorUnitarioPrevisto = Int16.Parse(txtVlrPrevCusto.Text),
                ValorUnitarioReal = Int16.Parse(txtVlrRealCusto.Text),
            });



            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                ModoNavegacaoCustos("navegar");
        }



        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModoNavegacaoCustos("editar");
        }

        private void TabProjetos_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((estadoAtual == "navegar") && (e.TabPage != pcVisaoGeral))
            {
                e.Cancel = true;
            }
            else if (e.TabPage == pcCustos)
            {
                ModoNavegacaoCustos("navegar");
            }
            else if (e.TabPage == pcRiscos)
            {
                ModoNavegacaoRiscos("navegar");
            }
        }

        private void panelCustos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelaCusto_Click(object sender, EventArgs e)
        {
            ModoNavegacaoCustos("navegar");
        }

        private void btnExcluiCusto_Click(object sender, EventArgs e)
        {
            string retorno;

            retorno = Servicos.gastosprojetosServico.Excluir(new GastosProjetos()
            {
                Id = Int16.Parse(txtIdCusto.Text),
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                ModoNavegacaoCustos("navegar");
        }

        private void btnSalvaRisco_Click(object sender, EventArgs e)
        {
            string retorno;


            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.riscosprojetosServico.Salvar(new RiscosProjetos()
            {
                Id = Int16.Parse(txtIdRisco.Text),
                Descricao = txtDescricaoRisco.Text,
                Impacto = Double.Parse(txtImpactoRisco.Text),
                Observacao = txtObservacaoRisco.Text,
                Previsto = Int16.Parse(txtPrevistoRisco.Text),
                Probabilidade = Int16.Parse(txtProbabilidadeRisco.Text),
                ProjetosId = Int16.Parse(txtIdprojetoRisco.Text),
                RiscoId = Int16.Parse(txtIdRiscoOrigem.Text),
                Score = Int16.Parse(txtScoreRisco.Text),
            });



            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                ModoNavegacaoRiscos("navegar");

        }

        private void btnNovoRisco_Click(object sender, EventArgs e)
        {
            ModoNavegacaoRiscos("inserir");
            //recebe zero para confirmar que é um registro novo
            txtIdRisco.Text = "0";
        }

        private void btnExcluiRisco_Click(object sender, EventArgs e)
        {
            string retorno;

            retorno = Servicos.riscosprojetosServico.Excluir(new RiscosProjetos()
            {
                Id = Int16.Parse(txtIdRisco.Text),
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                ModoNavegacaoRiscos("navegar");
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModoNavegacaoRiscos("editar");
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            int linha = 10, coluna = 18, cont = 1, numeroSorteio;
            Color cor;

            //limpa o panel
            foreach (var posicoes in labelNome)
            { 
                posicoes.Parent = null;
                Controls.Remove(posicoes);
                pcScore.Controls.Remove(posicoes);
            }
                
            foreach (var posicoes in labelPos)
            {
                posicoes.Parent = null;
                Controls.Remove(posicoes);
                pcScore.Controls.Remove(posicoes);
            }


            //sorteia uma cor
            Random r = new Random();
            numeroSorteio = r.Next(0, 5);
            List<Color> cores = new List<Color>();
            cores.Add(Color.Magenta);
            cores.Add(Color.Purple);
            cores.Add(Color.Gray);
            cores.Add(Color.Blue);
            cores.Add(Color.Brown);
            cores.Add(Color.Cornsilk);
            cores.Add(Color.DarkBlue);
            cores.Add(Color.DarkSalmon);
            cores.Add(Color.DarkOrchid);
            cores.Add(Color.DarkKhaki);
            cores.Add(Color.DarkGoldenrod);
            cores.Add(Color.Cyan);
            cores.Add(Color.Coral);



            //percorre lista de riscos salvos e cria os labels


            foreach (var risco in Servicos.riscosServico.SelecionarRiscos(" projetosid == " + txtIdProjeto.Text))
            {
                // adiciona o label fixo
                Label labelteste = new Label();
                numeroSorteio = r.Next(0, 12);
                cor = cores[numeroSorteio];
                labelteste.AutoSize = true;
                labelteste.Location = new System.Drawing.Point(linha, coluna);
                //labelteste.Size = new System.Drawing.Size(35, 13);      
                labelteste.Text = cont.ToString() + " - " + risco.Nome;
                labelteste.ForeColor = cor;
                labelteste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                this.Controls.Add(labelteste);
                labelNome.Add(labelteste);
                labelteste.BringToFront();
                
                



                pcScore.Controls.Add(labelteste);


                // adiciona o label móvel 
                Label labelteste2 = new Label();
                labelteste2.AutoSize = true;
                if (risco.Impacto == 0)
                    labelteste2.Location = new System.Drawing.Point(linha + 150, coluna);
                else
                {
                    int prob = (int)Math.Round(risco.Probabilidade * 3.5 + 425);
                    int impacto = (int)Math.Round(336 - risco.Impacto * 3.3);
                    labelteste2.Location = new System.Drawing.Point(prob, impacto);
                }

                //labelteste2.Size = new System.Drawing.Size(35, 13);
                labelteste2.Text = cont.ToString();
                labelteste2.ForeColor = cor;
                labelteste2.AccessibleName = risco.Id.ToString(); // salva o id para mais tarde
                labelteste2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                this.Controls.Add(labelteste2);
                Mover.Init(labelteste2);
                labelPos.Add(labelteste2);
                labelteste2.BringToFront();

                pcScore.Controls.Add(labelteste2);

                coluna = coluna + 20;
                cont = cont + 1;
            }

        }

        private void pcScore_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvaScore_Click(object sender, EventArgs e)
        {
            string retorno;
            foreach (var posicoes in labelPos)
            {
                if (posicoes.Location.Y != 18) // inalterado
                {
                    // calculo para descobrir onde ele se encontra no mapa, os valores foram pegos de movers.cs onde tem valores maximos e minimos que o quadro ocupa
                    double prob = Math.Round((posicoes.Location.X - 425) / 3.5);
                    double impacto = Math.Round((336 - posicoes.Location.Y) / 3.3);

                    gridRiscos.CurrentCell = gridRiscos.Rows[1].Cells[0];

                    //string teste = (gridRiscos.Rows[0].Cells[0].Value).ToString();
                    string teste = txtObservacaoRisco.Text;

                    int i = 0;

                    //procura a linha no grid equivalente ao risco
                    while (posicoes.AccessibleName != gridRiscos.Rows[i].Cells[0].Value.ToString())
                        i++;

                    // posiciona o grid
                    gridRiscos.CurrentCell = gridRiscos.Rows[i].Cells[0];

                    //salva
                    retorno = Servicos.riscosprojetosServico.Salvar(new RiscosProjetos()
                    {
                        Id = Int16.Parse(txtIdRisco.Text),
                        Impacto = impacto,
                        Probabilidade = prob,
                        Descricao = txtDescricaoRisco.Text,
                        Observacao = txtObservacaoRisco.Text,
                        Previsto = Int16.Parse(txtPrevistoRisco.Text),
                        ProjetosId = Int16.Parse(txtIdprojetoRisco.Text),
                        RiscoId = Int16.Parse(txtIdRiscoOrigem.Text),
                        Score = Int16.Parse(txtScoreRisco.Text),
                    });
                }
            }
            ModoNavegacaoRiscos("navegar");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroRisco fCadRisco = new CadastroRisco();
            fCadRisco.ShowDialog();
            txtIdRiscoOrigem.Text = fCadRisco.idRisco.ToString();
            txtNomeRisco.Text = fCadRisco.nome;
            txtDescricaoRiscoOrigem.Text = fCadRisco.descricao;
            txtPlanoContigenciaRiscoOrigem.Text = fCadRisco.contingencia;
            txtMedidaPrevRiscoOrigem.Text = fCadRisco.preventiva;
        }

        private void btnPesquisaCusto_Click(object sender, EventArgs e)
        {
            CadastroCusto fcadCusto = new CadastroCusto();
            fcadCusto.ShowDialog();
            txtidGastoOrigem.Text = fcadCusto.idGasto.ToString();
            txtDescricaoCusto.Text = fcadCusto.descricao;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VisualizaRelCustos VRelCustos = new VisualizaRelCustos();
            VRelCustos.titulo = lblNomeProjeto.Text;
            VRelCustos.ShowDialog();
        }

        private void btnInfoProjeto_Click(object sender, EventArgs e)
        {
            if (estadoAtual != "navegar")
                TabProjetos.SelectTab(pcInfoProjeto);
        }

        private void btnCustos_Click(object sender, EventArgs e)
        {
            if (estadoAtual != "navegar")
                TabProjetos.SelectTab(pcCustos);
        }

        private void btnRiscos_Click(object sender, EventArgs e)
        {
            if (estadoAtual != "navegar")
                TabProjetos.SelectTab(pcRiscos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string retorno;

            //salvar e validar dados      
            retorno = Servicos.projetosServico.Salvar(new Projetos()
            {
                Id = Int16.Parse(txtIdProjeto.Text),
                NomeProjeto = txtNomeProjeto.Text,
                ResponsavelId = Int16.Parse(txtResponsavelId.Text),
                DataInicio = dateInicioProjeto.Value,
                DataFim = dateInicioProjeto.Value
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{TAB}");
        }

        private void btnCancelaRisco_Click(object sender, EventArgs e)
        {
            ModoNavegacaoRiscos("navegar");
        }

        private void pcListaRiscos_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void txtResponsavelId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)            
                TabProjetos.SelectedTab = pcCustos;
            
        }

        private void txtResponsavelId_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
                ((TextBox)sender).Text = "0";

        }

    }
}
