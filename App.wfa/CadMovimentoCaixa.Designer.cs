namespace App.wfa
{
    partial class CadMovimentoCaixa
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMovImentoCaixa = new System.Windows.Forms.TextBox();
            this.txtValorMovimento = new System.Windows.Forms.TextBox();
            this.txtDataMovimento = new System.Windows.Forms.DateTimePicker();
            this.txtTotalCaixa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.gridMovimentoCaixa = new System.Windows.Forms.DataGridView();
            this.cmbDebitoCredito = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.bsMovimentoCaixa = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.ColunaValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCreditoDebito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentoCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDebitoCredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentoCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(7, 12);
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
            this.btnSalvar.Location = new System.Drawing.Point(91, 12);
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
            this.btnCancelar.Location = new System.Drawing.Point(175, 12);
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
            this.btnExcluir.Location = new System.Drawing.Point(259, 12);
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
            this.gbInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.txtValorTotal);
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.cmbDebitoCredito);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.txtDesconto);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.txtAcrescimo);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.txtDescricao);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.txtIdMovImentoCaixa);
            this.gbInfo.Controls.Add(this.txtValorMovimento);
            this.gbInfo.Controls.Add(this.txtDataMovimento);
            this.gbInfo.Location = new System.Drawing.Point(-6, 88);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(878, 149);
            this.gbInfo.TabIndex = 14;
            this.gbInfo.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(343, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(419, 115);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(61, 23);
            this.txtDesconto.TabIndex = 38;
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(181, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Acréscimo";
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.Location = new System.Drawing.Point(262, 115);
            this.txtAcrescimo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(61, 23);
            this.txtAcrescimo.TabIndex = 36;
            this.txtAcrescimo.Leave += new System.EventHandler(this.txtAcrescimo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(26, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(108, 82);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(356, 23);
            this.txtDescricao.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(23, 115);
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
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id";
            // 
            // txtIdMovImentoCaixa
            // 
            this.txtIdMovImentoCaixa.Enabled = false;
            this.txtIdMovImentoCaixa.Location = new System.Drawing.Point(72, 10);
            this.txtIdMovImentoCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMovImentoCaixa.Name = "txtIdMovImentoCaixa";
            this.txtIdMovImentoCaixa.Size = new System.Drawing.Size(35, 23);
            this.txtIdMovImentoCaixa.TabIndex = 13;
            this.txtIdMovImentoCaixa.TabStop = false;
            // 
            // txtValorMovimento
            // 
            this.txtValorMovimento.Location = new System.Drawing.Point(72, 112);
            this.txtValorMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorMovimento.Name = "txtValorMovimento";
            this.txtValorMovimento.Size = new System.Drawing.Size(61, 23);
            this.txtValorMovimento.TabIndex = 3;
            this.txtValorMovimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMovimento_KeyPress);
            this.txtValorMovimento.Leave += new System.EventHandler(this.txtValorMovimento_Leave);
            // 
            // txtDataMovimento
            // 
            this.txtDataMovimento.CustomFormat = "\"dd/mm/yyyy\"";
            this.txtDataMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataMovimento.Location = new System.Drawing.Point(72, 43);
            this.txtDataMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataMovimento.Name = "txtDataMovimento";
            this.txtDataMovimento.Size = new System.Drawing.Size(90, 23);
            this.txtDataMovimento.TabIndex = 0;
            // 
            // txtTotalCaixa
            // 
            this.txtTotalCaixa.Enabled = false;
            this.txtTotalCaixa.Location = new System.Drawing.Point(662, 567);
            this.txtTotalCaixa.Name = "txtTotalCaixa";
            this.txtTotalCaixa.Size = new System.Drawing.Size(100, 23);
            this.txtTotalCaixa.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Location = new System.Drawing.Point(-15, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 81);
            this.panel1.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(550, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Saldo de Caixa:";
            // 
            // gridMovimentoCaixa
            // 
            this.gridMovimentoCaixa.AutoGenerateColumns = false;
            this.gridMovimentoCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovimentoCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaValorTotal,
            this.gridCreditoDebito,
            this.Descricao,
            this.Data,
            this.ColunaValor,
            this.ColunaDesconto,
            this.ColunaAcrescimo,
            this.Id});
            this.gridMovimentoCaixa.DataSource = this.bsMovimentoCaixa;
            this.gridMovimentoCaixa.Location = new System.Drawing.Point(-1, 227);
            this.gridMovimentoCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.gridMovimentoCaixa.Name = "gridMovimentoCaixa";
            this.gridMovimentoCaixa.ReadOnly = true;
            this.gridMovimentoCaixa.Size = new System.Drawing.Size(837, 333);
            this.gridMovimentoCaixa.TabIndex = 1;
            this.gridMovimentoCaixa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMovimentoCaixa_CellDoubleClick);
            this.gridMovimentoCaixa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridMovimentoCaixa_CellFormatting);
            // 
            // cmbDebitoCredito
            // 
            this.cmbDebitoCredito.Location = new System.Drawing.Point(448, 44);
            this.cmbDebitoCredito.Name = "cmbDebitoCredito";
            this.cmbDebitoCredito.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDebitoCredito.Properties.Items.AddRange(new object[] {
            "Crédito",
            "Débito"});
            this.cmbDebitoCredito.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbDebitoCredito.Size = new System.Drawing.Size(100, 20);
            this.cmbDebitoCredito.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(343, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Débito/Crédito";
            // 
            // bsMovimentoCaixa
            // 
            this.bsMovimentoCaixa.DataSource = typeof(App.Dominio.MovimentoCaixa);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(556, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(637, 115);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(61, 23);
            this.txtValorTotal.TabIndex = 42;
            // 
            // ColunaValorTotal
            // 
            this.ColunaValorTotal.HeaderText = "Valor Total";
            this.ColunaValorTotal.Name = "ColunaValorTotal";
            this.ColunaValorTotal.ReadOnly = true;
            // 
            // gridCreditoDebito
            // 
            this.gridCreditoDebito.DataPropertyName = "CreditoDebito";
            this.gridCreditoDebito.HeaderText = "CreditoDebito";
            this.gridCreditoDebito.Name = "gridCreditoDebito";
            this.gridCreditoDebito.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // ColunaValor
            // 
            this.ColunaValor.DataPropertyName = "Valor";
            this.ColunaValor.HeaderText = "Valor";
            this.ColunaValor.Name = "ColunaValor";
            this.ColunaValor.ReadOnly = true;
            // 
            // ColunaDesconto
            // 
            this.ColunaDesconto.DataPropertyName = "Desconto";
            this.ColunaDesconto.HeaderText = "Desconto";
            this.ColunaDesconto.Name = "ColunaDesconto";
            this.ColunaDesconto.ReadOnly = true;
            // 
            // ColunaAcrescimo
            // 
            this.ColunaAcrescimo.DataPropertyName = "Acrescimo";
            this.ColunaAcrescimo.HeaderText = "Acrescimo";
            this.ColunaAcrescimo.Name = "ColunaAcrescimo";
            this.ColunaAcrescimo.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CadMovimentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(849, 595);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridMovimentoCaixa);
            this.Controls.Add(this.txtTotalCaixa);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadMovimentoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movimento de Caixa";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fMovimentoCaixa_KeyPress);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentoCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDebitoCredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentoCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsMovimentoCaixa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMovImentoCaixa;
        private System.Windows.Forms.TextBox txtValorMovimento;
        private System.Windows.Forms.DateTimePicker txtDataMovimento;
        private System.Windows.Forms.TextBox txtTotalCaixa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView gridMovimentoCaixa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDebitoCredito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCreditoDebito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaAcrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}