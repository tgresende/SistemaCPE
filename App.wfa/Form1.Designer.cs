﻿namespace App.wfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TabProjetos = new System.Windows.Forms.TabControl();
            this.pcVisaoGeral = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pcInfoProjeto = new System.Windows.Forms.TabPage();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtResponsavelId = new System.Windows.Forms.TextBox();
            this.txtNomeProjeto = new System.Windows.Forms.TextBox();
            this.dateInicioProjeto = new System.Windows.Forms.DateTimePicker();
            this.dateFimProjeto = new System.Windows.Forms.DateTimePicker();
            this.pcPrazos = new System.Windows.Forms.TabPage();
            this.pcCustos = new System.Windows.Forms.TabPage();
            this.pcPlanoProjeto = new System.Windows.Forms.TabPage();
            this.pcRiscos = new System.Windows.Forms.TabPage();
            this.pcStakeholders = new System.Windows.Forms.TabPage();
            this.nomeProjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProjetos = new System.Windows.Forms.BindingSource(this.components);
            this.bsGastos = new System.Windows.Forms.BindingSource(this.components);
            this.panelCusto = new System.Windows.Forms.Panel();
            this.pcListaCustos = new System.Windows.Forms.TabControl();
            this.tabListaCustos = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gastoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projetoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadePrevistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDetalhesCustos = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabProjetos.SuspendLayout();
            this.pcVisaoGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pcInfoProjeto.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.pcCustos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGastos)).BeginInit();
            this.panelCusto.SuspendLayout();
            this.pcListaCustos.SuspendLayout();
            this.tabListaCustos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabDetalhesCustos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(177, 467);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 69);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalva.FlatAppearance.BorderSize = 0;
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.Location = new System.Drawing.Point(258, 467);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 69);
            this.btnSalva.TabIndex = 9;
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancela.FlatAppearance.BorderSize = 0;
            this.btnCancela.Image = ((System.Drawing.Image)(resources.GetObject("btnCancela.Image")));
            this.btnCancela.Location = new System.Drawing.Point(339, 467);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 69);
            this.btnCancela.TabIndex = 10;
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(655, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 69);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(655, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 69);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(655, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 69);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(655, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 69);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(655, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 69);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(659, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TabProjetos
            // 
            this.TabProjetos.Controls.Add(this.pcVisaoGeral);
            this.TabProjetos.Controls.Add(this.pcInfoProjeto);
            this.TabProjetos.Controls.Add(this.pcPrazos);
            this.TabProjetos.Controls.Add(this.pcCustos);
            this.TabProjetos.Controls.Add(this.pcPlanoProjeto);
            this.TabProjetos.Controls.Add(this.pcRiscos);
            this.TabProjetos.Controls.Add(this.pcStakeholders);
            this.TabProjetos.Location = new System.Drawing.Point(12, 12);
            this.TabProjetos.Name = "TabProjetos";
            this.TabProjetos.SelectedIndex = 0;
            this.TabProjetos.Size = new System.Drawing.Size(641, 449);
            this.TabProjetos.TabIndex = 23;
            // 
            // pcVisaoGeral
            // 
            this.pcVisaoGeral.Controls.Add(this.dataGridView1);
            this.pcVisaoGeral.Location = new System.Drawing.Point(4, 22);
            this.pcVisaoGeral.Name = "pcVisaoGeral";
            this.pcVisaoGeral.Padding = new System.Windows.Forms.Padding(3);
            this.pcVisaoGeral.Size = new System.Drawing.Size(633, 423);
            this.pcVisaoGeral.TabIndex = 0;
            this.pcVisaoGeral.Text = "Visão Geral";
            this.pcVisaoGeral.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProjetoDataGridViewTextBoxColumn,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataFimDataGridViewTextBoxColumn,
            this.responsavelIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsProjetos;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 417);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pcInfoProjeto
            // 
            this.pcInfoProjeto.Controls.Add(this.panelInfo);
            this.pcInfoProjeto.Location = new System.Drawing.Point(4, 22);
            this.pcInfoProjeto.Name = "pcInfoProjeto";
            this.pcInfoProjeto.Padding = new System.Windows.Forms.Padding(3);
            this.pcInfoProjeto.Size = new System.Drawing.Size(633, 423);
            this.pcInfoProjeto.TabIndex = 1;
            this.pcInfoProjeto.Text = "Informações do Projeto";
            this.pcInfoProjeto.UseVisualStyleBackColor = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.label6);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.textBox3);
            this.panelInfo.Controls.Add(this.txtResponsavelId);
            this.panelInfo.Controls.Add(this.txtNomeProjeto);
            this.panelInfo.Controls.Add(this.dateInicioProjeto);
            this.panelInfo.Controls.Add(this.dateFimProjeto);
            this.panelInfo.Location = new System.Drawing.Point(6, 6);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(363, 357);
            this.panelInfo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Responsável";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data de Finalização";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data de Ínicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome do Projeto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "Id", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(111, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // txtResponsavelId
            // 
            this.txtResponsavelId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "ResponsavelId", true));
            this.txtResponsavelId.Location = new System.Drawing.Point(111, 112);
            this.txtResponsavelId.Name = "txtResponsavelId";
            this.txtResponsavelId.Size = new System.Drawing.Size(100, 20);
            this.txtResponsavelId.TabIndex = 14;
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "NomeProjeto", true));
            this.txtNomeProjeto.Location = new System.Drawing.Point(111, 29);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProjeto.TabIndex = 11;
            // 
            // dateInicioProjeto
            // 
            this.dateInicioProjeto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "DataInicio", true));
            this.dateInicioProjeto.Location = new System.Drawing.Point(111, 55);
            this.dateInicioProjeto.Name = "dateInicioProjeto";
            this.dateInicioProjeto.Size = new System.Drawing.Size(200, 20);
            this.dateInicioProjeto.TabIndex = 12;
            // 
            // dateFimProjeto
            // 
            this.dateFimProjeto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "DataFim", true));
            this.dateFimProjeto.Location = new System.Drawing.Point(111, 86);
            this.dateFimProjeto.Name = "dateFimProjeto";
            this.dateFimProjeto.Size = new System.Drawing.Size(200, 20);
            this.dateFimProjeto.TabIndex = 13;
            // 
            // pcPrazos
            // 
            this.pcPrazos.Location = new System.Drawing.Point(4, 22);
            this.pcPrazos.Name = "pcPrazos";
            this.pcPrazos.Padding = new System.Windows.Forms.Padding(3);
            this.pcPrazos.Size = new System.Drawing.Size(633, 423);
            this.pcPrazos.TabIndex = 2;
            this.pcPrazos.Text = "Plano de Prazos";
            this.pcPrazos.UseVisualStyleBackColor = true;
            // 
            // pcCustos
            // 
            this.pcCustos.Controls.Add(this.panelCusto);
            this.pcCustos.Location = new System.Drawing.Point(4, 22);
            this.pcCustos.Name = "pcCustos";
            this.pcCustos.Padding = new System.Windows.Forms.Padding(3);
            this.pcCustos.Size = new System.Drawing.Size(633, 423);
            this.pcCustos.TabIndex = 3;
            this.pcCustos.Text = "Plano de Custos";
            this.pcCustos.UseVisualStyleBackColor = true;
            // 
            // pcPlanoProjeto
            // 
            this.pcPlanoProjeto.Location = new System.Drawing.Point(4, 22);
            this.pcPlanoProjeto.Name = "pcPlanoProjeto";
            this.pcPlanoProjeto.Padding = new System.Windows.Forms.Padding(3);
            this.pcPlanoProjeto.Size = new System.Drawing.Size(633, 423);
            this.pcPlanoProjeto.TabIndex = 4;
            this.pcPlanoProjeto.Text = "Plano de Projeto";
            this.pcPlanoProjeto.UseVisualStyleBackColor = true;
            // 
            // pcRiscos
            // 
            this.pcRiscos.Location = new System.Drawing.Point(4, 22);
            this.pcRiscos.Name = "pcRiscos";
            this.pcRiscos.Padding = new System.Windows.Forms.Padding(3);
            this.pcRiscos.Size = new System.Drawing.Size(633, 423);
            this.pcRiscos.TabIndex = 5;
            this.pcRiscos.Text = "Plano de Riscos";
            this.pcRiscos.UseVisualStyleBackColor = true;
            // 
            // pcStakeholders
            // 
            this.pcStakeholders.Location = new System.Drawing.Point(4, 22);
            this.pcStakeholders.Name = "pcStakeholders";
            this.pcStakeholders.Padding = new System.Windows.Forms.Padding(3);
            this.pcStakeholders.Size = new System.Drawing.Size(633, 423);
            this.pcStakeholders.TabIndex = 6;
            this.pcStakeholders.Text = "Stakeholders";
            this.pcStakeholders.UseVisualStyleBackColor = true;
            // 
            // nomeProjetoDataGridViewTextBoxColumn
            // 
            this.nomeProjetoDataGridViewTextBoxColumn.DataPropertyName = "NomeProjeto";
            this.nomeProjetoDataGridViewTextBoxColumn.HeaderText = "Nome do Projeto";
            this.nomeProjetoDataGridViewTextBoxColumn.Name = "nomeProjetoDataGridViewTextBoxColumn";
            this.nomeProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProjetoDataGridViewTextBoxColumn.Width = 110;
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "Data de Inicio";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            this.dataInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFimDataGridViewTextBoxColumn
            // 
            this.dataFimDataGridViewTextBoxColumn.DataPropertyName = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.HeaderText = "Data Fim";
            this.dataFimDataGridViewTextBoxColumn.Name = "dataFimDataGridViewTextBoxColumn";
            this.dataFimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsavelIdDataGridViewTextBoxColumn
            // 
            this.responsavelIdDataGridViewTextBoxColumn.DataPropertyName = "ResponsavelId";
            this.responsavelIdDataGridViewTextBoxColumn.HeaderText = "Id do Responsável";
            this.responsavelIdDataGridViewTextBoxColumn.Name = "responsavelIdDataGridViewTextBoxColumn";
            this.responsavelIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.responsavelIdDataGridViewTextBoxColumn.Width = 130;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsProjetos
            // 
            this.bsProjetos.DataSource = typeof(App.Dominio.Projetos);
            // 
            // bsGastos
            // 
            this.bsGastos.DataSource = typeof(App.Dominio.GastosProjetos);
            // 
            // panelCusto
            // 
            this.panelCusto.Controls.Add(this.pcListaCustos);
            this.panelCusto.Location = new System.Drawing.Point(6, 3);
            this.panelCusto.Name = "panelCusto";
            this.panelCusto.Size = new System.Drawing.Size(624, 414);
            this.panelCusto.TabIndex = 2;
            // 
            // pcListaCustos
            // 
            this.pcListaCustos.Controls.Add(this.tabListaCustos);
            this.pcListaCustos.Controls.Add(this.tabDetalhesCustos);
            this.pcListaCustos.Location = new System.Drawing.Point(3, 0);
            this.pcListaCustos.Name = "pcListaCustos";
            this.pcListaCustos.SelectedIndex = 0;
            this.pcListaCustos.Size = new System.Drawing.Size(618, 414);
            this.pcListaCustos.TabIndex = 2;
            // 
            // tabListaCustos
            // 
            this.tabListaCustos.Controls.Add(this.button10);
            this.tabListaCustos.Controls.Add(this.button9);
            this.tabListaCustos.Controls.Add(this.button8);
            this.tabListaCustos.Controls.Add(this.button7);
            this.tabListaCustos.Controls.Add(this.dataGridView2);
            this.tabListaCustos.Location = new System.Drawing.Point(4, 22);
            this.tabListaCustos.Name = "tabListaCustos";
            this.tabListaCustos.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaCustos.Size = new System.Drawing.Size(610, 388);
            this.tabListaCustos.TabIndex = 0;
            this.tabListaCustos.Text = "Custos";
            this.tabListaCustos.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gastoIdDataGridViewTextBoxColumn,
            this.Origem,
            this.projetoIdDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.quantidadePrevistaDataGridViewTextBoxColumn,
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn,
            this.quantidadeRealDataGridViewTextBoxColumn,
            this.valorUnitarioRealDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bsGastos;
            this.dataGridView2.Location = new System.Drawing.Point(3, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(601, 332);
            this.dataGridView2.TabIndex = 1;
            // 
            // gastoIdDataGridViewTextBoxColumn
            // 
            this.gastoIdDataGridViewTextBoxColumn.DataPropertyName = "GastoId";
            this.gastoIdDataGridViewTextBoxColumn.HeaderText = "GastoId";
            this.gastoIdDataGridViewTextBoxColumn.Name = "gastoIdDataGridViewTextBoxColumn";
            this.gastoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.gastoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Origem
            // 
            this.Origem.HeaderText = "Origem";
            this.Origem.Name = "Origem";
            this.Origem.ReadOnly = true;
            // 
            // projetoIdDataGridViewTextBoxColumn
            // 
            this.projetoIdDataGridViewTextBoxColumn.DataPropertyName = "ProjetoId";
            this.projetoIdDataGridViewTextBoxColumn.HeaderText = "ProjetoId";
            this.projetoIdDataGridViewTextBoxColumn.Name = "projetoIdDataGridViewTextBoxColumn";
            this.projetoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.projetoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // quantidadePrevistaDataGridViewTextBoxColumn
            // 
            this.quantidadePrevistaDataGridViewTextBoxColumn.DataPropertyName = "QuantidadePrevista";
            this.quantidadePrevistaDataGridViewTextBoxColumn.HeaderText = "Qtd Prevista";
            this.quantidadePrevistaDataGridViewTextBoxColumn.Name = "quantidadePrevistaDataGridViewTextBoxColumn";
            this.quantidadePrevistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorUnitarioPrevistoDataGridViewTextBoxColumn
            // 
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitarioPrevisto";
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn.HeaderText = "Vlr Unit. Previsto";
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn.Name = "valorUnitarioPrevistoDataGridViewTextBoxColumn";
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn.Width = 120;
            // 
            // quantidadeRealDataGridViewTextBoxColumn
            // 
            this.quantidadeRealDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeReal";
            this.quantidadeRealDataGridViewTextBoxColumn.HeaderText = "Qtd Real";
            this.quantidadeRealDataGridViewTextBoxColumn.Name = "quantidadeRealDataGridViewTextBoxColumn";
            this.quantidadeRealDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeRealDataGridViewTextBoxColumn.Width = 80;
            // 
            // valorUnitarioRealDataGridViewTextBoxColumn
            // 
            this.valorUnitarioRealDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitarioReal";
            this.valorUnitarioRealDataGridViewTextBoxColumn.HeaderText = "Vlr Unit. Real";
            this.valorUnitarioRealDataGridViewTextBoxColumn.Name = "valorUnitarioRealDataGridViewTextBoxColumn";
            this.valorUnitarioRealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tabDetalhesCustos
            // 
            this.tabDetalhesCustos.Controls.Add(this.panel1);
            this.tabDetalhesCustos.Location = new System.Drawing.Point(4, 22);
            this.tabDetalhesCustos.Name = "tabDetalhesCustos";
            this.tabDetalhesCustos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalhesCustos.Size = new System.Drawing.Size(610, 388);
            this.tabDetalhesCustos.TabIndex = 1;
            this.tabDetalhesCustos.Text = "Detalhes individuais";
            this.tabDetalhesCustos.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Location = new System.Drawing.Point(177, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 39);
            this.button7.TabIndex = 17;
            this.button7.Text = "Salvar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Location = new System.Drawing.Point(236, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 39);
            this.button8.TabIndex = 18;
            this.button8.Text = "Cancela";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Location = new System.Drawing.Point(118, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 39);
            this.button9.TabIndex = 19;
            this.button9.Text = "Novo";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.Location = new System.Drawing.Point(295, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 39);
            this.button10.TabIndex = 20;
            this.button10.Text = "Excluir";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 366);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 565);
            this.Controls.Add(this.TabProjetos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escritório de Projetos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabProjetos.ResumeLayout(false);
            this.pcVisaoGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pcInfoProjeto.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.pcCustos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGastos)).EndInit();
            this.panelCusto.ResumeLayout(false);
            this.pcListaCustos.ResumeLayout(false);
            this.tabListaCustos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabDetalhesCustos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.BindingSource bsProjetos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl TabProjetos;
        private System.Windows.Forms.TabPage pcVisaoGeral;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage pcInfoProjeto;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtResponsavelId;
        private System.Windows.Forms.TextBox txtNomeProjeto;
        private System.Windows.Forms.DateTimePicker dateInicioProjeto;
        private System.Windows.Forms.DateTimePicker dateFimProjeto;
        private System.Windows.Forms.TabPage pcPrazos;
        private System.Windows.Forms.TabPage pcCustos;
        private System.Windows.Forms.TabPage pcPlanoProjeto;
        private System.Windows.Forms.TabPage pcRiscos;
        private System.Windows.Forms.TabPage pcStakeholders;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsGastos;
        private System.Windows.Forms.Panel panelCusto;
        private System.Windows.Forms.TabControl pcListaCustos;
        private System.Windows.Forms.TabPage tabListaCustos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn projetoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadePrevistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioPrevistoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeRealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioRealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabDetalhesCustos;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;




    }
}

