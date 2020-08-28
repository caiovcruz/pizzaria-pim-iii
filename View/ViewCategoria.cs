using Control;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class ViewCategoria : Form
    {
        ControlCategoria myCategoria = new ControlCategoria();
        Validar myValidar = new Validar();

        private bool eNovo = false;
        private bool eEditar = false;

        public ViewCategoria()
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
            this.txtCodigoCategoria.Text = string.Empty;
            this.txtNomeCategoria.Text = string.Empty;
            this.txtDescricaoCategoria.Text = string.Empty;
        }

        // Habilitar os text box
        private void Habilitar(bool Valor)
        {
            this.txtCodigoCategoria.Enabled = false;
            this.txtNomeCategoria.Enabled = Valor;
            this.txtDescricaoCategoria.Enabled = Valor;
        }

        // Habilitar os botões
        private void Botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovoCategoria.Enabled = false;
                this.btnSalvarCategoria.Enabled = true;
                this.btnEditarCategoria.Enabled = false;
                this.btnCancelarCategoria.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovoCategoria.Enabled = true;
                this.btnSalvarCategoria.Enabled = false;
                this.btnEditarCategoria.Enabled = true;
                this.btnCancelarCategoria.Enabled = false;
            }
        }

        private void OcultarColunas()
        {
            this.dgvCategoria.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (this.dgvCategoria.Rows.Count == 0)
            {
                this.chkDeletarCategoria.Enabled = false;
                this.btnDeletarCategoria.Enabled = false;
                this.txtBuscarCategoria.Enabled = false;
                this.btnBuscarCategoria.Enabled = false;
                this.dgvCategoria.Enabled = false;
            }
            else
            {
                this.chkDeletarCategoria.Enabled = true;
                this.btnDeletarCategoria.Enabled = true;
                this.txtBuscarCategoria.Enabled = true;
                this.btnBuscarCategoria.Enabled = true;
                this.dgvCategoria.Enabled = true;
            }
        }

        private void MostrarCategoria()
        {
            this.dgvCategoria.DataSource = myCategoria.MostrarCategoria();
            this.OcultarColunas();
            lblTotalCategoria.Text = "Total de Registros:  " + Convert.ToString(dgvCategoria.Rows.Count);

            this.dgvCategoria.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dgvCategoria.Columns[1].HeaderText = "CÓDIGO";
            this.dgvCategoria.Columns[2].HeaderText = "NOME";
            this.dgvCategoria.Columns[3].HeaderText = "DESCRIÇÃO";

            this.dgvCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridView();
        }

        private void BuscarNomeCategoria()
        {
            this.dgvCategoria.DataSource = myCategoria.BuscarNomeCategoria(this.txtBuscarCategoria.Text);
            lblTotalCategoria.Text = "Total de Registros:  " + Convert.ToString(dgvCategoria.Rows.Count);
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

        private void ViewCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarCategoria();
            this.Habilitar(false);
            this.Botoes();
            this.BuscarNomeCategoria();
        }

        private void dgvCategoria_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigoCategoria.Text = Convert.ToString(this.dgvCategoria.CurrentRow.Cells["ID_Categoria"].Value);
            this.txtNomeCategoria.Text = Convert.ToString(this.dgvCategoria.CurrentRow.Cells["NM_Categoria"].Value);
            this.txtDescricaoCategoria.Text = Convert.ToString(this.dgvCategoria.CurrentRow.Cells["DS_Categoria"].Value);

            this.tctrlCategoria.SelectedIndex = 1;
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCategoria.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvCategoria.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNomeCategoria();
        }

        private void chkDeletarCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarCategoria.Checked)
            {
                this.dgvCategoria.Columns[0].Visible = true;

            }
            else
            {
                this.dgvCategoria.Columns[0].Visible = false;
            }
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            this.BuscarNomeCategoria();
        }

        private void btnDeletarCategoria_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvCategoria.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há categorias selecionados para excluir");
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
                        string Nome;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvCategoria.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                Nome = Convert.ToString(row.Cells[2].Value);
                                resp = myCategoria.ExcluirCategoria(Convert.ToInt32(Codigo), Nome);
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

                        this.MostrarCategoria();
                        chkDeletarCategoria.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnNovoCategoria_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.Botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtNomeCategoria.Focus();
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                bool NomeCategoriaOK = false;
                bool DescricaoCategoriaOK = false;

                string resp = "";

                ValidarCampoNulo(txtNomeCategoria);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNomeCategoria, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        NomeCategoriaOK = true;
                    }
                }

                ValidarCampoNulo(txtDescricaoCategoria);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtDescricaoCategoria, 150);
                    if (myValidar.TamanhoValido == true)
                    {
                        DescricaoCategoriaOK = true;
                    }
                }


                bool CATcadastrada = false;

                foreach (DataGridViewRow row in dgvCategoria.Rows)
                {
                    if (txtCodigoCategoria.Text != Convert.ToString(row.Cells["ID_Categoria"].Value))
                    {
                        if (txtNomeCategoria.Text == Convert.ToString(row.Cells["NM_Categoria"].Value))
                        {
                            CATcadastrada = true;
                        }
                    }
                }

                if (CATcadastrada == true)
                {
                    MensagemErro("Categoria já cadastrada na base de dados");
                }
                else
                {
                    if (NomeCategoriaOK == false ||
                        DescricaoCategoriaOK == false)
                    {
                        MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                    }
                    else
                    {
                        errorIcone.Clear();

                        if (this.eNovo)
                        {

                            resp = myCategoria.InserirCategoria(
                            this.txtNomeCategoria.Text.Trim(),
                            this.txtDescricaoCategoria.Text.Trim()
                            );

                        }
                        else
                        {
                            resp = myCategoria.EditarCategoria(
                                Convert.ToInt32(this.txtCodigoCategoria.Text),
                                this.txtNomeCategoria.Text.Trim(),
                                this.txtDescricaoCategoria.Text.Trim()
                                );
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
                        this.MostrarCategoria();
                        this.BuscarNomeCategoria();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (this.txtNomeCategoria.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para editar");
            }
            else
            {
                this.txtCodigoCategoria.Enabled = false;
                this.txtNomeCategoria.Focus();
                this.eEditar = true;
                this.Botoes();
                this.Habilitar(true);
            }
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            this.eNovo = false;
            this.eEditar = false;
            this.Botoes();
            this.Habilitar(false);
            this.Limpar();
        }

        private void tctrlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlCategoria.SelectedIndex == 0)
            {
                this.Habilitar(false);
                this.Limpar();

                this.btnNovoCategoria.Enabled = true;
                this.btnSalvarCategoria.Enabled = false;
                this.btnEditarCategoria.Enabled = true;
                this.btnCancelarCategoria.Enabled = false;
            }
        }
    }
}
