namespace App.MetroApp.UsersControl
{
    partial class ucMovimentoCaixa
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMovimentoCaixa));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.gridCashMovement = new DevExpress.XtraGrid.GridControl();
            this.bsMovimentoCaixa = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcrescimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditoDebito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem4 = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridCashMovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentoCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCashMovement
            // 
            this.gridCashMovement.DataSource = this.bsMovimentoCaixa;
            this.gridCashMovement.Font = new System.Drawing.Font("Tahoma", 12F);
            gridLevelNode1.RelationName = "Level1";
            this.gridCashMovement.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridCashMovement.Location = new System.Drawing.Point(3, 3);
            this.gridCashMovement.MainView = this.gridView1;
            this.gridCashMovement.Name = "gridCashMovement";
            this.gridCashMovement.Size = new System.Drawing.Size(864, 409);
            this.gridCashMovement.TabIndex = 0;
            this.gridCashMovement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridCashMovement.Load += new System.EventHandler(this.gridControl1_Load);
            this.gridCashMovement.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCashMovement_MouseDoubleClick);
            // 
            // bsMovimentoCaixa
            // 
            this.bsMovimentoCaixa.DataSource = typeof(App.Dominio.MovimentoCaixa);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colValor,
            this.colDesconto,
            this.colAcrescimo,
            this.colDescricao,
            this.colCreditoDebito,
            this.colData,
            this.colId,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridCashMovement;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Movimento do Caixa";
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gridView1_CustomSummaryCalculate);
            // 
            // colValor
            // 
            this.colValor.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colValor.AppearanceCell.Options.UseFont = true;
            this.colValor.Caption = "Valor Base";
            this.colValor.DisplayFormat.FormatString = "c2";
            this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 0;
            this.colValor.Width = 88;
            // 
            // colDesconto
            // 
            this.colDesconto.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colDesconto.AppearanceCell.Options.UseFont = true;
            this.colDesconto.DisplayFormat.FormatString = "c2";
            this.colDesconto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDesconto.FieldName = "Desconto";
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.Visible = true;
            this.colDesconto.VisibleIndex = 1;
            this.colDesconto.Width = 88;
            // 
            // colAcrescimo
            // 
            this.colAcrescimo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colAcrescimo.AppearanceCell.Options.UseFont = true;
            this.colAcrescimo.Caption = "Acréscimo";
            this.colAcrescimo.DisplayFormat.FormatString = "c2";
            this.colAcrescimo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAcrescimo.FieldName = "Acrescimo";
            this.colAcrescimo.Name = "colAcrescimo";
            this.colAcrescimo.Visible = true;
            this.colAcrescimo.VisibleIndex = 2;
            this.colAcrescimo.Width = 88;
            // 
            // colDescricao
            // 
            this.colDescricao.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colDescricao.AppearanceCell.Options.UseFont = true;
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 4;
            this.colDescricao.Width = 88;
            // 
            // colCreditoDebito
            // 
            this.colCreditoDebito.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colCreditoDebito.AppearanceCell.Options.UseFont = true;
            this.colCreditoDebito.Caption = "Crédito/Débito";
            this.colCreditoDebito.FieldName = "CreditoDebito";
            this.colCreditoDebito.Name = "colCreditoDebito";
            this.colCreditoDebito.Visible = true;
            this.colCreditoDebito.VisibleIndex = 5;
            this.colCreditoDebito.Width = 107;
            // 
            // colData
            // 
            this.colData.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colData.AppearanceCell.Options.UseFont = true;
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 6;
            this.colData.Width = 80;
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 7;
            this.colId.Width = 82;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.Caption = "Valor Total";
            this.gridColumn1.DisplayFormat.FormatString = "c2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn1.FieldName = "colValorTotal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colValorTotal", "Total: {0:c2}")});
            this.gridColumn1.UnboundExpression = "[Valor] + [Acrescimo] - [Desconto]";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 88;
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tileBar1.AppearanceText.Options.UseFont = true;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(878, 5);
            this.tileBar1.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.tileBar1.MaxId = 6;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(182, 409);
            this.tileBar1.TabIndex = 51;
            this.tileBar1.Text = "tileBar1";
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
            this.tileBarItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem1_ItemClick);
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
            // ucMovimentoCaixa
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.gridCashMovement);
            this.Name = "ucMovimentoCaixa";
            this.Size = new System.Drawing.Size(1036, 417);
            this.Load += new System.EventHandler(this.ucMovimentoCaixa_Load);
            this.VisibleChanged += new System.EventHandler(this.ucMovimentoCaixa_VisibleChanged);
            this.Enter += new System.EventHandler(this.ucMovimentoCaixa_Enter);
            this.Validated += new System.EventHandler(this.ucMovimentoCaixa_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.gridCashMovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentoCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCashMovement;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsMovimentoCaixa;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colDesconto;
        private DevExpress.XtraGrid.Columns.GridColumn colAcrescimo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditoDebito;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem4;
    }
}
