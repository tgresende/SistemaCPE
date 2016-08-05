namespace App.MetroApp.UsersControl
{
    partial class ucCadCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCadCliente));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsClients = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClienteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPessoaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPFCNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCidadeEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem4 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup1 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem3 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem5 = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bsClients;
            this.gridControl1.Location = new System.Drawing.Point(3, 83);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(671, 292);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsClients
            // 
            this.bsClients.DataSource = typeof(App.DTO.ClientsInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClienteId,
            this.colPessoaId,
            this.colNome,
            this.colCPFCNPJ,
            this.colTipoDocumento,
            this.colTelefone,
            this.colCidadeEstado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colClienteId
            // 
            this.colClienteId.FieldName = "ClienteId";
            this.colClienteId.Name = "colClienteId";
            this.colClienteId.Visible = true;
            this.colClienteId.VisibleIndex = 0;
            // 
            // colPessoaId
            // 
            this.colPessoaId.FieldName = "PessoaId";
            this.colPessoaId.Name = "colPessoaId";
            this.colPessoaId.Visible = true;
            this.colPessoaId.VisibleIndex = 1;
            // 
            // colNome
            // 
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 2;
            // 
            // colCPFCNPJ
            // 
            this.colCPFCNPJ.FieldName = "CPFCNPJ";
            this.colCPFCNPJ.Name = "colCPFCNPJ";
            this.colCPFCNPJ.Visible = true;
            this.colCPFCNPJ.VisibleIndex = 3;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.FieldName = "TipoDocumento";
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.Visible = true;
            this.colTipoDocumento.VisibleIndex = 4;
            // 
            // colTelefone
            // 
            this.colTelefone.FieldName = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.Visible = true;
            this.colTelefone.VisibleIndex = 5;
            // 
            // colCidadeEstado
            // 
            this.colCidadeEstado.FieldName = "CidadeEstado";
            this.colCidadeEstado.Name = "colCidadeEstado";
            this.colCidadeEstado.Visible = true;
            this.colCidadeEstado.VisibleIndex = 6;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tileBarItem1);
            this.tileBarGroup2.Items.Add(this.tileBarItem2);
            this.tileBarGroup2.Items.Add(this.tileBarItem4);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.Text = "Novo";
            this.tileBarItem1.Elements.Add(tileItemElement1);
            this.tileBarItem1.Id = 1;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.Text = "Excluir";
            this.tileBarItem2.Elements.Add(tileItemElement2);
            this.tileBarItem2.Id = 2;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // tileBarItem4
            // 
            this.tileBarItem4.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.Text = "Abrir/Fechar Caixa";
            this.tileBarItem4.Elements.Add(tileItemElement3);
            this.tileBarItem4.Id = 4;
            this.tileBarItem4.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem4.Name = "tileBarItem4";
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tileBar1.AppearanceText.Options.UseFont = true;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup1);
            this.tileBar1.Location = new System.Drawing.Point(685, 83);
            this.tileBar1.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.tileBar1.MaxId = 6;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(182, 271);
            this.tileBar1.TabIndex = 52;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup1
            // 
            this.tileBarGroup1.Items.Add(this.tileBarItem3);
            this.tileBarGroup1.Items.Add(this.tileBarItem5);
            this.tileBarGroup1.Name = "tileBarGroup1";
            // 
            // tileBarItem3
            // 
            this.tileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.Text = "Novo";
            this.tileBarItem3.Elements.Add(tileItemElement4);
            this.tileBarItem3.Id = 1;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem3.Name = "tileBarItem3";
            // 
            // tileBarItem5
            // 
            this.tileBarItem5.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.Text = "Excluir";
            this.tileBarItem5.Elements.Add(tileItemElement5);
            this.tileBarItem5.Id = 2;
            this.tileBarItem5.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem5.Name = "tileBarItem5";
            // 
            // ucCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ucCadCliente";
            this.Size = new System.Drawing.Size(875, 411);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsClients;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteId;
        private DevExpress.XtraGrid.Columns.GridColumn colPessoaId;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colCPFCNPJ;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefone;
        private DevExpress.XtraGrid.Columns.GridColumn colCidadeEstado;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem4;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem3;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem5;
    }
}
