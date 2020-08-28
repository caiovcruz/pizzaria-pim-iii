using Control;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class ViewLogin : Form
    {
        ControlLogin myLogin = new ControlLogin();
        ControlFuncionario myFuncionario = new ControlFuncionario();
        ControlNivelAcesso myNivelAcesso = new ControlNivelAcesso();
        ControlUnidadeRede myUnidadeRede = new ControlUnidadeRede();
        Validar myValidar = new Validar();

        private bool eNovo = false;
        private bool eEditar = false;

        private string _DSUnidade;
        private string _NMUsuario;
        private string _NVAcesso;
        private int _IDUnidadeRede;

        public string DSUnidade { get => _DSUnidade; set => _DSUnidade = value; }
        public string NMUsuario { get => _NMUsuario; set => _NMUsuario = value; }
        public string NVAcesso { get => _NVAcesso; set => _NVAcesso = value; }
        public int IDUnidadeRede { get => _IDUnidadeRede; set => _IDUnidadeRede = value; }

        public ViewLogin()
        {
            InitializeComponent();
        }

        public ViewLogin(int id_unidade)
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
            this.txtCodigoLogin.Text = string.Empty;
            this.cboxNomeFuncionarioLogin.Text = null;
            this.txtUsuarioLogin.Text = string.Empty;
            this.txtSenhaLogin.Text = string.Empty;
            this.cboxNivelAcessoLogin.Text = null;
        }

        // Habilitar os text box
        private void Habilitar(bool Valor)
        {
            this.txtCodigoLogin.Enabled = false;
            this.cboxNomeFuncionarioLogin.Enabled = Valor;
            this.txtUsuarioLogin.Enabled = Valor;
            this.txtSenhaLogin.Enabled = Valor;
            this.cboxNivelAcessoLogin.Enabled = Valor;
        }

        // Habilitar os botões
        private void Botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovoLogin.Enabled = false;
                this.btnSalvarLogin.Enabled = true;
                this.btnEditarLogin.Enabled = false;
                this.btnCancelarLogin.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovoLogin.Enabled = true;
                this.btnSalvarLogin.Enabled = false;
                this.btnEditarLogin.Enabled = true;
                this.btnCancelarLogin.Enabled = false;
            }
        }

        private void OcultarDeletarLogin()
        {
            this.dgvLogin.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (this.dgvLogin.Rows.Count == 0)
            {
                this.chkDeletarLogin.Enabled = false;
                this.btnDeletarLogin.Enabled = false;
                this.txtBuscarLogin.Enabled = false;
                this.btnBuscarLogin.Enabled = false;
                this.dgvLogin.Enabled = false;
            }
            else
            {
                this.chkDeletarLogin.Enabled = true;
                this.btnDeletarLogin.Enabled = true;
                this.txtBuscarLogin.Enabled = true;
                this.btnBuscarLogin.Enabled = true;
                this.dgvLogin.Enabled = true;
            }
        }

        private void MostrarLogin()
        {
            this.dgvLogin.DataSource = myLogin.MostrarLogin(this.IDUnidadeRede);
            this.OcultarDeletarLogin();
            lblTotalLogin.Text = "Total de Registros:  " + Convert.ToString(dgvLogin.Rows.Count);

            this.dgvLogin.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dgvLogin.Columns[1].HeaderText = "CÓDIGO";
            this.dgvLogin.Columns[2].Visible = false;
            this.dgvLogin.Columns[3].HeaderText = "UNIDADE\nREDE";
            this.dgvLogin.Columns[4].Visible = false;
            this.dgvLogin.Columns[5].HeaderText = "FUNCIONÁRIO";
            this.dgvLogin.Columns[6].Visible = false;
            this.dgvLogin.Columns[7].HeaderText = "NÍVEL\nACESSO";
            this.dgvLogin.Columns[8].HeaderText = "USUÁRIO";
            this.dgvLogin.Columns[9].HeaderText = "SENHA";

            this.dgvLogin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLogin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridView();
        }

        private void MostrarNivelAcesso()
        {
            this.cboxNivelAcessoLogin.DataSource = myNivelAcesso.MostrarNivelAcesso();
            this.cboxNivelAcessoLogin.DisplayMember = "DS_NivelAcesso";
            this.cboxNivelAcessoLogin.ValueMember = "ID_NivelAcesso";
        }

        private void MostrarFuncionarioLogin()
        {
            this.cboxNomeFuncionarioLogin.DataSource = myFuncionario.MostrarFuncionario(this.IDUnidadeRede);
            this.cboxNomeFuncionarioLogin.DisplayMember = "NM_Funcionario";
            this.cboxNomeFuncionarioLogin.ValueMember = "ID_Funcionario";
        }

        private void BuscarNomeFuncionarioLogin()
        {
            this.dgvLogin.DataSource = myLogin.BuscarNomeFuncionarioLogin(this.txtBuscarLogin.Text, this.IDUnidadeRede);
            this.OcultarDeletarLogin();
            lblTotalLogin.Text = "Total de Registros:  " + Convert.ToString(dgvLogin.Rows.Count);
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

        private void ViewLogin_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarLogin();
            this.Habilitar(false);
            this.Botoes();
            this.MostrarNivelAcesso();
            this.MostrarFuncionarioLogin();
            this.BuscarNomeFuncionarioLogin();

            this.cboxNomeFuncionarioLogin.Text = null;
            this.cboxNivelAcessoLogin.Text = null;
        }

        private void txtBuscarLogin_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNomeFuncionarioLogin();
        }

        private void btnBuscarLogin_Click(object sender, EventArgs e)
        {
            this.BuscarNomeFuncionarioLogin();
        }

        private void btnDeletarLogin_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvLogin.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há logins selecionados para excluir");
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

                        foreach (DataGridViewRow row in dgvLogin.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                resp = myLogin.ExcluirLogin(Convert.ToInt32(Codigo));
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

                        this.MostrarLogin();
                        chkDeletarLogin.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkDeletarLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarLogin.Checked)
            {
                this.dgvLogin.Columns[0].Visible = true;
            }
            else
            {
                this.dgvLogin.Columns[0].Visible = false;
            }
        }

        private void dgvLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLogin.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvLogin.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dgvLogin_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigoLogin.Text = Convert.ToString(this.dgvLogin.CurrentRow.Cells["ID_Login"].Value);
            this.cboxNomeFuncionarioLogin.Text = Convert.ToString(this.dgvLogin.CurrentRow.Cells["NM_Funcionario"].Value);
            this.txtUsuarioLogin.Text = Convert.ToString(this.dgvLogin.CurrentRow.Cells["DS_Usuario"].Value);
            this.txtSenhaLogin.Text = Convert.ToString(this.dgvLogin.CurrentRow.Cells["DS_Senha"].Value);
            this.cboxNivelAcessoLogin.Text = Convert.ToString(this.dgvLogin.CurrentRow.Cells["DS_NivelAcesso"].Value);

            this.tctrlLogin.SelectedIndex = 1;
        }

        private void btnNovoLogin_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.Botoes();
            this.Limpar();
            this.Habilitar(true);
            this.cboxNomeFuncionarioLogin.Focus();
        }

        private void btnSalvarLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool FuncionarioLoginOK = false;
                bool UsuarioLoginOK = false;
                bool SenhaLoginOK = false;
                bool NivelAcessoLoginOK = false;
                bool UnidadeRedeLoginOK = false;

                string resp = "";

                if (cboxNomeFuncionarioLogin.Text == string.Empty)
                {
                    errorIcone.SetError(cboxNomeFuncionarioLogin, "Selecione o funcionário deste login");
                }
                else
                {
                    errorIcone.SetError(cboxNomeFuncionarioLogin, string.Empty);
                    FuncionarioLoginOK = true;
                }

                ValidarCampoNulo(txtUsuarioLogin);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtUsuarioLogin, 20);
                    if (myValidar.TamanhoValido == true)
                    {
                        UsuarioLoginOK = true;
                    }
                }

                ValidarCampoNulo(txtSenhaLogin);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtSenhaLogin, 20);
                    if (myValidar.TamanhoValido == true)
                    {
                        SenhaLoginOK = true;
                    }
                }

                if (cboxNivelAcessoLogin.Text == string.Empty)
                {
                    errorIcone.SetError(cboxNivelAcessoLogin, "Selecione o nível de acesso deste login");
                }
                else
                {
                    errorIcone.SetError(cboxNivelAcessoLogin, string.Empty);
                    NivelAcessoLoginOK = true;
                }

                bool FunLoginCadastrado = false;

                foreach (DataGridViewRow row in dgvLogin.Rows)
                {
                    if (txtCodigoLogin.Text != Convert.ToString(row.Cells["ID_Login"].Value))
                    {
                        if (cboxNomeFuncionarioLogin.Text == Convert.ToString(row.Cells["NM_Funcionario"].Value))
                        {
                            FunLoginCadastrado = true;
                        }
                    }
                }

                if (FunLoginCadastrado == true)
                {
                    MensagemErro("Funcionário já tem um login cadastrado na base de dados");
                }
                else
                {
                    bool UserLoginCadastrado = false;

                    foreach (DataGridViewRow row in dgvLogin.Rows)
                    {
                        if (txtCodigoLogin.Text != Convert.ToString(row.Cells["ID_Login"].Value))
                        {
                            if (txtUsuarioLogin.Text == Convert.ToString(row.Cells["DS_Usuario"].Value))
                            {
                                UserLoginCadastrado = true;
                            }
                        }
                    }

                    if (UserLoginCadastrado == true)
                    {
                        MensagemErro("Este nome de usuário já pertence a um login cadastrado na base de dados");
                    }
                    else
                    {
                        if (FuncionarioLoginOK == false ||
                            UsuarioLoginOK == false ||
                            SenhaLoginOK == false ||
                            NivelAcessoLoginOK == false ||
                            UnidadeRedeLoginOK == false)
                        {
                            MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                        }
                        else
                        {
                            errorIcone.Clear();

                            if (this.eNovo)
                            {
                                resp = myLogin.InserirLogin(
                                    Convert.ToInt32(this.cboxNomeFuncionarioLogin.SelectedValue),
                                    Convert.ToInt32(this.cboxNivelAcessoLogin.SelectedValue),
                                    this.IDUnidadeRede,
                                    this.txtUsuarioLogin.Text,
                                    this.txtSenhaLogin.Text);
                            }
                            else
                            {
                                resp = myLogin.EditarLogin(
                                    Convert.ToInt32(this.txtCodigoLogin.Text),
                                    Convert.ToInt32(this.cboxNivelAcessoLogin.SelectedValue),
                                    this.txtUsuarioLogin.Text,
                                    this.txtSenhaLogin.Text);
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
                                this.Habilitar(false);
                                this.Limpar();
                                this.MostrarLogin();
                            }
                            else
                            {
                                this.MensagemErro(resp);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarLogin_Click(object sender, EventArgs e)
        {
            if (this.txtCodigoLogin.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para editar");
            }
            else
            {
                this.cboxNomeFuncionarioLogin.Focus();
                this.eEditar = true;
                this.Botoes();
                this.Habilitar(true);
            }
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            this.eNovo = false;
            this.eEditar = false;
            this.Botoes();
            this.Habilitar(false);
            this.Limpar();
        }

        private void tctrlLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlLogin.SelectedIndex == 0)
            {
                this.Habilitar(false);
                this.Limpar();

                this.btnNovoLogin.Enabled = true;
                this.btnSalvarLogin.Enabled = false;
                this.btnEditarLogin.Enabled = true;
                this.btnCancelarLogin.Enabled = false;
            }
        }
    }
}
