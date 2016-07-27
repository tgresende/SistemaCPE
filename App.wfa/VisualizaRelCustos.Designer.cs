namespace App.wfa
{
    partial class VisualizaRelCustos
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
            this.dsGastosProjetos = new System.Windows.Forms.BindingSource(this.components);
            this.rvCustos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsGastosProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // rvCustos
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsGastosProjetos;
            this.rvCustos.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCustos.LocalReport.ReportEmbeddedResource = "App.wfa.RelCustos.rdlc";
            this.rvCustos.Location = new System.Drawing.Point(16, 15);
            this.rvCustos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rvCustos.Name = "rvCustos";
            this.rvCustos.Size = new System.Drawing.Size(636, 567);
            this.rvCustos.TabIndex = 0;
            // 
            // VisualizaRelCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 585);
            this.Controls.Add(this.rvCustos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VisualizaRelCustos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatório de Custos";
            this.Load += new System.EventHandler(this.VisualizaRelCustos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGastosProjetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCustos;
        private System.Windows.Forms.BindingSource dsGastosProjetos;
    }
}