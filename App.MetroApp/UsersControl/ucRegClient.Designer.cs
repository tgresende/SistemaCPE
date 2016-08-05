namespace App.MetroApp.UsersControl
{
    partial class ucRegClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRegClient));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDocType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtClientId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCPFCNPJ = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPhone1 = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone2 = new DevExpress.XtraEditors.TextEdit();
            this.txtStreet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtComplement = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtDistrict = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtZipCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lblCityState = new DevExpress.XtraEditors.LabelControl();
            this.txtPersonId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.bsClient = new System.Windows.Forms.BindingSource(this.components);
            this.bsPerson = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPFCNPJ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComplement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZipCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(463, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 44);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "Cancelar";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(463, 143);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(68, 44);
            this.simpleButton2.TabIndex = 64;
            this.simpleButton2.Text = "Salvar";
            // 
            // cmbDocType
            // 
            this.cmbDocType.Location = new System.Drawing.Point(125, 76);
            this.cmbDocType.Name = "cmbDocType";
            this.cmbDocType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbDocType.Properties.Appearance.Options.UseFont = true;
            this.cmbDocType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDocType.Properties.Items.AddRange(new object[] {
            "Crédito",
            "Débito"});
            this.cmbDocType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbDocType.Size = new System.Drawing.Size(100, 22);
            this.cmbDocType.TabIndex = 60;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 41);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(245, 22);
            this.txtName.TabIndex = 56;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Location = new System.Drawing.Point(28, 177);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 16);
            this.labelControl6.TabIndex = 54;
            this.labelControl6.Text = "Telefone (2):";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(38, 143);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 16);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Telefone:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Location = new System.Drawing.Point(3, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(116, 16);
            this.labelControl5.TabIndex = 52;
            this.labelControl5.Text = "Tipo de Documento:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(47, 110);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 16);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "CPF/CNPJ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(66, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 16);
            this.labelControl3.TabIndex = 50;
            this.labelControl3.Text = "Nome:";
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(110, 8);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtClientId.Properties.Appearance.Options.UseFont = true;
            this.txtClientId.Size = new System.Drawing.Size(75, 22);
            this.txtClientId.TabIndex = 49;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(48, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 16);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "Id Cliente:";
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(110, 107);
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCPFCNPJ.Properties.Appearance.Options.UseFont = true;
            this.txtCPFCNPJ.Size = new System.Drawing.Size(245, 22);
            this.txtCPFCNPJ.TabIndex = 66;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblCityState);
            this.groupControl1.Controls.Add(this.txtCity);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtZipCode);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtDistrict);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.TxtComplement);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtNumber);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtStreet);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Location = new System.Drawing.Point(28, 206);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(378, 243);
            this.groupControl1.TabIndex = 67;
            this.groupControl1.Text = "Endereço";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(110, 140);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPhone1.Properties.Appearance.Options.UseFont = true;
            this.txtPhone1.Size = new System.Drawing.Size(245, 22);
            this.txtPhone1.TabIndex = 68;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(110, 174);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPhone2.Properties.Appearance.Options.UseFont = true;
            this.txtPhone2.Size = new System.Drawing.Size(245, 22);
            this.txtPhone2.TabIndex = 69;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(82, 35);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtStreet.Properties.Appearance.Options.UseFont = true;
            this.txtStreet.Size = new System.Drawing.Size(245, 22);
            this.txtStreet.TabIndex = 70;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Location = new System.Drawing.Point(10, 38);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 16);
            this.labelControl7.TabIndex = 69;
            this.labelControl7.Text = "Rua:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(82, 63);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Size = new System.Drawing.Size(245, 22);
            this.txtNumber.TabIndex = 72;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Location = new System.Drawing.Point(10, 66);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 16);
            this.labelControl8.TabIndex = 71;
            this.labelControl8.Text = "Número:";
            // 
            // TxtComplement
            // 
            this.TxtComplement.Location = new System.Drawing.Point(100, 91);
            this.TxtComplement.Name = "TxtComplement";
            this.TxtComplement.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TxtComplement.Properties.Appearance.Options.UseFont = true;
            this.TxtComplement.Size = new System.Drawing.Size(245, 22);
            this.TxtComplement.TabIndex = 74;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Location = new System.Drawing.Point(10, 94);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 16);
            this.labelControl9.TabIndex = 73;
            this.labelControl9.Text = "Complemento:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(82, 124);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDistrict.Properties.Appearance.Options.UseFont = true;
            this.txtDistrict.Size = new System.Drawing.Size(245, 22);
            this.txtDistrict.TabIndex = 76;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Location = new System.Drawing.Point(10, 127);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(39, 16);
            this.labelControl10.TabIndex = 75;
            this.labelControl10.Text = "Bairro:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(82, 152);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtZipCode.Properties.Appearance.Options.UseFont = true;
            this.txtZipCode.Size = new System.Drawing.Size(245, 22);
            this.txtZipCode.TabIndex = 78;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Location = new System.Drawing.Point(10, 155);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(27, 16);
            this.labelControl11.TabIndex = 77;
            this.labelControl11.Text = "Cep:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(82, 180);
            this.txtCity.Name = "txtCity";
            this.txtCity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCity.Properties.Appearance.Options.UseFont = true;
            this.txtCity.Size = new System.Drawing.Size(55, 22);
            this.txtCity.TabIndex = 80;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl12.Location = new System.Drawing.Point(10, 183);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(44, 16);
            this.labelControl12.TabIndex = 79;
            this.labelControl12.Text = "Cidade:";
            // 
            // lblCityState
            // 
            this.lblCityState.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCityState.Location = new System.Drawing.Point(154, 183);
            this.lblCityState.Name = "lblCityState";
            this.lblCityState.Size = new System.Drawing.Size(27, 16);
            this.lblCityState.TabIndex = 81;
            this.lblCityState.Text = "Cep:";
            // 
            // txtPersonId
            // 
            this.txtPersonId.Enabled = false;
            this.txtPersonId.Location = new System.Drawing.Point(280, 5);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPersonId.Properties.Appearance.Options.UseFont = true;
            this.txtPersonId.Size = new System.Drawing.Size(75, 22);
            this.txtPersonId.TabIndex = 71;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl14.Location = new System.Drawing.Point(214, 11);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(60, 16);
            this.labelControl14.TabIndex = 70;
            this.labelControl14.Text = "Id Pessoa:";
            // 
            // bsClient
            // 
            this.bsClient.DataSource = typeof(App.Dominio.Clientes);
            // 
            // bsPerson
            // 
            this.bsPerson.DataSource = typeof(App.Dominio.Pessoas);
            // 
            // ucRegClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPersonId);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtCPFCNPJ);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cmbDocType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.labelControl2);
            this.Name = "ucRegClient";
            this.Size = new System.Drawing.Size(646, 482);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPFCNPJ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComplement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZipCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDocType;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtClientId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCPFCNPJ;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtDistrict;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TxtComplement;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtStreet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPhone1;
        private DevExpress.XtraEditors.TextEdit txtPhone2;
        private DevExpress.XtraEditors.TextEdit txtZipCode;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl lblCityState;
        private DevExpress.XtraEditors.TextEdit txtCity;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtPersonId;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.BindingSource bsClient;
        private System.Windows.Forms.BindingSource bsPerson;
    }
}
