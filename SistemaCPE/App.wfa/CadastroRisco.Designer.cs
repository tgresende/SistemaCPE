namespace App.wfa
{
    partial class CadastroRisco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroRisco));
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaPreventivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoContigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRiscos = new System.Windows.Forms.BindingSource(this.components);
            this.panelInfo = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPrevencao = new System.Windows.Forms.TextBox();
            this.txtContingencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRiscos)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridView1);
            this.panelGrid.Location = new System.Drawing.Point(16, 58);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(455, 380);
            this.panelGrid.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.medidaPreventivaDataGridViewTextBoxColumn,
            this.planoContigenciaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsRiscos;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(447, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medidaPreventivaDataGridViewTextBoxColumn
            // 
            this.medidaPreventivaDataGridViewTextBoxColumn.DataPropertyName = "MedidaPreventiva";
            this.medidaPreventivaDataGridViewTextBoxColumn.HeaderText = "Medida Preventiva";
            this.medidaPreventivaDataGridViewTextBoxColumn.Name = "medidaPreventivaDataGridViewTextBoxColumn";
            this.medidaPreventivaDataGridViewTextBoxColumn.ReadOnly = true;
            this.medidaPreventivaDataGridViewTextBoxColumn.Width = 120;
            // 
            // planoContigenciaDataGridViewTextBoxColumn
            // 
            this.planoContigenciaDataGridViewTextBoxColumn.DataPropertyName = "PlanoContigencia";
            this.planoContigenciaDataGridViewTextBoxColumn.HeaderText = "Plano Contigência";
            this.planoContigenciaDataGridViewTextBoxColumn.Name = "planoContigenciaDataGridViewTextBoxColumn";
            this.planoContigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.planoContigenciaDataGridViewTextBoxColumn.Width = 120;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsRiscos
            // 
            this.bsRiscos.DataSource = typeof(App.Dominio.Riscos);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.txtDescricao);
            this.panelInfo.Controls.Add(this.txtId);
            this.panelInfo.Controls.Add(this.txtNome);
            this.panelInfo.Controls.Add(this.txtPrevencao);
            this.panelInfo.Controls.Add(this.txtContingencia);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Location = new System.Drawing.Point(479, 58);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(395, 380);
            this.panelInfo.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(8, 73);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(371, 37);
            this.txtDescricao.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(33, 12);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(31, 23);
            this.txtId.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(145, 12);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(233, 23);
            this.txtNome.TabIndex = 7;
            // 
            // txtPrevencao
            // 
            this.txtPrevencao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "MedidaPreventiva", true));
            this.txtPrevencao.Location = new System.Drawing.Point(8, 134);
            this.txtPrevencao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrevencao.Multiline = true;
            this.txtPrevencao.Name = "txtPrevencao";
            this.txtPrevencao.Size = new System.Drawing.Size(371, 107);
            this.txtPrevencao.TabIndex = 6;
            // 
            // txtContingencia
            // 
            this.txtContingencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "PlanoContigencia", true));
            this.txtContingencia.Location = new System.Drawing.Point(8, 266);
            this.txtContingencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContingencia.Multiline = true;
            this.txtContingencia.Name = "txtContingencia";
            this.txtContingencia.Size = new System.Drawing.Size(371, 107);
            this.txtContingencia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plano de Contingência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medida de Prevenção";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExclui.FlatAppearance.BorderSize = 0;
            this.btnExclui.Location = new System.Drawing.Point(523, 6);
            this.btnExclui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(76, 48);
            this.btnExclui.TabIndex = 38;
            this.btnExclui.Text = "Excluir";
            this.btnExclui.UseVisualStyleBackColor = false;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(287, 6);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 48);
            this.btnNovo.TabIndex = 37;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancela.FlatAppearance.BorderSize = 0;
            this.btnCancela.Location = new System.Drawing.Point(444, 6);
            this.btnCancela.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(76, 48);
            this.btnCancela.TabIndex = 36;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalva.FlatAppearance.BorderSize = 0;
            this.btnSalva.Location = new System.Drawing.Point(365, 6);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(76, 48);
            this.btnSalva.TabIndex = 35;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirma.FlatAppearance.BorderSize = 0;
            this.btnConfirma.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirma.Image")));
            this.btnConfirma.Location = new System.Drawing.Point(820, 7);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(53, 47);
            this.btnConfirma.TabIndex = 39;
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.button3_Click);
            // 
            // CadastroRisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 447);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadastroRisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Riscos";
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRiscos)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPrevencao;
        private System.Windows.Forms.TextBox txtContingencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaPreventivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoContigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsRiscos;
        private System.Windows.Forms.Button btnConfirma;
    }
}