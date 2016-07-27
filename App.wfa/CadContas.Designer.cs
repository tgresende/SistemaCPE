namespace App.wfa
{
    partial class CadContas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadContas));
            this.pcContas = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.cmbPagarReceber = new System.Windows.Forms.ComboBox();
            this.btnPesquisaPessoa = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataPgto = new System.Windows.Forms.DateTimePicker();
            this.txtDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtPessoaId = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaDescricao = new System.Windows.Forms.TextBox();
            this.btnPesquisaCusto = new System.Windows.Forms.Button();
            this.gridContas = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bsContas = new System.Windows.Forms.BindingSource(this.components);
            this.bsPessoa = new System.Windows.Forms.BindingSource(this.components);
            this.pagarReceberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcContas.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // pcContas
            // 
            this.pcContas.Controls.Add(this.tabInfo);
            this.pcContas.Controls.Add(this.tabPesquisa);
            this.pcContas.Location = new System.Drawing.Point(-1, 80);
            this.pcContas.Margin = new System.Windows.Forms.Padding(4);
            this.pcContas.Name = "pcContas";
            this.pcContas.SelectedIndex = 0;
            this.pcContas.Size = new System.Drawing.Size(655, 330);
            this.pcContas.TabIndex = 19;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.tabInfo.Controls.Add(this.gbInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tabInfo.Size = new System.Drawing.Size(647, 301);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Informações";
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.gbInfo.Controls.Add(this.lblPessoa);
            this.gbInfo.Controls.Add(this.cmbPagarReceber);
            this.gbInfo.Controls.Add(this.btnPesquisaPessoa);
            this.gbInfo.Controls.Add(this.txtDescricao);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtDataPgto);
            this.gbInfo.Controls.Add(this.txtDataVencimento);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtDataEmissao);
            this.gbInfo.Controls.Add(this.txtPessoaId);
            this.gbInfo.Controls.Add(this.txtJuros);
            this.gbInfo.Controls.Add(this.txtValor);
            this.gbInfo.Controls.Add(this.label61);
            this.gbInfo.Controls.Add(this.label60);
            this.gbInfo.Controls.Add(this.label59);
            this.gbInfo.Controls.Add(this.label57);
            this.gbInfo.Controls.Add(this.label56);
            this.gbInfo.Controls.Add(this.label55);
            this.gbInfo.Controls.Add(this.txtId);
            this.gbInfo.Location = new System.Drawing.Point(6, 6);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(622, 289);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(534, 49);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(13, 17);
            this.lblPessoa.TabIndex = 31;
            this.lblPessoa.Text = "-";
            // 
            // cmbPagarReceber
            // 
            this.cmbPagarReceber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPagarReceber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPagarReceber.FormattingEnabled = true;
            this.cmbPagarReceber.Items.AddRange(new object[] {
            "Pagar",
            "Receber"});
            this.cmbPagarReceber.Location = new System.Drawing.Point(449, 13);
            this.cmbPagarReceber.Name = "cmbPagarReceber";
            this.cmbPagarReceber.Size = new System.Drawing.Size(121, 24);
            this.cmbPagarReceber.TabIndex = 55;
            // 
            // btnPesquisaPessoa
            // 
            this.btnPesquisaPessoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisaPessoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaPessoa.BackgroundImage")));
            this.btnPesquisaPessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisaPessoa.FlatAppearance.BorderSize = 0;
            this.btnPesquisaPessoa.Location = new System.Drawing.Point(495, 43);
            this.btnPesquisaPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaPessoa.Name = "btnPesquisaPessoa";
            this.btnPesquisaPessoa.Size = new System.Drawing.Size(32, 29);
            this.btnPesquisaPessoa.TabIndex = 54;
            this.btnPesquisaPessoa.UseVisualStyleBackColor = false;
            this.btnPesquisaPessoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(130, 46);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(180, 23);
            this.txtDescricao.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Descrição";
            // 
            // txtDataPgto
            // 
            this.txtDataPgto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataPgto.Location = new System.Drawing.Point(129, 220);
            this.txtDataPgto.Name = "txtDataPgto";
            this.txtDataPgto.Size = new System.Drawing.Size(95, 23);
            this.txtDataPgto.TabIndex = 5;
            this.txtDataPgto.ValueChanged += new System.EventHandler(this.txtDataPgto_ValueChanged);
            this.txtDataPgto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataPgto_KeyPress);
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVencimento.Location = new System.Drawing.Point(130, 184);
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(95, 23);
            this.txtDataVencimento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Data Vencimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Data Emissão";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEmissao.Location = new System.Drawing.Point(130, 149);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(95, 23);
            this.txtDataEmissao.TabIndex = 3;
            // 
            // txtPessoaId
            // 
            this.txtPessoaId.Location = new System.Drawing.Point(449, 46);
            this.txtPessoaId.Name = "txtPessoaId";
            this.txtPessoaId.Size = new System.Drawing.Size(39, 23);
            this.txtPessoaId.TabIndex = 7;
            this.txtPessoaId.Leave += new System.EventHandler(this.txtPessoaId_Leave);
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(130, 115);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(95, 23);
            this.txtJuros.TabIndex = 2;
            this.txtJuros.Leave += new System.EventHandler(this.txtJuros_Leave);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(130, 80);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 1;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(339, 46);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(55, 17);
            this.label61.TabIndex = 42;
            this.label61.Text = "Pessoa";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(339, 19);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(104, 17);
            this.label60.TabIndex = 41;
            this.label60.Text = "Pagar/Receber";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(8, 225);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(71, 17);
            this.label59.TabIndex = 40;
            this.label59.Text = "Data Pgto";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 19);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(19, 17);
            this.label57.TabIndex = 39;
            this.label57.Text = "Id";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(6, 118);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(43, 17);
            this.label56.TabIndex = 38;
            this.label56.Text = "Juros";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 83);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(41, 17);
            this.label55.TabIndex = 37;
            this.label55.Text = "Valor";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(130, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 23);
            this.txtId.TabIndex = 36;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPesquisa.Controls.Add(this.label1);
            this.tabPesquisa.Controls.Add(this.txtPesquisaDescricao);
            this.tabPesquisa.Controls.Add(this.btnPesquisaCusto);
            this.tabPesquisa.Controls.Add(this.gridContas);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 25);
            this.tabPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(4);
            this.tabPesquisa.Size = new System.Drawing.Size(647, 301);
            this.tabPesquisa.TabIndex = 1;
            this.tabPesquisa.Text = "Pesquisa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descricao";
            // 
            // txtPesquisaDescricao
            // 
            this.txtPesquisaDescricao.Location = new System.Drawing.Point(94, 17);
            this.txtPesquisaDescricao.Name = "txtPesquisaDescricao";
            this.txtPesquisaDescricao.Size = new System.Drawing.Size(172, 23);
            this.txtPesquisaDescricao.TabIndex = 5;
            // 
            // btnPesquisaCusto
            // 
            this.btnPesquisaCusto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisaCusto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCusto.BackgroundImage")));
            this.btnPesquisaCusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisaCusto.FlatAppearance.BorderSize = 0;
            this.btnPesquisaCusto.Location = new System.Drawing.Point(273, 8);
            this.btnPesquisaCusto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaCusto.Name = "btnPesquisaCusto";
            this.btnPesquisaCusto.Size = new System.Drawing.Size(40, 34);
            this.btnPesquisaCusto.TabIndex = 4;
            this.btnPesquisaCusto.UseVisualStyleBackColor = false;
            this.btnPesquisaCusto.Click += new System.EventHandler(this.btnPesquisaCusto_Click);
            // 
            // gridContas
            // 
            this.gridContas.AutoGenerateColumns = false;
            this.gridContas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pagarReceberDataGridViewTextBoxColumn,
            this.Quitado,
            this.dataGridViewTextBoxColumn1,
            this.valorDataGridViewTextBoxColumn,
            this.jurosDataGridViewTextBoxColumn,
            this.dataEmissaoDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.dataPagamentoDataGridViewTextBoxColumn,
            this.pessoaIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.gridContas.DataSource = this.bsContas;
            this.gridContas.Location = new System.Drawing.Point(7, 59);
            this.gridContas.Name = "gridContas";
            this.gridContas.ReadOnly = true;
            this.gridContas.Size = new System.Drawing.Size(620, 235);
            this.gridContas.TabIndex = 0;
            this.gridContas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContas_CellDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(267, 13);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 48);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(183, 13);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 48);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(99, 13);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 48);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(15, 13);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 48);
            this.btnNovo.TabIndex = 27;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Location = new System.Drawing.Point(-1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 81);
            this.panel1.TabIndex = 31;
            // 
            // bsContas
            // 
            this.bsContas.DataSource = typeof(App.Dominio.Contas);
            // 
            // bsPessoa
            // 
            this.bsPessoa.DataSource = typeof(App.Dominio.Pessoas);
            // 
            // pagarReceberDataGridViewTextBoxColumn
            // 
            this.pagarReceberDataGridViewTextBoxColumn.DataPropertyName = "PagarReceber";
            this.pagarReceberDataGridViewTextBoxColumn.HeaderText = "Pagar/Receber";
            this.pagarReceberDataGridViewTextBoxColumn.Name = "pagarReceberDataGridViewTextBoxColumn";
            this.pagarReceberDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagarReceberDataGridViewTextBoxColumn.Width = 110;
            // 
            // Quitado
            // 
            this.Quitado.DataPropertyName = "Quitado";
            this.Quitado.HeaderText = "Pago";
            this.Quitado.Name = "Quitado";
            this.Quitado.ReadOnly = true;
            this.Quitado.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            this.jurosDataGridViewTextBoxColumn.DataPropertyName = "Juros";
            this.jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            this.jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            this.jurosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEmissaoDataGridViewTextBoxColumn
            // 
            this.dataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.HeaderText = "Data de Emissao";
            this.dataEmissaoDataGridViewTextBoxColumn.Name = "dataEmissaoDataGridViewTextBoxColumn";
            this.dataEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data de Vencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPagamentoDataGridViewTextBoxColumn
            // 
            this.dataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DataPagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.HeaderText = "Data do Pagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.Name = "dataPagamentoDataGridViewTextBoxColumn";
            this.dataPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pessoaIdDataGridViewTextBoxColumn
            // 
            this.pessoaIdDataGridViewTextBoxColumn.DataPropertyName = "PessoaId";
            this.pessoaIdDataGridViewTextBoxColumn.HeaderText = "Id da Pessoa";
            this.pessoaIdDataGridViewTextBoxColumn.Name = "pessoaIdDataGridViewTextBoxColumn";
            this.pessoaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CadContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(653, 423);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.pcContas);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Contas";
            this.pcContas.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaDescricao;
        private System.Windows.Forms.Button btnPesquisaCusto;
        private System.Windows.Forms.DataGridView gridContas;
        private System.Windows.Forms.BindingSource bsContas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnPesquisaPessoa;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDataPgto;
        private System.Windows.Forms.DateTimePicker txtDataVencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDataEmissao;
        private System.Windows.Forms.TextBox txtPessoaId;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbPagarReceber;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.BindingSource bsPessoa;
        public System.Windows.Forms.TabControl pcContas;
        public System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagarReceberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}