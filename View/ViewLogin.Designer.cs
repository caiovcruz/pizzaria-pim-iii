namespace View
{
    partial class ViewLogin
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
            this.gboxLogin = new System.Windows.Forms.GroupBox();
            this.cboxNomeFuncionarioLogin = new System.Windows.Forms.ComboBox();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.cboxNivelAcessoLogin = new System.Windows.Forms.ComboBox();
            this.lblNivelAcessoLogin = new System.Windows.Forms.Label();
            this.btnCancelarLogin = new System.Windows.Forms.Button();
            this.btnNovoLogin = new System.Windows.Forms.Button();
            this.btnEditarLogin = new System.Windows.Forms.Button();
            this.btnSalvarLogin = new System.Windows.Forms.Button();
            this.lblNomeFuncionarioLogin = new System.Windows.Forms.Label();
            this.lblCodigoFuncionarioLogin = new System.Windows.Forms.Label();
            this.txtCodigoLogin = new System.Windows.Forms.TextBox();
            this.tpgConfiguracoesLogin = new System.Windows.Forms.TabPage();
            this.lblBuscarLogin = new System.Windows.Forms.Label();
            this.ttmesagem = new System.Windows.Forms.ToolTip(this.components);
            this.btnDeletarLogin = new System.Windows.Forms.Button();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscarLogin = new System.Windows.Forms.Button();
            this.tctrlLogin = new System.Windows.Forms.TabControl();
            this.tpgListarLogin = new System.Windows.Forms.TabPage();
            this.chkDeletarLogin = new System.Windows.Forms.CheckBox();
            this.dgvLogin = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarLogin = new System.Windows.Forms.TextBox();
            this.lblTotalLogin = new System.Windows.Forms.Label();
            this.gboxLogin.SuspendLayout();
            this.tpgConfiguracoesLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.tctrlLogin.SuspendLayout();
            this.tpgListarLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxLogin
            // 
            this.gboxLogin.BackColor = System.Drawing.Color.White;
            this.gboxLogin.Controls.Add(this.cboxNomeFuncionarioLogin);
            this.gboxLogin.Controls.Add(this.lblSenhaLogin);
            this.gboxLogin.Controls.Add(this.txtSenhaLogin);
            this.gboxLogin.Controls.Add(this.lblUsuarioLogin);
            this.gboxLogin.Controls.Add(this.txtUsuarioLogin);
            this.gboxLogin.Controls.Add(this.cboxNivelAcessoLogin);
            this.gboxLogin.Controls.Add(this.lblNivelAcessoLogin);
            this.gboxLogin.Controls.Add(this.btnCancelarLogin);
            this.gboxLogin.Controls.Add(this.btnNovoLogin);
            this.gboxLogin.Controls.Add(this.btnEditarLogin);
            this.gboxLogin.Controls.Add(this.btnSalvarLogin);
            this.gboxLogin.Controls.Add(this.lblNomeFuncionarioLogin);
            this.gboxLogin.Controls.Add(this.lblCodigoFuncionarioLogin);
            this.gboxLogin.Controls.Add(this.txtCodigoLogin);
            this.gboxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxLogin.Location = new System.Drawing.Point(2, 0);
            this.gboxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.gboxLogin.Name = "gboxLogin";
            this.gboxLogin.Padding = new System.Windows.Forms.Padding(2);
            this.gboxLogin.Size = new System.Drawing.Size(1300, 692);
            this.gboxLogin.TabIndex = 0;
            this.gboxLogin.TabStop = false;
            this.gboxLogin.Text = "Cliente";
            // 
            // cboxNomeFuncionarioLogin
            // 
            this.cboxNomeFuncionarioLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNomeFuncionarioLogin.FormattingEnabled = true;
            this.cboxNomeFuncionarioLogin.Location = new System.Drawing.Point(374, 39);
            this.cboxNomeFuncionarioLogin.Margin = new System.Windows.Forms.Padding(2);
            this.cboxNomeFuncionarioLogin.Name = "cboxNomeFuncionarioLogin";
            this.cboxNomeFuncionarioLogin.Size = new System.Drawing.Size(276, 27);
            this.cboxNomeFuncionarioLogin.TabIndex = 2;
            this.ttmesagem.SetToolTip(this.cboxNomeFuncionarioLogin, "Selecione o funcionário deste login");
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaLogin.Location = new System.Drawing.Point(61, 132);
            this.lblSenhaLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(53, 19);
            this.lblSenhaLogin.TabIndex = 122;
            this.lblSenhaLogin.Text = "Senha";
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(118, 129);
            this.txtSenhaLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(186, 24);
            this.txtSenhaLogin.TabIndex = 4;
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogin.Location = new System.Drawing.Point(56, 89);
            this.lblUsuarioLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(58, 19);
            this.lblUsuarioLogin.TabIndex = 120;
            this.lblUsuarioLogin.Text = "Usuário";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(118, 86);
            this.txtUsuarioLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(186, 24);
            this.txtUsuarioLogin.TabIndex = 3;
            // 
            // cboxNivelAcessoLogin
            // 
            this.cboxNivelAcessoLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNivelAcessoLogin.FormattingEnabled = true;
            this.cboxNivelAcessoLogin.Location = new System.Drawing.Point(503, 83);
            this.cboxNivelAcessoLogin.Margin = new System.Windows.Forms.Padding(2);
            this.cboxNivelAcessoLogin.Name = "cboxNivelAcessoLogin";
            this.cboxNivelAcessoLogin.Size = new System.Drawing.Size(147, 27);
            this.cboxNivelAcessoLogin.TabIndex = 5;
            this.ttmesagem.SetToolTip(this.cboxNivelAcessoLogin, "Selecione o nível de acesso para este login");
            // 
            // lblNivelAcessoLogin
            // 
            this.lblNivelAcessoLogin.AutoSize = true;
            this.lblNivelAcessoLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelAcessoLogin.Location = new System.Drawing.Point(407, 86);
            this.lblNivelAcessoLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivelAcessoLogin.Name = "lblNivelAcessoLogin";
            this.lblNivelAcessoLogin.Size = new System.Drawing.Size(92, 19);
            this.lblNivelAcessoLogin.TabIndex = 118;
            this.lblNivelAcessoLogin.Text = "Nível Acesso";
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnCancelarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLogin.ForeColor = System.Drawing.Color.White;
            this.btnCancelarLogin.Location = new System.Drawing.Point(530, 225);
            this.btnCancelarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Size = new System.Drawing.Size(120, 31);
            this.btnCancelarLogin.TabIndex = 10;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = false;
            this.btnCancelarLogin.Click += new System.EventHandler(this.btnCancelarLogin_Click);
            // 
            // btnNovoLogin
            // 
            this.btnNovoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnNovoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoLogin.ForeColor = System.Drawing.Color.White;
            this.btnNovoLogin.Location = new System.Drawing.Point(118, 225);
            this.btnNovoLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoLogin.Name = "btnNovoLogin";
            this.btnNovoLogin.Size = new System.Drawing.Size(120, 31);
            this.btnNovoLogin.TabIndex = 7;
            this.btnNovoLogin.Text = "Novo";
            this.btnNovoLogin.UseVisualStyleBackColor = false;
            this.btnNovoLogin.Click += new System.EventHandler(this.btnNovoLogin_Click);
            // 
            // btnEditarLogin
            // 
            this.btnEditarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnEditarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarLogin.ForeColor = System.Drawing.Color.White;
            this.btnEditarLogin.Location = new System.Drawing.Point(394, 225);
            this.btnEditarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarLogin.Name = "btnEditarLogin";
            this.btnEditarLogin.Size = new System.Drawing.Size(120, 31);
            this.btnEditarLogin.TabIndex = 9;
            this.btnEditarLogin.Text = "Editar";
            this.btnEditarLogin.UseVisualStyleBackColor = false;
            this.btnEditarLogin.Click += new System.EventHandler(this.btnEditarLogin_Click);
            // 
            // btnSalvarLogin
            // 
            this.btnSalvarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSalvarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarLogin.ForeColor = System.Drawing.Color.White;
            this.btnSalvarLogin.Location = new System.Drawing.Point(255, 225);
            this.btnSalvarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarLogin.Name = "btnSalvarLogin";
            this.btnSalvarLogin.Size = new System.Drawing.Size(120, 31);
            this.btnSalvarLogin.TabIndex = 8;
            this.btnSalvarLogin.Text = "Salvar";
            this.btnSalvarLogin.UseVisualStyleBackColor = false;
            this.btnSalvarLogin.Click += new System.EventHandler(this.btnSalvarLogin_Click);
            // 
            // lblNomeFuncionarioLogin
            // 
            this.lblNomeFuncionarioLogin.AutoSize = true;
            this.lblNomeFuncionarioLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionarioLogin.Location = new System.Drawing.Point(280, 42);
            this.lblNomeFuncionarioLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeFuncionarioLogin.Name = "lblNomeFuncionarioLogin";
            this.lblNomeFuncionarioLogin.Size = new System.Drawing.Size(90, 19);
            this.lblNomeFuncionarioLogin.TabIndex = 108;
            this.lblNomeFuncionarioLogin.Text = "Funcionário";
            // 
            // lblCodigoFuncionarioLogin
            // 
            this.lblCodigoFuncionarioLogin.AutoSize = true;
            this.lblCodigoFuncionarioLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFuncionarioLogin.Location = new System.Drawing.Point(54, 47);
            this.lblCodigoFuncionarioLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoFuncionarioLogin.Name = "lblCodigoFuncionarioLogin";
            this.lblCodigoFuncionarioLogin.Size = new System.Drawing.Size(60, 19);
            this.lblCodigoFuncionarioLogin.TabIndex = 107;
            this.lblCodigoFuncionarioLogin.Text = "Código";
            // 
            // txtCodigoLogin
            // 
            this.txtCodigoLogin.Location = new System.Drawing.Point(118, 44);
            this.txtCodigoLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoLogin.Name = "txtCodigoLogin";
            this.txtCodigoLogin.Size = new System.Drawing.Size(62, 24);
            this.txtCodigoLogin.TabIndex = 1;
            this.txtCodigoLogin.TabStop = false;
            // 
            // tpgConfiguracoesLogin
            // 
            this.tpgConfiguracoesLogin.Controls.Add(this.gboxLogin);
            this.tpgConfiguracoesLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgConfiguracoesLogin.Location = new System.Drawing.Point(4, 28);
            this.tpgConfiguracoesLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesLogin.Name = "tpgConfiguracoesLogin";
            this.tpgConfiguracoesLogin.Padding = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesLogin.Size = new System.Drawing.Size(1192, 688);
            this.tpgConfiguracoesLogin.TabIndex = 1;
            this.tpgConfiguracoesLogin.Text = "Configurações";
            this.tpgConfiguracoesLogin.UseVisualStyleBackColor = true;
            // 
            // lblBuscarLogin
            // 
            this.lblBuscarLogin.AutoSize = true;
            this.lblBuscarLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarLogin.Location = new System.Drawing.Point(57, 24);
            this.lblBuscarLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarLogin.Name = "lblBuscarLogin";
            this.lblBuscarLogin.Size = new System.Drawing.Size(54, 19);
            this.lblBuscarLogin.TabIndex = 0;
            this.lblBuscarLogin.Text = "Buscar";
            // 
            // ttmesagem
            // 
            this.ttmesagem.IsBalloon = true;
            // 
            // btnDeletarLogin
            // 
            this.btnDeletarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnDeletarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarLogin.ForeColor = System.Drawing.Color.White;
            this.btnDeletarLogin.Location = new System.Drawing.Point(506, 18);
            this.btnDeletarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletarLogin.Name = "btnDeletarLogin";
            this.btnDeletarLogin.Size = new System.Drawing.Size(105, 31);
            this.btnDeletarLogin.TabIndex = 6;
            this.btnDeletarLogin.Text = "Deletar";
            this.btnDeletarLogin.UseVisualStyleBackColor = false;
            this.btnDeletarLogin.Click += new System.EventHandler(this.btnDeletarLogin_Click);
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // btnBuscarLogin
            // 
            this.btnBuscarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnBuscarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLogin.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLogin.Location = new System.Drawing.Point(364, 18);
            this.btnBuscarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarLogin.Name = "btnBuscarLogin";
            this.btnBuscarLogin.Size = new System.Drawing.Size(105, 31);
            this.btnBuscarLogin.TabIndex = 3;
            this.btnBuscarLogin.Text = "Buscar";
            this.btnBuscarLogin.UseVisualStyleBackColor = false;
            this.btnBuscarLogin.Click += new System.EventHandler(this.btnBuscarLogin_Click);
            // 
            // tctrlLogin
            // 
            this.tctrlLogin.Controls.Add(this.tpgListarLogin);
            this.tctrlLogin.Controls.Add(this.tpgConfiguracoesLogin);
            this.tctrlLogin.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlLogin.Location = new System.Drawing.Point(1, 80);
            this.tctrlLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tctrlLogin.Name = "tctrlLogin";
            this.tctrlLogin.SelectedIndex = 0;
            this.tctrlLogin.Size = new System.Drawing.Size(1200, 720);
            this.tctrlLogin.TabIndex = 21;
            this.tctrlLogin.SelectedIndexChanged += new System.EventHandler(this.tctrlLogin_SelectedIndexChanged);
            // 
            // tpgListarLogin
            // 
            this.tpgListarLogin.BackColor = System.Drawing.Color.Transparent;
            this.tpgListarLogin.Controls.Add(this.chkDeletarLogin);
            this.tpgListarLogin.Controls.Add(this.dgvLogin);
            this.tpgListarLogin.Controls.Add(this.txtBuscarLogin);
            this.tpgListarLogin.Controls.Add(this.lblTotalLogin);
            this.tpgListarLogin.Controls.Add(this.btnBuscarLogin);
            this.tpgListarLogin.Controls.Add(this.btnDeletarLogin);
            this.tpgListarLogin.Controls.Add(this.lblBuscarLogin);
            this.tpgListarLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgListarLogin.Location = new System.Drawing.Point(4, 28);
            this.tpgListarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tpgListarLogin.Name = "tpgListarLogin";
            this.tpgListarLogin.Padding = new System.Windows.Forms.Padding(2);
            this.tpgListarLogin.Size = new System.Drawing.Size(1192, 688);
            this.tpgListarLogin.TabIndex = 0;
            this.tpgListarLogin.Text = "Listar";
            // 
            // chkDeletarLogin
            // 
            this.chkDeletarLogin.AutoSize = true;
            this.chkDeletarLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeletarLogin.Location = new System.Drawing.Point(12, 53);
            this.chkDeletarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.chkDeletarLogin.Name = "chkDeletarLogin";
            this.chkDeletarLogin.Size = new System.Drawing.Size(78, 23);
            this.chkDeletarLogin.TabIndex = 4;
            this.chkDeletarLogin.Text = "Deletar";
            this.chkDeletarLogin.UseVisualStyleBackColor = true;
            this.chkDeletarLogin.CheckedChanged += new System.EventHandler(this.chkDeletarLogin_CheckedChanged);
            // 
            // dgvLogin
            // 
            this.dgvLogin.AllowUserToAddRows = false;
            this.dgvLogin.AllowUserToDeleteRows = false;
            this.dgvLogin.AllowUserToOrderColumns = true;
            this.dgvLogin.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLogin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLogin.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvLogin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogin.ColumnHeadersHeight = 50;
            this.dgvLogin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.dgvLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLogin.EnableHeadersVisualStyles = false;
            this.dgvLogin.GridColor = System.Drawing.Color.Black;
            this.dgvLogin.Location = new System.Drawing.Point(2, 107);
            this.dgvLogin.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLogin.MultiSelect = false;
            this.dgvLogin.Name = "dgvLogin";
            this.dgvLogin.ReadOnly = true;
            this.dgvLogin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLogin.RowHeadersVisible = false;
            this.dgvLogin.RowHeadersWidth = 51;
            this.dgvLogin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogin.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLogin.RowTemplate.Height = 24;
            this.dgvLogin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogin.Size = new System.Drawing.Size(1180, 577);
            this.dgvLogin.TabIndex = 5;
            this.dgvLogin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogin_CellContentClick);
            this.dgvLogin.DoubleClick += new System.EventHandler(this.dgvLogin_DoubleClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.MinimumWidth = 6;
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            this.Deletar.Width = 67;
            // 
            // txtBuscarLogin
            // 
            this.txtBuscarLogin.Location = new System.Drawing.Point(115, 21);
            this.txtBuscarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarLogin.Name = "txtBuscarLogin";
            this.txtBuscarLogin.Size = new System.Drawing.Size(188, 24);
            this.txtBuscarLogin.TabIndex = 2;
            this.txtBuscarLogin.TextChanged += new System.EventHandler(this.txtBuscarLogin_TextChanged);
            // 
            // lblTotalLogin
            // 
            this.lblTotalLogin.AutoSize = true;
            this.lblTotalLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLogin.Location = new System.Drawing.Point(360, 57);
            this.lblTotalLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalLogin.Name = "lblTotalLogin";
            this.lblTotalLogin.Size = new System.Drawing.Size(57, 19);
            this.lblTotalLogin.TabIndex = 5;
            this.lblTotalLogin.Text = "lblTotal";
            // 
            // ViewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tctrlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewLogin";
            this.Text = "Logins";
            this.Load += new System.EventHandler(this.ViewLogin_Load);
            this.gboxLogin.ResumeLayout(false);
            this.gboxLogin.PerformLayout();
            this.tpgConfiguracoesLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.tctrlLogin.ResumeLayout(false);
            this.tpgListarLogin.ResumeLayout(false);
            this.tpgListarLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxLogin;
        private System.Windows.Forms.ComboBox cboxNivelAcessoLogin;
        private System.Windows.Forms.Label lblNivelAcessoLogin;
        private System.Windows.Forms.Button btnCancelarLogin;
        private System.Windows.Forms.Button btnNovoLogin;
        private System.Windows.Forms.Button btnEditarLogin;
        private System.Windows.Forms.Button btnSalvarLogin;
        private System.Windows.Forms.Label lblNomeFuncionarioLogin;
        private System.Windows.Forms.Label lblCodigoFuncionarioLogin;
        private System.Windows.Forms.TextBox txtCodigoLogin;
        private System.Windows.Forms.TabPage tpgConfiguracoesLogin;
        private System.Windows.Forms.Label lblBuscarLogin;
        private System.Windows.Forms.ToolTip ttmesagem;
        private System.Windows.Forms.Button btnDeletarLogin;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.TabControl tctrlLogin;
        private System.Windows.Forms.TabPage tpgListarLogin;
        private System.Windows.Forms.CheckBox chkDeletarLogin;
        private System.Windows.Forms.DataGridView dgvLogin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.TextBox txtBuscarLogin;
        private System.Windows.Forms.Label lblTotalLogin;
        private System.Windows.Forms.Button btnBuscarLogin;
        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.ComboBox cboxNomeFuncionarioLogin;
    }
}