namespace App.wfa
{
    partial class VisualizaRelContas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvContas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsContas = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsContas)).BeginInit();
            this.SuspendLayout();
            // 
            // rvContas
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bsContas;
            this.rvContas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvContas.LocalReport.ReportEmbeddedResource = "App.wfa.RelContas1.rdlc";
            this.rvContas.Location = new System.Drawing.Point(0, 0);
            this.rvContas.Name = "rvContas";
            this.rvContas.Size = new System.Drawing.Size(644, 573);
            this.rvContas.TabIndex = 0;
            // 
            // bsContas
            // 
            this.bsContas.DataSource = typeof(App.DTO.ContasPessoas);
            // 
            // VisualizaRelContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 585);
            this.Controls.Add(this.rvContas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisualizaRelContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatório de Custos";
            this.Load += new System.EventHandler(this.VisualizaRelCustos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvContas;
        private System.Windows.Forms.BindingSource bsContas;
    }
}