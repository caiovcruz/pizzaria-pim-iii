using Control;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class ViewUnidadeRede : Form
    {
        Validar myValidar = new Validar();
        ControlUnidadeRede myUnidadeRede = new ControlUnidadeRede();
        ControlCompra myCompra = new ControlCompra();
        ControlVenda myVenda = new ControlVenda();
        ControlInsumo myInsumo = new ControlInsumo();

        TabPage TabRemove = new TabPage();

        private bool eNovo = false;
        private bool eEditar = false;

        private int _IDUnidadeRede;

        public int IDUnidadeRede { get => _IDUnidadeRede; set => _IDUnidadeRede = value; }

        public ViewUnidadeRede()
        {
            InitializeComponent();
        }

        public ViewUnidadeRede(int id_unidade)
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

        private void OcultarTabValidar()
        {
            this.TabRemove = tpgValidar;
            this.tctrlUnidadeRede.Controls.Remove(tpgValidar);
        }

        private void MostrarTabValidar()
        {
            this.tctrlUnidadeRede.Controls.Add(TabRemove);
        }

        private void MostrarVendas()
        {
            this.dgvVendaValida.DataSource = myVenda.MostrarVenda(this.IDUnidadeRede);
        }

        private void MostrarCompras()
        {
            this.dgvCompraValida.DataSource = myCompra.MostrarCompra(this.IDUnidadeRede);
        }

        private void MostrarInsumos()
        {
            this.dgvInsumoValida.DataSource = myInsumo.MostrarInsumo();
        }

        private void Limpar()
        {
            this.txtCodigoUnidadeRede.Text = string.Empty;
            this.txtDescricaoUnidadeRede.Text = string.Empty;
            this.txtGastoCompraUnidadeRede.Text = string.Empty;
            this.txtLucroVendaUnidadeRede.Text = string.Empty;
        }

        // Habilitar os text box
        private void Habilitar(bool Valor)
        {
            this.txtCodigoUnidadeRede.Enabled = false;
            this.txtDescricaoUnidadeRede.Enabled = Valor;
            this.txtGastoCompraUnidadeRede.Enabled = false;
            this.txtLucroVendaUnidadeRede.Enabled = false;
        }

        // Habilitar os botões
        private void Botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovaUnidadeRede.Enabled = false;
                this.btnSalvarUnidadeRede.Enabled = true;
                this.btnEditarUnidadeRede.Enabled = false;
                this.btnCancelarUnidadeRede.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovaUnidadeRede.Enabled = true;
                this.btnSalvarUnidadeRede.Enabled = false;
                this.btnEditarUnidadeRede.Enabled = true;
                this.btnCancelarUnidadeRede.Enabled = false;
            }
        }

        private void HabilitarDataGridView()
        {
            if (this.dgvUnidadeRede.Rows.Count == 0)
            {
                this.chkDeletarUnidadeRede.Enabled = false;
                this.btnDeletarUnidadeRede.Enabled = false;
                this.txtBuscarUnidadeRede.Enabled = false;
                this.btnBuscarUnidadeRede.Enabled = false;
                this.dgvUnidadeRede.Enabled = false;
            }
            else
            {
                this.chkDeletarUnidadeRede.Enabled = true;
                this.btnDeletarUnidadeRede.Enabled = true;
                this.txtBuscarUnidadeRede.Enabled = true;
                this.btnBuscarUnidadeRede.Enabled = true;
                this.dgvUnidadeRede.Enabled = true;
            }
        }

        private void MostrarUnidade()
        {
            this.dgvUnidadeRede.DataSource = myUnidadeRede.MostrarUnidadeRede();
            lblTotalUnidadeRede.Text = "Total de Registros:  " + Convert.ToString(dgvUnidadeRede.Rows.Count);

            this.dgvUnidadeRede.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dgvUnidadeRede.Columns[1].HeaderText = "CÓDIGO";
            this.dgvUnidadeRede.Columns[2].HeaderText = "UNIDADE";
            this.dgvUnidadeRede.Columns[3].HeaderText = "VALOR\nGASTOS";
            this.dgvUnidadeRede.Columns[4].HeaderText = "VALOR\nVENDAS";
            this.dgvUnidadeRede.Columns[0].Visible = false;

            this.dgvUnidadeRede.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUnidadeRede.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridView();
        }




        private void CarregarValoresUnidadeRede(TextBox campo)
        {
            this.MostrarTabValidar();
            this.MostrarCompras();
            this.MostrarInsumos();
            double ValorTotalGastoCompra = 0;
            double ValorTotalLucroVenda = 0;

            for (int i = 0; i < this.dgvCompraValida.Rows.Count; i++)
            {
                if (campo.Text == Convert.ToString(this.dgvCompraValida.Rows[i].Cells["ID_UnidadeRede"].Value))
                {
                    int Insumo = Convert.ToInt32(this.dgvCompraValida.Rows[i].Cells["ID_Insumo"].Value);
                    double QuantidadeCompra = Convert.ToDouble(this.dgvCompraValida.Rows[i].Cells["QTDE_InsumoCompra"].Value);

                    this.MostrarInsumos();
                    for (int k = 0; k < this.dgvInsumoValida.Rows.Count; k++)
                    {

                        if (Insumo == Convert.ToInt32(this.dgvInsumoValida.Rows[k].Cells["ID_Insumo"].Value))
                        {
                            double PrecoCompra = Convert.ToDouble(this.dgvInsumoValida.Rows[k].Cells["PR_Insumo"].Value);
                            ValorTotalGastoCompra += PrecoCompra * QuantidadeCompra;
                            MensagemOk("VALOR" + ValorTotalGastoCompra);
                        }
                    }
                }
            }

            this.MostrarVendas();

            for (int i = 0; i < this.dgvVendaValida.Rows.Count; i++)
            {
                if (campo.Text == Convert.ToString(dgvVendaValida.Rows[i].Cells["ID_UnidadeRede"].Value))
                {
                    ValorTotalLucroVenda += Convert.ToDouble(dgvVendaValida.Rows[i].Cells["VL_Total"].Value);
                    ValorTotalLucroVenda.ToString("N2");
                    MensagemOk("Total Venda " + ValorTotalLucroVenda);
                }
            }

            myUnidadeRede.CarregaValoresUnidade(Convert.ToInt32(campo.Text),
                ValorTotalGastoCompra,
                ValorTotalLucroVenda);

            this.OcultarTabValidar();
        }

        private void BuscarUnidadeRede()
        {
            this.dgvUnidadeRede.DataSource = myUnidadeRede.BuscarUnidadeRede(this.txtBuscarUnidadeRede.Text);
            lblTotalUnidadeRede.Text = "Total de Registros:  " + Convert.ToString(dgvUnidadeRede.Rows.Count);

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

        private void ViewUnidadeRede_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarUnidade();
            this.Habilitar(false);
            this.Botoes();
            this.Limpar();
            this.OcultarTabValidar();
        }

        private void txtBuscarUnidadeRede_TextChanged(object sender, EventArgs e)
        {
            this.BuscarUnidadeRede();
        }

        private void btnBuscarUnidadeRede_Click(object sender, EventArgs e)
        {
            this.BuscarUnidadeRede();
        }

        private void btnDeletarUnidadeRede_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvUnidadeRede.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há unidades da rede selecionadas para excluir");
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

                        foreach (DataGridViewRow row in dgvUnidadeRede.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                resp = myUnidadeRede.ExcluirUnidadeRede(Convert.ToInt32(Codigo));
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

                        this.MostrarUnidade();
                        chkDeletarUnidadeRede.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkDeletarUnidadeRede_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarUnidadeRede.Checked)
            {
                this.dgvUnidadeRede.Columns[0].Visible = true;

            }
            else
            {
                this.dgvUnidadeRede.Columns[0].Visible = false;
            }
        }

        private void dgvUnidadeRede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUnidadeRede.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvUnidadeRede.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dgvUnidadeRede_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigoUnidadeRede.Text = Convert.ToString(this.dgvUnidadeRede.CurrentRow.Cells["ID_UnidadeRede"].Value);
            this.txtDescricaoUnidadeRede.Text = Convert.ToString(this.dgvUnidadeRede.CurrentRow.Cells["DS_UnidadeRede"].Value);
            this.txtGastoCompraUnidadeRede.Text = Convert.ToString(this.dgvUnidadeRede.CurrentRow.Cells["VL_GastoCompra"].Value);
            this.txtLucroVendaUnidadeRede.Text = Convert.ToString(this.dgvUnidadeRede.CurrentRow.Cells["VL_LucroVenda"].Value);

            this.tctrlUnidadeRede.SelectedIndex = 1;
        }

        private void btnNovaUnidadeRede_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.Botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtDescricaoUnidadeRede.Focus();
        }

        private void btnSalvarUnidadeRede_Click(object sender, EventArgs e)
        {
            try
            {
                bool DescricaoUnidadeOK = false;
                bool UnidadeCadastrada = false;
                string resp = "";

                ValidarCampoNulo(txtDescricaoUnidadeRede);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtDescricaoUnidadeRede, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        DescricaoUnidadeOK = true;
                    }
                }

                foreach (DataGridViewRow row in dgvUnidadeRede.Rows)
                {
                    if (txtCodigoUnidadeRede.Text != Convert.ToString(row.Cells["ID_UnidadeRede"].Value))
                    {
                        if (txtDescricaoUnidadeRede.Text == Convert.ToString(row.Cells["DS_UnidadeRede"].Value))

                        {
                            UnidadeCadastrada = true;
                        }
                    }
                }

                if (UnidadeCadastrada == true)
                {
                    MensagemErro("Nome da unidade já cadastrada na base de dados");
                }
                else
                {
                    if (DescricaoUnidadeOK == false)
                    {
                        MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                    }
                    else
                    {
                        errorIcone.Clear();

                        if (this.eNovo)
                        {

                            resp = myUnidadeRede.InserirUnidadeRede(
                            this.txtDescricaoUnidadeRede.Text,
                           Convert.ToDouble(this.txtGastoCompraUnidadeRede.Text),
                           Convert.ToDouble(this.txtLucroVendaUnidadeRede.Text));

                        }
                        else
                        {
                            resp = myUnidadeRede.EditarUnidadeRede(
                            Convert.ToInt32(this.txtCodigoUnidadeRede.Text),
                            this.txtDescricaoUnidadeRede.Text,
                            Convert.ToDouble(this.txtGastoCompraUnidadeRede.Text),
                            Convert.ToDouble(this.txtLucroVendaUnidadeRede.Text));

                            this.CarregarValoresUnidadeRede(this.txtCodigoUnidadeRede);
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
                        this.MostrarUnidade();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarUnidadeRede_Click(object sender, EventArgs e)
        {
            if (this.txtDescricaoUnidadeRede.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para editar");
            }
            else
            {
                this.txtDescricaoUnidadeRede.Focus();
                this.eEditar = true;
                this.eNovo = false;
                this.Botoes();
                this.Habilitar(true);
            }
        }

        private void btnCancelarUnidadeRede_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            this.eNovo = false;
            this.eEditar = false;
            this.Botoes();
            this.Habilitar(false);
            this.Limpar();
        }

        private void tctrlUnidadeRede_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlUnidadeRede.SelectedIndex == 0)
            {
                this.eNovo = false;
                this.eEditar = false;
                this.Botoes();
                this.Habilitar(false);
                this.Limpar();
            }
        }
    }
}
