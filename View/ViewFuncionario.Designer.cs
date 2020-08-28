namespace View
{
    partial class ViewFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCEPFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimentoFuncionario = new System.Windows.Forms.Label();
            this.cboxUFFuncionario = new System.Windows.Forms.ComboBox();
            this.lblUFFuncionario = new System.Windows.Forms.Label();
            this.lblCidadeFuncionario = new System.Windows.Forms.Label();
            this.gboxFuncionario = new System.Windows.Forms.GroupBox();
            this.txtSalarioFuncionario = new System.Windows.Forms.TextBox();
            this.dtpAdmissaoFuncionario = new System.Windows.Forms.DateTimePicker();
            this.dtpNascimentoFuncionario = new System.Windows.Forms.DateTimePicker();
            this.lblAdmissaoFuncionario = new System.Windows.Forms.Label();
            this.lblSalarioFuncionario = new System.Windows.Forms.Label();
            this.txtCargoFuncionario = new System.Windows.Forms.TextBox();
            this.lblCargoFuncionario = new System.Windows.Forms.Label();
            this.txtCidadeFuncionario = new System.Windows.Forms.TextBox();
            this.lblComplementoFuncionario = new System.Windows.Forms.Label();
            this.txtComplementoFuncionario = new System.Windows.Forms.TextBox();
            this.lblBairroFuncionario = new System.Windows.Forms.Label();
            this.txtBairroFuncionario = new System.Windows.Forms.TextBox();
            this.lblNumCasaFuncionario = new System.Windows.Forms.Label();
            this.txtNumCasaFuncionario = new System.Windows.Forms.TextBox();
            this.lblRuaFuncionario = new System.Windows.Forms.Label();
            this.txtRuaFuncionario = new System.Windows.Forms.TextBox();
            this.cboxSexoFuncionario = new System.Windows.Forms.ComboBox();
            this.lblCEPFuncionario = new System.Windows.Forms.Label();
            this.lblEmailFuncionario = new System.Windows.Forms.Label();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.lblTelefoneFuncionario = new System.Windows.Forms.Label();
            this.lblCPFFuncionario = new System.Windows.Forms.Label();
            this.lblSexoFuncionario = new System.Windows.Forms.Label();
            this.btnCancelarFuncionario = new System.Windows.Forms.Button();
            this.btnNovoFuncionario = new System.Windows.Forms.Button();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnSalvarFuncionario = new System.Windows.Forms.Button();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.tpgConfiguracoesFuncionario = new System.Windows.Forms.TabPage();
            this.lblBuscarFuncionario = new System.Windows.Forms.Label();
            this.ttmesagem = new System.Windows.Forms.ToolTip(this.components);
            this.cboBuscarFuncionario = new System.Windows.Forms.ComboBox();
            this.btnDeletarFuncionario = new System.Windows.Forms.Button();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.tctrlFuncionario = new System.Windows.Forms.TabControl();
            this.tpgListarFuncionario = new System.Windows.Forms.TabPage();
            this.chkDeletarFuncionario = new System.Windows.Forms.CheckBox();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarFuncionario = new System.Windows.Forms.TextBox();
            this.lblTotalFuncionario = new System.Windows.Forms.Label();
            this.gboxFuncionario.SuspendLayout();
            this.tpgConfiguracoesFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.tctrlFuncionario.SuspendLayout();
            this.tpgListarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCEPFuncionario
            // 
            this.txtCEPFuncionario.BeepOnError = true;
            this.txtCEPFuncionario.Location = new System.Drawing.Point(112, 273);
            this.txtCEPFuncionario.Mask = "00000-000";
            this.txtCEPFuncionario.Name = "txtCEPFuncionario";
            this.txtCEPFuncionario.Size = new System.Drawing.Size(85, 24);
            this.txtCEPFuncionario.TabIndex = 11;
            this.txtCEPFuncionario.Text = "99999999";
            this.txtCEPFuncionario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCEPFuncionario.ValidatingType = typeof(System.DateTime);
            // 
            // txtCPFFuncionario
            // 
            this.txtCPFFuncionario.BeepOnError = true;
            this.txtCPFFuncionario.Culture = new System.Globalization.CultureInfo("en-US");
            this.txtCPFFuncionario.Location = new System.Drawing.Point(112, 144);
            this.txtCPFFuncionario.Mask = "000.000.000-00";
            this.txtCPFFuncionario.Name = "txtCPFFuncionario";
            this.txtCPFFuncionario.Size = new System.Drawing.Size(120, 24);
            this.txtCPFFuncionario.TabIndex = 3;
            this.txtCPFFuncionario.Text = "99999999999";
            this.txtCPFFuncionario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefoneFuncionario
            // 
            this.txtTelefoneFuncionario.BeepOnError = true;
            this.txtTelefoneFuncionario.Location = new System.Drawing.Point(112, 188);
            this.txtTelefoneFuncionario.Mask = "(00) 00000-0000";
            this.txtTelefoneFuncionario.Name = "txtTelefoneFuncionario";
            this.txtTelefoneFuncionario.Size = new System.Drawing.Size(120, 24);
            this.txtTelefoneFuncionario.TabIndex = 6;
            this.txtTelefoneFuncionario.Text = "99999999999";
            this.txtTelefoneFuncionario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblNascimentoFuncionario
            // 
            this.lblNascimentoFuncionario.AutoSize = true;
            this.lblNascimentoFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimentoFuncionario.Location = new System.Drawing.Point(245, 147);
            this.lblNascimentoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNascimentoFuncionario.Name = "lblNascimentoFuncionario";
            this.lblNascimentoFuncionario.Size = new System.Drawing.Size(86, 19);
            this.lblNascimentoFuncionario.TabIndex = 142;
            this.lblNascimentoFuncionario.Text = "Data Nasc.";
            // 
            // cboxUFFuncionario
            // 
            this.cboxUFFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUFFuncionario.FormattingEnabled = true;
            this.cboxUFFuncionario.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cboxUFFuncionario.Location = new System.Drawing.Point(388, 410);
            this.cboxUFFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.cboxUFFuncionario.Name = "cboxUFFuncionario";
            this.cboxUFFuncionario.Size = new System.Drawing.Size(100, 27);
            this.cboxUFFuncionario.TabIndex = 16;
            this.ttmesagem.SetToolTip(this.cboxUFFuncionario, "Selecione a UF da cidade");
            // 
            // lblUFFuncionario
            // 
            this.lblUFFuncionario.AutoSize = true;
            this.lblUFFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFFuncionario.Location = new System.Drawing.Point(328, 413);
            this.lblUFFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUFFuncionario.Name = "lblUFFuncionario";
            this.lblUFFuncionario.Size = new System.Drawing.Size(56, 19);
            this.lblUFFuncionario.TabIndex = 139;
            this.lblUFFuncionario.Text = "Estado";
            // 
            // lblCidadeFuncionario
            // 
            this.lblCidadeFuncionario.AutoSize = true;
            this.lblCidadeFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeFuncionario.Location = new System.Drawing.Point(46, 413);
            this.lblCidadeFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidadeFuncionario.Name = "lblCidadeFuncionario";
            this.lblCidadeFuncionario.Size = new System.Drawing.Size(62, 19);
            this.lblCidadeFuncionario.TabIndex = 137;
            this.lblCidadeFuncionario.Text = "Cidade";
            // 
            // gboxFuncionario
            // 
            this.gboxFuncionario.BackColor = System.Drawing.Color.White;
            this.gboxFuncionario.Controls.Add(this.txtSalarioFuncionario);
            this.gboxFuncionario.Controls.Add(this.dtpAdmissaoFuncionario);
            this.gboxFuncionario.Controls.Add(this.dtpNascimentoFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblAdmissaoFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblSalarioFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtCargoFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblCargoFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtCEPFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtCPFFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtTelefoneFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblNascimentoFuncionario);
            this.gboxFuncionario.Controls.Add(this.cboxUFFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblUFFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblCidadeFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtCidadeFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblComplementoFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtComplementoFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblBairroFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtBairroFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblNumCasaFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtNumCasaFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblRuaFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtRuaFuncionario);
            this.gboxFuncionario.Controls.Add(this.cboxSexoFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblCEPFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblEmailFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtEmailFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblTelefoneFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblCPFFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblSexoFuncionario);
            this.gboxFuncionario.Controls.Add(this.btnCancelarFuncionario);
            this.gboxFuncionario.Controls.Add(this.btnNovoFuncionario);
            this.gboxFuncionario.Controls.Add(this.btnEditarFuncionario);
            this.gboxFuncionario.Controls.Add(this.btnSalvarFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblNomeFuncionario);
            this.gboxFuncionario.Controls.Add(this.lblCodigoFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtNomeFuncionario);
            this.gboxFuncionario.Controls.Add(this.txtCodigoFuncionario);
            this.gboxFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxFuncionario.Location = new System.Drawing.Point(2, 0);
            this.gboxFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.gboxFuncionario.Name = "gboxFuncionario";
            this.gboxFuncionario.Padding = new System.Windows.Forms.Padding(2);
            this.gboxFuncionario.Size = new System.Drawing.Size(1300, 692);
            this.gboxFuncionario.TabIndex = 0;
            this.gboxFuncionario.TabStop = false;
            this.gboxFuncionario.Text = "Funcionário";
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(699, 144);
            this.txtSalarioFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(114, 24);
            this.txtSalarioFuncionario.TabIndex = 155;
            // 
            // dtpAdmissaoFuncionario
            // 
            this.dtpAdmissaoFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdmissaoFuncionario.Location = new System.Drawing.Point(665, 188);
            this.dtpAdmissaoFuncionario.MaxDate = new System.DateTime(2020, 5, 20, 0, 0, 0, 0);
            this.dtpAdmissaoFuncionario.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpAdmissaoFuncionario.Name = "dtpAdmissaoFuncionario";
            this.dtpAdmissaoFuncionario.Size = new System.Drawing.Size(117, 24);
            this.dtpAdmissaoFuncionario.TabIndex = 10;
            this.dtpAdmissaoFuncionario.Value = new System.DateTime(2020, 5, 19, 0, 0, 0, 0);
            // 
            // dtpNascimentoFuncionario
            // 
            this.dtpNascimentoFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimentoFuncionario.Location = new System.Drawing.Point(332, 146);
            this.dtpNascimentoFuncionario.MaxDate = new System.DateTime(2020, 5, 15, 0, 0, 0, 0);
            this.dtpNascimentoFuncionario.Name = "dtpNascimentoFuncionario";
            this.dtpNascimentoFuncionario.Size = new System.Drawing.Size(117, 24);
            this.dtpNascimentoFuncionario.TabIndex = 4;
            this.dtpNascimentoFuncionario.Value = new System.DateTime(2020, 5, 15, 0, 0, 0, 0);
            // 
            // lblAdmissaoFuncionario
            // 
            this.lblAdmissaoFuncionario.AutoSize = true;
            this.lblAdmissaoFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissaoFuncionario.Location = new System.Drawing.Point(587, 191);
            this.lblAdmissaoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmissaoFuncionario.Name = "lblAdmissaoFuncionario";
            this.lblAdmissaoFuncionario.Size = new System.Drawing.Size(73, 19);
            this.lblAdmissaoFuncionario.TabIndex = 153;
            this.lblAdmissaoFuncionario.Text = "Admissão";
            // 
            // lblSalarioFuncionario
            // 
            this.lblSalarioFuncionario.AutoSize = true;
            this.lblSalarioFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFuncionario.Location = new System.Drawing.Point(640, 149);
            this.lblSalarioFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalarioFuncionario.Name = "lblSalarioFuncionario";
            this.lblSalarioFuncionario.Size = new System.Drawing.Size(55, 19);
            this.lblSalarioFuncionario.TabIndex = 151;
            this.lblSalarioFuncionario.Text = "Salário";
            // 
            // txtCargoFuncionario
            // 
            this.txtCargoFuncionario.Location = new System.Drawing.Point(718, 102);
            this.txtCargoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargoFuncionario.Name = "txtCargoFuncionario";
            this.txtCargoFuncionario.Size = new System.Drawing.Size(114, 24);
            this.txtCargoFuncionario.TabIndex = 8;
            // 
            // lblCargoFuncionario
            // 
            this.lblCargoFuncionario.AutoSize = true;
            this.lblCargoFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoFuncionario.Location = new System.Drawing.Point(667, 107);
            this.lblCargoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargoFuncionario.Name = "lblCargoFuncionario";
            this.lblCargoFuncionario.Size = new System.Drawing.Size(52, 19);
            this.lblCargoFuncionario.TabIndex = 149;
            this.lblCargoFuncionario.Text = "Cargo";
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(112, 410);
            this.txtCidadeFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidadeFuncionario.Name = "txtCidadeFuncionario";
            this.txtCidadeFuncionario.Size = new System.Drawing.Size(202, 24);
            this.txtCidadeFuncionario.TabIndex = 16;
            // 
            // lblComplementoFuncionario
            // 
            this.lblComplementoFuncionario.AutoSize = true;
            this.lblComplementoFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplementoFuncionario.Location = new System.Drawing.Point(325, 367);
            this.lblComplementoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplementoFuncionario.Name = "lblComplementoFuncionario";
            this.lblComplementoFuncionario.Size = new System.Drawing.Size(109, 19);
            this.lblComplementoFuncionario.TabIndex = 135;
            this.lblComplementoFuncionario.Text = "Complemento";
            // 
            // txtComplementoFuncionario
            // 
            this.txtComplementoFuncionario.Location = new System.Drawing.Point(438, 364);
            this.txtComplementoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplementoFuncionario.Name = "txtComplementoFuncionario";
            this.txtComplementoFuncionario.Size = new System.Drawing.Size(336, 24);
            this.txtComplementoFuncionario.TabIndex = 15;
            // 
            // lblBairroFuncionario
            // 
            this.lblBairroFuncionario.AutoSize = true;
            this.lblBairroFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroFuncionario.Location = new System.Drawing.Point(62, 367);
            this.lblBairroFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairroFuncionario.Name = "lblBairroFuncionario";
            this.lblBairroFuncionario.Size = new System.Drawing.Size(47, 19);
            this.lblBairroFuncionario.TabIndex = 133;
            this.lblBairroFuncionario.Text = "Bairro";
            // 
            // txtBairroFuncionario
            // 
            this.txtBairroFuncionario.Location = new System.Drawing.Point(112, 364);
            this.txtBairroFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairroFuncionario.Name = "txtBairroFuncionario";
            this.txtBairroFuncionario.Size = new System.Drawing.Size(203, 24);
            this.txtBairroFuncionario.TabIndex = 14;
            // 
            // lblNumCasaFuncionario
            // 
            this.lblNumCasaFuncionario.AutoSize = true;
            this.lblNumCasaFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCasaFuncionario.Location = new System.Drawing.Point(581, 322);
            this.lblNumCasaFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCasaFuncionario.Name = "lblNumCasaFuncionario";
            this.lblNumCasaFuncionario.Size = new System.Drawing.Size(24, 19);
            this.lblNumCasaFuncionario.TabIndex = 131;
            this.lblNumCasaFuncionario.Text = "Nº";
            // 
            // txtNumCasaFuncionario
            // 
            this.txtNumCasaFuncionario.Location = new System.Drawing.Point(609, 319);
            this.txtNumCasaFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumCasaFuncionario.Name = "txtNumCasaFuncionario";
            this.txtNumCasaFuncionario.Size = new System.Drawing.Size(85, 24);
            this.txtNumCasaFuncionario.TabIndex = 13;
            // 
            // lblRuaFuncionario
            // 
            this.lblRuaFuncionario.AutoSize = true;
            this.lblRuaFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuaFuncionario.Location = new System.Drawing.Point(72, 322);
            this.lblRuaFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRuaFuncionario.Name = "lblRuaFuncionario";
            this.lblRuaFuncionario.Size = new System.Drawing.Size(37, 19);
            this.lblRuaFuncionario.TabIndex = 129;
            this.lblRuaFuncionario.Text = "Rua";
            // 
            // txtRuaFuncionario
            // 
            this.txtRuaFuncionario.Location = new System.Drawing.Point(113, 319);
            this.txtRuaFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtRuaFuncionario.Name = "txtRuaFuncionario";
            this.txtRuaFuncionario.Size = new System.Drawing.Size(464, 24);
            this.txtRuaFuncionario.TabIndex = 12;
            // 
            // cboxSexoFuncionario
            // 
            this.cboxSexoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSexoFuncionario.FormattingEnabled = true;
            this.cboxSexoFuncionario.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Indefinido"});
            this.cboxSexoFuncionario.Location = new System.Drawing.Point(499, 144);
            this.cboxSexoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.cboxSexoFuncionario.Name = "cboxSexoFuncionario";
            this.cboxSexoFuncionario.Size = new System.Drawing.Size(100, 27);
            this.cboxSexoFuncionario.TabIndex = 5;
            this.ttmesagem.SetToolTip(this.cboxSexoFuncionario, "Selecione o sexo do funcionário");
            // 
            // lblCEPFuncionario
            // 
            this.lblCEPFuncionario.AutoSize = true;
            this.lblCEPFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEPFuncionario.Location = new System.Drawing.Point(73, 276);
            this.lblCEPFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCEPFuncionario.Name = "lblCEPFuncionario";
            this.lblCEPFuncionario.Size = new System.Drawing.Size(36, 19);
            this.lblCEPFuncionario.TabIndex = 126;
            this.lblCEPFuncionario.Text = "CEP";
            // 
            // lblEmailFuncionario
            // 
            this.lblEmailFuncionario.AutoSize = true;
            this.lblEmailFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFuncionario.Location = new System.Drawing.Point(245, 191);
            this.lblEmailFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailFuncionario.Name = "lblEmailFuncionario";
            this.lblEmailFuncionario.Size = new System.Drawing.Size(51, 19);
            this.lblEmailFuncionario.TabIndex = 124;
            this.lblEmailFuncionario.Text = "E-mail";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Location = new System.Drawing.Point(300, 188);
            this.txtEmailFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(244, 24);
            this.txtEmailFuncionario.TabIndex = 7;
            // 
            // lblTelefoneFuncionario
            // 
            this.lblTelefoneFuncionario.AutoSize = true;
            this.lblTelefoneFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneFuncionario.Location = new System.Drawing.Point(42, 191);
            this.lblTelefoneFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefoneFuncionario.Name = "lblTelefoneFuncionario";
            this.lblTelefoneFuncionario.Size = new System.Drawing.Size(66, 19);
            this.lblTelefoneFuncionario.TabIndex = 122;
            this.lblTelefoneFuncionario.Text = "Telefone";
            // 
            // lblCPFFuncionario
            // 
            this.lblCPFFuncionario.AutoSize = true;
            this.lblCPFFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFFuncionario.Location = new System.Drawing.Point(73, 147);
            this.lblCPFFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPFFuncionario.Name = "lblCPFFuncionario";
            this.lblCPFFuncionario.Size = new System.Drawing.Size(35, 19);
            this.lblCPFFuncionario.TabIndex = 120;
            this.lblCPFFuncionario.Text = "CPF";
            // 
            // lblSexoFuncionario
            // 
            this.lblSexoFuncionario.AutoSize = true;
            this.lblSexoFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoFuncionario.Location = new System.Drawing.Point(458, 147);
            this.lblSexoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexoFuncionario.Name = "lblSexoFuncionario";
            this.lblSexoFuncionario.Size = new System.Drawing.Size(41, 19);
            this.lblSexoFuncionario.TabIndex = 118;
            this.lblSexoFuncionario.Text = "Sexo";
            // 
            // btnCancelarFuncionario
            // 
            this.btnCancelarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnCancelarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCancelarFuncionario.Location = new System.Drawing.Point(524, 506);
            this.btnCancelarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarFuncionario.Name = "btnCancelarFuncionario";
            this.btnCancelarFuncionario.Size = new System.Drawing.Size(120, 31);
            this.btnCancelarFuncionario.TabIndex = 20;
            this.btnCancelarFuncionario.Text = "Cancelar";
            this.btnCancelarFuncionario.UseVisualStyleBackColor = false;
            this.btnCancelarFuncionario.Click += new System.EventHandler(this.btnCancelarFuncionario_Click);
            // 
            // btnNovoFuncionario
            // 
            this.btnNovoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnNovoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnNovoFuncionario.Location = new System.Drawing.Point(112, 506);
            this.btnNovoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoFuncionario.Name = "btnNovoFuncionario";
            this.btnNovoFuncionario.Size = new System.Drawing.Size(120, 31);
            this.btnNovoFuncionario.TabIndex = 17;
            this.btnNovoFuncionario.Text = "Novo";
            this.btnNovoFuncionario.UseVisualStyleBackColor = false;
            this.btnNovoFuncionario.Click += new System.EventHandler(this.btnNovoFuncionario_Click);
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnEditarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnEditarFuncionario.Location = new System.Drawing.Point(388, 506);
            this.btnEditarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(120, 31);
            this.btnEditarFuncionario.TabIndex = 19;
            this.btnEditarFuncionario.Text = "Editar";
            this.btnEditarFuncionario.UseVisualStyleBackColor = false;
            this.btnEditarFuncionario.Click += new System.EventHandler(this.btnEditarFuncionario_Click);
            // 
            // btnSalvarFuncionario
            // 
            this.btnSalvarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSalvarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnSalvarFuncionario.Location = new System.Drawing.Point(249, 506);
            this.btnSalvarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            this.btnSalvarFuncionario.Size = new System.Drawing.Size(120, 31);
            this.btnSalvarFuncionario.TabIndex = 18;
            this.btnSalvarFuncionario.Text = "Salvar";
            this.btnSalvarFuncionario.UseVisualStyleBackColor = false;
            this.btnSalvarFuncionario.Click += new System.EventHandler(this.btnSalvarFuncionario_Click);
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(59, 104);
            this.lblNomeFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(50, 19);
            this.lblNomeFuncionario.TabIndex = 108;
            this.lblNomeFuncionario.Text = "Nome";
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(49, 51);
            this.lblCodigoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(60, 19);
            this.lblCodigoFuncionario.TabIndex = 107;
            this.lblCodigoFuncionario.Text = "Código";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(113, 101);
            this.txtNomeFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(512, 24);
            this.txtNomeFuncionario.TabIndex = 2;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(112, 48);
            this.txtCodigoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(99, 24);
            this.txtCodigoFuncionario.TabIndex = 1;
            this.txtCodigoFuncionario.TabStop = false;
            // 
            // tpgConfiguracoesFuncionario
            // 
            this.tpgConfiguracoesFuncionario.Controls.Add(this.gboxFuncionario);
            this.tpgConfiguracoesFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgConfiguracoesFuncionario.Location = new System.Drawing.Point(4, 28);
            this.tpgConfiguracoesFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesFuncionario.Name = "tpgConfiguracoesFuncionario";
            this.tpgConfiguracoesFuncionario.Padding = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesFuncionario.Size = new System.Drawing.Size(1192, 688);
            this.tpgConfiguracoesFuncionario.TabIndex = 1;
            this.tpgConfiguracoesFuncionario.Text = "Configurações";
            this.tpgConfiguracoesFuncionario.UseVisualStyleBackColor = true;
            // 
            // lblBuscarFuncionario
            // 
            this.lblBuscarFuncionario.AutoSize = true;
            this.lblBuscarFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarFuncionario.Location = new System.Drawing.Point(57, 24);
            this.lblBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarFuncionario.Name = "lblBuscarFuncionario";
            this.lblBuscarFuncionario.Size = new System.Drawing.Size(54, 19);
            this.lblBuscarFuncionario.TabIndex = 0;
            this.lblBuscarFuncionario.Text = "Buscar";
            // 
            // ttmesagem
            // 
            this.ttmesagem.IsBalloon = true;
            // 
            // cboBuscarFuncionario
            // 
            this.cboBuscarFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarFuncionario.FormattingEnabled = true;
            this.cboBuscarFuncionario.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.cboBuscarFuncionario.Location = new System.Drawing.Point(119, 21);
            this.cboBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.cboBuscarFuncionario.Name = "cboBuscarFuncionario";
            this.cboBuscarFuncionario.Size = new System.Drawing.Size(101, 27);
            this.cboBuscarFuncionario.TabIndex = 1;
            this.ttmesagem.SetToolTip(this.cboBuscarFuncionario, "Selecione o método de busca desejado");
            this.cboBuscarFuncionario.SelectedIndexChanged += new System.EventHandler(this.cboBuscarFuncionario_SelectedIndexChanged);
            // 
            // btnDeletarFuncionario
            // 
            this.btnDeletarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnDeletarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnDeletarFuncionario.Location = new System.Drawing.Point(626, 18);
            this.btnDeletarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletarFuncionario.Name = "btnDeletarFuncionario";
            this.btnDeletarFuncionario.Size = new System.Drawing.Size(105, 31);
            this.btnDeletarFuncionario.TabIndex = 6;
            this.btnDeletarFuncionario.Text = "Deletar";
            this.btnDeletarFuncionario.UseVisualStyleBackColor = false;
            this.btnDeletarFuncionario.Click += new System.EventHandler(this.btnDeletarFuncionario_Click);
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnBuscarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(484, 18);
            this.btnBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(105, 31);
            this.btnBuscarFuncionario.TabIndex = 3;
            this.btnBuscarFuncionario.Text = "Buscar";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = false;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // tctrlFuncionario
            // 
            this.tctrlFuncionario.Controls.Add(this.tpgListarFuncionario);
            this.tctrlFuncionario.Controls.Add(this.tpgConfiguracoesFuncionario);
            this.tctrlFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlFuncionario.Location = new System.Drawing.Point(2, 79);
            this.tctrlFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tctrlFuncionario.Name = "tctrlFuncionario";
            this.tctrlFuncionario.SelectedIndex = 0;
            this.tctrlFuncionario.Size = new System.Drawing.Size(1200, 720);
            this.tctrlFuncionario.TabIndex = 21;
            this.tctrlFuncionario.SelectedIndexChanged += new System.EventHandler(this.tctrlFuncionario_SelectedIndexChanged);
            // 
            // tpgListarFuncionario
            // 
            this.tpgListarFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.tpgListarFuncionario.Controls.Add(this.cboBuscarFuncionario);
            this.tpgListarFuncionario.Controls.Add(this.chkDeletarFuncionario);
            this.tpgListarFuncionario.Controls.Add(this.dgvFuncionario);
            this.tpgListarFuncionario.Controls.Add(this.txtBuscarFuncionario);
            this.tpgListarFuncionario.Controls.Add(this.lblTotalFuncionario);
            this.tpgListarFuncionario.Controls.Add(this.btnBuscarFuncionario);
            this.tpgListarFuncionario.Controls.Add(this.btnDeletarFuncionario);
            this.tpgListarFuncionario.Controls.Add(this.lblBuscarFuncionario);
            this.tpgListarFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgListarFuncionario.Location = new System.Drawing.Point(4, 28);
            this.tpgListarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tpgListarFuncionario.Name = "tpgListarFuncionario";
            this.tpgListarFuncionario.Padding = new System.Windows.Forms.Padding(2);
            this.tpgListarFuncionario.Size = new System.Drawing.Size(1192, 688);
            this.tpgListarFuncionario.TabIndex = 0;
            this.tpgListarFuncionario.Text = "Listar";
            // 
            // chkDeletarFuncionario
            // 
            this.chkDeletarFuncionario.AutoSize = true;
            this.chkDeletarFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeletarFuncionario.Location = new System.Drawing.Point(12, 53);
            this.chkDeletarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.chkDeletarFuncionario.Name = "chkDeletarFuncionario";
            this.chkDeletarFuncionario.Size = new System.Drawing.Size(78, 23);
            this.chkDeletarFuncionario.TabIndex = 4;
            this.chkDeletarFuncionario.Text = "Deletar";
            this.chkDeletarFuncionario.UseVisualStyleBackColor = true;
            this.chkDeletarFuncionario.CheckedChanged += new System.EventHandler(this.chkDeletarFuncionario_CheckedChanged);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.AllowUserToOrderColumns = true;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFuncionario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionario.ColumnHeadersHeight = 50;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.dgvFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFuncionario.EnableHeadersVisualStyles = false;
            this.dgvFuncionario.GridColor = System.Drawing.Color.Black;
            this.dgvFuncionario.Location = new System.Drawing.Point(2, 107);
            this.dgvFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFuncionario.MultiSelect = false;
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.RowHeadersWidth = 51;
            this.dgvFuncionario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFuncionario.RowTemplate.Height = 24;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(1180, 577);
            this.dgvFuncionario.TabIndex = 5;
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            this.dgvFuncionario.DoubleClick += new System.EventHandler(this.dgvFuncionario_DoubleClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.MinimumWidth = 6;
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            this.Deletar.Width = 67;
            // 
            // txtBuscarFuncionario
            // 
            this.txtBuscarFuncionario.Location = new System.Drawing.Point(235, 21);
            this.txtBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarFuncionario.Name = "txtBuscarFuncionario";
            this.txtBuscarFuncionario.Size = new System.Drawing.Size(188, 24);
            this.txtBuscarFuncionario.TabIndex = 2;
            this.txtBuscarFuncionario.TextChanged += new System.EventHandler(this.txtBuscarFuncionario_TextChanged);
            // 
            // lblTotalFuncionario
            // 
            this.lblTotalFuncionario.AutoSize = true;
            this.lblTotalFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFuncionario.Location = new System.Drawing.Point(480, 57);
            this.lblTotalFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalFuncionario.Name = "lblTotalFuncionario";
            this.lblTotalFuncionario.Size = new System.Drawing.Size(57, 19);
            this.lblTotalFuncionario.TabIndex = 5;
            this.lblTotalFuncionario.Text = "lblTotal";
            // 
            // ViewFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tctrlFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewFuncionario";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.ViewFuncionario_Load);
            this.gboxFuncionario.ResumeLayout(false);
            this.gboxFuncionario.PerformLayout();
            this.tpgConfiguracoesFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.tctrlFuncionario.ResumeLayout(false);
            this.tpgListarFuncionario.ResumeLayout(false);
            this.tpgListarFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtCEPFuncionario;
        private System.Windows.Forms.MaskedTextBox txtCPFFuncionario;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFuncionario;
        private System.Windows.Forms.Label lblNascimentoFuncionario;
        private System.Windows.Forms.ComboBox cboxUFFuncionario;
        private System.Windows.Forms.Label lblUFFuncionario;
        private System.Windows.Forms.Label lblCidadeFuncionario;
        private System.Windows.Forms.GroupBox gboxFuncionario;
        private System.Windows.Forms.TextBox txtCidadeFuncionario;
        private System.Windows.Forms.Label lblComplementoFuncionario;
        private System.Windows.Forms.TextBox txtComplementoFuncionario;
        private System.Windows.Forms.Label lblBairroFuncionario;
        private System.Windows.Forms.TextBox txtBairroFuncionario;
        private System.Windows.Forms.Label lblNumCasaFuncionario;
        private System.Windows.Forms.TextBox txtNumCasaFuncionario;
        private System.Windows.Forms.Label lblRuaFuncionario;
        private System.Windows.Forms.TextBox txtRuaFuncionario;
        private System.Windows.Forms.ComboBox cboxSexoFuncionario;
        private System.Windows.Forms.Label lblCEPFuncionario;
        private System.Windows.Forms.Label lblEmailFuncionario;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.Label lblTelefoneFuncionario;
        private System.Windows.Forms.Label lblCPFFuncionario;
        private System.Windows.Forms.Label lblSexoFuncionario;
        private System.Windows.Forms.Button btnCancelarFuncionario;
        private System.Windows.Forms.Button btnNovoFuncionario;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Button btnSalvarFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.TabPage tpgConfiguracoesFuncionario;
        private System.Windows.Forms.Label lblBuscarFuncionario;
        private System.Windows.Forms.ToolTip ttmesagem;
        private System.Windows.Forms.Button btnDeletarFuncionario;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.TabControl tctrlFuncionario;
        private System.Windows.Forms.TabPage tpgListarFuncionario;
        private System.Windows.Forms.ComboBox cboBuscarFuncionario;
        private System.Windows.Forms.CheckBox chkDeletarFuncionario;
        private System.Windows.Forms.TextBox txtBuscarFuncionario;
        private System.Windows.Forms.Label lblTotalFuncionario;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.TextBox txtCargoFuncionario;
        private System.Windows.Forms.Label lblCargoFuncionario;
        private System.Windows.Forms.Label lblAdmissaoFuncionario;
        private System.Windows.Forms.Label lblSalarioFuncionario;
        private System.Windows.Forms.DateTimePicker dtpNascimentoFuncionario;
        private System.Windows.Forms.DateTimePicker dtpAdmissaoFuncionario;
        private System.Windows.Forms.TextBox txtSalarioFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
    }
}