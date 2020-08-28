using Control;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class ViewInsumo : Form
    {
        ControlInsumo myInsumo = new ControlInsumo();
        ControlEstoque myEstoque = new ControlEstoque();
        Validar myValidar = new Validar();

        private bool eNovo = false;
        private bool eEditar = false;

        private int _IDUnidadeRede;

        public int IDUnidadeRede { get => _IDUnidadeRede; set => _IDUnidadeRede = value; }

        public ViewInsumo()
        {
            InitializeComponent();
        }

        public ViewInsumo(int id_unidade)
        {
            InitializeComponent();
            this.IDUnidadeRede = id_unidade;
        }

        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "PIZZA VINTAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "PIZZA VINTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpar()
        {
            this.txtCodigoInsumo.Text = string.Empty;
            this.txtNomeInsumo.Text = string.Empty;
            this.txtPrecoInsumo.Text = string.Empty;
            this.txtArmazenamentoInsumo.Text = string.Empty;
        }

        // Habilitar os text box
        private void Habilitar(bool Valor)
        {
            this.txtCodigoInsumo.Enabled = false;
            this.txtNomeInsumo.Enabled = Valor;
            this.txtPrecoInsumo.Enabled = Valor;
            this.txtArmazenamentoInsumo.Enabled = Valor;
        }

        // Habilitar os botões
        private void Botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovoInsumo.Enabled = false;
                this.btnSalvarInsumo.Enabled = true;
                this.btnEditarInsumo.Enabled = false;
                this.btnCancelarInsumo.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovoInsumo.Enabled = true;
                this.btnSalvarInsumo.Enabled = false;
                this.btnEditarInsumo.Enabled = true;
                this.btnCancelarInsumo.Enabled = false;
            }
        }

        private void OcultarColunasInsumo()
        {
            this.dgvInsumo.Columns[0].Visible = false;
        }

        private void HabilitarDataGridViewInsumo()
        {
            if (this.dgvInsumo.Rows.Count == 0)
            {
                this.chkDeletarInsumo.Enabled = false;
                this.btnDeletarInsumo.Enabled = false;
                this.txtBuscarInsumo.Enabled = false;
                this.btnBuscarInsumo.Enabled = false;
                this.dgvInsumo.Enabled = false;
            }
            else
            {
                this.chkDeletarInsumo.Enabled = true;
                this.btnDeletarInsumo.Enabled = true;
                this.txtBuscarInsumo.Enabled = true;
                this.btnBuscarInsumo.Enabled = true;
                this.dgvInsumo.Enabled = true;
            }
        }

        private void OcultarColunasEstoque()
        {
            this.dgvEstoque.Columns[0].Visible = false;
        }

        private void HabilitarDataGridViewEstoque()
        {
            if (this.dgvEstoque.Rows.Count == 0)
            {
                this.chkDeletarEstoque.Enabled = false;
                this.btnDeletarEstoque.Enabled = false;
                this.txtBuscarEstoque.Enabled = false;
                this.btnBuscarEstoque.Enabled = false;
                this.dgvEstoque.Enabled = false;
            }
            else
            {
                this.chkDeletarEstoque.Enabled = true;
                this.btnDeletarEstoque.Enabled = true;
                this.txtBuscarEstoque.Enabled = true;
                this.btnBuscarEstoque.Enabled = true;
                this.dgvEstoque.Enabled = true;
            }
        }

        private void MostrarEstoque()
        {
            this.dgvEstoque.DataSource = myEstoque.MostrarEstoque(this.IDUnidadeRede);
            this.OcultarColunasEstoque();
            lblTotalEstoque.Text = "Total de Registros:  " + Convert.ToString(dgvEstoque.Rows.Count);

            this.dgvEstoque.Columns[1].Visible = false;
            this.dgvEstoque.Columns[2].HeaderText = "UNIDADE\nREDE";
            this.dgvEstoque.Columns[3].Visible = false;
            this.dgvEstoque.Columns[4].HeaderText = "INSUMO";
            this.dgvEstoque.Columns[5].HeaderText = "QTDE.TOTAL\nESTOQUE";

            this.dgvEstoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridViewEstoque();
        }

        private void BuscarNomeInsumoEstoque()
        {
            this.dgvEstoque.DataSource = myEstoque.BuscarNomeInsumoEstoque(this.IDUnidadeRede, this.txtBuscarEstoque.Text);
            lblTotalEstoque.Text = "Total de Registros:  " + Convert.ToString(dgvEstoque.Rows.Count);
        }

        private void MostrarInsumo()
        {
            this.dgvInsumo.DataSource = myInsumo.MostrarInsumo();
            this.OcultarColunasInsumo();
            lblTotalInsumo.Text = "Total de Registros:  " + Convert.ToString(dgvInsumo.Rows.Count);

            this.dgvInsumo.Columns[1].HeaderText = "CÓDIGO";
            this.dgvInsumo.Columns[2].HeaderText = "NOME";
            this.dgvInsumo.Columns[3].HeaderText = "TIPO\nARMAZENAMENTO";
            this.dgvInsumo.Columns[4].HeaderText = "PREÇO";

            this.dgvInsumo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInsumo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridViewInsumo();
        }

        private void BuscarNomeInsumo()
        {
            this.dgvInsumo.DataSource = myInsumo.BuscarNomeInsumo(this.txtBuscarInsumo.Text);
            lblTotalInsumo.Text = "Total de Registros:  " + Convert.ToString(dgvInsumo.Rows.Count);
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

        private void ViewInsumo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarInsumo();
            this.MostrarEstoque();
            this.Habilitar(false);
            this.Botoes();
        }

        private void txtBuscarInsumo_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNomeInsumo();
        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            this.BuscarNomeInsumo();
        }

        private void btnDeletarInsumo_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvInsumo.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há insumos selecionados para excluir");
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
                        int Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvInsumo.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                resp = myInsumo.ExcluirInsumo(Codigo);
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

                        this.MostrarInsumo();
                        chkDeletarInsumo.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkDeletarInsumo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarInsumo.Checked)
            {
                this.dgvInsumo.Columns[0].Visible = true;
            }
            else
            {
                this.dgvInsumo.Columns[0].Visible = false;
            }
        }

        private void dgvInsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInsumo.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvInsumo.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dgvInsumo_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigoInsumo.Text = Convert.ToString(this.dgvInsumo.CurrentRow.Cells["ID_Insumo"].Value);
            this.txtNomeInsumo.Text = Convert.ToString(this.dgvInsumo.CurrentRow.Cells["NM_Insumo"].Value);
            this.txtArmazenamentoInsumo.Text = Convert.ToString(this.dgvInsumo.CurrentRow.Cells["DS_TipoArmazenamento"].Value);
            this.txtPrecoInsumo.Text = Convert.ToString(this.dgvInsumo.CurrentRow.Cells["PR_Insumo"].Value);

            this.tctrlInsumo.SelectedIndex = 1;
        }

        private void btnNovoInsumo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.Botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtNomeInsumo.Focus();
        }

        private void btnSalvarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                bool NomeInsumoOK = false;
                bool ArmazenamentoInsumoOK = false;
                bool PrecoInsumoOK = false;

                string resp = "";

                ValidarCampoNulo(txtNomeInsumo);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNomeInsumo, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        NomeInsumoOK = true;
                    }
                }

                ValidarCampoNulo(txtArmazenamentoInsumo);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtArmazenamentoInsumo, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        ArmazenamentoInsumoOK = true;
                    }
                }

                ValidarCampoNulo(txtPrecoInsumo);
                if (myValidar.CampoValido == true)
                {
                    ValidarValor(txtPrecoInsumo);
                    if (myValidar.ValorValido == true)
                    {
                        PrecoInsumoOK = true;
                    }
                }

                bool INScadastrado = false;

                foreach (DataGridViewRow row in dgvInsumo.Rows)
                {
                    if (txtCodigoInsumo.Text != Convert.ToString(row.Cells["ID_Insumo"].Value))
                    {
                        if (txtNomeInsumo.Text == Convert.ToString(row.Cells["NM_Insumo"].Value))
                        {
                            INScadastrado = true;
                        }
                    }
                }

                if (INScadastrado == true)
                {
                    MensagemErro("Insumo já cadastrado na base de dados");
                }
                else
                {
                    if (NomeInsumoOK == false ||
                        ArmazenamentoInsumoOK == false ||
                        PrecoInsumoOK == false)
                    {
                        MensagemErro("Por favor, preencha todos os campos corretamente");
                    }
                    else
                    {
                        errorIcone.Clear();

                        if (this.eNovo)
                        {
                            resp = myInsumo.InserirInsumo(
                                this.txtNomeInsumo.Text,
                                this.txtArmazenamentoInsumo.Text,
                                Convert.ToDouble(this.txtPrecoInsumo.Text));
                    }
                        else
                        {
                            resp = myInsumo.EditarInsumo(
                                Convert.ToInt32(this.txtCodigoInsumo.Text),
                                this.txtNomeInsumo.Text,
                                this.txtArmazenamentoInsumo.Text,
                                Convert.ToDouble(this.txtPrecoInsumo.Text));
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
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }

                        this.eNovo = false;
                        this.eEditar = false;
                        this.Botoes();
                        this.Limpar();
                        this.MostrarInsumo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarInsumo_Click(object sender, EventArgs e)
        {
            if (this.txtCodigoInsumo.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para editar");
            }
            else
            {
                this.txtNomeInsumo.Focus();
                this.eEditar = true;
                this.Botoes();
                this.Habilitar(true);
            }
        }

        private void btnCancelarInsumo_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            this.eNovo = false;
            this.eEditar = false;
            this.Botoes();
            this.Habilitar(false);
            this.Limpar();
        }

        private void tctrlInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlInsumo.SelectedIndex == 0)
            {
                this.Habilitar(false);
                this.Limpar();

                this.btnNovoInsumo.Enabled = true;
                this.btnSalvarInsumo.Enabled = false;
                this.btnEditarInsumo.Enabled = true;
                this.btnCancelarInsumo.Enabled = false;
            }
        }

        private void txtBuscarEstoque_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNomeInsumoEstoque();
        }

        private void btnBuscarEstoque_Click(object sender, EventArgs e)
        {
            this.BuscarNomeInsumoEstoque();
        }

        private void btnDeletarEstoque_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvEstoque.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há estoques selecionados para excluir");
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
                        int Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvEstoque.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                resp = myEstoque.ExcluirEstoque(Codigo, 1);
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

                        this.MostrarEstoque();
                        chkDeletarEstoque.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkDeletarEstoque_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarEstoque.Checked)
            {
                this.dgvEstoque.Columns[0].Visible = true;
            }
            else
            {
                this.dgvEstoque.Columns[0].Visible = false;
            }
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEstoque.Columns["DeletarEST"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvEstoque.Rows[e.RowIndex].Cells["DeletarEST"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }
    }
}
