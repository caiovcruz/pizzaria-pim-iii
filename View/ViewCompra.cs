using Control;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class ViewCompra : Form
    {
        ControlCompra myCompra = new ControlCompra();
        ControlEstoque myEstoque = new ControlEstoque();
        ControlInsumo myInsumo = new ControlInsumo();
        Validar myValidar = new Validar();

        private bool eNovo = false;
        private bool eEditar = false;

        private int _IDUnidadeRede;

        public int IDUnidadeRede { get => _IDUnidadeRede; set => _IDUnidadeRede = value; }

        public ViewCompra()
        {
            InitializeComponent();
        }

        public ViewCompra(int id_unidade)
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

        // Limpar campos
        private void Limpar()
        {
            this.txtCodigoCompra.Text = string.Empty;
            this.cboxInsumoCompra.Text = null;
            this.dtCompra.Value = DateTime.Today;
            this.txtQuantidadeInsumoCompra.Text = string.Empty;
        }

        // Habilitar os text box
        private void Habilitar(bool Valor)
        {
            this.txtCodigoCompra.Enabled = false;
            this.cboxInsumoCompra.Enabled = Valor;
            this.dtCompra.Enabled = false;
            this.txtQuantidadeInsumoCompra.Enabled = Valor;
        }

        // Habilitar os botões
        private void Botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovaCompra.Enabled = false;
                this.btnSalvarCompra.Enabled = true;
                this.btnCancelarCompra.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovaCompra.Enabled = true;
                this.btnSalvarCompra.Enabled = false;
                this.btnCancelarCompra.Enabled = false;
            }
        }

        private void OcultarColunas()
        {
            this.dgvCompra.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (this.dgvCompra.Rows.Count == 0)
            {
                this.chkDeletarCompra.Enabled = false;
                this.btnDeletarCompra.Enabled = false;
                this.dtBuscarCompra.Enabled = false;
                this.btnBuscarCompra.Enabled = false;
                this.dgvCompra.Enabled = false;
            }
            else
            {
                this.chkDeletarCompra.Enabled = true;
                this.btnDeletarCompra.Enabled = true;
                this.dtBuscarCompra.Enabled = true;
                this.btnBuscarCompra.Enabled = true;
                this.dgvCompra.Enabled = true;
            }
        }

        private void MostrarCompra()
        {
            this.dgvCompra.DataSource = myCompra.MostrarCompra(this.IDUnidadeRede);
            this.OcultarColunas();
            lblTotalCompra.Text = "Total de Registros:  " + Convert.ToString(dgvCompra.Rows.Count);

            this.dgvCompra.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dgvCompra.Columns[1].Visible = false;
            this.dgvCompra.Columns[2].HeaderText = "UNIDADE\nDA REDE";
            this.dgvCompra.Columns[3].HeaderText = "COMPRA";
            this.dgvCompra.Columns[4].HeaderText = "INSUMO";
            this.dgvCompra.Columns[5].Visible = false;
            this.dgvCompra.Columns[6].HeaderText = "DATA";
            this.dgvCompra.Columns[7].HeaderText = "QUANTIDADE";

            this.dgvCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridView();
        }

        private void MostrarInsumo()
        {
            this.cboxInsumoCompra.DataSource = myInsumo.MostrarInsumo();
            this.cboxInsumoCompra.DisplayMember = "NM_Insumo";
            this.cboxInsumoCompra.ValueMember = "ID_Insumo";
        }

        private void BuscarDataCompra()
        {
            this.dgvCompra.DataSource = myCompra.BuscarDataCompra(this.dtBuscarCompra.Value, 1);
            this.OcultarColunas();
            lblTotalCompra.Text = "Total de Registros:  " + Convert.ToString(dgvCompra.Rows.Count);

            this.dgvCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void ViewCompra_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarCompra();
            this.MostrarInsumo();
            this.Habilitar(false);
            this.Botoes();
            this.cboxInsumoCompra.Text = null;
        }

        private void dtBuscarCompra_ValueChanged(object sender, EventArgs e)
        {
            this.BuscarDataCompra();
        }

        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            this.BuscarDataCompra();
        }

        private void btnDeletarCompra_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvCompra.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há compras selecionadas para excluir");
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

                        foreach (DataGridViewRow row in dgvCompra.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                resp = myCompra.ExcluirCompra(Codigo, this.IDUnidadeRede);
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

                        this.MostrarCompra();
                        chkDeletarCompra.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkDeletarCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarCompra.Checked)
            {
                this.dgvCompra.Columns[0].Visible = true;
            }
            else
            {
                this.dgvCompra.Columns[0].Visible = false;
            }
        }

        private void dgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCompra.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvCompra.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dgvCompra_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigoCompra.Text = Convert.ToString(this.dgvCompra.CurrentRow.Cells["ID_Compra"].Value);
            this.cboxInsumoCompra.Text = Convert.ToString(this.dgvCompra.CurrentRow.Cells["NM_Insumo"].Value);
            this.dtCompra.Value = Convert.ToDateTime(this.dgvCompra.CurrentRow.Cells["DT_Compra"].Value);
            this.txtQuantidadeInsumoCompra.Text = Convert.ToString(this.dgvCompra.CurrentRow.Cells["QTDE_InsumoCompra"].Value);

            this.tctrlCompra.SelectedIndex = 1;
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.Botoes();
            this.Limpar();
            this.Habilitar(true);
            this.cboxInsumoCompra.Focus();
            this.cboxInsumoCompra.Text = null;
        }

        private void btnSalvarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                bool InsumoCompraOK = false;
                bool QuantidadeInsumoCompraOK = false;

                string resp = "";

                if (cboxInsumoCompra.Text == string.Empty)
                {
                    errorIcone.SetError(cboxInsumoCompra, "Selecione o insumo da compra");
                }
                else
                {
                    errorIcone.SetError(cboxInsumoCompra, string.Empty);
                    InsumoCompraOK = true;
                }

                ValidarCampoNulo(txtQuantidadeInsumoCompra);
                if (myValidar.CampoValido == true)
                {
                    ValidarValor(txtQuantidadeInsumoCompra);
                    if (myValidar.ValorValido == true)
                    {
                        QuantidadeInsumoCompraOK = true;
                    }
                }

                if (InsumoCompraOK == false ||
                    QuantidadeInsumoCompraOK == false)
                {
                    MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                }
                else
                {
                    errorIcone.Clear();

                    if (this.eNovo)
                    {
                        resp = myCompra.InserirCompra(
                            Convert.ToInt32(this.cboxInsumoCompra.SelectedValue),
                            this.dtCompra.Value,
                            Convert.ToDouble(this.txtQuantidadeInsumoCompra.Text),
                            this.IDUnidadeRede);

                        foreach (DataGridViewRow row in dgvCompra.Rows)
                        {
                            if (Convert.ToInt32(this.cboxInsumoCompra.SelectedValue) == Convert.ToInt32(row.Cells["ID_Insumo"].Value))
                            {
                                myEstoque.EditarEstoque(
                                    Convert.ToInt32(this.cboxInsumoCompra.SelectedValue), 
                                    Convert.ToDouble(this.txtQuantidadeInsumoCompra.Text),
                                    this.IDUnidadeRede);
                            }
                            else
                            {
                                myEstoque.InserirEstoque(
                                    Convert.ToInt32(this.cboxInsumoCompra.SelectedValue), 
                                    Convert.ToDouble(this.txtQuantidadeInsumoCompra.Text),
                                    this.IDUnidadeRede);
                            }
                        }
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
                    this.MostrarCompra();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            this.eNovo = false;
            this.eEditar = false;
            this.Botoes();
            this.Habilitar(false);
            this.Limpar();
        }

        private void tctrlCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlCompra.SelectedIndex == 0)
            {
                this.Habilitar(false);
                this.Limpar();

                this.btnNovaCompra.Enabled = true;
                this.btnSalvarCompra.Enabled = false;
                this.btnCancelarCompra.Enabled = false;
            }
        }
    }
}
