namespace App.MetroApp.UsersControl
{
    partial class ucLockCashMovement
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLockCashMovement));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.dateData = new DevExpress.XtraEditors.DateEdit();
            this.calcOpenValue = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem4 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup1 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem5 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem6 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.calcEndValue = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.tileBarGroup3 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dateData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcOpenValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEndValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateData
            // 
            this.dateData.EditValue = null;
            this.dateData.Location = new System.Drawing.Point(121, 68);
            this.dateData.Name = "dateData";
            this.dateData.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateData.Properties.Appearance.Options.UseFont = true;
            this.dateData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateData.Size = new System.Drawing.Size(100, 22);
            this.dateData.TabIndex = 50;
            this.dateData.EditValueChanged += new System.EventHandler(this.dateData_EditValueChanged);
            // 
            // calcOpenValue
            // 
            this.calcOpenValue.Location = new System.Drawing.Point(121, 134);
            this.calcOpenValue.Name = "calcOpenValue";
            this.calcOpenValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.calcOpenValue.Properties.Appearance.Options.UseFont = true;
            this.calcOpenValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcOpenValue.Size = new System.Drawing.Size(100, 22);
            this.calcOpenValue.TabIndex = 48;
            this.calcOpenValue.EditValueChanged += new System.EventHandler(this.calcBaseValue_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(26, 137);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 16);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Valor Abertura:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Location = new System.Drawing.Point(74, 104);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 16);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Status:";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(84, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 16);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Data:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(121, 33);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(75, 22);
            this.txtId.TabIndex = 44;
            this.txtId.EditValueChanged += new System.EventHandler(this.txtId_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(99, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(16, 16);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Id:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
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
            this.tileBar1.Location = new System.Drawing.Point(325, 25);
            this.tileBar1.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.tileBar1.MaxId = 6;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(182, 189);
            this.tileBar1.TabIndex = 52;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup1
            // 
            this.tileBarGroup1.Items.Add(this.tileBarItem5);
            this.tileBarGroup1.Items.Add(this.tileBarItem6);
            this.tileBarGroup1.Name = "tileBarGroup1";
            // 
            // tileBarItem5
            // 
            this.tileBarItem5.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.Text = "Abrir Caixa";
            this.tileBarItem5.Elements.Add(tileItemElement4);
            this.tileBarItem5.Id = 2;
            this.tileBarItem5.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem5.Name = "tileBarItem5";
            this.tileBarItem5.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem5_ItemClick);
            // 
            // tileBarItem6
            // 
            this.tileBarItem6.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.Text = "Fechar Caixa";
            this.tileBarItem6.Elements.Add(tileItemElement5);
            this.tileBarItem6.Id = 4;
            this.tileBarItem6.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem6.Name = "tileBarItem6";
            // 
            // calcEndValue
            // 
            this.calcEndValue.Location = new System.Drawing.Point(121, 167);
            this.calcEndValue.Name = "calcEndValue";
            this.calcEndValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.calcEndValue.Properties.Appearance.Options.UseFont = true;
            this.calcEndValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEndValue.Size = new System.Drawing.Size(100, 22);
            this.calcEndValue.TabIndex = 54;
            this.calcEndValue.EditValueChanged += new System.EventHandler(this.calcEdit1_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(6, 170);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(109, 16);
            this.labelControl4.TabIndex = 53;
            this.labelControl4.Text = "Valor Fechamento:";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(121, 101);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(100, 22);
            this.textEdit1.TabIndex = 55;
            // 
            // tileBarGroup3
            // 
            this.tileBarGroup3.Name = "tileBarGroup3";
            // 
            // ucLockCashMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.calcEndValue);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.dateData);
            this.Controls.Add(this.calcOpenValue);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelControl2);
            this.Name = "ucLockCashMovement";
            this.Size = new System.Drawing.Size(1317, 422);
            ((System.ComponentModel.ISupportInitialize)(this.dateData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcOpenValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEndValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateData;
        private DevExpress.XtraEditors.CalcEdit calcOpenValue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem4;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem5;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem6;
        private DevExpress.XtraEditors.CalcEdit calcEndValue;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup3;
    }
}
