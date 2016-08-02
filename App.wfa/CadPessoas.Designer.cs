namespace App.wfa
{
    partial class CadPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadPessoas));
            this.pcPessoas = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.btnPesquisaCusto = new System.Windows.Forms.Button();
            this.gridPessoas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPessoas = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.pcPessoas.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // pcPessoas
            // 
            this.pcPessoas.Controls.Add(this.tabInfo);
            this.pcPessoas.Controls.Add(this.tabPesquisa);
            this.pcPessoas.Location = new System.Drawing.Point(0, 76);
            this.pcPessoas.Margin = new System.Windows.Forms.Padding(4);
            this.pcPessoas.Name = "pcPessoas";
            this.pcPessoas.SelectedIndex = 0;
            this.pcPessoas.Size = new System.Drawing.Size(649, 496);
            this.pcPessoas.TabIndex = 18;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.gbInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tabInfo.Size = new System.Drawing.Size(641, 467);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Informações";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.gbInfo.Controls.Add(this.txtCidade);
            this.gbInfo.Controls.Add(this.label64);
            this.gbInfo.Controls.Add(this.txtBairro);
            this.gbInfo.Controls.Add(this.txtCep);
            this.gbInfo.Controls.Add(this.label63);
            this.gbInfo.Controls.Add(this.label62);
            this.gbInfo.Controls.Add(this.txtComplemento);
            this.gbInfo.Controls.Add(this.txtNumero);
            this.gbInfo.Controls.Add(this.txtRua);
            this.gbInfo.Controls.Add(this.label61);
            this.gbInfo.Controls.Add(this.label60);
            this.gbInfo.Controls.Add(this.label59);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtTelefone);
            this.gbInfo.Controls.Add(this.txtCPFCNPJ);
            this.gbInfo.Controls.Add(this.txtNome);
            this.gbInfo.Controls.Add(this.label58);
            this.gbInfo.Controls.Add(this.label56);
            this.gbInfo.Controls.Add(this.label55);
            this.gbInfo.Controls.Add(this.txtId);
            this.gbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInfo.Location = new System.Drawing.Point(0, 0);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(632, 460);
            this.gbInfo.TabIndex = 5;
            this.gbInfo.TabStop = false;
            this.gbInfo.Enter += new System.EventHandler(this.gbInfo_Enter);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(309, 76);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(130, 23);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(88, 76);
            this.txtCPFCNPJ.Mask = "000.000.000-00";
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Size = new System.Drawing.Size(130, 23);
            this.txtCPFCNPJ.TabIndex = 1;
            this.txtCPFCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPFCNPJ.Enter += new System.EventHandler(this.txtCPFCNPJ_Enter);
            this.txtCPFCNPJ.Leave += new System.EventHandler(this.txtCpfCnp_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(538, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(230, 79);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(80, 17);
            this.label58.TabIndex = 26;
            this.label58.Text = "Telefone 1:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(51, 79);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(38, 17);
            this.label56.TabIndex = 24;
            this.label56.Text = "CPF:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(40, 47);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(49, 17);
            this.label55.TabIndex = 23;
            this.label55.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(88, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(43, 23);
            this.txtId.TabIndex = 22;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPesquisa.Controls.Add(this.label1);
            this.tabPesquisa.Controls.Add(this.txtPesquisaNome);
            this.tabPesquisa.Controls.Add(this.btnPesquisaCusto);
            this.tabPesquisa.Controls.Add(this.gridPessoas);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 25);
            this.tabPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(4);
            this.tabPesquisa.Size = new System.Drawing.Size(634, 429);
            this.tabPesquisa.TabIndex = 1;
            this.tabPesquisa.Text = "Pesquisa";
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
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(68, 17);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(172, 23);
            this.txtPesquisaNome.TabIndex = 5;
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
            this.btnPesquisaCusto.Click += new System.EventHandler(this.btnPesquisaCusto_Click);
            // 
            // gridPessoas
            // 
            this.gridPessoas.AutoGenerateColumns = false;
            this.gridPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFCNPJDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn});
            this.gridPessoas.DataSource = this.bsPessoas;
            this.gridPessoas.Location = new System.Drawing.Point(2, 47);
            this.gridPessoas.Name = "gridPessoas";
            this.gridPessoas.ReadOnly = true;
            this.gridPessoas.Size = new System.Drawing.Size(630, 251);
            this.gridPessoas.TabIndex = 0;
            this.gridPessoas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPessoas_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id da Pessoa";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFCNPJDataGridViewTextBoxColumn
            // 
            this.cPFCNPJDataGridViewTextBoxColumn.DataPropertyName = "CPFCNPJ";
            this.cPFCNPJDataGridViewTextBoxColumn.HeaderText = "CPF/CNPJ";
            this.cPFCNPJDataGridViewTextBoxColumn.Name = "cPFCNPJDataGridViewTextBoxColumn";
            this.cPFCNPJDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "Rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "Cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPessoas
            // 
            this.bsPessoas.DataSource = typeof(App.Dominio.Pessoas);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(259, 13);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 48);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(175, 13);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 48);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(91, 13);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 48);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(7, 13);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 48);
            this.btnNovo.TabIndex = 19;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Location = new System.Drawing.Point(-7, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 81);
            this.panel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Código:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(137, 395);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 23);
            this.txtCidade.TabIndex = 63;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(38, 398);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(52, 17);
            this.label64.TabIndex = 69;
            this.label64.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(137, 364);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 23);
            this.txtBairro.TabIndex = 62;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(137, 332);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 23);
            this.txtCep.TabIndex = 61;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(38, 367);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(46, 17);
            this.label63.TabIndex = 68;
            this.label63.Text = "Bairro";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(37, 334);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(33, 17);
            this.label62.TabIndex = 67;
            this.label62.Text = "Cep";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(137, 300);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 23);
            this.txtComplemento.TabIndex = 60;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(137, 268);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 59;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(137, 236);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(173, 23);
            this.txtRua.TabIndex = 58;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(37, 302);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(94, 17);
            this.label61.TabIndex = 66;
            this.label61.Text = "Complemento";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(37, 271);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(58, 17);
            this.label60.TabIndex = 65;
            this.label60.Text = "Número";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(37, 239);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(34, 17);
            this.label59.TabIndex = 64;
            this.label59.Text = "Rua";
            // 
            // CadPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(747, 638);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.pcPessoas);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Pessoas";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadPessoas_KeyPress);
            this.pcPessoas.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPessoas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Button btnPesquisaCusto;
        private System.Windows.Forms.BindingSource bsPessoas;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.TabControl pcPessoas;
        public System.Windows.Forms.TabPage tabInfo;
        public System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.MaskedTextBox txtCPFCNPJ;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
    }
}