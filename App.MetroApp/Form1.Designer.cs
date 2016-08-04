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
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.ucContainer = new DevExpress.XtraEditors.XtraUserControl();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton4 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarCadastroCliente = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarMovimentoCaixa = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem4 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem5 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SuspendLayout();
            // 
            // ucContainer
            // 
            this.ucContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucContainer.Location = new System.Drawing.Point(0, 360);
            this.ucContainer.Name = "ucContainer";
            this.ucContainer.Size = new System.Drawing.Size(1191, 166);
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
            this.tileNavPane1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(1191, 49);
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
            this.tileBar1.ItemSize = 200;
            this.tileBar1.Location = new System.Drawing.Point(0, 49);
            this.tileBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar1.MaxId = 12;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(0);
            this.tileBar1.Size = new System.Drawing.Size(1191, 311);
            this.tileBar1.TabIndex = 4;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tileBarMovimentoCaixa);
            this.tileBarGroup2.Items.Add(this.tileBarCadastroCliente);
            this.tileBarGroup2.Items.Add(this.tileBarItem4);
            this.tileBarGroup2.Items.Add(this.tileBarItem5);
            this.tileBarGroup2.Items.Add(this.tileBarItem1);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tileBarCadastroCliente
            // 
            this.tileBarCadastroCliente.AppearanceItem.Normal.BackColor = System.Drawing.Color.Blue;
            this.tileBarCadastroCliente.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarCadastroCliente.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Text = "Cadastro de Clientes";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarCadastroCliente.Elements.Add(tileItemElement2);
            this.tileBarCadastroCliente.Id = 7;
            this.tileBarCadastroCliente.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tileBarCadastroCliente.Name = "tileBarCadastroCliente";
            this.tileBarCadastroCliente.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem1_ItemClick);
            // 
            // tileBarMovimentoCaixa
            // 
            this.tileBarMovimentoCaixa.AppearanceItem.Normal.BackColor = System.Drawing.Color.Green;
            this.tileBarMovimentoCaixa.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarMovimentoCaixa.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Movimento de Caixa";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarMovimentoCaixa.Elements.Add(tileItemElement1);
            this.tileBarMovimentoCaixa.Id = 8;
            this.tileBarMovimentoCaixa.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tileBarMovimentoCaixa.Name = "tileBarMovimentoCaixa";
            this.tileBarMovimentoCaixa.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem1_ItemClick);
            // 
            // tileBarItem4
            // 
            this.tileBarItem4.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "tileBarItem4";
            this.tileBarItem4.Elements.Add(tileItemElement3);
            this.tileBarItem4.Id = 9;
            this.tileBarItem4.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tileBarItem4.Name = "tileBarItem4";
            this.tileBarItem4.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem1_ItemClick);
            // 
            // tileBarItem5
            // 
            this.tileBarItem5.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "tileBarItem5";
            this.tileBarItem5.Elements.Add(tileItemElement4);
            this.tileBarItem5.Id = 10;
            this.tileBarItem5.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tileBarItem5.Name = "tileBarItem5";
            this.tileBarItem5.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem1_ItemClick);
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Button", null, -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, null, -1, false, true),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Button", null, -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, null, -1, false, true)});
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 526);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(1191, 108);
            this.windowsUIButtonPanel1.TabIndex = 5;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "tileBarItem1";
            this.tileBarItem1.Elements.Add(tileItemElement5);
            this.tileBarItem1.Id = 11;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 634);
            this.Controls.Add(this.ucContainer);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.tileNavPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraUserControl ucContainer;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton4;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarCadastroCliente;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarMovimentoCaixa;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem4;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem5;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
    }
}

