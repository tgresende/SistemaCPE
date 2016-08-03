namespace App.wfa
{
    partial class CadTipoConta
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
            this.gbTipoConta = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.cmbPagarReceber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bsTipoConta = new System.Windows.Forms.BindingSource(this.components);
            this.gridTipoConta = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPagarReceber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gbTipoConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPagarReceber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTipoConta
            // 
            this.gbTipoConta.Controls.Add(this.cmbPagarReceber);
            this.gbTipoConta.Controls.Add(this.txtDescricao);
            this.gbTipoConta.Controls.Add(this.labelControl3);
            this.gbTipoConta.Controls.Add(this.labelControl2);
            this.gbTipoConta.Controls.Add(this.labelControl1);
            this.gbTipoConta.Controls.Add(this.txtId);
            this.gbTipoConta.Location = new System.Drawing.Point(17, 83);
            this.gbTipoConta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbTipoConta.Name = "gbTipoConta";
            this.gbTipoConta.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbTipoConta.Size = new System.Drawing.Size(753, 158);
            this.gbTipoConta.TabIndex = 48;
            this.gbTipoConta.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(131, 59);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDescricao.Properties.Appearance.Options.UseFont = true;
            this.txtDescricao.Size = new System.Drawing.Size(207, 22);
            this.txtDescricao.TabIndex = 48;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(11, 94);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 16);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Pagar/Receber:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(40, 62);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 16);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "Descrição:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(84, 23);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(16, 16);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(131, 20);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(73, 22);
            this.txtId.TabIndex = 44;
            // 
            // cmbPagarReceber
            // 
            this.cmbPagarReceber.Location = new System.Drawing.Point(131, 93);
            this.cmbPagarReceber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPagarReceber.Name = "cmbPagarReceber";
            this.cmbPagarReceber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPagarReceber.Properties.Items.AddRange(new object[] {
            "Pagar",
            "Receber"});
            this.cmbPagarReceber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPagarReceber.Size = new System.Drawing.Size(133, 20);
            this.cmbPagarReceber.TabIndex = 49;
            // 
            // bsTipoConta
            // 
            this.bsTipoConta.DataSource = typeof(App.Dominio.TipoConta);
            // 
            // gridTipoConta
            // 
            this.gridTipoConta.DataSource = this.bsTipoConta;
            this.gridTipoConta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridTipoConta.Location = new System.Drawing.Point(17, 250);
            this.gridTipoConta.MainView = this.gridView1;
            this.gridTipoConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridTipoConta.Name = "gridTipoConta";
            this.gridTipoConta.Size = new System.Drawing.Size(753, 294);
            this.gridTipoConta.TabIndex = 49;
            this.gridTipoConta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridTipoConta.DoubleClick += new System.EventHandler(this.gridTipoConta_DoubleClick);
            this.gridTipoConta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridTipoConta_MouseDoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPagarReceber,
            this.colDescricao,
            this.colId});
            this.gridView1.GridControl = this.gridTipoConta;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colPagarReceber
            // 
            this.colPagarReceber.FieldName = "PagarReceber";
            this.colPagarReceber.Name = "colPagarReceber";
            this.colPagarReceber.Visible = true;
            this.colPagarReceber.VisibleIndex = 0;
            // 
            // colDescricao
            // 
            this.colDescricao.FieldName = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(353, 14);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 59);
            this.btnExcluir.TabIndex = 53;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(241, 14);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 59);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(129, 14);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 59);
            this.btnSalvar.TabIndex = 51;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(17, 14);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(101, 59);
            this.btnNovo.TabIndex = 50;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // CadTipoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 569);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gridTipoConta);
            this.Controls.Add(this.gbTipoConta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadTipoConta";
            this.Text = "cadTipoConta";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadTipoConta_KeyPress);
            this.gbTipoConta.ResumeLayout(false);
            this.gbTipoConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPagarReceber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTipoConta;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPagarReceber;
        private System.Windows.Forms.BindingSource bsTipoConta;
        private DevExpress.XtraGrid.GridControl gridTipoConta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPagarReceber;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
    }
}