namespace App.MetroApp.UsersControl
{
    partial class ucRegCashMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRegCashMovement));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.calcBaseValue = new DevExpress.XtraEditors.CalcEdit();
            this.calcDiscount = new DevExpress.XtraEditors.CalcEdit();
            this.calcAddition = new DevExpress.XtraEditors.CalcEdit();
            this.cmbDebitCredit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateData = new DevExpress.XtraEditors.DateEdit();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.bsCashMov = new System.Windows.Forms.BindingSource(this.components);
            this.calcTotalValue = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBaseValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcAddition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDebitCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCashMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcTotalValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(77, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(16, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(99, 20);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(75, 22);
            this.txtId.TabIndex = 3;
            this.txtId.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(62, 56);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Data:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(33, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 16);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Descrição:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Location = new System.Drawing.Point(6, 122);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 16);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Débito/Crédito:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(27, 155);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 16);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Valor Base:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Location = new System.Drawing.Point(36, 188);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 16);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Desconto:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Location = new System.Drawing.Point(29, 221);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 16);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Acréscimo:";
            // 
            // calcBaseValue
            // 
            this.calcBaseValue.Location = new System.Drawing.Point(99, 154);
            this.calcBaseValue.Name = "calcBaseValue";
            this.calcBaseValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.calcBaseValue.Properties.Appearance.Options.UseFont = true;
            this.calcBaseValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBaseValue.Size = new System.Drawing.Size(100, 22);
            this.calcBaseValue.TabIndex = 16;
            // 
            // calcDiscount
            // 
            this.calcDiscount.Location = new System.Drawing.Point(99, 187);
            this.calcDiscount.Name = "calcDiscount";
            this.calcDiscount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.calcDiscount.Properties.Appearance.Options.UseFont = true;
            this.calcDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcDiscount.Size = new System.Drawing.Size(100, 22);
            this.calcDiscount.TabIndex = 17;
            // 
            // calcAddition
            // 
            this.calcAddition.Location = new System.Drawing.Point(99, 220);
            this.calcAddition.Name = "calcAddition";
            this.calcAddition.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.calcAddition.Properties.Appearance.Options.UseFont = true;
            this.calcAddition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcAddition.Size = new System.Drawing.Size(100, 22);
            this.calcAddition.TabIndex = 18;
            // 
            // cmbDebitCredit
            // 
            this.cmbDebitCredit.Location = new System.Drawing.Point(99, 121);
            this.cmbDebitCredit.Name = "cmbDebitCredit";
            this.cmbDebitCredit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbDebitCredit.Properties.Appearance.Options.UseFont = true;
            this.cmbDebitCredit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDebitCredit.Properties.Items.AddRange(new object[] {
            "Crédito",
            "Débito"});
            this.cmbDebitCredit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbDebitCredit.Size = new System.Drawing.Size(100, 22);
            this.cmbDebitCredit.TabIndex = 41;
            // 
            // dateData
            // 
            this.dateData.EditValue = null;
            this.dateData.Location = new System.Drawing.Point(99, 55);
            this.dateData.Name = "dateData";
            this.dateData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateData.Size = new System.Drawing.Size(100, 20);
            this.dateData.TabIndex = 42;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 86);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Size = new System.Drawing.Size(245, 22);
            this.txtDescription.TabIndex = 11;
            // 
            // bsCashMov
            // 
            this.bsCashMov.DataSource = typeof(App.Dominio.MovimentoCaixa);
            // 
            // calcTotalValue
            // 
            this.calcTotalValue.Location = new System.Drawing.Point(99, 253);
            this.calcTotalValue.Name = "calcTotalValue";
            this.calcTotalValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.calcTotalValue.Properties.Appearance.Options.UseFont = true;
            this.calcTotalValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcTotalValue.Size = new System.Drawing.Size(100, 22);
            this.calcTotalValue.TabIndex = 44;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Location = new System.Drawing.Point(27, 254);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(68, 16);
            this.labelControl8.TabIndex = 43;
            this.labelControl8.Text = "Valor Total:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(326, 294);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(68, 44);
            this.simpleButton2.TabIndex = 46;
            this.simpleButton2.Text = "Salvar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(252, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 44);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucRegCashMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.calcTotalValue);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.dateData);
            this.Controls.Add(this.cmbDebitCredit);
            this.Controls.Add(this.calcAddition);
            this.Controls.Add(this.calcDiscount);
            this.Controls.Add(this.calcBaseValue);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelControl2);
            this.Name = "ucRegCashMovement";
            this.Size = new System.Drawing.Size(669, 382);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBaseValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcAddition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDebitCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCashMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcTotalValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CalcEdit calcBaseValue;
        private DevExpress.XtraEditors.CalcEdit calcDiscount;
        private DevExpress.XtraEditors.CalcEdit calcAddition;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDebitCredit;
        private DevExpress.XtraEditors.DateEdit dateData;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private System.Windows.Forms.BindingSource bsCashMov;
        private DevExpress.XtraEditors.CalcEdit calcTotalValue;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
