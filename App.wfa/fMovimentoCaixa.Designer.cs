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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMovImentoCaixa = new System.Windows.Forms.TextBox();
            this.txtValorMovimento = new System.Windows.Forms.TextBox();
            this.txtDataMovimento = new System.Windows.Forms.DateTimePicker();
            this.txtContaId = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMovimentoCaixa = new System.Windows.Forms.BindingSource(this.components);
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagarReceber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentoCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Valor,
            this.Data,
            this.ContaId,
            this.Nome,
            this.PagarReceber});
            this.dataGridView2.DataSource = this.bsMovimentoCaixa;
            this.dataGridView2.Location = new System.Drawing.Point(16, 227);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(835, 240);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(19, 24);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 48);
            this.btnNovo.TabIndex = 10;
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
            this.btnSalvar.TabIndex = 11;
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
            this.btnCancelar.TabIndex = 12;
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
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gbInfo
            // 
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
            this.gbInfo.Size = new System.Drawing.Size(571, 142);
            this.gbInfo.TabIndex = 14;
            this.gbInfo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(23, 122);
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
            this.label3.Location = new System.Drawing.Point(23, 91);
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
            this.txtIdMovImentoCaixa.Location = new System.Drawing.Point(50, 16);
            this.txtIdMovImentoCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMovImentoCaixa.Name = "txtIdMovImentoCaixa";
            this.txtIdMovImentoCaixa.Size = new System.Drawing.Size(35, 23);
            this.txtIdMovImentoCaixa.TabIndex = 13;
            // 
            // txtValorMovimento
            // 
            this.txtValorMovimento.Location = new System.Drawing.Point(72, 85);
            this.txtValorMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorMovimento.Name = "txtValorMovimento";
            this.txtValorMovimento.Size = new System.Drawing.Size(61, 23);
            this.txtValorMovimento.TabIndex = 12;
            // 
            // txtDataMovimento
            // 
            this.txtDataMovimento.CustomFormat = "\"dd/mm/yyyy\"";
            this.txtDataMovimento.Location = new System.Drawing.Point(132, 50);
            this.txtDataMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataMovimento.Name = "txtDataMovimento";
            this.txtDataMovimento.Size = new System.Drawing.Size(279, 23);
            this.txtDataMovimento.TabIndex = 11;
            // 
            // txtContaId
            // 
            this.txtContaId.Location = new System.Drawing.Point(72, 116);
            this.txtContaId.Margin = new System.Windows.Forms.Padding(4);
            this.txtContaId.Name = "txtContaId";
            this.txtContaId.Size = new System.Drawing.Size(39, 23);
            this.txtContaId.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bsMovimentoCaixa
            // 
            this.bsMovimentoCaixa.DataSource = typeof(App.DTO.MovimentoCaixaContasPessoas);
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // ContaId
            // 
            this.ContaId.DataPropertyName = "ContaId";
            this.ContaId.HeaderText = "ContaId";
            this.ContaId.Name = "ContaId";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // PagarReceber
            // 
            this.PagarReceber.DataPropertyName = "PagarReceber";
            this.PagarReceber.HeaderText = "PagarReceber";
            this.PagarReceber.Name = "PagarReceber";
            // 
            // fMovimentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 544);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMovimentoCaixa";
            this.Text = "Movimento de Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentoCaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagarReceber;

    }
}