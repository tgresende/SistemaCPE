namespace App.wfa
{
    partial class CadInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadInsumo));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pcInsumos = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.btnPesquisaCusto = new System.Windows.Forms.Button();
            this.gridInsumos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bsInsumo = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcInsumos.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(260, 22);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 48);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(176, 22);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 48);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(92, 22);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 48);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(8, 22);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 48);
            this.btnNovo.TabIndex = 34;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pcInsumos
            // 
            this.pcInsumos.Controls.Add(this.tabInfo);
            this.pcInsumos.Controls.Add(this.tabPesquisa);
            this.pcInsumos.Location = new System.Drawing.Point(0, 85);
            this.pcInsumos.Margin = new System.Windows.Forms.Padding(4);
            this.pcInsumos.Name = "pcInsumos";
            this.pcInsumos.SelectedIndex = 0;
            this.pcInsumos.Size = new System.Drawing.Size(641, 318);
            this.pcInsumos.TabIndex = 33;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.gbInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tabInfo.Size = new System.Drawing.Size(633, 289);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Informações";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.cmbUnidade);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtValor);
            this.gbInfo.Controls.Add(this.txtDescricao);
            this.gbInfo.Controls.Add(this.txtNome);
            this.gbInfo.Controls.Add(this.label58);
            this.gbInfo.Controls.Add(this.label57);
            this.gbInfo.Controls.Add(this.label56);
            this.gbInfo.Controls.Add(this.label55);
            this.gbInfo.Controls.Add(this.txtId);
            this.gbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInfo.Location = new System.Drawing.Point(-4, 0);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(632, 303);
            this.gbInfo.TabIndex = 5;
            this.gbInfo.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(130, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(9, 129);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(41, 17);
            this.label58.TabIndex = 26;
            this.label58.Text = "Valor";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(9, 19);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(19, 17);
            this.label57.TabIndex = 25;
            this.label57.Text = "Id";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(9, 92);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(71, 17);
            this.label56.TabIndex = 24;
            this.label56.Text = "Descrição";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(9, 54);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(45, 17);
            this.label55.TabIndex = 23;
            this.label55.Text = "Nome";
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
            this.tabPesquisa.Controls.Add(this.gridInsumos);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 25);
            this.tabPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(4);
            this.tabPesquisa.Size = new System.Drawing.Size(633, 289);
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
            // gridInsumos
            // 
            this.gridInsumos.AutoGenerateColumns = false;
            this.gridInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.gridInsumos.DataSource = this.bsInsumo;
            this.gridInsumos.Location = new System.Drawing.Point(2, 47);
            this.gridInsumos.Name = "gridInsumos";
            this.gridInsumos.ReadOnly = true;
            this.gridInsumos.Size = new System.Drawing.Size(630, 240);
            this.gridInsumos.TabIndex = 0;
            this.gridInsumos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridInsumos_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Location = new System.Drawing.Point(-15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 81);
            this.panel1.TabIndex = 38;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(88, 89);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(130, 23);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(88, 123);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(130, 23);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Unidade";
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "Quilograma",
            "Litro",
            "Unidade",
            "Metro linear",
            "Metro quadrado",
            "Metro cúbico",
            "Par"});
            this.cmbUnidade.Location = new System.Drawing.Point(88, 161);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(130, 24);
            this.cmbUnidade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "/ Unidade";
            // 
            // bsInsumo
            // 
            this.bsInsumo.DataSource = typeof(App.Dominio.Insumos);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CadInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(641, 419);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.pcInsumos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Insumos";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadInsumo_KeyPress);
            this.pcInsumos.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInsumo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.TabControl pcInsumos;
        public System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Button btnPesquisaCusto;
        private System.Windows.Forms.DataGridView gridInsumos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.BindingSource bsInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

    }
}