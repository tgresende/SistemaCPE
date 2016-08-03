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
    public partial class CadProduto : Form
    {
        private void PreencheGrid(string filtro)
        {
            if (filtro == "")
            {
                foreach (var Produto in Servicos.ProdutosServico.SelecionarTodos())
                {
                    bsProduto.Add(Produto);
                }
            }
        }

        private void PreencherGridInsumo(string filtro)
        {
            if (filtro != "")
            {
               /* foreach (var insumo in Servicos.InsumosServico.SelecionarInsumoPorProduto(filtro))
                {
                    bsInsumos.Add(insumo);
                }
                txtTotal.Text = gridInsumos.Rows.Cast<DataGridViewRow>()
                                  .AsEnumerable()
                                  .Sum(x => Convert.ToDouble(x.Cells[5].Value.ToString()))
                                  .ToString();
                                  */
            }
        }
        public CadProduto()
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

            gridInsumos.Enabled = false;
            btnNovoInsumo.Enabled = true;
            btnCancelarInsumo.Enabled = false;
            btncExcluirInsumo.Enabled = true;
            btnSalvarInsumo.Enabled = false;
            gbInsumo.Enabled = false;


            txtProdutoId.Text = "0";
            gbInfo.Enabled = true;
            pcProdutos.SelectedTab = tabInfo;
            txtNome.Focus();


            bsProduto.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno;

            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.ProdutosServico.Salvar(new Produtos()
            {
                Id = Int16.Parse(txtProdutoId.Text),
                Descricao = txtDescricao.Text,
                Nome = txtNome.Text,
                Peso = Convert.ToDouble(txtPeso.Text),
      //          Unidade = cmbUnidade.Text
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                btnCancelar_Click(null, null);              
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gridInsumos.Enabled = true;
            btnNovoInsumo.Enabled = true;
            btnCancelarInsumo.Enabled = false;
            btncExcluirInsumo.Enabled = true;
            btnSalvarInsumo.Enabled = false;
            gbInsumo.Enabled = false;


            txtProdutoInsumoId.Clear();
            txtInsumo.Clear();
            lblNomeInsumo.Text = "-";
            txtValorInsumo.Clear();
            txtUnidadeInsumo.Clear();
            txtQuantidade.Clear();


            bsInsumos.Clear();
            
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            gbInfo.Enabled = false;
            gridInsumos.Enabled = false;
            btnNovoInsumo.Enabled = false;
            btnCancelarInsumo.Enabled = false;
            btncExcluirInsumo.Enabled = false;
            btnSalvarInsumo.Enabled = false;
            gbInsumo.Enabled = false;


            pcProdutos.SelectedTab = tabInfo;

            
            txtProdutoId.Clear();
            txtDescricao.Clear();
            txtNome.Clear();
            txtPeso.Clear();
            //cmbUnidade.SelectedIndex = 0;


            bsProduto.Clear();
            bsInsumos.Clear();
            bsPesquisaInsumo.Clear();
            txtTotal.Clear();

            PreencheGrid("");

            btnNovo.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string retorno;

            if (bsProduto.Count == 0)
                return;


            DialogResult Question = MessageBox.Show("Deseja realmente excluir este registro?", "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Question == DialogResult.Yes)
            {
                retorno = Servicos.ProdutosServico.Excluir(new Produtos()
                {
                    Id = Int32.Parse(((Produtos)bsProduto.Current).Id.ToString()),
                });

                if (!string.IsNullOrWhiteSpace(retorno))
                    MessageBox.Show(retorno);
                else
                    btnCancelar_Click(null, null);
            }
        }

        private void btnPesquisaCusto_Click(object sender, EventArgs e)
        {
            bsProduto.Clear();
            foreach (var Pessoa in Servicos.ProdutosServico.SelecionarProduto("Nome.Contains(\"" + txtPesquisaNome.Text + "\")"))
                bsProduto.Add(Pessoa);   
        }

        private void gridPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtProdutoId.Text = ((Produtos)bsProduto.Current).Id.ToString();
            txtDescricao.Text = ((Produtos)bsProduto.Current).Descricao;
            txtNome.Text = ((Produtos)bsProduto.Current).Nome;
            txtPeso.Text = ((Produtos)bsProduto.Current).Peso.ToString();
    //        cmbUnidade.SelectedIndex = cmbUnidade.FindString(((Produtos)bsProduto.Current).Unidade, 0);

            PreencherGridInsumo("ProdutoId = " + ((Produtos)bsProduto.Current).Id.ToString());
        


            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            gridInsumos.Enabled = true;
            btnNovoInsumo.Enabled = true;
            btnCancelarInsumo.Enabled = false;
            btncExcluirInsumo.Enabled = true;
            btnSalvarInsumo.Enabled = false;
            gbInsumo.Enabled = false;




            gbInfo.Enabled = true;
            pcProdutos.SelectedTab = tabInfo;
            txtNome.Focus();
            
        }

        private void CadProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            double i;
            if (!double.TryParse(txtPeso.Text, out i))
                txtPeso.Text = "0";
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }      
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnNovoInsumo_Click(object sender, EventArgs e)
        {
            gridInsumos.Enabled = false;
            btnNovoInsumo.Enabled = false;
            btnCancelarInsumo.Enabled = true;
            btncExcluirInsumo.Enabled = false;
            btnSalvarInsumo.Enabled = true;
            gbInsumo.Enabled = true;

            txtProdutoInsumoId.Text = "0";
            txtInsumo.Focus();
        }

        private void btnSalvarInsumo_Click(object sender, EventArgs e)
        {
            string retorno;

            //0 - Novo                 id - edição
            //salvar e validar dados      
            retorno = Servicos.ProdutosInsumosServico.Salvar(new ProdutosInsumos()
            {
                Id = Int16.Parse(txtProdutoInsumoId.Text),
                ProdutoId = Int16.Parse(txtProdutoId.Text),
                InsumoId = Int16.Parse(txtInsumo.Text),
                Quantidade = Convert.ToDouble(txtQuantidade.Text)
            });

            if (!string.IsNullOrWhiteSpace(retorno))
                MessageBox.Show(retorno);
            else
                btnCancelarInsumo_Click(null, null);              
        }

        private void btnCancelarInsumo_Click(object sender, EventArgs e)
        {
            

            gridInsumos.Enabled = true;
            btnNovoInsumo.Enabled = true;
            btnCancelarInsumo.Enabled = false;
            btncExcluirInsumo.Enabled = true;
            btnSalvarInsumo.Enabled = false;
            gbInsumo.Enabled = false;


            txtProdutoInsumoId.Clear();
            txtInsumo.Clear();
            lblNomeInsumo.Text = "-";
            txtValorInsumo.Clear();
            txtUnidadeInsumo.Clear();
            txtQuantidade.Clear();
           

            bsInsumos.Clear();

            PreencherGridInsumo("ProdutoID = " + txtProdutoId.Text);
            btnNovoInsumo.Focus();
        }

        private void btncExcluirInsumo_Click(object sender, EventArgs e)
        {
            string retorno;

            if (bsInsumos.Count == 0)
                return;


            DialogResult Question = MessageBox.Show("Deseja realmente excluir este insumo?", "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Question == DialogResult.Yes)
            {
                retorno = Servicos.ProdutosInsumosServico.Excluir(new ProdutosInsumos()
                {
                    Id = Int32.Parse(((InsumosProdutos)bsInsumos.Current).Id.ToString()),
                });

                if (!string.IsNullOrWhiteSpace(retorno))
                    MessageBox.Show(retorno);
                else
                    btnCancelarInsumo_Click(null, null);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CadProduto fcadInsumo = new CadProduto();
            //fcadInsumo.PesquisaViaProduto = true;
            //fcadInsumo.pcInsumos.SelectedTab = fcadInsumo.tabPesquisa;
            fcadInsumo.ShowDialog();
         //   txtInsumo.Text = fcadInsumo.id;
            txtInsumo_Leave(null, null);
        }

        private void txtInsumo_Leave(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(txtInsumo.Text, out i))
            {
                txtInsumo.Text = "0";
                lblNomeInsumo.Text = "-";
                txtValorInsumo.Clear();
                txtUnidadeInsumo.Clear();
            }

            bsPesquisaInsumo.Clear();
       /*     bsPesquisaInsumo.Add(Servicos.InsumosServico.Selecionar(Int16.Parse(txtInsumo.Text)));
            if (((Insumos)bsPesquisaInsumo.Current) != null)
            {
                txtInsumo.Text = ((Insumos)bsPesquisaInsumo.Current).Id.ToString();
                lblNomeInsumo.Text = ((Insumos)bsPesquisaInsumo.Current).Nome;
                txtUnidadeInsumo.Text = ((Insumos)bsPesquisaInsumo.Current).Unidade;
                txtValorInsumo.Text = ((Insumos)bsPesquisaInsumo.Current).Valor.ToString();
            }
            else
            {
                txtInsumo.Text = "0";
                lblNomeInsumo.Text = "-";
                txtValorInsumo.Clear();
                txtUnidadeInsumo.Clear();
            }
            */
        }

        private void gridInsumos_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
        
        }

        private void gridInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = gridInsumos.Rows[e.RowIndex];
            double valueA = Convert.ToDouble(row.Cells[valorDataGridViewTextBoxColumn.Index].Value);
            double valueB = Convert.ToDouble(row.Cells[Quantidade.Index].Value);

            row.Cells[TotalColuna.Index].Value = valueA * valueB;
        }

        private void gridInsumos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow row = gridInsumos.Rows[e.RowIndex];
            double valueA = Convert.ToDouble(row.Cells[valorDataGridViewTextBoxColumn.Index].Value);
            double valueB = Convert.ToDouble(row.Cells[Quantidade.Index].Value);

            row.Cells[TotalColuna.Index].Value = valueA * valueB;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }    
        }

        private void gridInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gridInsumos.Enabled = false;
            btnNovoInsumo.Enabled = false;
            btnCancelarInsumo.Enabled = true;
            btncExcluirInsumo.Enabled = false;
            btnSalvarInsumo.Enabled = true;
            gbInsumo.Enabled = true;

            txtInsumo.Focus();

            txtProdutoInsumoId.Text = ((InsumosProdutos)bsInsumos.Current).Id.ToString();
            txtInsumo.Text = ((InsumosProdutos)bsInsumos.Current).InsumoId.ToString();
            lblNomeInsumo.Text = ((InsumosProdutos)bsInsumos.Current).Nome;
            txtUnidadeInsumo.Text = ((InsumosProdutos)bsInsumos.Current).Unidade;
            txtValorInsumo.Text = ((InsumosProdutos)bsInsumos.Current).Valor.ToString();
            txtQuantidade.Text = ((InsumosProdutos)bsInsumos.Current).Quantidade.ToString();
         
        }
    }
}
