using Control;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class ViewFuncionario : Form
    {
        ControlFuncionario myFuncionario = new ControlFuncionario();
        Validar myValidar = new Validar();

        private bool eNovo = false;
        private bool eEditar = false;

        private int _IDUnidadeRede;

        public int IDUnidadeRede { get => _IDUnidadeRede; set => _IDUnidadeRede = value; }

        public ViewFuncionario()
        {
            InitializeComponent();
        }

        public ViewFuncionario(int id_unidade)
        {
            InitializeComponent();
            this.IDUnidadeRede = id_unidade;
        }

        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "PIZZA VINTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "PIZZA VINTAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpar()
        {
            this.txtCodigoFuncionario.Text = string.Empty;
            this.txtNomeFuncionario.Text = string.Empty;
            this.cboxSexoFuncionario.Text = null;
            this.txtCPFFuncionario.Text = string.Empty;
            this.dtpNascimentoFuncionario.Value = dtpNascimentoFuncionario.MaxDate;
            this.txtTelefoneFuncionario.Text = string.Empty;
            this.txtEmailFuncionario.Text = string.Empty;

            this.txtCargoFuncionario.Text = string.Empty;
            this.txtSalarioFuncionario.Text = string.Empty;
            this.dtpAdmissaoFuncionario.Value = dtpAdmissaoFuncionario.MaxDate;

            this.txtCEPFuncionario.Text = string.Empty;
            this.txtRuaFuncionario.Text = string.Empty;
            this.txtNumCasaFuncionario.Text = string.Empty;
            this.txtBairroFuncionario.Text = string.Empty;
            this.txtComplementoFuncionario.Text = string.Empty;
            this.txtCidadeFuncionario.Text = string.Empty;
            this.cboxUFFuncionario.Text = null;
        }

        // Habilitar os text box
        private void Habilitar(bool Valor)
        {
            this.txtCodigoFuncionario.Enabled = false;
            this.txtNomeFuncionario.Enabled = Valor;
            this.cboxSexoFuncionario.Enabled = Valor;
            this.txtCPFFuncionario.Enabled = Valor;
            this.dtpNascimentoFuncionario.Enabled = Valor;
            this.txtTelefoneFuncionario.Enabled = Valor;
            this.txtEmailFuncionario.Enabled = Valor;

            this.txtCargoFuncionario.Enabled = Valor;
            this.txtSalarioFuncionario.Enabled = Valor;
            this.dtpAdmissaoFuncionario.Enabled = Valor;

            this.txtCEPFuncionario.Enabled = Valor;
            this.txtRuaFuncionario.Enabled = Valor;
            this.txtNumCasaFuncionario.Enabled = Valor;
            this.txtBairroFuncionario.Enabled = Valor;
            this.txtComplementoFuncionario.Enabled = Valor;
            this.txtCidadeFuncionario.Enabled = Valor;
            this.cboxUFFuncionario.Enabled = Valor;
        }

        private void Botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovoFuncionario.Enabled = false;
                this.btnSalvarFuncionario.Enabled = true;
                this.btnEditarFuncionario.Enabled = false;
                this.btnCancelarFuncionario.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovoFuncionario.Enabled = true;
                this.btnSalvarFuncionario.Enabled = false;
                this.btnEditarFuncionario.Enabled = true;
                this.btnCancelarFuncionario.Enabled = false;
            }
        }

        private void OcultarColunas()
        {
            this.dgvFuncionario.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (this.dgvFuncionario.Rows.Count == 0)
            {
                this.chkDeletarFuncionario.Enabled = false;
                this.btnDeletarFuncionario.Enabled = false;
                this.cboBuscarFuncionario.Enabled = false;
                this.txtBuscarFuncionario.Enabled = false;
                this.btnBuscarFuncionario.Enabled = false;
                this.dgvFuncionario.Enabled = false;
            }
            else
            {
                this.chkDeletarFuncionario.Enabled = true;
                this.btnDeletarFuncionario.Enabled = true;
                this.cboBuscarFuncionario.Enabled = true;
                this.txtBuscarFuncionario.Enabled = true;
                this.btnBuscarFuncionario.Enabled = true;
                this.dgvFuncionario.Enabled = true;
            }
        }

        private void MostrarFuncionario()
        {
            this.dgvFuncionario.DataSource = myFuncionario.MostrarFuncionario(this.IDUnidadeRede);
            this.OcultarColunas();
            lblTotalFuncionario.Text = "Total de Registros:  " + Convert.ToString(dgvFuncionario.Rows.Count);

            this.dgvFuncionario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dgvFuncionario.Columns[1].Visible = false;
            this.dgvFuncionario.Columns[2].HeaderText = "UNIDADE\nDA REDE";
            this.dgvFuncionario.Columns[3].HeaderText = "CÓDIGO";
            this.dgvFuncionario.Columns[4].HeaderText = "NOME";
            this.dgvFuncionario.Columns[5].HeaderText = "SEXO";
            this.dgvFuncionario.Columns[6].HeaderText = "CPF";
            this.dgvFuncionario.Columns[7].HeaderText = "DATA\nNASCIMENTO";
            this.dgvFuncionario.Columns[8].HeaderText = "TELEFONE";
            this.dgvFuncionario.Columns[9].HeaderText = "E-MAIL";
            this.dgvFuncionario.Columns[10].HeaderText = "CARGO";
            this.dgvFuncionario.Columns[11].HeaderText = "SALÁRIO";
            this.dgvFuncionario.Columns[12].HeaderText = "DATA\nADMISSÃO";
            this.dgvFuncionario.Columns[13].HeaderText = "RUA";
            this.dgvFuncionario.Columns[14].HeaderText = "Nº";
            this.dgvFuncionario.Columns[15].HeaderText = "COMPLEMENTO";
            this.dgvFuncionario.Columns[16].HeaderText = "BAIRRO";
            this.dgvFuncionario.Columns[17].HeaderText = "CEP";
            this.dgvFuncionario.Columns[18].HeaderText = "CIDADE";
            this.dgvFuncionario.Columns[19].HeaderText = "UF";

            this.dgvFuncionario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridView();
        }

        private void BuscarNomeFuncionario()
        {
            this.dgvFuncionario.DataSource = myFuncionario.BuscarNomeFuncionario(this.txtBuscarFuncionario.Text, this.IDUnidadeRede);
            this.OcultarColunas();
            lblTotalFuncionario.Text = "Total de Registros:  " + Convert.ToString(dgvFuncionario.Rows.Count);
        }

        private void BuscarCPFFuncionario()
        {
            this.dgvFuncionario.DataSource = myFuncionario.BuscarCPFFuncionario(this.txtBuscarFuncionario.Text, this.IDUnidadeRede);
            this.OcultarColunas();
            lblTotalFuncionario.Text = "Total de Registros:  " + Convert.ToString(dgvFuncionario.Rows.Count);
        }

        private void ValidarTamanhoCampo(TextBox campo, int tamanho)
        {
            string tamanhovalido = Convert.ToString(campo.Text);
            myValidar.TamanhoCampo(tamanhovalido, tamanho);

            if (myValidar.TamanhoValido == false)
            {
                errorIcone.SetError(campo, "Limite de caracteres excedido" +
                                            "\nO limite para este campo é: " + tamanho + " caracteres" +
                                            "\nQuantidade utilizada: " + campo.TextLength);
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarCampoNulo(TextBox campo)
        {
            string campovalido = Convert.ToString(campo.Text);
            myValidar.CampoNulo(campovalido);

            if (myValidar.CampoValido == false)
            {
                errorIcone.SetError(campo, "Este campo é obrigatório");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarCampoNuloMasked(MaskedTextBox campo)
        {
            string campovalido = Convert.ToString(campo.Text);
            myValidar.CampoNulo(campovalido);

            if (myValidar.CampoValido == false)
            {
                errorIcone.SetError(campo, "Este campo é obrigatório");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarLetra(TextBox campo)
        {
            string letravalida = Convert.ToString(campo.Text);
            myValidar.Letra(letravalida);

            if (myValidar.LetraValida == false)
            {
                errorIcone.SetError(campo, "Este campo deve ser preenchido somente com letras");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarNumero(TextBox campo)
        {
            string numerovalido = Convert.ToString(campo.Text);
            myValidar.Numero(numerovalido);

            if (myValidar.NumeroValido == false)
            {
                errorIcone.SetError(campo, "Este campo deve ser preenchido somente com números");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarNascimento(DateTimePicker campo)
        {
            myValidar.DataNascimentoObrigatorio(campo);

            if (myValidar.DtNascimentoValido == false)
            {
                errorIcone.SetError(campo, "O funcionário deve ter mais de 18 anos para ser cadastrado");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarValor(TextBox campo)
        {
            string valorvalido = Convert.ToString(campo.Text);
            myValidar.Valor(valorvalido);

            if (myValidar.ValorValido == false)
            {
                errorIcone.SetError(campo, "Este campo deve ser preenchido somente com números, vírgulas e pontos." +
                                            "\nVerifique também a disposição dos números conforme Ex: 999.999,00");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ViewFuncionario_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarFuncionario();
            this.Habilitar(false);
            this.Botoes();
            this.txtCodigoFuncionario.Enabled = false;

            this.dtpAdmissaoFuncionario.MaxDate = DateTime.Today;
            this.dtpAdmissaoFuncionario.Value = dtpAdmissaoFuncionario.MaxDate;

            this.dtpNascimentoFuncionario.MinDate = DateTime.Today.AddYears(-60);
            this.dtpNascimentoFuncionario.MaxDate = DateTime.Today.AddDays(-6574.5);
        }

        private void cboBuscarFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscarFuncionario.Text = string.Empty;
        }

        private void txtBuscarFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (cboBuscarFuncionario.Text.Equals("Nome"))
            {
                this.BuscarNomeFuncionario();
            }
            else if (cboBuscarFuncionario.Text.Equals("CPF"))
            {
                this.BuscarCPFFuncionario();
            }
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            if (cboBuscarFuncionario.Text.Equals("Nome"))
            {
                this.BuscarNomeFuncionario();
            }
            else if (cboBuscarFuncionario.Text.Equals("CPF"))
            {
                this.BuscarCPFFuncionario();
            }
        }

        private void chkDeletarFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarFuncionario.Checked)
            {
                this.dgvFuncionario.Columns[0].Visible = true;
            }
            else
            {
                this.dgvFuncionario.Columns[0].Visible = false;
            }
        }

        private void btnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvFuncionario.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há funcionários selecionados para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja apagar os registros?",
                        "PIZZA VINTAGE",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        string Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvFuncionario.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                resp = myFuncionario.ExcluirFuncionario(Convert.ToInt32(Codigo), this.IDUnidadeRede);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            this.MensagemOk("Registro(s) excluído(s) com sucesso");
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }

                        this.MostrarFuncionario();
                        chkDeletarFuncionario.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFuncionario.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvFuncionario.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dgvFuncionario_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvFuncionario.Rows.Count == 0)
            {
                MensagemErro("Não há funcionários cadastrados");
            }
            else
            {
                this.txtCodigoFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["ID_Funcionario"].Value);
                this.txtNomeFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["NM_Funcionario"].Value);
                this.cboxSexoFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["DS_Sexo"].Value);
                this.txtCPFFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["NR_CPF"].Value);
                this.dtpNascimentoFuncionario.Value = Convert.ToDateTime(this.dgvFuncionario.CurrentRow.Cells["DT_Nascimento"].Value);
                this.txtTelefoneFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["NR_Telefone"].Value);
                this.txtEmailFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["DS_Email"].Value);
                this.txtCEPFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["NR_CEP"].Value);
                this.txtRuaFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["NM_Rua"].Value);
                this.txtNumCasaFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["NR_Casa"].Value);
                this.txtBairroFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["NM_Bairro"].Value);
                this.txtComplementoFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["DS_Complemento"].Value);
                this.txtCidadeFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["NM_Cidade"].Value);
                this.cboxUFFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["DS_UF"].Value);
                this.txtCargoFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["DS_Cargo"].Value);
                this.txtSalarioFuncionario.Text = Convert.ToString(this.dgvFuncionario.CurrentRow.Cells["VL_Salario"].Value);
                this.dtpAdmissaoFuncionario.Value = Convert.ToDateTime(this.dgvFuncionario.CurrentRow.Cells["DT_Admissao"].Value);

                this.tctrlFuncionario.SelectedIndex = 1;
            }
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.Botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtNomeFuncionario.Focus();
        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                bool NomeFuncionarioOK = false;
                bool CPFFuncionarioOK = false;
                bool NascimentoFuncionarioOK = false;
                bool TelefoneFuncionarioOK = false;
                bool CargoFuncionarioOK = false;
                bool SalarioFuncionarioOK = false;
                bool RuaFuncionarioOK = false;
                bool NumCasaFuncionarioOK = false;
                bool BairroFuncionarioOK = false;

                bool CPFcadastrado = false;

                string resp = "";

                ValidarCampoNulo(txtNomeFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNomeFuncionario, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        ValidarLetra(txtNomeFuncionario);
                        if (myValidar.LetraValida == true)
                        {
                            NomeFuncionarioOK = true;
                        }
                    }
                }

                ValidarCampoNuloMasked(txtCPFFuncionario);
                if (myValidar.CampoValido == true)
                {
                    if (!txtCPFFuncionario.MaskCompleted)
                    {
                        errorIcone.SetError(txtCPFFuncionario, "O CPF está incompleto");
                    }
                    else
                    {
                        if (myValidar.ValidaCPF(txtCPFFuncionario.Text) == false)
                        {
                            errorIcone.SetError(txtCPFFuncionario, "Número de CPF inválido");
                        }
                        else
                        {
                            errorIcone.SetError(txtCPFFuncionario, string.Empty);
                            CPFFuncionarioOK = true;
                        }                                           
                    }
                }

                ValidarNascimento(dtpNascimentoFuncionario);
                if (myValidar.DtNascimentoValido == true)
                {
                    NascimentoFuncionarioOK = true;
                }

                if (cboxSexoFuncionario.Text == null)
                {
                    cboxSexoFuncionario.Text = null;
                }

                ValidarCampoNuloMasked(txtTelefoneFuncionario);
                if (myValidar.CampoValido == true)
                {
                    if (!txtTelefoneFuncionario.MaskCompleted)
                    {
                        errorIcone.SetError(txtTelefoneFuncionario, "O telefone está incompleto");
                    }
                    else
                    {
                        errorIcone.SetError(txtTelefoneFuncionario, string.Empty);
                        TelefoneFuncionarioOK = true;
                    }
                }

                if (txtEmailFuncionario.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtEmailFuncionario, 50);
                }

                ValidarCampoNulo(txtRuaFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtRuaFuncionario, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        RuaFuncionarioOK = true;
                    }
                }

                ValidarCampoNulo(txtNumCasaFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNumCasaFuncionario, 5);
                    if (myValidar.TamanhoValido == true)
                    {
                        ValidarNumero(txtNumCasaFuncionario);
                        if (myValidar.NumeroValido == true)
                        {
                            NumCasaFuncionarioOK = true;
                        }
                    }
                }

                ValidarCampoNulo(txtBairroFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtBairroFuncionario, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        BairroFuncionarioOK = true;
                    }
                }

                if (txtComplementoFuncionario.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtComplementoFuncionario, 50);
                }

                if (txtCidadeFuncionario.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtCidadeFuncionario, 30);
                }

                ValidarCampoNulo(txtCargoFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtCargoFuncionario, 30);
                    if (myValidar.TamanhoValido == true)
                    {
                        ValidarLetra(txtCargoFuncionario);
                        if (myValidar.LetraValida == true)
                        {
                            CargoFuncionarioOK = true;
                        }
                    }
                }

                ValidarCampoNulo(txtSalarioFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarValor(txtSalarioFuncionario);
                    if (myValidar.ValorValido == true)
                    {
                        SalarioFuncionarioOK = true;
                    }
                }

                if (NomeFuncionarioOK == false ||
                    CPFFuncionarioOK == false ||
                    NascimentoFuncionarioOK == false ||
                    TelefoneFuncionarioOK == false ||
                    CargoFuncionarioOK == false ||
                    SalarioFuncionarioOK == false ||
                    RuaFuncionarioOK == false ||
                    NumCasaFuncionarioOK == false ||
                    BairroFuncionarioOK == false)
                {
                    MensagemErro("Preencha corretamente todos os campos sinalizados");
                }
                else
                {
                    errorIcone.Clear();

                    if (this.eNovo)
                    {

                        foreach (DataGridViewRow row in dgvFuncionario.Rows)
                        {
                            if (txtCPFFuncionario.Text == Convert.ToString(row.Cells["NR_CPF"].Value))
                            {
                                CPFcadastrado = true;
                            }
                        }

                        if (CPFcadastrado == true)
                        {
                            MensagemErro("CPF já cadastrado na base de dados");
                        }
                        else
                        {
                            resp = myFuncionario.InserirFuncionario(
                            this.txtNomeFuncionario.Text.Trim(),
                            this.cboxSexoFuncionario.Text,
                            this.txtCPFFuncionario.Text,
                            this.dtpNascimentoFuncionario.Value,
                            this.txtTelefoneFuncionario.Text,
                            this.txtEmailFuncionario.Text.Trim(),
                            this.txtCEPFuncionario.Text,
                            this.txtRuaFuncionario.Text.Trim(),
                            this.txtNumCasaFuncionario.Text,
                            this.txtBairroFuncionario.Text.Trim(),
                            this.txtComplementoFuncionario.Text.Trim(),
                            this.txtCidadeFuncionario.Text.Trim(),
                            this.cboxUFFuncionario.Text,
                            this.txtCargoFuncionario.Text.Trim(),
                            Convert.ToDouble(this.txtSalarioFuncionario.Text),
                            this.dtpAdmissaoFuncionario.Value,
                            this.IDUnidadeRede);
                        }
                    }
                    else
                    {
                        resp = myFuncionario.EditarFuncionario(
                            Convert.ToInt32(this.txtCodigoFuncionario.Text),
                            this.txtNomeFuncionario.Text.Trim(),
                            this.cboxSexoFuncionario.Text,
                            this.txtCPFFuncionario.Text,
                            this.dtpNascimentoFuncionario.Value,
                            this.txtTelefoneFuncionario.Text,
                            this.txtEmailFuncionario.Text.Trim(),
                            this.txtCEPFuncionario.Text,
                            this.txtRuaFuncionario.Text.Trim(),
                            this.txtNumCasaFuncionario.Text,
                            this.txtBairroFuncionario.Text.Trim(),
                            this.txtComplementoFuncionario.Text.Trim(),
                            this.txtCidadeFuncionario.Text.Trim(),
                            this.cboxUFFuncionario.Text,
                            this.txtCargoFuncionario.Text.Trim(),
                            Convert.ToDouble(this.txtSalarioFuncionario.Text),
                            this.dtpAdmissaoFuncionario.Value,
                            this.IDUnidadeRede);
                    }
                    if (resp.Equals("OK"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOk("Registro salvo com sucesso");
                        }
                        else
                        {
                            this.MensagemOk("Registro editado com sucesso");
                        }

                        this.eNovo = false;
                        this.eEditar = false;
                        this.Botoes();
                        this.Limpar();
                        this.MostrarFuncionario();
                    }
                    else
                    {
                        if (CPFcadastrado == false)
                        {
                            this.MensagemErro(resp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            if (this.txtNomeFuncionario.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para editar");
            }
            else
            {
                this.txtCodigoFuncionario.Enabled = false;
                this.eEditar = true;
                this.Botoes();
                this.Habilitar(true);

                this.txtCodigoFuncionario.Enabled = false;
                this.txtCPFFuncionario.Enabled = false;
                this.txtNomeFuncionario.Enabled = false;
                this.dtpNascimentoFuncionario.Enabled = false;
                this.dtpAdmissaoFuncionario.Enabled = false;
            }
        }

        private void btnCancelarFuncionario_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            this.eNovo = false;
            this.eEditar = false;
            this.Botoes();
            this.Habilitar(false);
            this.Limpar();
        }

        private void tctrlFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlFuncionario.SelectedIndex == 0)
            {
                this.Habilitar(false);
                this.Limpar();

                this.btnNovoFuncionario.Enabled = true;
                this.btnSalvarFuncionario.Enabled = false;
                this.btnEditarFuncionario.Enabled = true;
                this.btnCancelarFuncionario.Enabled = false;
            }
        }
    }
}
