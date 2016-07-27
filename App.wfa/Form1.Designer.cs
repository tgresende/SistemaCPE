namespace App.wfa
{
    partial class Form1
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
            this.btnMovimentoCaixa = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnCadContas = new System.Windows.Forms.Button();
            this.btnCadPessoas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMovimentoCaixa
            // 
            this.btnMovimentoCaixa.BackColor = System.Drawing.SystemColors.Control;
            this.btnMovimentoCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMovimentoCaixa.FlatAppearance.BorderSize = 0;
            this.btnMovimentoCaixa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMovimentoCaixa.Location = new System.Drawing.Point(13, 51);
            this.btnMovimentoCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovimentoCaixa.Name = "btnMovimentoCaixa";
            this.btnMovimentoCaixa.Size = new System.Drawing.Size(112, 70);
            this.btnMovimentoCaixa.TabIndex = 25;
            this.btnMovimentoCaixa.Text = "Movimento de Caixa";
            this.btnMovimentoCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMovimentoCaixa.UseVisualStyleBackColor = false;
            this.btnMovimentoCaixa.Click += new System.EventHandler(this.btnMovimentoCaixa_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.SystemColors.Control;
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRelatorio.Location = new System.Drawing.Point(366, 51);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(114, 70);
            this.btnRelatorio.TabIndex = 26;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnCadContas
            // 
            this.btnCadContas.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadContas.FlatAppearance.BorderSize = 0;
            this.btnCadContas.Location = new System.Drawing.Point(133, 51);
            this.btnCadContas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadContas.Name = "btnCadContas";
            this.btnCadContas.Size = new System.Drawing.Size(115, 70);
            this.btnCadContas.TabIndex = 27;
            this.btnCadContas.Text = "Cadastro de Contas Receber/Pagar";
            this.btnCadContas.UseVisualStyleBackColor = false;
            this.btnCadContas.Click += new System.EventHandler(this.btnCadContas_Click);
            // 
            // btnCadPessoas
            // 
            this.btnCadPessoas.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadPessoas.FlatAppearance.BorderSize = 0;
            this.btnCadPessoas.Location = new System.Drawing.Point(249, 51);
            this.btnCadPessoas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadPessoas.Name = "btnCadPessoas";
            this.btnCadPessoas.Size = new System.Drawing.Size(115, 70);
            this.btnCadPessoas.TabIndex = 28;
            this.btnCadPessoas.Text = "Cadastro de Pessoas";
            this.btnCadPessoas.UseVisualStyleBackColor = false;
            this.btnCadPessoas.Click += new System.EventHandler(this.btnCadPessoas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Location = new System.Drawing.Point(-72, -56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1611, 100);
            this.panel1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1193, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadPessoas);
            this.Controls.Add(this.btnCadContas);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnMovimentoCaixa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fábrica S.A";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMovimentoCaixa;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnCadContas;
        private System.Windows.Forms.Button btnCadPessoas;
        private System.Windows.Forms.Panel panel1;




    }
}

