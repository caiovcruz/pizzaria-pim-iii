namespace View
{
    partial class ViewCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBuscarCompra = new System.Windows.Forms.Label();
            this.btnBuscarCompra = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnNovaCompra = new System.Windows.Forms.Button();
            this.chkDeletarCompra = new System.Windows.Forms.CheckBox();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSalvarCompra = new System.Windows.Forms.Button();
            this.lblInsumoCompra = new System.Windows.Forms.Label();
            this.lblCodigoCompra = new System.Windows.Forms.Label();
            this.tpgListarCompra = new System.Windows.Forms.TabPage();
            this.dtBuscarCompra = new System.Windows.Forms.DateTimePicker();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.btnDeletarCompra = new System.Windows.Forms.Button();
            this.tctrlCompra = new System.Windows.Forms.TabControl();
            this.tpgConfiguracoesCompra = new System.Windows.Forms.TabPage();
            this.gboxCompra = new System.Windows.Forms.GroupBox();
            this.dtCompra = new System.Windows.Forms.DateTimePicker();
            this.lblDtCompra = new System.Windows.Forms.Label();
            this.txtQuantidadeInsumoCompra = new System.Windows.Forms.TextBox();
            this.lblQuantidadeInsumoCompra = new System.Windows.Forms.Label();
            this.cboxInsumoCompra = new System.Windows.Forms.ComboBox();
            this.txtCodigoCompra = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttmesagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.tpgListarCompra.SuspendLayout();
            this.tctrlCompra.SuspendLayout();
            this.tpgConfiguracoesCompra.SuspendLayout();
            this.gboxCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarCompra
            // 
            this.lblBuscarCompra.AutoSize = true;
            this.lblBuscarCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCompra.Location = new System.Drawing.Point(38, 24);
            this.lblBuscarCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarCompra.Name = "lblBuscarCompra";
            this.lblBuscarCompra.Size = new System.Drawing.Size(54, 19);
            this.lblBuscarCompra.TabIndex = 0;
            this.lblBuscarCompra.Text = "Buscar";
            // 
            // btnBuscarCompra
            // 
            this.btnBuscarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnBuscarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCompra.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCompra.Location = new System.Drawing.Point(332, 18);
            this.btnBuscarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCompra.Name = "btnBuscarCompra";
            this.btnBuscarCompra.Size = new System.Drawing.Size(105, 31);
            this.btnBuscarCompra.TabIndex = 2;
            this.btnBuscarCompra.Text = "Buscar";
            this.btnBuscarCompra.UseVisualStyleBackColor = false;
            this.btnBuscarCompra.Click += new System.EventHandler(this.btnBuscarCompra_Click);
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCompra.Location = new System.Drawing.Point(478, 193);
            this.btnCancelarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(120, 31);
            this.btnCancelarCompra.TabIndex = 11;
            this.btnCancelarCompra.Text = "Cancelar";
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnNovaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaCompra.ForeColor = System.Drawing.Color.White;
            this.btnNovaCompra.Location = new System.Drawing.Point(118, 193);
            this.btnNovaCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Size = new System.Drawing.Size(120, 31);
            this.btnNovaCompra.TabIndex = 8;
            this.btnNovaCompra.Text = "Novo";
            this.btnNovaCompra.UseVisualStyleBackColor = false;
            this.btnNovaCompra.Click += new System.EventHandler(this.btnNovaCompra_Click);
            // 
            // chkDeletarCompra
            // 
            this.chkDeletarCompra.AutoSize = true;
            this.chkDeletarCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeletarCompra.Location = new System.Drawing.Point(12, 53);
            this.chkDeletarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.chkDeletarCompra.Name = "chkDeletarCompra";
            this.chkDeletarCompra.Size = new System.Drawing.Size(78, 23);
            this.chkDeletarCompra.TabIndex = 3;
            this.chkDeletarCompra.Text = "Deletar";
            this.chkDeletarCompra.UseVisualStyleBackColor = true;
            this.chkDeletarCompra.CheckedChanged += new System.EventHandler(this.chkDeletarCompra_CheckedChanged);
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AllowUserToOrderColumns = true;
            this.dgvCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCompra.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCompra.ColumnHeadersHeight = 50;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.dgvCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCompra.EnableHeadersVisualStyles = false;
            this.dgvCompra.GridColor = System.Drawing.Color.Black;
            this.dgvCompra.Location = new System.Drawing.Point(2, 107);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCompra.MultiSelect = false;
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCompra.RowHeadersVisible = false;
            this.dgvCompra.RowHeadersWidth = 51;
            this.dgvCompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCompra.RowTemplate.Height = 24;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(1180, 577);
            this.dgvCompra.TabIndex = 4;
            this.dgvCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellContentClick);
            this.dgvCompra.DoubleClick += new System.EventHandler(this.dgvCompra_DoubleClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.MinimumWidth = 6;
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            this.Deletar.Width = 67;
            // 
            // btnSalvarCompra
            // 
            this.btnSalvarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSalvarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCompra.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCompra.Location = new System.Drawing.Point(255, 193);
            this.btnSalvarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarCompra.Name = "btnSalvarCompra";
            this.btnSalvarCompra.Size = new System.Drawing.Size(120, 31);
            this.btnSalvarCompra.TabIndex = 9;
            this.btnSalvarCompra.Text = "Salvar";
            this.btnSalvarCompra.UseVisualStyleBackColor = false;
            this.btnSalvarCompra.Click += new System.EventHandler(this.btnSalvarCompra_Click);
            // 
            // lblInsumoCompra
            // 
            this.lblInsumoCompra.AutoSize = true;
            this.lblInsumoCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsumoCompra.Location = new System.Drawing.Point(56, 88);
            this.lblInsumoCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsumoCompra.Name = "lblInsumoCompra";
            this.lblInsumoCompra.Size = new System.Drawing.Size(57, 19);
            this.lblInsumoCompra.TabIndex = 108;
            this.lblInsumoCompra.Text = "Insumo";
            // 
            // lblCodigoCompra
            // 
            this.lblCodigoCompra.AutoSize = true;
            this.lblCodigoCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCompra.Location = new System.Drawing.Point(54, 47);
            this.lblCodigoCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoCompra.Name = "lblCodigoCompra";
            this.lblCodigoCompra.Size = new System.Drawing.Size(60, 19);
            this.lblCodigoCompra.TabIndex = 107;
            this.lblCodigoCompra.Text = "Código";
            // 
            // tpgListarCompra
            // 
            this.tpgListarCompra.BackColor = System.Drawing.Color.Transparent;
            this.tpgListarCompra.Controls.Add(this.dtBuscarCompra);
            this.tpgListarCompra.Controls.Add(this.chkDeletarCompra);
            this.tpgListarCompra.Controls.Add(this.dgvCompra);
            this.tpgListarCompra.Controls.Add(this.lblTotalCompra);
            this.tpgListarCompra.Controls.Add(this.btnBuscarCompra);
            this.tpgListarCompra.Controls.Add(this.btnDeletarCompra);
            this.tpgListarCompra.Controls.Add(this.lblBuscarCompra);
            this.tpgListarCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgListarCompra.Location = new System.Drawing.Point(4, 28);
            this.tpgListarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.tpgListarCompra.Name = "tpgListarCompra";
            this.tpgListarCompra.Padding = new System.Windows.Forms.Padding(2);
            this.tpgListarCompra.Size = new System.Drawing.Size(1192, 688);
            this.tpgListarCompra.TabIndex = 0;
            this.tpgListarCompra.Text = "Listar";
            // 
            // dtBuscarCompra
            // 
            this.dtBuscarCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBuscarCompra.Location = new System.Drawing.Point(97, 19);
            this.dtBuscarCompra.Name = "dtBuscarCompra";
            this.dtBuscarCompra.Size = new System.Drawing.Size(188, 24);
            this.dtBuscarCompra.TabIndex = 128;
            this.dtBuscarCompra.ValueChanged += new System.EventHandler(this.dtBuscarCompra_ValueChanged);
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(328, 57);
            this.lblTotalCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(57, 19);
            this.lblTotalCompra.TabIndex = 5;
            this.lblTotalCompra.Text = "lblTotal";
            // 
            // btnDeletarCompra
            // 
            this.btnDeletarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnDeletarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarCompra.ForeColor = System.Drawing.Color.White;
            this.btnDeletarCompra.Location = new System.Drawing.Point(474, 18);
            this.btnDeletarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletarCompra.Name = "btnDeletarCompra";
            this.btnDeletarCompra.Size = new System.Drawing.Size(105, 31);
            this.btnDeletarCompra.TabIndex = 5;
            this.btnDeletarCompra.Text = "Deletar";
            this.btnDeletarCompra.UseVisualStyleBackColor = false;
            this.btnDeletarCompra.Click += new System.EventHandler(this.btnDeletarCompra_Click);
            // 
            // tctrlCompra
            // 
            this.tctrlCompra.Controls.Add(this.tpgListarCompra);
            this.tctrlCompra.Controls.Add(this.tpgConfiguracoesCompra);
            this.tctrlCompra.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlCompra.Location = new System.Drawing.Point(1, 80);
            this.tctrlCompra.Margin = new System.Windows.Forms.Padding(2);
            this.tctrlCompra.Name = "tctrlCompra";
            this.tctrlCompra.SelectedIndex = 0;
            this.tctrlCompra.Size = new System.Drawing.Size(1200, 720);
            this.tctrlCompra.TabIndex = 21;
            this.tctrlCompra.SelectedIndexChanged += new System.EventHandler(this.tctrlCompra_SelectedIndexChanged);
            // 
            // tpgConfiguracoesCompra
            // 
            this.tpgConfiguracoesCompra.Controls.Add(this.gboxCompra);
            this.tpgConfiguracoesCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgConfiguracoesCompra.Location = new System.Drawing.Point(4, 28);
            this.tpgConfiguracoesCompra.Margin = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesCompra.Name = "tpgConfiguracoesCompra";
            this.tpgConfiguracoesCompra.Padding = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesCompra.Size = new System.Drawing.Size(1192, 688);
            this.tpgConfiguracoesCompra.TabIndex = 1;
            this.tpgConfiguracoesCompra.Text = "Configurações";
            this.tpgConfiguracoesCompra.UseVisualStyleBackColor = true;
            // 
            // gboxCompra
            // 
            this.gboxCompra.BackColor = System.Drawing.Color.White;
            this.gboxCompra.Controls.Add(this.dtCompra);
            this.gboxCompra.Controls.Add(this.lblDtCompra);
            this.gboxCompra.Controls.Add(this.txtQuantidadeInsumoCompra);
            this.gboxCompra.Controls.Add(this.lblQuantidadeInsumoCompra);
            this.gboxCompra.Controls.Add(this.cboxInsumoCompra);
            this.gboxCompra.Controls.Add(this.btnCancelarCompra);
            this.gboxCompra.Controls.Add(this.btnNovaCompra);
            this.gboxCompra.Controls.Add(this.btnSalvarCompra);
            this.gboxCompra.Controls.Add(this.lblInsumoCompra);
            this.gboxCompra.Controls.Add(this.lblCodigoCompra);
            this.gboxCompra.Controls.Add(this.txtCodigoCompra);
            this.gboxCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxCompra.Location = new System.Drawing.Point(2, 0);
            this.gboxCompra.Margin = new System.Windows.Forms.Padding(2);
            this.gboxCompra.Name = "gboxCompra";
            this.gboxCompra.Padding = new System.Windows.Forms.Padding(2);
            this.gboxCompra.Size = new System.Drawing.Size(1300, 692);
            this.gboxCompra.TabIndex = 0;
            this.gboxCompra.TabStop = false;
            this.gboxCompra.Text = "Produto";
            // 
            // dtCompra
            // 
            this.dtCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCompra.Location = new System.Drawing.Point(410, 47);
            this.dtCompra.Name = "dtCompra";
            this.dtCompra.Size = new System.Drawing.Size(188, 24);
            this.dtCompra.TabIndex = 133;
            // 
            // lblDtCompra
            // 
            this.lblDtCompra.AutoSize = true;
            this.lblDtCompra.Location = new System.Drawing.Point(301, 52);
            this.lblDtCompra.Name = "lblDtCompra";
            this.lblDtCompra.Size = new System.Drawing.Size(103, 19);
            this.lblDtCompra.TabIndex = 132;
            this.lblDtCompra.Text = "Data compra";
            this.lblDtCompra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtQuantidadeInsumoCompra
            // 
            this.txtQuantidadeInsumoCompra.Location = new System.Drawing.Point(410, 86);
            this.txtQuantidadeInsumoCompra.Name = "txtQuantidadeInsumoCompra";
            this.txtQuantidadeInsumoCompra.Size = new System.Drawing.Size(101, 24);
            this.txtQuantidadeInsumoCompra.TabIndex = 131;
            // 
            // lblQuantidadeInsumoCompra
            // 
            this.lblQuantidadeInsumoCompra.AutoSize = true;
            this.lblQuantidadeInsumoCompra.Location = new System.Drawing.Point(308, 89);
            this.lblQuantidadeInsumoCompra.Name = "lblQuantidadeInsumoCompra";
            this.lblQuantidadeInsumoCompra.Size = new System.Drawing.Size(96, 19);
            this.lblQuantidadeInsumoCompra.TabIndex = 130;
            this.lblQuantidadeInsumoCompra.Text = "Quantidade";
            // 
            // cboxInsumoCompra
            // 
            this.cboxInsumoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxInsumoCompra.FormattingEnabled = true;
            this.cboxInsumoCompra.Location = new System.Drawing.Point(118, 85);
            this.cboxInsumoCompra.Name = "cboxInsumoCompra";
            this.cboxInsumoCompra.Size = new System.Drawing.Size(162, 27);
            this.cboxInsumoCompra.TabIndex = 129;
            this.ttmesagem.SetToolTip(this.cboxInsumoCompra, "Selecione o insumo da compra");
            // 
            // txtCodigoCompra
            // 
            this.txtCodigoCompra.Location = new System.Drawing.Point(118, 47);
            this.txtCodigoCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoCompra.Name = "txtCodigoCompra";
            this.txtCodigoCompra.Size = new System.Drawing.Size(99, 24);
            this.txtCodigoCompra.TabIndex = 1;
            this.txtCodigoCompra.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // ttmesagem
            // 
            this.ttmesagem.IsBalloon = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 79);
            this.panel1.TabIndex = 20;
            // 
            // ViewCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tctrlCompra);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.ViewCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.tpgListarCompra.ResumeLayout(false);
            this.tpgListarCompra.PerformLayout();
            this.tctrlCompra.ResumeLayout(false);
            this.tpgConfiguracoesCompra.ResumeLayout(false);
            this.gboxCompra.ResumeLayout(false);
            this.gboxCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarCompra;
        private System.Windows.Forms.Button btnBuscarCompra;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button btnNovaCompra;
        private System.Windows.Forms.CheckBox chkDeletarCompra;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.Button btnSalvarCompra;
        private System.Windows.Forms.Label lblInsumoCompra;
        private System.Windows.Forms.Label lblCodigoCompra;
        private System.Windows.Forms.TabPage tpgListarCompra;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Button btnDeletarCompra;
        private System.Windows.Forms.TabControl tctrlCompra;
        private System.Windows.Forms.TabPage tpgConfiguracoesCompra;
        private System.Windows.Forms.GroupBox gboxCompra;
        private System.Windows.Forms.TextBox txtCodigoCompra;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip ttmesagem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtBuscarCompra;
        private System.Windows.Forms.DateTimePicker dtCompra;
        private System.Windows.Forms.Label lblDtCompra;
        private System.Windows.Forms.TextBox txtQuantidadeInsumoCompra;
        private System.Windows.Forms.Label lblQuantidadeInsumoCompra;
        private System.Windows.Forms.ComboBox cboxInsumoCompra;
    }
}