namespace App.MetroApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.ucContainer = new DevExpress.XtraEditors.XtraUserControl();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton4 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarMovimentoCaixa = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarCadastroCliente = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem4 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SuspendLayout();
            // 
            // ucContainer
            // 
            this.ucContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucContainer.Location = new System.Drawing.Point(0, 263);
            this.ucContainer.Margin = new System.Windows.Forms.Padding(2);
            this.ucContainer.Name = "ucContainer";
            this.ucContainer.Size = new System.Drawing.Size(893, 149);
            this.ucContainer.TabIndex = 0;
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.navButton4);
            this.tileNavPane1.Buttons.Add(this.navButton1);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(893, 32);
            this.tileNavPane1.TabIndex = 3;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // navButton4
            // 
            this.navButton4.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton4.Caption = "";
            this.navButton4.Glyph = ((System.Drawing.Image)(resources.GetObject("navButton4.Glyph")));
            this.navButton4.Name = "navButton4";
            this.navButton4.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton4_ElementClick);
            // 
            // navButton1
            // 
            this.navButton1.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton1.Caption = "";
            this.navButton1.Glyph = ((System.Drawing.Image)(resources.GetObject("navButton1.Glyph")));
            this.navButton1.Name = "navButton1";
            this.navButton1.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton1_ElementClick);
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tileBar1.ItemPadding = new System.Windows.Forms.Padding(12, 0, 12, 10);
            this.tileBar1.ItemSize = 100;
            this.tileBar1.Location = new System.Drawing.Point(0, 32);
            this.tileBar1.MaxId = 22;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(0);
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(893, 231);
            this.tileBar1.TabIndex = 4;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tileBarMovimentoCaixa);
            this.tileBarGroup2.Items.Add(this.tileBarCadastroCliente);
            this.tileBarGroup2.Items.Add(this.tileBarItem4);
            this.tileBarGroup2.Items.Add(this.tileBarItem1);
            this.tileBarGroup2.Items.Add(this.tileBarItem2);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tileBarMovimentoCaixa
            // 
            this.tileBarMovimentoCaixa.AppearanceItem.Normal.BackColor = System.Drawing.Color.Green;
            this.tileBarMovimentoCaixa.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarMovimentoCaixa.DropDownOptions.AutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.tileBarMovimentoCaixa.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement6.Appearance.Normal.Options.UseFont = true;
            tileItemElement6.ImageToTextIndent = 1;
            tileItemElement6.Text = "Movimento de Caixa";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarMovimentoCaixa.Elements.Add(tileItemElement6);
            this.tileBarMovimentoCaixa.Id = 8;
            this.tileBarMovimentoCaixa.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarMovimentoCaixa.Name = "tileBarMovimentoCaixa";
            this.tileBarMovimentoCaixa.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
            this.tileBarMovimentoCaixa.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem1_ItemClick);
            // 
            // tileBarCadastroCliente
            // 
            this.tileBarCadastroCliente.AppearanceItem.Normal.BackColor = System.Drawing.Color.Blue;
            this.tileBarCadastroCliente.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarCadastroCliente.DropDownOptions.AutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.tileBarCadastroCliente.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement7.Appearance.Normal.Options.UseFont = true;
            tileItemElement7.Text = "Cadastro";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarCadastroCliente.Elements.Add(tileItemElement7);
            this.tileBarCadastroCliente.Id = 7;
            this.tileBarCadastroCliente.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarCadastroCliente.Name = "tileBarCadastroCliente";
            this.tileBarCadastroCliente.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
            this.tileBarCadastroCliente.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem1_ItemClick);
            // 
            // tileBarItem4
            // 
            this.tileBarItem4.DropDownOptions.AutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.tileBarItem4.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBarItem4.DropDownOptions.Height = 5;
            tileItemElement8.AnchorIndent = 0;
            tileItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 20F);
            tileItemElement8.Appearance.Normal.Options.UseFont = true;
            tileItemElement8.ImageToTextIndent = 0;
            tileItemElement8.Text = "Financeiro";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileItemElement8.UseImageInTransition = false;
            tileItemElement8.UseTextInTransition = false;
            this.tileBarItem4.Elements.Add(tileItemElement8);
            this.tileBarItem4.Id = 9;
            this.tileBarItem4.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileBarItem4.Name = "tileBarItem4";
            this.tileBarItem4.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
            this.tileBarItem4.ShowItemShadow = DevExpress.Utils.DefaultBoolean.False;
            this.tileBarItem4.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem1_ItemClick);
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 16F);
            tileItemElement9.Appearance.Normal.Options.UseFont = true;
            tileItemElement9.Text = "Comercial";
            this.tileBarItem1.Elements.Add(tileItemElement9);
            this.tileBarItem1.Id = 20;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement10.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 16F);
            tileItemElement10.Appearance.Normal.Options.UseFont = true;
            tileItemElement10.Text = "Relatórios";
            this.tileBarItem2.Elements.Add(tileItemElement10);
            this.tileBarItem2.Id = 21;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 412);
            this.Controls.Add(this.ucContainer);
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.tileNavPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton4;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarCadastroCliente;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarMovimentoCaixa;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem4;
        public DevExpress.XtraEditors.XtraUserControl ucContainer;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
    }
}

