namespace App.wfa
{
    partial class fMovimentoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMovimentoCaixa));
            this.gridMovimentoCaixa = new System.Windows.Forms.DataGridView();
            this.bsMovimentoCaixa = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnPesquisaCusto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMovImentoCaixa = new System.Windows.Forms.TextBox();
            this.txtValorMovimento = new System.Windows.Forms.TextBox();
            this.txtDataMovimento = new System.Windows.Forms.DateTimePicker();
            this.txtContaId = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.bsConta = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotalCaixa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagarReceber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentoCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentoCaixa)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsConta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMovimentoCaixa
            // 
            this.gridMovimentoCaixa.AutoGenerateColumns = false;
            this.gridMovimentoCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovimentoCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Valor,
            this.Data,
            this.ContaId,
            this.Nome,
            this.PagarReceber});
            this.gridMovimentoCaixa.DataSource = this.bsMovimentoCaixa;
            this.gridMovimentoCaixa.Location = new System.Drawing.Point(16, 227);
            this.gridMovimentoCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.gridMovimentoCaixa.Name = "gridMovimentoCaixa";
            this.gridMovimentoCaixa.ReadOnly = true;
            this.gridMovimentoCaixa.Size = new System.Drawing.Size(665, 216);
            this.gridMovimentoCaixa.TabIndex = 1;
            this.gridMovimentoCaixa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMovimentoCaixa_CellDoubleClick);
            // 
            // bsMovimentoCaixa
            // 
            this.bsMovimentoCaixa.DataSource = typeof(App.DTO.MovimentoCaixaContasPessoas);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(19, 24);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 48);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovoCusto_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(103, 24);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 48);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(187, 24);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 48);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(271, 24);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 48);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblConta);
            this.gbInfo.Controls.Add(this.btnPesquisaCusto);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.txtIdMovImentoCaixa);
            this.gbInfo.Controls.Add(this.txtValorMovimento);
            this.gbInfo.Controls.Add(this.txtDataMovimento);
            this.gbInfo.Controls.Add(this.txtContaId);
            this.gbInfo.Location = new System.Drawing.Point(19, 79);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(662, 142);
            this.gbInfo.TabIndex = 14;
            this.gbInfo.TabStop = false;
            // 
            // btnPesquisaCusto
            // 
            this.btnPesquisaCusto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisaCusto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCusto.BackgroundImage")));
            this.btnPesquisaCusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisaCusto.FlatAppearance.BorderSize = 0;
            this.btnPesquisaCusto.Location = new System.Drawing.Point(119, 82);
            this.btnPesquisaCusto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaCusto.Name = "btnPesquisaCusto";
            this.btnPesquisaCusto.Size = new System.Drawing.Size(32, 29);
            this.btnPesquisaCusto.TabIndex = 18;
            this.btnPesquisaCusto.UseVisualStyleBackColor = false;
            this.btnPesquisaCusto.Click += new System.EventHandler(this.btnPesquisaCusto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(23, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data Movimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id";
            // 
            // txtIdMovImentoCaixa
            // 
            this.txtIdMovImentoCaixa.Enabled = false;
            this.txtIdMovImentoCaixa.Location = new System.Drawing.Point(50, 16);
            this.txtIdMovImentoCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMovImentoCaixa.Name = "txtIdMovImentoCaixa";
            this.txtIdMovImentoCaixa.Size = new System.Drawing.Size(35, 23);
            this.txtIdMovImentoCaixa.TabIndex = 13;
            this.txtIdMovImentoCaixa.TabStop = false;
            // 
            // txtValorMovimento
            // 
            this.txtValorMovimento.Location = new System.Drawing.Point(72, 116);
            this.txtValorMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorMovimento.Name = "txtValorMovimento";
            this.txtValorMovimento.Size = new System.Drawing.Size(61, 23);
            this.txtValorMovimento.TabIndex = 1;
            this.txtValorMovimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMovimento_KeyPress);
            this.txtValorMovimento.Leave += new System.EventHandler(this.txtValorMovimento_Leave);
            // 
            // txtDataMovimento
            // 
            this.txtDataMovimento.CustomFormat = "\"dd/mm/yyyy\"";
            this.txtDataMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataMovimento.Location = new System.Drawing.Point(141, 55);
            this.txtDataMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataMovimento.Name = "txtDataMovimento";
            this.txtDataMovimento.Size = new System.Drawing.Size(90, 23);
            this.txtDataMovimento.TabIndex = 0;
            // 
            // txtContaId
            // 
            this.txtContaId.Location = new System.Drawing.Point(72, 85);
            this.txtContaId.Margin = new System.Windows.Forms.Padding(4);
            this.txtContaId.Name = "txtContaId";
            this.txtContaId.Size = new System.Drawing.Size(39, 23);
            this.txtContaId.TabIndex = 2;
            this.txtContaId.Leave += new System.EventHandler(this.txtContaId_Leave);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(158, 88);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(13, 17);
            this.lblConta.TabIndex = 19;
            this.lblConta.Text = "-";
            // 
            // bsConta
            // 
            this.bsConta.DataSource = typeof(App.Dominio.Contas);
            // 
            // txtTotalCaixa
            // 
            this.txtTotalCaixa.Enabled = false;
            this.txtTotalCaixa.Location = new System.Drawing.Point(581, 450);
            this.txtTotalCaixa.Name = "txtTotalCaixa";
            this.txtTotalCaixa.Size = new System.Drawing.Size(100, 23);
            this.txtTotalCaixa.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total em Caixa";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data do Movimento";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // ContaId
            // 
            this.ContaId.DataPropertyName = "ContaId";
            this.ContaId.HeaderText = "Id da Conta";
            this.ContaId.Name = "ContaId";
            this.ContaId.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome da Pessoa";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // PagarReceber
            // 
            this.PagarReceber.DataPropertyName = "PagarReceber";
            this.PagarReceber.HeaderText = "Pagar/Receber";
            this.PagarReceber.Name = "PagarReceber";
            this.PagarReceber.ReadOnly = true;
            this.PagarReceber.Width = 110;
            // 
            // fMovimentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 478);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalCaixa);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gridMovimentoCaixa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMovimentoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movimento de Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentoCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentoCaixa)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsConta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMovimentoCaixa;
        private System.Windows.Forms.BindingSource bsMovimentoCaixa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMovImentoCaixa;
        private System.Windows.Forms.TextBox txtValorMovimento;
        private System.Windows.Forms.DateTimePicker txtDataMovimento;
        private System.Windows.Forms.TextBox txtContaId;
        private System.Windows.Forms.Button btnPesquisaCusto;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.BindingSource bsConta;
        private System.Windows.Forms.TextBox txtTotalCaixa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagarReceber;

    }
}