using Control;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class ViewCliente : Form
    {
        ControlCliente myCliente = new ControlCliente();
        Validar myValidar = new Validar();

        private bool eNovo = false;
        private bool eEditar = false;

        public ViewCliente()
        {
            InitializeComponent();
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
            this.txtCodigoCliente.Text = string.Empty;
            this.txtNomeCliente.Text = string.Empty;
            this.cboxSexoCliente.Text = null;
            this.txtCPFCliente.Text = string.Empty;
            this.dtpNascimentoCliente.Value = dtpNascimentoCliente.MaxDate;
            this.txtTelefoneCliente.Text = string.Empty;
            this.txtEmailCliente.Text = string.Empty;

            this.txtCEPCliente.Text = string.Empty;
            this.txtRuaCliente.Text = string.Empty;
            this.txtNumCasaCliente.Text = string.Empty;
            this.txtBairroCliente.Text = string.Empty;
            this.txtComplementoCliente.Text = string.Empty;
            this.txtCidadeCliente.Text = string.Empty;
            this.cboxUFCliente.Text = null;
        }

        // Habilitar os text box
        private void Habilitar(bool Valor)
        {
            this.txtCodigoCliente.Enabled = false;
            this.txtNomeCliente.Enabled = Valor;
            this.cboxSexoCliente.Enabled = Valor;
            this.txtCPFCliente.Enabled = Valor;
            this.dtpNascimentoCliente.Enabled = Valor;
            this.txtTelefoneCliente.Enabled = Valor;
            this.txtEmailCliente.Enabled = Valor;

            this.txtCEPCliente.Enabled = Valor;
            this.txtRuaCliente.Enabled = Valor;
            this.txtNumCasaCliente.Enabled = Valor;
            this.txtBairroCliente.Enabled = Valor;
            this.txtComplementoCliente.Enabled = Valor;
            this.txtCidadeCliente.Enabled = Valor;
            this.cboxUFCliente.Enabled = Valor;
        }

        private void Botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovoCliente.Enabled = false;
                this.btnSalvarCliente.Enabled = true;
                this.btnEditarCliente.Enabled = false;
                this.btnCancelarCliente.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovoCliente.Enabled = true;
                this.btnSalvarCliente.Enabled = false;
                this.btnEditarCliente.Enabled = true;
                this.btnCancelarCliente.Enabled = false;
            }
        }

        private void OcultarColunas()
        {
            this.dgvCliente.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (this.dgvCliente.Rows.Count == 0)
            {
                this.chkDeletarCliente.Enabled = false;
                this.btnDeletarCliente.Enabled = false;
                this.cboBuscarCliente.Enabled = false;
                this.txtBuscarCliente.Enabled = false;
                this.btnBuscarCliente.Enabled = false;
                this.dgvCliente.Enabled = false;
            }
            else
            {
                this.chkDeletarCliente.Enabled = true;
                this.btnDeletarCliente.Enabled = true;
                this.cboBuscarCliente.Enabled = true;
                this.txtBuscarCliente.Enabled = true;
                this.btnBuscarCliente.Enabled = true;
                this.dgvCliente.Enabled = true;
            }
        }

        private void MostrarCliente()
        {
            this.dgvCliente.DataSource = myCliente.MostrarCliente();
            this.OcultarColunas();
            lblTotalCliente.Text = "Total de Registros:  " + Convert.ToString(dgvCliente.Rows.Count);

            this.dgvCliente.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dgvCliente.Columns[1].HeaderText = "CÓDIGO";
            this.dgvCliente.Columns[2].HeaderText = "NOME";
            this.dgvCliente.Columns[3].HeaderText = "SEXO";
            this.dgvCliente.Columns[4].HeaderText = "CPF";
            this.dgvCliente.Columns[5].HeaderText = "DATA\nNASCIMENTO";
            this.dgvCliente.Columns[6].HeaderText = "TELEFONE";
            this.dgvCliente.Columns[7].HeaderText = "E-MAIL";
            this.dgvCliente.Columns[8].HeaderText = "RUA";
            this.dgvCliente.Columns[9].HeaderText = "Nº";
            this.dgvCliente.Columns[10].HeaderText = "COMPLEMENTO";
            this.dgvCliente.Columns[11].HeaderText = "BAIRRO";
            this.dgvCliente.Columns[12].HeaderText = "CEP";
            this.dgvCliente.Columns[13].HeaderText = "CIDADE";
            this.dgvCliente.Columns[14].HeaderText = "UF";

            this.dgvCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridView();
        }

        private void BuscarNomeCliente()
        {
            this.dgvCliente.DataSource = myCliente.BuscarNomeCliente(this.txtBuscarCliente.Text);
            this.OcultarColunas();
            lblTotalCliente.Text = "Total de Registros:  " + Convert.ToString(dgvCliente.Rows.Count);
        }

        private void BuscarCPFCliente()
        {
            this.dgvCliente.DataSource = myCliente.BuscarCPFCliente(this.txtBuscarCliente.Text);
            this.OcultarColunas();
            lblTotalCliente.Text = "Total de Registros:  " + Convert.ToString(dgvCliente.Rows.Count);
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

        private void ViewCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarCliente();
            this.Habilitar(false);
            this.Botoes();
            this.txtCodigoCliente.Enabled = false;

            this.dtpNascimentoCliente.MinDate = DateTime.Today.AddYears(- 130);
            this.dtpNascimentoCliente.MaxDate = DateTime.Today.AddDays(- 6574.5);
        }

        private void cboBuscarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscarCliente.Text = string.Empty;
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            if (cboBuscarCliente.Text.Equals("Nome"))
            {
                this.BuscarNomeCliente();
            }
            else if (cboBuscarCliente.Text.Equals("CPF"))
            {
                this.BuscarCPFCliente();
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (cboBuscarCliente.Text.Equals("Nome"))
            {
                this.BuscarNomeCliente();
            }
            else if (cboBuscarCliente.Text.Equals("CPF"))
            {
                this.BuscarCPFCliente();
            }
        }

        private void chkDeletarCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarCliente.Checked)
            {
                this.dgvCliente.Columns[0].Visible = true;
            }
            else
            {
                this.dgvCliente.Columns[0].Visible = false;

                foreach (DataGridViewRow row in dgvCliente.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvCliente.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há clientes selecionados para excluir");
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

                        foreach (DataGridViewRow row in dgvCliente.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                resp = myCliente.ExcluirCliente(Convert.ToInt32(Codigo));
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

                        this.MostrarCliente();
                        chkDeletarCliente.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCliente.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvCliente.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigoCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["ID_Cliente"].Value);
            this.txtNomeCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["NM_Cliente"].Value);
            this.cboxSexoCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["DS_Sexo"].Value);
            this.txtCPFCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["NR_CPF"].Value);

            try
            {
                this.dtpNascimentoCliente.Value = Convert.ToDateTime(this.dgvCliente.CurrentRow.Cells["DT_Nascimento"].Value);
            }
            catch (Exception)
            {
                this.dtpNascimentoCliente.Value = dtpNascimentoCliente.MaxDate;
            }

            this.txtTelefoneCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["NR_Telefone"].Value);
            this.txtEmailCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["DS_Email"].Value);
            this.txtCEPCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["NR_CEP"].Value);
            this.txtRuaCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["NM_Rua"].Value);
            this.txtNumCasaCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["NR_Casa"].Value);
            this.txtBairroCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["NM_Bairro"].Value);
            this.txtComplementoCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["DS_Complemento"].Value);
            this.txtCidadeCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["NM_Cidade"].Value);
            this.cboxUFCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["DS_UF"].Value);

            this.tctrlCliente.SelectedIndex = 1;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.Botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtNomeCliente.Focus();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                bool NomeClienteOK = false;
                bool CPFClienteOK = false;
                bool TelefoneClienteOK = false;
                bool RuaClienteOK = false;
                bool NumCasaClienteOK = false;
                bool BairroClienteOK = false;

                bool CPFcadastrado = false;

                ValidarCampoNulo(txtNomeCliente);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNomeCliente, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        ValidarLetra(txtNomeCliente);
                        if (myValidar.LetraValida == true)
                        {
                            NomeClienteOK = true;
                        }
                    }
                }

                ValidarCampoNuloMasked(txtCPFCliente);
                if (myValidar.CampoValido == true)
                {
                    if (!txtCPFCliente.MaskCompleted)
                    {
                        errorIcone.SetError(txtCPFCliente, "O CPF está incompleto");
                    }
                    else
                    {                       
                        if (myValidar.ValidaCPF(txtCPFCliente.Text) == false)
                        {
                            errorIcone.SetError(txtCPFCliente, "Número de CPF inválido");
                        }
                        else
                        {
                            errorIcone.SetError(txtCPFCliente, string.Empty);
                            CPFClienteOK = true;
                        }                   
                    }
                }

                myValidar.DataNascimento(dtpNascimentoCliente);

                if (cboxSexoCliente.Text == string.Empty)
                {
                    cboxSexoCliente.Text = null;
                }

                ValidarCampoNuloMasked(txtTelefoneCliente);
                if (myValidar.CampoValido == true)
                {
                    if (!txtTelefoneCliente.MaskCompleted)
                    {
                        errorIcone.SetError(txtTelefoneCliente, "O telefone está incompleto");
                    }
                    else
                    {
                        errorIcone.SetError(txtTelefoneCliente, string.Empty);
                        TelefoneClienteOK = true;
                    }
                }

                if (txtEmailCliente.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtEmailCliente, 50);
                }

                ValidarCampoNulo(txtRuaCliente);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtRuaCliente, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        RuaClienteOK = true;
                    }
                }

                ValidarCampoNulo(txtNumCasaCliente);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNumCasaCliente, 5);
                    if (myValidar.TamanhoValido == true)
                    {
                        ValidarNumero(txtNumCasaCliente);
                        if (myValidar.NumeroValido == true)
                        {
                            NumCasaClienteOK = true;
                        }
                    }
                }

                ValidarCampoNulo(txtBairroCliente);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtBairroCliente, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        BairroClienteOK = true;
                    }
                }

                if (txtComplementoCliente.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtComplementoCliente, 50);
                }

                if (txtCidadeCliente.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtCidadeCliente, 30);
                }

                if (NomeClienteOK == false ||
                    CPFClienteOK == false ||
                    TelefoneClienteOK == false ||
                    RuaClienteOK == false ||
                    NumCasaClienteOK == false ||
                    BairroClienteOK == false)
                {
                    MensagemErro("Preencha corretamente todos os campos sinalizados");
                }
                else
                {
                    errorIcone.Clear();

                    if (this.eNovo)
                    {
                        foreach (DataGridViewRow row in dgvCliente.Rows)
                        {
                            if (txtCPFCliente.Text == Convert.ToString(row.Cells["NR_CPF"].Value))
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
                            resp = myCliente.InserirCliente(
                            this.txtNomeCliente.Text.Trim(),
                            this.cboxSexoCliente.Text,
                            this.txtCPFCliente.Text,
                            myValidar.DtNascimento,
                            this.txtTelefoneCliente.Text,
                            this.txtEmailCliente.Text.Trim(),
                            this.txtCEPCliente.Text,
                            this.txtRuaCliente.Text.Trim(),
                            this.txtNumCasaCliente.Text,
                            this.txtBairroCliente.Text.Trim(),
                            this.txtComplementoCliente.Text.Trim(),
                            this.txtCidadeCliente.Text.Trim(),
                            this.cboxUFCliente.Text);
                        }
                    }
                    else
                    {
                        resp = myCliente.EditarCliente(
                            Convert.ToInt32(this.txtCodigoCliente.Text),
                            this.txtNomeCliente.Text.Trim(),
                            this.cboxSexoCliente.Text,
                            this.txtCPFCliente.Text,
                            myValidar.DtNascimento,
                            this.txtTelefoneCliente.Text,
                            this.txtEmailCliente.Text.Trim(),
                            this.txtCEPCliente.Text,
                            this.txtRuaCliente.Text.Trim(),
                            this.txtNumCasaCliente.Text,
                            this.txtBairroCliente.Text.Trim(),
                            this.txtComplementoCliente.Text.Trim(),
                            this.txtCidadeCliente.Text.Trim(),
                            this.cboxUFCliente.Text);
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
                        this.MostrarCliente();
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

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (this.txtNomeCliente.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para editar");
            }
            else
            {
                this.eEditar = true;
                this.Botoes();
                this.Habilitar(true);

                this.txtCodigoCliente.Enabled = false;
                this.txtCPFCliente.Enabled = false;
                this.txtNomeCliente.Enabled = false;

                if (this.dtpNascimentoCliente.Value != DateTime.Today)
                {
                    this.dtpNascimentoCliente.Enabled = false;
                }
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            this.eNovo = false;
            this.eEditar = false;
            this.Botoes();
            this.Habilitar(false);
            this.Limpar();
        }

        private void tctrlCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlCliente.SelectedIndex == 0)
            {
                this.Habilitar(false);
                this.Limpar();

                this.btnNovoCliente.Enabled = true;
                this.btnSalvarCliente.Enabled = false;
                this.btnEditarCliente.Enabled = true;
                this.btnCancelarCliente.Enabled = false;
            }
        }
    }
}
