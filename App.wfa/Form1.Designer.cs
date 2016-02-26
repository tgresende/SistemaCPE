namespace App.wfa
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
            this.TabProjetos = new System.Windows.Forms.TabControl();
            this.pcVisaoGeral = new System.Windows.Forms.TabPage();
            this.btnRiscos = new System.Windows.Forms.Button();
            this.btnCustos = new System.Windows.Forms.Button();
            this.btnInfoProjeto = new System.Windows.Forms.Button();
            this.gridProjetos = new System.Windows.Forms.DataGridView();
            this.nomeProjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProjetos = new System.Windows.Forms.BindingSource(this.components);
            this.pcInfoProjeto = new System.Windows.Forms.TabPage();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdProjeto = new System.Windows.Forms.TextBox();
            this.txtResponsavelId = new System.Windows.Forms.TextBox();
            this.txtNomeProjeto = new System.Windows.Forms.TextBox();
            this.dateInicioProjeto = new System.Windows.Forms.DateTimePicker();
            this.dateFimProjeto = new System.Windows.Forms.DateTimePicker();
            this.pcCustos = new System.Windows.Forms.TabPage();
            this.panelCustos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelInfoCustos = new System.Windows.Forms.Panel();
            this.btnPesquisaCusto = new System.Windows.Forms.Button();
            this.txtVlrPrevCusto = new System.Windows.Forms.TextBox();
            this.bsGastos = new System.Windows.Forms.BindingSource(this.components);
            this.txtVlrRealCusto = new System.Windows.Forms.TextBox();
            this.txtQtdRealCusto = new System.Windows.Forms.TextBox();
            this.txtQtdPrevCusto = new System.Windows.Forms.TextBox();
            this.txtObservacaoCusto = new System.Windows.Forms.TextBox();
            this.txtDescricaoCusto = new System.Windows.Forms.TextBox();
            this.txtidGastoOrigem = new System.Windows.Forms.TextBox();
            this.txtIdprojetoCusto = new System.Windows.Forms.TextBox();
            this.txtIdCusto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluiCusto = new System.Windows.Forms.Button();
            this.btnNovoCusto = new System.Windows.Forms.Button();
            this.btnCancelaCusto = new System.Windows.Forms.Button();
            this.btnSalvaCusto = new System.Windows.Forms.Button();
            this.gridCustos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projetosIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadePrevistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcRiscos = new System.Windows.Forms.TabPage();
            this.tabRiscos = new System.Windows.Forms.TabControl();
            this.pcListaRiscos = new System.Windows.Forms.TabPage();
            this.btnExcluiRisco = new System.Windows.Forms.Button();
            this.btnNovoRisco = new System.Windows.Forms.Button();
            this.btnCancelaRisco = new System.Windows.Forms.Button();
            this.btnSalvaRisco = new System.Windows.Forms.Button();
            this.panelInfoRisco = new System.Windows.Forms.Panel();
            this.btnPesquisaRisco = new System.Windows.Forms.Button();
            this.txtPlanoContigenciaRiscoOrigem = new System.Windows.Forms.TextBox();
            this.bsRiscos = new System.Windows.Forms.BindingSource(this.components);
            this.txtMedidaPrevRiscoOrigem = new System.Windows.Forms.TextBox();
            this.txtDescricaoRisco = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtProbabilidadeRisco = new System.Windows.Forms.TextBox();
            this.txtImpactoRisco = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDescricaoRiscoOrigem = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrevistoRisco = new System.Windows.Forms.TextBox();
            this.txtScoreRisco = new System.Windows.Forms.TextBox();
            this.txtObservacaoRisco = new System.Windows.Forms.TextBox();
            this.txtNomeRisco = new System.Windows.Forms.TextBox();
            this.txtIdRiscoOrigem = new System.Windows.Forms.TextBox();
            this.txtIdprojetoRisco = new System.Windows.Forms.TextBox();
            this.txtIdRisco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gridRiscos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riscoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projetosIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previstoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoRiscosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaPreventivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoContigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcScore = new System.Windows.Forms.TabPage();
            this.btnSalvaScore = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.TabProjetos.SuspendLayout();
            this.pcVisaoGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).BeginInit();
            this.pcInfoProjeto.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.pcCustos.SuspendLayout();
            this.panelCustos.SuspendLayout();
            this.panelInfoCustos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustos)).BeginInit();
            this.pcRiscos.SuspendLayout();
            this.tabRiscos.SuspendLayout();
            this.pcListaRiscos.SuspendLayout();
            this.panelInfoRisco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRiscos)).BeginInit();
            this.pcScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(417, 598);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(77, 70);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalva.FlatAppearance.BorderSize = 0;
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.Location = new System.Drawing.Point(502, 598);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(77, 70);
            this.btnSalva.TabIndex = 9;
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancela.FlatAppearance.BorderSize = 0;
            this.btnCancela.Image = ((System.Drawing.Image)(resources.GetObject("btnCancela.Image")));
            this.btnCancela.Location = new System.Drawing.Point(587, 598);
            this.btnCancela.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(77, 70);
            this.btnCancela.TabIndex = 10;
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1085, 598);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 70);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // TabProjetos
            // 
            this.TabProjetos.Controls.Add(this.pcVisaoGeral);
            this.TabProjetos.Controls.Add(this.pcInfoProjeto);
            this.TabProjetos.Controls.Add(this.pcCustos);
            this.TabProjetos.Controls.Add(this.pcRiscos);
            this.TabProjetos.Location = new System.Drawing.Point(5, 41);
            this.TabProjetos.Margin = new System.Windows.Forms.Padding(4);
            this.TabProjetos.Name = "TabProjetos";
            this.TabProjetos.SelectedIndex = 0;
            this.TabProjetos.Size = new System.Drawing.Size(1175, 553);
            this.TabProjetos.TabIndex = 23;
            this.TabProjetos.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabProjetos_Selecting);
            // 
            // pcVisaoGeral
            // 
            this.pcVisaoGeral.Controls.Add(this.btnRiscos);
            this.pcVisaoGeral.Controls.Add(this.btnCustos);
            this.pcVisaoGeral.Controls.Add(this.btnInfoProjeto);
            this.pcVisaoGeral.Controls.Add(this.gridProjetos);
            this.pcVisaoGeral.Location = new System.Drawing.Point(4, 25);
            this.pcVisaoGeral.Margin = new System.Windows.Forms.Padding(4);
            this.pcVisaoGeral.Name = "pcVisaoGeral";
            this.pcVisaoGeral.Padding = new System.Windows.Forms.Padding(4);
            this.pcVisaoGeral.Size = new System.Drawing.Size(1167, 524);
            this.pcVisaoGeral.TabIndex = 0;
            this.pcVisaoGeral.Text = "Visão Geral";
            this.pcVisaoGeral.UseVisualStyleBackColor = true;
            // 
            // btnRiscos
            // 
            this.btnRiscos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRiscos.FlatAppearance.BorderSize = 0;
            this.btnRiscos.Image = ((System.Drawing.Image)(resources.GetObject("btnRiscos.Image")));
            this.btnRiscos.Location = new System.Drawing.Point(233, 17);
            this.btnRiscos.Margin = new System.Windows.Forms.Padding(4);
            this.btnRiscos.Name = "btnRiscos";
            this.btnRiscos.Size = new System.Drawing.Size(77, 70);
            this.btnRiscos.TabIndex = 19;
            this.btnRiscos.UseVisualStyleBackColor = false;
            this.btnRiscos.Click += new System.EventHandler(this.btnRiscos_Click);
            // 
            // btnCustos
            // 
            this.btnCustos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCustos.FlatAppearance.BorderSize = 0;
            this.btnCustos.Image = ((System.Drawing.Image)(resources.GetObject("btnCustos.Image")));
            this.btnCustos.Location = new System.Drawing.Point(125, 17);
            this.btnCustos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustos.Name = "btnCustos";
            this.btnCustos.Size = new System.Drawing.Size(77, 70);
            this.btnCustos.TabIndex = 18;
            this.btnCustos.UseVisualStyleBackColor = false;
            this.btnCustos.Click += new System.EventHandler(this.btnCustos_Click);
            // 
            // btnInfoProjeto
            // 
            this.btnInfoProjeto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfoProjeto.FlatAppearance.BorderSize = 0;
            this.btnInfoProjeto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInfoProjeto.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoProjeto.Image")));
            this.btnInfoProjeto.Location = new System.Drawing.Point(17, 17);
            this.btnInfoProjeto.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfoProjeto.Name = "btnInfoProjeto";
            this.btnInfoProjeto.Size = new System.Drawing.Size(77, 70);
            this.btnInfoProjeto.TabIndex = 17;
            this.btnInfoProjeto.UseVisualStyleBackColor = false;
            this.btnInfoProjeto.Click += new System.EventHandler(this.btnInfoProjeto_Click);
            // 
            // gridProjetos
            // 
            this.gridProjetos.AutoGenerateColumns = false;
            this.gridProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProjetoDataGridViewTextBoxColumn,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataFimDataGridViewTextBoxColumn,
            this.responsavelIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.gridProjetos.DataSource = this.bsProjetos;
            this.gridProjetos.Location = new System.Drawing.Point(0, 106);
            this.gridProjetos.Margin = new System.Windows.Forms.Padding(4);
            this.gridProjetos.Name = "gridProjetos";
            this.gridProjetos.Size = new System.Drawing.Size(1147, 407);
            this.gridProjetos.TabIndex = 16;
            this.gridProjetos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // pcInfoProjeto
            // 
            this.pcInfoProjeto.Controls.Add(this.panelInfo);
            this.pcInfoProjeto.Location = new System.Drawing.Point(4, 25);
            this.pcInfoProjeto.Margin = new System.Windows.Forms.Padding(4);
            this.pcInfoProjeto.Name = "pcInfoProjeto";
            this.pcInfoProjeto.Padding = new System.Windows.Forms.Padding(4);
            this.pcInfoProjeto.Size = new System.Drawing.Size(1167, 524);
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
            this.panelInfo.Controls.Add(this.txtIdProjeto);
            this.panelInfo.Controls.Add(this.txtResponsavelId);
            this.panelInfo.Controls.Add(this.txtNomeProjeto);
            this.panelInfo.Controls.Add(this.dateInicioProjeto);
            this.panelInfo.Controls.Add(this.dateFimProjeto);
            this.panelInfo.Location = new System.Drawing.Point(8, 7);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(484, 439);
            this.panelInfo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Responsável";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data de Finalização";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data de Ínicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome do Projeto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id";
            // 
            // txtIdProjeto
            // 
            this.txtIdProjeto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "Id", true));
            this.txtIdProjeto.Enabled = false;
            this.txtIdProjeto.Location = new System.Drawing.Point(148, 4);
            this.txtIdProjeto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProjeto.Name = "txtIdProjeto";
            this.txtIdProjeto.Size = new System.Drawing.Size(132, 23);
            this.txtIdProjeto.TabIndex = 1;
            // 
            // txtResponsavelId
            // 
            this.txtResponsavelId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "ResponsavelId", true));
            this.txtResponsavelId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtResponsavelId.Location = new System.Drawing.Point(148, 138);
            this.txtResponsavelId.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponsavelId.Name = "txtResponsavelId";
            this.txtResponsavelId.Size = new System.Drawing.Size(132, 23);
            this.txtResponsavelId.TabIndex = 5;
            this.txtResponsavelId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResponsavelId_KeyPress);
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "NomeProjeto", true));
            this.txtNomeProjeto.Location = new System.Drawing.Point(148, 36);
            this.txtNomeProjeto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Size = new System.Drawing.Size(132, 23);
            this.txtNomeProjeto.TabIndex = 2;
            this.txtNomeProjeto.TextChanged += new System.EventHandler(this.txtNomeProjeto_TextChanged);
            // 
            // dateInicioProjeto
            // 
            this.dateInicioProjeto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "DataInicio", true));
            this.dateInicioProjeto.Location = new System.Drawing.Point(148, 68);
            this.dateInicioProjeto.Margin = new System.Windows.Forms.Padding(4);
            this.dateInicioProjeto.Name = "dateInicioProjeto";
            this.dateInicioProjeto.Size = new System.Drawing.Size(265, 23);
            this.dateInicioProjeto.TabIndex = 3;
            // 
            // dateFimProjeto
            // 
            this.dateFimProjeto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "DataFim", true));
            this.dateFimProjeto.Location = new System.Drawing.Point(148, 106);
            this.dateFimProjeto.Margin = new System.Windows.Forms.Padding(4);
            this.dateFimProjeto.Name = "dateFimProjeto";
            this.dateFimProjeto.Size = new System.Drawing.Size(265, 23);
            this.dateFimProjeto.TabIndex = 4;
            // 
            // pcCustos
            // 
            this.pcCustos.Controls.Add(this.panelCustos);
            this.pcCustos.Location = new System.Drawing.Point(4, 25);
            this.pcCustos.Margin = new System.Windows.Forms.Padding(4);
            this.pcCustos.Name = "pcCustos";
            this.pcCustos.Padding = new System.Windows.Forms.Padding(4);
            this.pcCustos.Size = new System.Drawing.Size(1167, 524);
            this.pcCustos.TabIndex = 3;
            this.pcCustos.Text = "Plano de Custos";
            this.pcCustos.UseVisualStyleBackColor = true;
            // 
            // panelCustos
            // 
            this.panelCustos.Controls.Add(this.button1);
            this.panelCustos.Controls.Add(this.panelInfoCustos);
            this.panelCustos.Controls.Add(this.btnExcluiCusto);
            this.panelCustos.Controls.Add(this.btnNovoCusto);
            this.panelCustos.Controls.Add(this.btnCancelaCusto);
            this.panelCustos.Controls.Add(this.btnSalvaCusto);
            this.panelCustos.Controls.Add(this.gridCustos);
            this.panelCustos.Location = new System.Drawing.Point(9, 15);
            this.panelCustos.Margin = new System.Windows.Forms.Padding(4);
            this.panelCustos.Name = "panelCustos";
            this.panelCustos.Size = new System.Drawing.Size(1151, 491);
            this.panelCustos.TabIndex = 1;
            this.panelCustos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCustos_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(679, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 57);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelInfoCustos
            // 
            this.panelInfoCustos.Controls.Add(this.btnPesquisaCusto);
            this.panelInfoCustos.Controls.Add(this.txtVlrPrevCusto);
            this.panelInfoCustos.Controls.Add(this.txtVlrRealCusto);
            this.panelInfoCustos.Controls.Add(this.txtQtdRealCusto);
            this.panelInfoCustos.Controls.Add(this.txtQtdPrevCusto);
            this.panelInfoCustos.Controls.Add(this.txtObservacaoCusto);
            this.panelInfoCustos.Controls.Add(this.txtDescricaoCusto);
            this.panelInfoCustos.Controls.Add(this.txtidGastoOrigem);
            this.panelInfoCustos.Controls.Add(this.txtIdprojetoCusto);
            this.panelInfoCustos.Controls.Add(this.txtIdCusto);
            this.panelInfoCustos.Controls.Add(this.label15);
            this.panelInfoCustos.Controls.Add(this.label14);
            this.panelInfoCustos.Controls.Add(this.label13);
            this.panelInfoCustos.Controls.Add(this.label11);
            this.panelInfoCustos.Controls.Add(this.label10);
            this.panelInfoCustos.Controls.Add(this.label8);
            this.panelInfoCustos.Controls.Add(this.label7);
            this.panelInfoCustos.Controls.Add(this.label3);
            this.panelInfoCustos.Location = new System.Drawing.Point(753, 4);
            this.panelInfoCustos.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfoCustos.Name = "panelInfoCustos";
            this.panelInfoCustos.Size = new System.Drawing.Size(381, 466);
            this.panelInfoCustos.TabIndex = 1;
            // 
            // btnPesquisaCusto
            // 
            this.btnPesquisaCusto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisaCusto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCusto.BackgroundImage")));
            this.btnPesquisaCusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisaCusto.FlatAppearance.BorderSize = 0;
            this.btnPesquisaCusto.Location = new System.Drawing.Point(101, 58);
            this.btnPesquisaCusto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaCusto.Name = "btnPesquisaCusto";
            this.btnPesquisaCusto.Size = new System.Drawing.Size(40, 34);
            this.btnPesquisaCusto.TabIndex = 3;
            this.btnPesquisaCusto.UseVisualStyleBackColor = false;
            this.btnPesquisaCusto.Click += new System.EventHandler(this.btnPesquisaCusto_Click);
            // 
            // txtVlrPrevCusto
            // 
            this.txtVlrPrevCusto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGastos, "ValorUnitarioPrevisto", true));
            this.txtVlrPrevCusto.Location = new System.Drawing.Point(142, 302);
            this.txtVlrPrevCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtVlrPrevCusto.Name = "txtVlrPrevCusto";
            this.txtVlrPrevCusto.Size = new System.Drawing.Size(88, 23);
            this.txtVlrPrevCusto.TabIndex = 6;
            // 
            // bsGastos
            // 
            this.bsGastos.DataSource = typeof(App.DTO.GastosProjetosGastos);
            // 
            // txtVlrRealCusto
            // 
            this.txtVlrRealCusto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGastos, "ValorUnitarioReal", true));
            this.txtVlrRealCusto.Location = new System.Drawing.Point(142, 373);
            this.txtVlrRealCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtVlrRealCusto.Name = "txtVlrRealCusto";
            this.txtVlrRealCusto.Size = new System.Drawing.Size(88, 23);
            this.txtVlrRealCusto.TabIndex = 8;
            // 
            // txtQtdRealCusto
            // 
            this.txtQtdRealCusto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGastos, "QuantidadeReal", true));
            this.txtQtdRealCusto.Location = new System.Drawing.Point(142, 344);
            this.txtQtdRealCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdRealCusto.Name = "txtQtdRealCusto";
            this.txtQtdRealCusto.Size = new System.Drawing.Size(88, 23);
            this.txtQtdRealCusto.TabIndex = 7;
            // 
            // txtQtdPrevCusto
            // 
            this.txtQtdPrevCusto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGastos, "QuantidadePrevista", true));
            this.txtQtdPrevCusto.Location = new System.Drawing.Point(142, 275);
            this.txtQtdPrevCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdPrevCusto.Name = "txtQtdPrevCusto";
            this.txtQtdPrevCusto.Size = new System.Drawing.Size(88, 23);
            this.txtQtdPrevCusto.TabIndex = 5;
            // 
            // txtObservacaoCusto
            // 
            this.txtObservacaoCusto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGastos, "Observacao", true));
            this.txtObservacaoCusto.Location = new System.Drawing.Point(11, 139);
            this.txtObservacaoCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacaoCusto.Multiline = true;
            this.txtObservacaoCusto.Name = "txtObservacaoCusto";
            this.txtObservacaoCusto.Size = new System.Drawing.Size(351, 131);
            this.txtObservacaoCusto.TabIndex = 4;
            // 
            // txtDescricaoCusto
            // 
            this.txtDescricaoCusto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGastos, "Descricao", true));
            this.txtDescricaoCusto.Enabled = false;
            this.txtDescricaoCusto.Location = new System.Drawing.Point(207, 63);
            this.txtDescricaoCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricaoCusto.Name = "txtDescricaoCusto";
            this.txtDescricaoCusto.Size = new System.Drawing.Size(155, 23);
            this.txtDescricaoCusto.TabIndex = 13;
            this.txtDescricaoCusto.TabStop = false;
            // 
            // txtidGastoOrigem
            // 
            this.txtidGastoOrigem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGastos, "GastoId", true));
            this.txtidGastoOrigem.Enabled = false;
            this.txtidGastoOrigem.Location = new System.Drawing.Point(155, 63);
            this.txtidGastoOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtidGastoOrigem.Name = "txtidGastoOrigem";
            this.txtidGastoOrigem.Size = new System.Drawing.Size(44, 23);
            this.txtidGastoOrigem.TabIndex = 12;
            this.txtidGastoOrigem.TabStop = false;
            // 
            // txtIdprojetoCusto
            // 
            this.txtIdprojetoCusto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGastos, "ProjetosId", true));
            this.txtIdprojetoCusto.Enabled = false;
            this.txtIdprojetoCusto.Location = new System.Drawing.Point(239, 15);
            this.txtIdprojetoCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdprojetoCusto.Name = "txtIdprojetoCusto";
            this.txtIdprojetoCusto.Size = new System.Drawing.Size(88, 23);
            this.txtIdprojetoCusto.TabIndex = 2;
            // 
            // txtIdCusto
            // 
            this.txtIdCusto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGastos, "Id", true));
            this.txtIdCusto.Enabled = false;
            this.txtIdCusto.Location = new System.Drawing.Point(33, 15);
            this.txtIdCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCusto.Name = "txtIdCusto";
            this.txtIdCusto.Size = new System.Drawing.Size(88, 23);
            this.txtIdCusto.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 305);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Valor Previsto Unit.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 376);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Valor Real Unit.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 347);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Quantidade Real";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 278);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Quantidade Prevista";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Observação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Id Projetos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gasto Fonte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id";
            // 
            // btnExcluiCusto
            // 
            this.btnExcluiCusto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluiCusto.FlatAppearance.BorderSize = 0;
            this.btnExcluiCusto.Location = new System.Drawing.Point(240, 16);
            this.btnExcluiCusto.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluiCusto.Name = "btnExcluiCusto";
            this.btnExcluiCusto.Size = new System.Drawing.Size(76, 48);
            this.btnExcluiCusto.TabIndex = 5;
            this.btnExcluiCusto.Text = "Excluir";
            this.btnExcluiCusto.UseVisualStyleBackColor = false;
            this.btnExcluiCusto.Click += new System.EventHandler(this.btnExcluiCusto_Click);
            // 
            // btnNovoCusto
            // 
            this.btnNovoCusto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovoCusto.FlatAppearance.BorderSize = 0;
            this.btnNovoCusto.Location = new System.Drawing.Point(4, 16);
            this.btnNovoCusto.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoCusto.Name = "btnNovoCusto";
            this.btnNovoCusto.Size = new System.Drawing.Size(76, 48);
            this.btnNovoCusto.TabIndex = 2;
            this.btnNovoCusto.Text = "Novo";
            this.btnNovoCusto.UseVisualStyleBackColor = false;
            this.btnNovoCusto.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // btnCancelaCusto
            // 
            this.btnCancelaCusto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelaCusto.FlatAppearance.BorderSize = 0;
            this.btnCancelaCusto.Location = new System.Drawing.Point(161, 16);
            this.btnCancelaCusto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelaCusto.Name = "btnCancelaCusto";
            this.btnCancelaCusto.Size = new System.Drawing.Size(76, 48);
            this.btnCancelaCusto.TabIndex = 4;
            this.btnCancelaCusto.Text = "Cancelar";
            this.btnCancelaCusto.UseVisualStyleBackColor = false;
            this.btnCancelaCusto.Click += new System.EventHandler(this.btnCancelaCusto_Click);
            // 
            // btnSalvaCusto
            // 
            this.btnSalvaCusto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvaCusto.FlatAppearance.BorderSize = 0;
            this.btnSalvaCusto.Location = new System.Drawing.Point(83, 16);
            this.btnSalvaCusto.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvaCusto.Name = "btnSalvaCusto";
            this.btnSalvaCusto.Size = new System.Drawing.Size(76, 48);
            this.btnSalvaCusto.TabIndex = 3;
            this.btnSalvaCusto.Text = "Salvar";
            this.btnSalvaCusto.UseVisualStyleBackColor = false;
            this.btnSalvaCusto.Click += new System.EventHandler(this.btnSalvaCusto_Click);
            // 
            // gridCustos
            // 
            this.gridCustos.AutoGenerateColumns = false;
            this.gridCustos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.descricaoDataGridViewTextBoxColumn,
            this.gastoIdDataGridViewTextBoxColumn,
            this.projetosIdDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.quantidadePrevistaDataGridViewTextBoxColumn,
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn,
            this.quantidadeRealDataGridViewTextBoxColumn,
            this.valorUnitarioRealDataGridViewTextBoxColumn});
            this.gridCustos.DataSource = this.bsGastos;
            this.gridCustos.Location = new System.Drawing.Point(3, 70);
            this.gridCustos.Margin = new System.Windows.Forms.Padding(4);
            this.gridCustos.Name = "gridCustos";
            this.gridCustos.ReadOnly = true;
            this.gridCustos.Size = new System.Drawing.Size(743, 409);
            this.gridCustos.TabIndex = 24;
            this.gridCustos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gastoIdDataGridViewTextBoxColumn
            // 
            this.gastoIdDataGridViewTextBoxColumn.DataPropertyName = "GastoId";
            this.gastoIdDataGridViewTextBoxColumn.HeaderText = "GastoId";
            this.gastoIdDataGridViewTextBoxColumn.Name = "gastoIdDataGridViewTextBoxColumn";
            this.gastoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projetosIdDataGridViewTextBoxColumn
            // 
            this.projetosIdDataGridViewTextBoxColumn.DataPropertyName = "ProjetosId";
            this.projetosIdDataGridViewTextBoxColumn.HeaderText = "ProjetosId";
            this.projetosIdDataGridViewTextBoxColumn.Name = "projetosIdDataGridViewTextBoxColumn";
            this.projetosIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadePrevistaDataGridViewTextBoxColumn
            // 
            this.quantidadePrevistaDataGridViewTextBoxColumn.DataPropertyName = "QuantidadePrevista";
            this.quantidadePrevistaDataGridViewTextBoxColumn.HeaderText = "QuantidadePrevista";
            this.quantidadePrevistaDataGridViewTextBoxColumn.Name = "quantidadePrevistaDataGridViewTextBoxColumn";
            this.quantidadePrevistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorUnitarioPrevistoDataGridViewTextBoxColumn
            // 
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitarioPrevisto";
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn.HeaderText = "ValorUnitarioPrevisto";
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn.Name = "valorUnitarioPrevistoDataGridViewTextBoxColumn";
            this.valorUnitarioPrevistoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeRealDataGridViewTextBoxColumn
            // 
            this.quantidadeRealDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeReal";
            this.quantidadeRealDataGridViewTextBoxColumn.HeaderText = "QuantidadeReal";
            this.quantidadeRealDataGridViewTextBoxColumn.Name = "quantidadeRealDataGridViewTextBoxColumn";
            this.quantidadeRealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorUnitarioRealDataGridViewTextBoxColumn
            // 
            this.valorUnitarioRealDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitarioReal";
            this.valorUnitarioRealDataGridViewTextBoxColumn.HeaderText = "ValorUnitarioReal";
            this.valorUnitarioRealDataGridViewTextBoxColumn.Name = "valorUnitarioRealDataGridViewTextBoxColumn";
            this.valorUnitarioRealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pcRiscos
            // 
            this.pcRiscos.Controls.Add(this.tabRiscos);
            this.pcRiscos.Location = new System.Drawing.Point(4, 25);
            this.pcRiscos.Margin = new System.Windows.Forms.Padding(4);
            this.pcRiscos.Name = "pcRiscos";
            this.pcRiscos.Padding = new System.Windows.Forms.Padding(4);
            this.pcRiscos.Size = new System.Drawing.Size(1167, 524);
            this.pcRiscos.TabIndex = 5;
            this.pcRiscos.Text = "Plano de Riscos";
            this.pcRiscos.UseVisualStyleBackColor = true;
            // 
            // tabRiscos
            // 
            this.tabRiscos.Controls.Add(this.pcListaRiscos);
            this.tabRiscos.Controls.Add(this.pcScore);
            this.tabRiscos.Location = new System.Drawing.Point(8, 7);
            this.tabRiscos.Margin = new System.Windows.Forms.Padding(4);
            this.tabRiscos.Name = "tabRiscos";
            this.tabRiscos.SelectedIndex = 0;
            this.tabRiscos.Size = new System.Drawing.Size(1148, 506);
            this.tabRiscos.TabIndex = 0;
            // 
            // pcListaRiscos
            // 
            this.pcListaRiscos.Controls.Add(this.btnExcluiRisco);
            this.pcListaRiscos.Controls.Add(this.btnNovoRisco);
            this.pcListaRiscos.Controls.Add(this.btnCancelaRisco);
            this.pcListaRiscos.Controls.Add(this.btnSalvaRisco);
            this.pcListaRiscos.Controls.Add(this.panelInfoRisco);
            this.pcListaRiscos.Controls.Add(this.gridRiscos);
            this.pcListaRiscos.Location = new System.Drawing.Point(4, 25);
            this.pcListaRiscos.Margin = new System.Windows.Forms.Padding(4);
            this.pcListaRiscos.Name = "pcListaRiscos";
            this.pcListaRiscos.Padding = new System.Windows.Forms.Padding(4);
            this.pcListaRiscos.Size = new System.Drawing.Size(1140, 477);
            this.pcListaRiscos.TabIndex = 0;
            this.pcListaRiscos.Text = "Lista de Riscos";
            this.pcListaRiscos.UseVisualStyleBackColor = true;
            this.pcListaRiscos.Enter += new System.EventHandler(this.pcListaRiscos_Enter);
            // 
            // btnExcluiRisco
            // 
            this.btnExcluiRisco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluiRisco.FlatAppearance.BorderSize = 0;
            this.btnExcluiRisco.Location = new System.Drawing.Point(244, 18);
            this.btnExcluiRisco.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluiRisco.Name = "btnExcluiRisco";
            this.btnExcluiRisco.Size = new System.Drawing.Size(76, 48);
            this.btnExcluiRisco.TabIndex = 5;
            this.btnExcluiRisco.Text = "Excluir";
            this.btnExcluiRisco.UseVisualStyleBackColor = false;
            this.btnExcluiRisco.Click += new System.EventHandler(this.btnExcluiRisco_Click);
            // 
            // btnNovoRisco
            // 
            this.btnNovoRisco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovoRisco.FlatAppearance.BorderSize = 0;
            this.btnNovoRisco.Location = new System.Drawing.Point(8, 18);
            this.btnNovoRisco.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoRisco.Name = "btnNovoRisco";
            this.btnNovoRisco.Size = new System.Drawing.Size(76, 48);
            this.btnNovoRisco.TabIndex = 2;
            this.btnNovoRisco.Text = "Novo";
            this.btnNovoRisco.UseVisualStyleBackColor = false;
            this.btnNovoRisco.Click += new System.EventHandler(this.btnNovoRisco_Click);
            // 
            // btnCancelaRisco
            // 
            this.btnCancelaRisco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelaRisco.FlatAppearance.BorderSize = 0;
            this.btnCancelaRisco.Location = new System.Drawing.Point(165, 18);
            this.btnCancelaRisco.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelaRisco.Name = "btnCancelaRisco";
            this.btnCancelaRisco.Size = new System.Drawing.Size(76, 48);
            this.btnCancelaRisco.TabIndex = 4;
            this.btnCancelaRisco.Text = "Cancelar";
            this.btnCancelaRisco.UseVisualStyleBackColor = false;
            this.btnCancelaRisco.Click += new System.EventHandler(this.btnCancelaRisco_Click);
            // 
            // btnSalvaRisco
            // 
            this.btnSalvaRisco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvaRisco.FlatAppearance.BorderSize = 0;
            this.btnSalvaRisco.Location = new System.Drawing.Point(87, 18);
            this.btnSalvaRisco.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvaRisco.Name = "btnSalvaRisco";
            this.btnSalvaRisco.Size = new System.Drawing.Size(76, 48);
            this.btnSalvaRisco.TabIndex = 3;
            this.btnSalvaRisco.Text = "Salvar";
            this.btnSalvaRisco.UseVisualStyleBackColor = false;
            this.btnSalvaRisco.Click += new System.EventHandler(this.btnSalvaRisco_Click);
            // 
            // panelInfoRisco
            // 
            this.panelInfoRisco.Controls.Add(this.btnPesquisaRisco);
            this.panelInfoRisco.Controls.Add(this.txtPlanoContigenciaRiscoOrigem);
            this.panelInfoRisco.Controls.Add(this.txtMedidaPrevRiscoOrigem);
            this.panelInfoRisco.Controls.Add(this.txtDescricaoRisco);
            this.panelInfoRisco.Controls.Add(this.label27);
            this.panelInfoRisco.Controls.Add(this.txtProbabilidadeRisco);
            this.panelInfoRisco.Controls.Add(this.txtImpactoRisco);
            this.panelInfoRisco.Controls.Add(this.label25);
            this.panelInfoRisco.Controls.Add(this.label26);
            this.panelInfoRisco.Controls.Add(this.txtDescricaoRiscoOrigem);
            this.panelInfoRisco.Controls.Add(this.label24);
            this.panelInfoRisco.Controls.Add(this.label17);
            this.panelInfoRisco.Controls.Add(this.label16);
            this.panelInfoRisco.Controls.Add(this.txtPrevistoRisco);
            this.panelInfoRisco.Controls.Add(this.txtScoreRisco);
            this.panelInfoRisco.Controls.Add(this.txtObservacaoRisco);
            this.panelInfoRisco.Controls.Add(this.txtNomeRisco);
            this.panelInfoRisco.Controls.Add(this.txtIdRiscoOrigem);
            this.panelInfoRisco.Controls.Add(this.txtIdprojetoRisco);
            this.panelInfoRisco.Controls.Add(this.txtIdRisco);
            this.panelInfoRisco.Controls.Add(this.label12);
            this.panelInfoRisco.Controls.Add(this.label18);
            this.panelInfoRisco.Controls.Add(this.label19);
            this.panelInfoRisco.Controls.Add(this.label21);
            this.panelInfoRisco.Controls.Add(this.label22);
            this.panelInfoRisco.Controls.Add(this.label23);
            this.panelInfoRisco.Location = new System.Drawing.Point(640, 7);
            this.panelInfoRisco.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfoRisco.Name = "panelInfoRisco";
            this.panelInfoRisco.Size = new System.Drawing.Size(440, 466);
            this.panelInfoRisco.TabIndex = 1;
            // 
            // btnPesquisaRisco
            // 
            this.btnPesquisaRisco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisaRisco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaRisco.BackgroundImage")));
            this.btnPesquisaRisco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisaRisco.FlatAppearance.BorderSize = 0;
            this.btnPesquisaRisco.Location = new System.Drawing.Point(94, 52);
            this.btnPesquisaRisco.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaRisco.Name = "btnPesquisaRisco";
            this.btnPesquisaRisco.Size = new System.Drawing.Size(40, 34);
            this.btnPesquisaRisco.TabIndex = 1;
            this.btnPesquisaRisco.UseVisualStyleBackColor = false;
            this.btnPesquisaRisco.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlanoContigenciaRiscoOrigem
            // 
            this.txtPlanoContigenciaRiscoOrigem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "PlanoContigencia", true));
            this.txtPlanoContigenciaRiscoOrigem.Enabled = false;
            this.txtPlanoContigenciaRiscoOrigem.Location = new System.Drawing.Point(145, 157);
            this.txtPlanoContigenciaRiscoOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlanoContigenciaRiscoOrigem.Name = "txtPlanoContigenciaRiscoOrigem";
            this.txtPlanoContigenciaRiscoOrigem.Size = new System.Drawing.Size(281, 23);
            this.txtPlanoContigenciaRiscoOrigem.TabIndex = 30;
            // 
            // bsRiscos
            // 
            this.bsRiscos.DataSource = typeof(App.DTO.RiscosProjetosRiscos);
            // 
            // txtMedidaPrevRiscoOrigem
            // 
            this.txtMedidaPrevRiscoOrigem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "MedidaPreventiva", true));
            this.txtMedidaPrevRiscoOrigem.Enabled = false;
            this.txtMedidaPrevRiscoOrigem.Location = new System.Drawing.Point(145, 128);
            this.txtMedidaPrevRiscoOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedidaPrevRiscoOrigem.Name = "txtMedidaPrevRiscoOrigem";
            this.txtMedidaPrevRiscoOrigem.Size = new System.Drawing.Size(281, 23);
            this.txtMedidaPrevRiscoOrigem.TabIndex = 29;
            // 
            // txtDescricaoRisco
            // 
            this.txtDescricaoRisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Descricao", true));
            this.txtDescricaoRisco.Enabled = false;
            this.txtDescricaoRisco.Location = new System.Drawing.Point(145, 208);
            this.txtDescricaoRisco.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricaoRisco.Name = "txtDescricaoRisco";
            this.txtDescricaoRisco.Size = new System.Drawing.Size(281, 23);
            this.txtDescricaoRisco.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 213);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(139, 17);
            this.label27.TabIndex = 28;
            this.label27.Text = "Descrição Específica";
            // 
            // txtProbabilidadeRisco
            // 
            this.txtProbabilidadeRisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Probabilidade", true));
            this.txtProbabilidadeRisco.Location = new System.Drawing.Point(316, 426);
            this.txtProbabilidadeRisco.Margin = new System.Windows.Forms.Padding(4);
            this.txtProbabilidadeRisco.Name = "txtProbabilidadeRisco";
            this.txtProbabilidadeRisco.Size = new System.Drawing.Size(88, 23);
            this.txtProbabilidadeRisco.TabIndex = 7;
            // 
            // txtImpactoRisco
            // 
            this.txtImpactoRisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Impacto", true));
            this.txtImpactoRisco.Location = new System.Drawing.Point(316, 398);
            this.txtImpactoRisco.Margin = new System.Windows.Forms.Padding(4);
            this.txtImpactoRisco.Name = "txtImpactoRisco";
            this.txtImpactoRisco.Size = new System.Drawing.Size(88, 23);
            this.txtImpactoRisco.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(214, 428);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 17);
            this.label25.TabIndex = 25;
            this.label25.Text = "Probabilidade";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(214, 401);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 17);
            this.label26.TabIndex = 24;
            this.label26.Text = "Impacto";
            // 
            // txtDescricaoRiscoOrigem
            // 
            this.txtDescricaoRiscoOrigem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "DescricaoRiscos", true));
            this.txtDescricaoRiscoOrigem.Enabled = false;
            this.txtDescricaoRiscoOrigem.Location = new System.Drawing.Point(98, 89);
            this.txtDescricaoRiscoOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricaoRiscoOrigem.Name = "txtDescricaoRiscoOrigem";
            this.txtDescricaoRiscoOrigem.Size = new System.Drawing.Size(328, 23);
            this.txtDescricaoRiscoOrigem.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 95);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 17);
            this.label24.TabIndex = 22;
            this.label24.Text = "Descrição";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 160);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "Plano Contigência";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 133);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "Medida Preventiva";
            // 
            // txtPrevistoRisco
            // 
            this.txtPrevistoRisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Previsto", true));
            this.txtPrevistoRisco.Location = new System.Drawing.Point(117, 425);
            this.txtPrevistoRisco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrevistoRisco.Name = "txtPrevistoRisco";
            this.txtPrevistoRisco.Size = new System.Drawing.Size(88, 23);
            this.txtPrevistoRisco.TabIndex = 5;
            // 
            // txtScoreRisco
            // 
            this.txtScoreRisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Score", true));
            this.txtScoreRisco.Location = new System.Drawing.Point(117, 398);
            this.txtScoreRisco.Margin = new System.Windows.Forms.Padding(4);
            this.txtScoreRisco.Name = "txtScoreRisco";
            this.txtScoreRisco.Size = new System.Drawing.Size(88, 23);
            this.txtScoreRisco.TabIndex = 4;
            // 
            // txtObservacaoRisco
            // 
            this.txtObservacaoRisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Observacao", true));
            this.txtObservacaoRisco.Location = new System.Drawing.Point(12, 262);
            this.txtObservacaoRisco.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacaoRisco.Multiline = true;
            this.txtObservacaoRisco.Name = "txtObservacaoRisco";
            this.txtObservacaoRisco.Size = new System.Drawing.Size(414, 131);
            this.txtObservacaoRisco.TabIndex = 3;
            // 
            // txtNomeRisco
            // 
            this.txtNomeRisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Nome", true));
            this.txtNomeRisco.Enabled = false;
            this.txtNomeRisco.Location = new System.Drawing.Point(213, 60);
            this.txtNomeRisco.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeRisco.Name = "txtNomeRisco";
            this.txtNomeRisco.Size = new System.Drawing.Size(213, 23);
            this.txtNomeRisco.TabIndex = 13;
            // 
            // txtIdRiscoOrigem
            // 
            this.txtIdRiscoOrigem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "RiscoId", true));
            this.txtIdRiscoOrigem.Enabled = false;
            this.txtIdRiscoOrigem.Location = new System.Drawing.Point(142, 60);
            this.txtIdRiscoOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdRiscoOrigem.Name = "txtIdRiscoOrigem";
            this.txtIdRiscoOrigem.Size = new System.Drawing.Size(63, 23);
            this.txtIdRiscoOrigem.TabIndex = 12;
            // 
            // txtIdprojetoRisco
            // 
            this.txtIdprojetoRisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "ProjetosId", true));
            this.txtIdprojetoRisco.Enabled = false;
            this.txtIdprojetoRisco.Location = new System.Drawing.Point(239, 15);
            this.txtIdprojetoRisco.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdprojetoRisco.Name = "txtIdprojetoRisco";
            this.txtIdprojetoRisco.Size = new System.Drawing.Size(88, 23);
            this.txtIdprojetoRisco.TabIndex = 11;
            // 
            // txtIdRisco
            // 
            this.txtIdRisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRiscos, "Id", true));
            this.txtIdRisco.Enabled = false;
            this.txtIdRisco.Location = new System.Drawing.Point(33, 15);
            this.txtIdRisco.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdRisco.Name = "txtIdRisco";
            this.txtIdRisco.Size = new System.Drawing.Size(88, 23);
            this.txtIdRisco.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 428);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Previsto?";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 401);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "Score";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 242);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "Observação";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(155, 18);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 17);
            this.label21.TabIndex = 2;
            this.label21.Text = "Id Projetos";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 61);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "Risco Fonte";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 18);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(19, 17);
            this.label23.TabIndex = 0;
            this.label23.Text = "Id";
            // 
            // gridRiscos
            // 
            this.gridRiscos.AutoGenerateColumns = false;
            this.gridRiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRiscos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.riscoIdDataGridViewTextBoxColumn,
            this.projetosIdDataGridViewTextBoxColumn1,
            this.descricaoDataGridViewTextBoxColumn1,
            this.observacaoDataGridViewTextBoxColumn1,
            this.scoreDataGridViewTextBoxColumn,
            this.impactoDataGridViewTextBoxColumn,
            this.probabilidadeDataGridViewTextBoxColumn,
            this.previstoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoRiscosDataGridViewTextBoxColumn,
            this.medidaPreventivaDataGridViewTextBoxColumn,
            this.planoContigenciaDataGridViewTextBoxColumn});
            this.gridRiscos.DataSource = this.bsRiscos;
            this.gridRiscos.Location = new System.Drawing.Point(8, 74);
            this.gridRiscos.Margin = new System.Windows.Forms.Padding(4);
            this.gridRiscos.Name = "gridRiscos";
            this.gridRiscos.ReadOnly = true;
            this.gridRiscos.Size = new System.Drawing.Size(611, 393);
            this.gridRiscos.TabIndex = 0;
            this.gridRiscos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            this.gridRiscos.DoubleClick += new System.EventHandler(this.dataGridView3_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // riscoIdDataGridViewTextBoxColumn
            // 
            this.riscoIdDataGridViewTextBoxColumn.DataPropertyName = "RiscoId";
            this.riscoIdDataGridViewTextBoxColumn.HeaderText = "RiscoId";
            this.riscoIdDataGridViewTextBoxColumn.Name = "riscoIdDataGridViewTextBoxColumn";
            this.riscoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projetosIdDataGridViewTextBoxColumn1
            // 
            this.projetosIdDataGridViewTextBoxColumn1.DataPropertyName = "ProjetosId";
            this.projetosIdDataGridViewTextBoxColumn1.HeaderText = "ProjetosId";
            this.projetosIdDataGridViewTextBoxColumn1.Name = "projetosIdDataGridViewTextBoxColumn1";
            this.projetosIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn1
            // 
            this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn1.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
            this.descricaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn1
            // 
            this.observacaoDataGridViewTextBoxColumn1.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn1.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn1.Name = "observacaoDataGridViewTextBoxColumn1";
            this.observacaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // impactoDataGridViewTextBoxColumn
            // 
            this.impactoDataGridViewTextBoxColumn.DataPropertyName = "Impacto";
            this.impactoDataGridViewTextBoxColumn.HeaderText = "Impacto";
            this.impactoDataGridViewTextBoxColumn.Name = "impactoDataGridViewTextBoxColumn";
            this.impactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // probabilidadeDataGridViewTextBoxColumn
            // 
            this.probabilidadeDataGridViewTextBoxColumn.DataPropertyName = "Probabilidade";
            this.probabilidadeDataGridViewTextBoxColumn.HeaderText = "Probabilidade";
            this.probabilidadeDataGridViewTextBoxColumn.Name = "probabilidadeDataGridViewTextBoxColumn";
            this.probabilidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // previstoDataGridViewTextBoxColumn
            // 
            this.previstoDataGridViewTextBoxColumn.DataPropertyName = "Previsto";
            this.previstoDataGridViewTextBoxColumn.HeaderText = "Previsto";
            this.previstoDataGridViewTextBoxColumn.Name = "previstoDataGridViewTextBoxColumn";
            this.previstoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoRiscosDataGridViewTextBoxColumn
            // 
            this.descricaoRiscosDataGridViewTextBoxColumn.DataPropertyName = "DescricaoRiscos";
            this.descricaoRiscosDataGridViewTextBoxColumn.HeaderText = "DescricaoRiscos";
            this.descricaoRiscosDataGridViewTextBoxColumn.Name = "descricaoRiscosDataGridViewTextBoxColumn";
            this.descricaoRiscosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medidaPreventivaDataGridViewTextBoxColumn
            // 
            this.medidaPreventivaDataGridViewTextBoxColumn.DataPropertyName = "MedidaPreventiva";
            this.medidaPreventivaDataGridViewTextBoxColumn.HeaderText = "MedidaPreventiva";
            this.medidaPreventivaDataGridViewTextBoxColumn.Name = "medidaPreventivaDataGridViewTextBoxColumn";
            this.medidaPreventivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planoContigenciaDataGridViewTextBoxColumn
            // 
            this.planoContigenciaDataGridViewTextBoxColumn.DataPropertyName = "PlanoContigencia";
            this.planoContigenciaDataGridViewTextBoxColumn.HeaderText = "PlanoContigencia";
            this.planoContigenciaDataGridViewTextBoxColumn.Name = "planoContigenciaDataGridViewTextBoxColumn";
            this.planoContigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pcScore
            // 
            this.pcScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcScore.BackgroundImage")));
            this.pcScore.Controls.Add(this.btnSalvaScore);
            this.pcScore.Controls.Add(this.label29);
            this.pcScore.Controls.Add(this.label28);
            this.pcScore.Location = new System.Drawing.Point(4, 25);
            this.pcScore.Margin = new System.Windows.Forms.Padding(4);
            this.pcScore.Name = "pcScore";
            this.pcScore.Padding = new System.Windows.Forms.Padding(4);
            this.pcScore.Size = new System.Drawing.Size(1140, 477);
            this.pcScore.TabIndex = 1;
            this.pcScore.Text = "Score";
            this.pcScore.UseVisualStyleBackColor = true;
            this.pcScore.Click += new System.EventHandler(this.pcScore_Click);
            this.pcScore.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnSalvaScore
            // 
            this.btnSalvaScore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvaScore.FlatAppearance.BorderSize = 0;
            this.btnSalvaScore.Location = new System.Drawing.Point(309, 8);
            this.btnSalvaScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvaScore.Name = "btnSalvaScore";
            this.btnSalvaScore.Size = new System.Drawing.Size(76, 48);
            this.btnSalvaScore.TabIndex = 32;
            this.btnSalvaScore.Text = "Salvar Score";
            this.btnSalvaScore.UseVisualStyleBackColor = false;
            this.btnSalvaScore.Click += new System.EventHandler(this.btnSalvaScore_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.Location = new System.Drawing.Point(328, 172);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 17);
            this.label29.TabIndex = 1;
            this.label29.Text = "Impacto";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(563, 386);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 17);
            this.label28.TabIndex = 0;
            this.label28.Text = "Probabilidade";
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.AutoSize = true;
            this.lblNomeProjeto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjetos, "NomeProjeto", true));
            this.lblNomeProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProjeto.Location = new System.Drawing.Point(279, 11);
            this.lblNomeProjeto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(176, 26);
            this.lblNomeProjeto.TabIndex = 24;
            this.lblNomeProjeto.Text = "Nome do Projeto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1193, 667);
            this.Controls.Add(this.lblNomeProjeto);
            this.Controls.Add(this.TabProjetos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escritório de Projetos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.TabProjetos.ResumeLayout(false);
            this.pcVisaoGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).EndInit();
            this.pcInfoProjeto.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.pcCustos.ResumeLayout(false);
            this.panelCustos.ResumeLayout(false);
            this.panelInfoCustos.ResumeLayout(false);
            this.panelInfoCustos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustos)).EndInit();
            this.pcRiscos.ResumeLayout(false);
            this.tabRiscos.ResumeLayout(false);
            this.pcListaRiscos.ResumeLayout(false);
            this.panelInfoRisco.ResumeLayout(false);
            this.panelInfoRisco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRiscos)).EndInit();
            this.pcScore.ResumeLayout(false);
            this.pcScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.BindingSource bsProjetos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl TabProjetos;
        private System.Windows.Forms.TabPage pcVisaoGeral;
        private System.Windows.Forms.DataGridView gridProjetos;
        private System.Windows.Forms.TabPage pcInfoProjeto;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProjeto;
        private System.Windows.Forms.TextBox txtResponsavelId;
        private System.Windows.Forms.TextBox txtNomeProjeto;
        private System.Windows.Forms.DateTimePicker dateInicioProjeto;
        private System.Windows.Forms.DateTimePicker dateFimProjeto;
        private System.Windows.Forms.TabPage pcCustos;
        private System.Windows.Forms.TabPage pcRiscos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsGastos;
        private System.Windows.Forms.Label lblNomeProjeto;
        private System.Windows.Forms.Panel panelCustos;
        private System.Windows.Forms.Panel panelInfoCustos;
        private System.Windows.Forms.Button btnExcluiCusto;
        private System.Windows.Forms.Button btnNovoCusto;
        private System.Windows.Forms.Button btnCancelaCusto;
        private System.Windows.Forms.Button btnSalvaCusto;
        private System.Windows.Forms.DataGridView gridCustos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVlrPrevCusto;
        private System.Windows.Forms.TextBox txtVlrRealCusto;
        private System.Windows.Forms.TextBox txtQtdRealCusto;
        private System.Windows.Forms.TextBox txtQtdPrevCusto;
        private System.Windows.Forms.TextBox txtObservacaoCusto;
        private System.Windows.Forms.TextBox txtDescricaoCusto;
        private System.Windows.Forms.TextBox txtIdprojetoCusto;
        private System.Windows.Forms.TextBox txtIdCusto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projetosIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadePrevistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioPrevistoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeRealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioRealDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabRiscos;
        private System.Windows.Forms.TabPage pcListaRiscos;
        private System.Windows.Forms.Panel panelInfoRisco;
        private System.Windows.Forms.TextBox txtPrevistoRisco;
        private System.Windows.Forms.TextBox txtScoreRisco;
        private System.Windows.Forms.TextBox txtObservacaoRisco;
        private System.Windows.Forms.TextBox txtNomeRisco;
        private System.Windows.Forms.TextBox txtIdRiscoOrigem;
        private System.Windows.Forms.TextBox txtIdprojetoRisco;
        private System.Windows.Forms.TextBox txtIdRisco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView gridRiscos;
        private System.Windows.Forms.Button btnExcluiRisco;
        private System.Windows.Forms.Button btnNovoRisco;
        private System.Windows.Forms.Button btnCancelaRisco;
        private System.Windows.Forms.Button btnSalvaRisco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn riscoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projetosIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previstoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoRiscosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaPreventivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoContigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsRiscos;
        private System.Windows.Forms.TextBox txtDescricaoRiscoOrigem;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtProbabilidadeRisco;
        private System.Windows.Forms.TextBox txtImpactoRisco;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtPlanoContigenciaRiscoOrigem;
        private System.Windows.Forms.TextBox txtMedidaPrevRiscoOrigem;
        private System.Windows.Forms.TextBox txtDescricaoRisco;
        private System.Windows.Forms.Label label27;
        public System.Windows.Forms.TextBox txtidGastoOrigem;
        private System.Windows.Forms.Button btnPesquisaRisco;
        private System.Windows.Forms.Button btnPesquisaCusto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRiscos;
        private System.Windows.Forms.Button btnCustos;
        private System.Windows.Forms.Button btnInfoProjeto;
        private System.Windows.Forms.TabPage pcScore;
        private System.Windows.Forms.Button btnSalvaScore;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;




    }
}

