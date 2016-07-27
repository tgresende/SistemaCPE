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
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.gbInfo = new System.Windows.Forms.GroupBox();
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
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisaCusto = new System.Windows.Forms.Button();
            this.gridContas = new System.Windows.Forms.DataGridView();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagarReceberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContas = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabControl3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Location = new System.Drawing.Point(11, 80);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(642, 330);
            this.tabControl3.TabIndex = 19;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.gbInfo);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(634, 301);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Informações";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // gbInfo
            // 
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
            // cmbPagarReceber
            // 
            this.cmbPagarReceber.FormattingEnabled = true;
            this.cmbPagarReceber.Items.AddRange(new object[] {
            "Pagar",
            "Receber"});
            this.cmbPagarReceber.Location = new System.Drawing.Point(439, 27);
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
            this.btnPesquisaPessoa.Location = new System.Drawing.Point(485, 55);
            this.btnPesquisaPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaPessoa.Name = "btnPesquisaPessoa";
            this.btnPesquisaPessoa.Size = new System.Drawing.Size(32, 29);
            this.btnPesquisaPessoa.TabIndex = 54;
            this.btnPesquisaPessoa.UseVisualStyleBackColor = false;
            this.btnPesquisaPessoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(83, 69);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(180, 23);
            this.txtDescricao.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
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
            this.txtDataPgto.Size = new System.Drawing.Size(100, 23);
            this.txtDataPgto.TabIndex = 5;
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVencimento.Location = new System.Drawing.Point(130, 191);
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(95, 23);
            this.txtDataVencimento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Data Vencimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Data Emissão";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEmissao.Location = new System.Drawing.Point(130, 153);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(93, 23);
            this.txtDataEmissao.TabIndex = 3;
            // 
            // txtPessoaId
            // 
            this.txtPessoaId.Location = new System.Drawing.Point(439, 58);
            this.txtPessoaId.Name = "txtPessoaId";
            this.txtPessoaId.Size = new System.Drawing.Size(39, 23);
            this.txtPessoaId.TabIndex = 7;
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(78, 127);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(100, 23);
            this.txtJuros.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(59, 98);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 1;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(329, 61);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(55, 17);
            this.label61.TabIndex = 42;
            this.label61.Text = "Pessoa";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(329, 31);
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
            this.label57.Location = new System.Drawing.Point(6, 34);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(19, 17);
            this.label57.TabIndex = 39;
            this.label57.Text = "Id";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(6, 130);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(43, 17);
            this.label56.TabIndex = 38;
            this.label56.Text = "Juros";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 101);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(41, 17);
            this.label55.TabIndex = 37;
            this.label55.Text = "Valor";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(59, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 36;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label1);
            this.tabPage8.Controls.Add(this.textBox1);
            this.tabPage8.Controls.Add(this.btnPesquisaCusto);
            this.tabPage8.Controls.Add(this.gridContas);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage8.Size = new System.Drawing.Size(634, 301);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Pesquisa";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 23);
            this.textBox1.TabIndex = 5;
            // 
            // btnPesquisaCusto
            // 
            this.btnPesquisaCusto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisaCusto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCusto.BackgroundImage")));
            this.btnPesquisaCusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisaCusto.FlatAppearance.BorderSize = 0;
            this.btnPesquisaCusto.Location = new System.Drawing.Point(247, 8);
            this.btnPesquisaCusto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaCusto.Name = "btnPesquisaCusto";
            this.btnPesquisaCusto.Size = new System.Drawing.Size(40, 34);
            this.btnPesquisaCusto.TabIndex = 4;
            this.btnPesquisaCusto.UseVisualStyleBackColor = false;
            // 
            // gridContas
            // 
            this.gridContas.AutoGenerateColumns = false;
            this.gridContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valorDataGridViewTextBoxColumn,
            this.jurosDataGridViewTextBoxColumn,
            this.dataEmissaoDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.dataPagamentoDataGridViewTextBoxColumn,
            this.pagarReceberDataGridViewTextBoxColumn,
            this.pessoaIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.Descricao,
            this.Column1});
            this.gridContas.DataSource = this.bsContas;
            this.gridContas.Location = new System.Drawing.Point(7, 59);
            this.gridContas.Name = "gridContas";
            this.gridContas.Size = new System.Drawing.Size(620, 166);
            this.gridContas.TabIndex = 0;
            this.gridContas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            this.jurosDataGridViewTextBoxColumn.DataPropertyName = "Juros";
            this.jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            this.jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            // 
            // dataEmissaoDataGridViewTextBoxColumn
            // 
            this.dataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.HeaderText = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.Name = "dataEmissaoDataGridViewTextBoxColumn";
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            // 
            // dataPagamentoDataGridViewTextBoxColumn
            // 
            this.dataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DataPagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.HeaderText = "DataPagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.Name = "dataPagamentoDataGridViewTextBoxColumn";
            // 
            // pagarReceberDataGridViewTextBoxColumn
            // 
            this.pagarReceberDataGridViewTextBoxColumn.DataPropertyName = "PagarReceber";
            this.pagarReceberDataGridViewTextBoxColumn.HeaderText = "PagarReceber";
            this.pagarReceberDataGridViewTextBoxColumn.Name = "pagarReceberDataGridViewTextBoxColumn";
            // 
            // pessoaIdDataGridViewTextBoxColumn
            // 
            this.pessoaIdDataGridViewTextBoxColumn.DataPropertyName = "PessoaId";
            this.pessoaIdDataGridViewTextBoxColumn.HeaderText = "PessoaId";
            this.pessoaIdDataGridViewTextBoxColumn.Name = "pessoaIdDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Descricao";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // bsContas
            // 
            this.bsContas.DataSource = typeof(App.Dominio.Contas);
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
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(183, 13);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 48);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
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
            // CadContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 423);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tabControl3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadContas";
            this.Text = "Cadastro de Contas";
            this.tabControl3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisaCusto;
        private System.Windows.Forms.DataGridView gridContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagarReceberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
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
    }
}