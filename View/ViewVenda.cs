using Control;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace View
{
    public partial class ViewVenda : Form
    {
        ControlVenda myVenda = new ControlVenda();
        ControlProduto myProduto = new ControlProduto();
        ControlItemVenda myItemVenda = new ControlItemVenda();
        ControlCliente myCliente = new ControlCliente();
        ControlFichaTecnica myFichaTecnica = new ControlFichaTecnica();
        ControlEstoque myEstoque = new ControlEstoque();
        Validar myValidar = new Validar();

        TabPage[] TabRemove = new TabPage[3];
        private bool eNovo = false;
        private bool eEditar = false;

        bool ValidarInsumoOK = false;

        private int _IDVenda;
        private int _IDFuncionario;
        private int _IDUnidade;

        public int IDVenda { get => _IDVenda; set => _IDVenda = value; }
        public int IDFuncionario { get => _IDFuncionario; set => _IDFuncionario = value; }
        public int IDUnidade { get => _IDUnidade; set => _IDUnidade = value; }

        public ViewVenda()
        {
            InitializeComponent();
        }

        public ViewVenda(int id_funcionario, int id_unidade)
        {
            InitializeComponent();
            this.IDFuncionario = id_funcionario;
            this.IDUnidade = id_unidade;
        }

        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "PIZZA VINTAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mostrar mensagem de Erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "PIZZA VINTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OcultarTabProdutos()
        {
            this.TabRemove[0] = tpgAdicionarProdutos;
            this.tctrlVenda.TabPages.Remove(tpgAdicionarProdutos);
        }

        private void OcultarTabVenda()
        {
            this.TabRemove[1] = tpgFinalizarVenda;
            this.tctrlVenda.TabPages.Remove(tpgFinalizarVenda);
        }

        private void OcultarTabValidar()
        {
            this.TabRemove[2] = tpgValidar;
            this.tctrlVenda.TabPages.Remove(tpgValidar);
        }

        private void MostrarTabProdutos()
        {
            this.tctrlVenda.TabPages.Add(TabRemove[0]);
        }

        private void MostrarTabVenda()
        {
            this.tctrlVenda.TabPages.Add(TabRemove[1]);
        }

        private void MostrarTabValidarEstoque()
        {
            this.tctrlVenda.TabPages.Add(TabRemove[2]);
        }

        private void HabilitarDataGridViewCliente()
        {
            if (this.dgvClienteVenda.Rows.Count == 0)
            {
                this.cboxBuscarClienteVenda.Enabled = false;
                this.txtBuscarClienteVenda.Enabled = false;
                this.btnBuscarClienteVenda.Enabled = false;
                this.dgvClienteVenda.Enabled = false;
            }
            else
            {
                this.cboxBuscarClienteVenda.Enabled = true;
                this.txtBuscarClienteVenda.Enabled = true;
                this.btnBuscarClienteVenda.Enabled = true;
                this.dgvClienteVenda.Enabled = true;
            }
        }

        private void HabilitarDataGridViewProduto()
        {
            if (this.dgvProdutoVenda.Rows.Count == 0)
            {
                this.txtBuscarProdutoVenda.Enabled = false;
                this.btnBuscarProdutoVenda.Enabled = false;
                this.dgvProdutoVenda.Enabled = false;
            }
            else
            {
                this.txtBuscarProdutoVenda.Enabled = true;
                this.btnBuscarProdutoVenda.Enabled = true;
                this.dgvProdutoVenda.Enabled = true;
            }
        }

        private void HabilitarDataGridViewItemVenda()
        {
            if (this.dgvItensVenda.Rows.Count == 0)
            {
                this.chkDeletarItemVenda.Enabled = false;
                this.dgvItensVenda.Enabled = false;
            }
            else
            {
                this.chkDeletarItemVenda.Enabled = true;
                this.dgvItensVenda.Enabled = true;
            }
        }

        //Buscar produto pelo nome
        private void BuscarNomeProduto()
        {
            this.dgvProdutoVenda.DataSource = myProduto.BuscarNomeProduto(this.txtBuscarProdutoVenda.Text);
        }

        //Buscar cliente pelo nome
        private void BuscarNomeCliente()
        {
            this.dgvClienteVenda.DataSource = myCliente.BuscarNomeCliente(this.txtBuscarClienteVenda.Text);
        }

        // Buscar pelo documento
        private void BuscasCPFCliente()
        {
            this.dgvClienteVenda.DataSource = myCliente.BuscarCPFCliente(this.txtBuscarClienteVenda.Text);
        }

        // Limpar campos com dados do cliente
        private void LimparDadosCliente()
        {
            this.txtCodigoClienteVenda.Text = string.Empty;
            this.txtNomeClienteVenda.Text = string.Empty;
            this.txtSexoClienteVenda.Text = string.Empty;
            this.txtCPFClienteVenda.Text = string.Empty;
            this.txtNascimentoClienteVenda.Text = string.Empty;
            this.txtTelefoneClienteVenda.Text = string.Empty;
            this.txtEmailClienteVenda.Text = string.Empty;

            this.txtCEPClienteVenda.Text = string.Empty;
            this.txtRuaClienteVenda.Text = string.Empty;
            this.txtNumCasaClienteVenda.Text = string.Empty;
            this.txtBairroClienteVenda.Text = string.Empty;
            this.txtComplementoClienteVenda.Text = string.Empty;
            this.txtCidadeClienteVenda.Text = string.Empty;
            this.txtUFClienteVenda.Text = string.Empty;
        }

        // Limpar campos com dados do produto
        private void LimparDadosProduto()
        {
            this.txtNomeProdutoVenda.Text = string.Empty;
            this.txtCodigoProdutoVenda.Text = string.Empty;
            this.pbProdutoVenda.Image = null;
            this.txtCategoriaProdutoVenda.Text = string.Empty;
            this.txtDescricaoProdutoVenda.Text = string.Empty;
            this.txtQuantidadeProdutoVenda.Text = string.Empty;
            this.txtPrecoProdutoVenda.Text = string.Empty;
        }

        private void LimparDadosVenda()
        {
            this.txtCodigoFuncionarioVendaF.Text = string.Empty;
            this.txtNomeFuncionarioVendaF.Text = string.Empty;

            this.txtCodigoClienteVendaF.Text = string.Empty;
            this.txtNomeClienteVendaF.Text = string.Empty;
            this.txtSexoClienteVendaF.Text = string.Empty;
            this.txtCPFClienteVendaF.Text = string.Empty;
            this.txtNascimentoClienteVendaF.Text = string.Empty;
            this.txtTelefoneClienteVendaF.Text = string.Empty;
            this.txtEmailClienteVendaF.Text = string.Empty;

            this.txtCEPClienteVendaF.Text = string.Empty;
            this.txtRuaClienteVendaF.Text = string.Empty;
            this.txtNumCasaClienteVendaF.Text = string.Empty;
            this.txtBairroClienteVendaF.Text = string.Empty;
            this.txtComplementoClienteVendaF.Text = string.Empty;
            this.txtCidadeClienteVendaF.Text = string.Empty;
            this.txtUFClienteVendaF.Text = string.Empty;

            this.dgvItensVendaF.Text = string.Empty;
            this.txtObservacoesVendaF.Text = string.Empty;
            this.cboxTipoPagamentoVendaF.Text = null;
            this.txtTaxaEntregaVendaF.Text = string.Empty;
            this.txtValorTotalVendaF.Text = string.Empty;
        }

        // Transferir dados do cliente confirmado
        private void TranferirDadosCliente()
        {
            this.txtCodigoClienteVendaF.Text = this.txtCodigoClienteVenda.Text;
            this.txtNomeClienteVendaF.Text = this.txtNomeClienteVenda.Text;
            this.txtSexoClienteVendaF.Text = this.txtSexoClienteVenda.Text;
            this.txtCPFClienteVendaF.Text = this.txtCPFClienteVenda.Text;
            this.txtNascimentoClienteVendaF.Text = this.txtNascimentoClienteVenda.Text;
            this.txtTelefoneClienteVendaF.Text = this.txtTelefoneClienteVenda.Text;
            this.txtEmailClienteVendaF.Text = this.txtEmailClienteVenda.Text;

            this.txtCEPClienteVendaF.Text = this.txtCEPClienteVenda.Text;
            this.txtRuaClienteVendaF.Text = this.txtRuaClienteVenda.Text;
            this.txtNumCasaClienteVendaF.Text = this.txtNumCasaClienteVenda.Text;
            this.txtBairroClienteVendaF.Text = this.txtBairroClienteVenda.Text;
            this.txtComplementoClienteVendaF.Text = this.txtComplementoClienteVenda.Text;
            this.txtCidadeClienteVendaF.Text = this.txtCidadeClienteVenda.Text;
            this.txtUFClienteVendaF.Text = this.txtUFClienteVenda.Text;
        }

        private void HabilitarCamposAdicionarCliente(bool Valor)
        {
            this.txtCodigoFuncionarioVenda.Text = Convert.ToString(this.IDFuncionario);
            this.txtCodigoFuncionarioVenda.Enabled = false;

            this.txtCodigoClienteVenda.Enabled = false;
            this.txtNomeClienteVenda.Enabled = false;
            this.txtSexoClienteVenda.Enabled = false;
            this.txtCPFClienteVenda.Enabled = false;
            this.txtNascimentoClienteVenda.Enabled = false;
            this.txtTelefoneClienteVenda.Enabled = false;
            this.txtEmailClienteVenda.Enabled = false;

            this.txtCEPClienteVenda.Enabled = false;
            this.txtRuaClienteVenda.Enabled = false;
            this.txtNumCasaClienteVenda.Enabled = false;
            this.txtBairroClienteVenda.Enabled = false;
            this.txtComplementoClienteVenda.Enabled = false;
            this.txtCidadeClienteVenda.Enabled = false;
            this.txtUFClienteVenda.Enabled = false;

            this.cboxBuscarClienteVenda.Enabled = Valor;
            this.txtBuscarClienteVenda.Enabled = Valor;
            this.btnBuscarClienteVenda.Enabled = Valor;

            this.dgvClienteVenda.Enabled = Valor;
        }


        private void HabilitarCamposAdicionarProduto(bool Valor)
        {
            this.OcultarTabValidar();

            this.txtBuscarProdutoVenda.Enabled = Valor;
            this.btnBuscarProdutoVenda.Enabled = Valor;
            this.dgvProdutoVenda.Enabled = Valor;

            this.txtCodigoProdutoVenda.Enabled = false;
            this.txtNomeProdutoVenda.Enabled = false;
            this.txtDescricaoProdutoVenda.Enabled = false;
            this.txtPrecoProdutoVenda.Enabled = false;
            this.txtCategoriaProdutoVenda.Enabled = false;
            this.txtQuantidadeProdutoVenda.Enabled = false;

            this.btnConfirmarProdutoVenda.Enabled = false;
            this.btnCancelarProdutoVenda.Enabled = false;

            this.chkDeletarItemVenda.Enabled = false;
            this.dgvItensVenda.Enabled = Valor;
            this.btnExcluirItemVenda.Enabled = false;

            this.btnRealizarPagamentoVenda.Enabled = Valor;

            this.dgvItensVenda.Columns[0].Visible = false;
        }

        // Habilitar os text box
        private void HabilitarCamposFinalizarVenda(bool Valor)
        {
            this.txtCodigoFuncionarioVendaF.Text = Convert.ToString(this.IDFuncionario);
            this.txtCodigoFuncionarioVendaF.Enabled = false;
            this.txtNomeFuncionarioVendaF.Enabled = false;

            this.txtCodigoClienteVendaF.Enabled = false;
            this.txtNomeClienteVendaF.Enabled = false;
            this.txtSexoClienteVendaF.Enabled = false;
            this.txtCPFClienteVendaF.Enabled = false;
            this.txtNascimentoClienteVendaF.Enabled = false;
            this.txtTelefoneClienteVendaF.Enabled = false;
            this.txtEmailClienteVendaF.Enabled = false;

            this.txtCEPClienteVendaF.Enabled = false;
            this.txtRuaClienteVendaF.Enabled = false;
            this.txtNumCasaClienteVendaF.Enabled = false;
            this.txtBairroClienteVendaF.Enabled = false;
            this.txtComplementoClienteVendaF.Enabled = false;
            this.txtCidadeClienteVendaF.Enabled = false;
            this.txtUFClienteVendaF.Enabled = false;

            this.dgvItensVendaF.Enabled = false;
            this.txtObservacoesVendaF.Enabled = Valor;
            this.cboxTipoPagamentoVendaF.Enabled = Valor;
            this.txtTaxaEntregaVendaF.Enabled = Valor;
            this.txtValorTotalVendaF.Enabled = false;

            this.btnCancelarVenda.Enabled = Valor;
            this.btnFinalizarVenda.Enabled = Valor;
        }

        // Habilitar os botões cliente
        private void BotoesCliente()
        {
            if (this.eNovo || this.eEditar)
            {
                this.btnConfirmarClienteVenda.Enabled = false;
                this.btnAlterarClienteVenda.Enabled = false;
                this.btnNovaVenda.Enabled = false;
            }
            else
            {
                this.btnConfirmarClienteVenda.Enabled = false;
                this.btnAlterarClienteVenda.Enabled = false;
                this.btnNovaVenda.Enabled = true;
            }
        }

        // Habilitar os botões produto
        private void BotoesProdutos()
        {
            if (this.eNovo || this.eEditar)
            {
                this.HabilitarCamposFinalizarVenda(true);
                this.btnFinalizarVenda.Enabled = true;
                this.btnCancelarProdutoVenda.Enabled = true;
                this.btnConfirmarProdutoVenda.Enabled = true;
            }
            else
            {
                this.HabilitarCamposFinalizarVenda(false);
                this.btnFinalizarVenda.Enabled = false;
                this.btnCancelarProdutoVenda.Enabled = false;
                this.btnConfirmarProdutoVenda.Enabled = false;
            }
        }

        private void InserirVenda()
        {
            try
            {
                string resp = "";

                if (txtNomeClienteVenda.Text == string.Empty)
                {
                    MensagemErro("Selecione um cliente");
                }
                else
                {
                    if (txtObservacoesVendaF.Text == string.Empty)
                    {
                        txtObservacoesVendaF.Text = "Sem Observações";
                    }

                    if (cboxTipoPagamentoVendaF.Text == string.Empty)
                    {
                        cboxTipoPagamentoVendaF.Text = null;
                    }

                    if (txtTaxaEntregaVendaF.Text == string.Empty)
                    {
                        txtTaxaEntregaVendaF.Text = "0,00";
                    }

                    if (this.eNovo)
                    {
                        resp = myVenda.InserirVenda(
                            Convert.ToInt32(this.txtCodigoFuncionarioVenda.Text),
                            Convert.ToInt32(this.txtCodigoClienteVenda.Text),
                            this.IDUnidade);

                        this.MostrarTabValidarEstoque();
                        this.dgvVendaValida.DataSource = myVenda.MostrarVenda(this.IDUnidade);

                        foreach (DataGridViewRow row in dgvVendaValida.Rows)
                        {
                            if (Convert.ToString(row.Cells["VL_Total"].Value) == string.Empty)
                            {
                                this.IDVenda = Convert.ToInt32(row.Cells["ID_Venda"].Value);
                            }
                        }
                    }
                    else
                    {
                        resp = myVenda.EditarVenda(
                            Convert.ToInt32(this.txtCodigoFuncionarioVenda.Text),
                            Convert.ToInt32(this.txtCodigoClienteVenda.Text),
                            this.txtObservacoesVendaF.Text,
                            this.cboxTipoPagamentoVendaF.Text,
                            Convert.ToDouble(this.txtTaxaEntregaVendaF.Text),
                            Convert.ToDouble(this.txtValorTotalVendaF.Text),
                            this.IDUnidade);
                    }

                    if (resp.Equals("OK"))
                    {
                        if (this.eNovo)
                        {
                            this.btnConfirmarProdutoVenda.Enabled = false;
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void InserirItemVenda()
        {
            try
            {
                string resp = "";

                if (this.eNovo)
                {
                    errorIcone.Clear();

                    resp = myItemVenda.InserirItemVenda(this.IDVenda,
                            Convert.ToInt32(this.txtCodigoProdutoVenda.Text),
                            Convert.ToInt32(this.txtQuantidadeProdutoVenda.Text),
                            Convert.ToDouble(this.txtPrecoProdutoVenda.Text));
                }

                if (resp.Equals("OK"))
                {
                    this.MostrarItemVenda();
                }
                else
                {
                    this.MensagemErro(resp);
                }

                this.eNovo = false;
                this.eEditar = false;
                this.BotoesCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MostrarClientes()
        {
            this.dgvClienteVenda.DataSource = myCliente.MostrarCliente();

            this.dgvClienteVenda.Columns[0].HeaderText = "CÓDIGO";
            this.dgvClienteVenda.Columns[1].HeaderText = "NOME";
            this.dgvClienteVenda.Columns[2].Visible = false;
            this.dgvClienteVenda.Columns[3].HeaderText = "CPF";
            this.dgvClienteVenda.Columns[4].HeaderText = "DATA\nNASCIMENTO";
            this.dgvClienteVenda.Columns[5].HeaderText = "TELEFONE";
            this.dgvClienteVenda.Columns[6].Visible = false;
            this.dgvClienteVenda.Columns[7].Visible = false;
            this.dgvClienteVenda.Columns[8].Visible = false;
            this.dgvClienteVenda.Columns[9].Visible = false;
            this.dgvClienteVenda.Columns[10].Visible = false;
            this.dgvClienteVenda.Columns[11].Visible = false;
            this.dgvClienteVenda.Columns[12].Visible = false;
            this.dgvClienteVenda.Columns[13].Visible = false;

            this.dgvClienteVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClienteVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridViewCliente();
        }

        private void MostrarItemVenda()
        {
            this.dgvItensVenda.DataSource = myItemVenda.MostrarItemVenda(this.IDVenda);

            this.dgvItensVenda.Columns[1].HeaderText = "VENDA";
            this.dgvItensVenda.Columns[2].HeaderText = "CÓDIGO\nPRODUTO";
            this.dgvItensVenda.Columns[3].HeaderText = "NOME";
            this.dgvItensVenda.Columns[4].HeaderText = "QUANTIDADE";
            this.dgvItensVenda.Columns[5].HeaderText = "PREÇO";

            this.dgvItensVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItensVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridViewItemVenda();
        }

        private void MostrarProduto()
        {
            this.dgvProdutoVenda.DataSource = myProduto.MostrarProduto();

            this.dgvProdutoVenda.Columns[0].HeaderText = "CÓDIGO";
            this.dgvProdutoVenda.Columns[1].HeaderText = "CATEGORIA";
            this.dgvProdutoVenda.Columns[2].HeaderText = "NOME";
            this.dgvProdutoVenda.Columns[3].HeaderText = "PREÇO";
            this.dgvProdutoVenda.Columns[4].Visible = false;
            this.dgvProdutoVenda.Columns[5].HeaderText = "DESCRIÇÃO";
            this.dgvProdutoVenda.Columns[6].Visible = false;

            this.dgvProdutoVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutoVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridViewProduto();
        }

        private void MostrarItemVendaFinal()
        {
            this.dgvItensVendaF.DataSource = myItemVenda.MostrarItemVenda(this.IDVenda);

            this.dgvItensVendaF.Columns[0].HeaderText = "VENDA";
            this.dgvItensVendaF.Columns[1].HeaderText = "CÓDIGO\nPRODUTO";
            this.dgvItensVendaF.Columns[2].HeaderText = "NOME";
            this.dgvItensVendaF.Columns[3].HeaderText = "QUANTIDADE";
            this.dgvItensVendaF.Columns[4].HeaderText = "PREÇO";

            this.CalcularVenda();

            this.dgvItensVendaF.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItensVendaF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void MostrarFichaTecnica(int campo)
        {
            this.dgvFichaTecnicaValida.DataSource = myFichaTecnica.MostrarFichaTecnica(campo);
        }

        private void MostrarEstoque()
        {
            this.dgvEstoqueValida.DataSource = myEstoque.MostrarEstoque(this.IDUnidade);
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

        private void ValidarValorComZero(TextBox campo)
        {
            string valorcomzerovalido = Convert.ToString(campo.Text);
            myValidar.ValorComZero(valorcomzerovalido);

            if (myValidar.ValorValido == false)
            {
                errorIcone.SetError(campo, "Este campo deve ser preenchido somente com números, vírgulas e pontos." +
                                            "\nVerifique também a disposição dos números conforme Ex: 000.000,00");
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

        private void CalcularVenda()
        {
            double subtotalVenda = 0;

            foreach (DataGridViewRow row in dgvItensVenda.Rows)
            {
                subtotalVenda += Convert.ToDouble(row.Cells["VL_SubTotal"].Value);
                this.txtSubTotalVenda.Text = subtotalVenda.ToString("N2");
            }

            double totalVenda = 0;

            foreach (DataGridViewRow row in dgvItensVendaF.Rows)
            {
                totalVenda += Convert.ToDouble(row.Cells["VL_SubTotal"].Value);
                this.txtValorTotalVendaF.Text = totalVenda.ToString("N2");

                ValidarValorComZero(txtTaxaEntregaVendaF);
                if (myValidar.ValorValido == true)
                {
                    this.txtValorTotalVendaF.Text = (totalVenda + Convert.ToDouble(txtTaxaEntregaVendaF.Text)).ToString("N2");
                }
            }
        }

        private void ValidarQuantidadeInsumo(int id_produto, int qtde_itemvenda)
        {
            this.MostrarTabValidarEstoque();
            this.MostrarFichaTecnica(id_produto);
            this.MostrarEstoque();

            for (int i = 0; i < this.dgvFichaTecnicaValida.Rows.Count; i++)
            {
                int j = 0;

                for (j = 0; j < dgvEstoqueValida.Rows.Count; j++)
                {
                    if (this.dgvFichaTecnicaValida.Rows[i].Cells["ID_Insumo"].Value.Equals(this.dgvEstoqueValida.Rows[j].Cells["ID_Insumo"].Value))
                    {
                        int ID_Insumo = Convert.ToInt32(this.dgvFichaTecnicaValida.Rows[i].Cells["ID_Insumo"].Value);

                        double QuantidadeUtilizada = Convert.ToDouble(this.dgvFichaTecnicaValida.Rows[i].Cells["QTDE_Utilizada"].Value);
                        QuantidadeUtilizada *= qtde_itemvenda;

                        double QuantidadeTotalEstoque = Convert.ToDouble(this.dgvEstoqueValida.Rows[j].Cells["QTDE_Estoque"].Value);

                        if (QuantidadeUtilizada > QuantidadeTotalEstoque)
                        {
                            double insumoInsuficiente = QuantidadeUtilizada - QuantidadeTotalEstoque;

                            this.MensagemErro("Insumo insuficiente" +
                                "\nInsumo : " + this.dgvFichaTecnicaValida.Rows[i].Cells["NM_Insumo"].Value +
                                "\nFaltaram " + insumoInsuficiente.ToString("N2") + " " +
                                this.dgvFichaTecnicaValida.Rows[i].Cells["DS_TipoArmazenamento"].Value);

                            ValidarInsumoOK = false;
                        }
                        else
                        {
                            myEstoque.BaixaEstoque(ID_Insumo, QuantidadeUtilizada, this.IDUnidade);
                            ValidarInsumoOK = true;
                        }
                        break;
                    }
                }
            }
            this.OcultarTabValidar();
        }

        private void RetornoEstoque()
        {
            this.MostrarTabValidarEstoque();

            foreach (DataGridViewRow row in dgvItensVenda.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    this.MostrarFichaTecnica(Convert.ToInt32(row.Cells["ID_Produto"].Value));
                    double QTDE_ItemVenda = Convert.ToDouble(row.Cells["QTDE_ItemVenda"].Value);

                    for (int i = 0; i < this.dgvFichaTecnicaValida.Rows.Count; i++)
                    {
                        int ID_Insumo = Convert.ToInt32(this.dgvFichaTecnicaValida.Rows[i].Cells["ID_Insumo"].Value);

                        double QuantidadeUtilizada = Convert.ToDouble(this.dgvFichaTecnicaValida.Rows[i].Cells["QTDE_Utilizada"].Value);
                        QuantidadeUtilizada = QuantidadeUtilizada * QTDE_ItemVenda;

                        myEstoque.EditarEstoque(ID_Insumo, QuantidadeUtilizada, this.IDUnidade);
                    }
                }
            }
            this.OcultarTabValidar();
        }

        public void ValidarVenda()
        {
            myVenda.ValidarVenda();
        }

        public void RetornoEstoqueVendaIncompleta()
        {
            this.OcultarTabValidar();
            this.MostrarTabValidarEstoque();

            this.dgvVendaValida.DataSource = myVenda.MostrarVenda(this.IDUnidade);
            this.dgvItemVendaValida.DataSource = myItemVenda.MostrarTodosItemVenda();

            for (int i = 0; i < dgvVendaValida.Rows.Count; i++)
            {
                if (this.dgvVendaValida.Rows[i].Cells["VL_Total"].Value.Equals(DBNull.Value))
                {
                    int id_venda = Convert.ToInt32(dgvVendaValida.Rows[i].Cells["ID_Venda"].Value);

                    for (int j = 0; j < dgvItemVendaValida.Rows.Count; j++)
                    {
                        if (dgvItemVendaValida.Rows[j].Cells["ID_Venda"].Value.Equals(id_venda))
                        {
                            int id_produto = Convert.ToInt32(dgvItemVendaValida.Rows[j].Cells["ID_Produto"].Value);
                            double qtde_itemvenda = Convert.ToDouble(dgvItemVendaValida.Rows[j].Cells["QTDE_ItemVenda"].Value);

                            this.MostrarFichaTecnica(id_produto);

                            for (int k = 0; k < dgvFichaTecnicaValida.RowCount; k++)
                            {
                                if (dgvFichaTecnicaValida.Rows[k].Cells["ID_Produto"].Value.Equals(dgvItemVendaValida.Rows[j].Cells["ID_Produto"].Value))
                                {
                                    int id_insumo = Convert.ToInt32(dgvFichaTecnicaValida.Rows[k].Cells["ID_Insumo"].Value);

                                    double qtde_utilizada = Convert.ToDouble(dgvFichaTecnicaValida.Rows[k].Cells["QTDE_Utilizada"].Value);
                                    qtde_utilizada *= qtde_itemvenda;

                                    myEstoque.EditarEstoque(id_insumo, qtde_utilizada, this.IDUnidade);
                                }
                            }
                        }
                    }
                }
            }
            this.OcultarTabValidar();
        }

        private void ViewVenda_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.OcultarTabProdutos();
            this.OcultarTabVenda();
            this.LimparDadosCliente();
            this.LimparDadosProduto();
            this.LimparDadosVenda();
            this.HabilitarCamposAdicionarCliente(false);
            this.HabilitarCamposAdicionarProduto(false);
            this.HabilitarCamposFinalizarVenda(false);
            this.dgvClienteVenda.DataSource = "";
            this.dgvProdutoVenda.DataSource = "";
            this.dgvItensVenda.DataSource = "";
            this.dgvItensVendaF.DataSource = "";
            this.BotoesCliente();
            this.BotoesProdutos();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            this.RetornoEstoqueVendaIncompleta();
            this.ValidarVenda();

            this.OcultarTabVenda();
            this.OcultarTabProdutos();
            this.MensagemOk("Nova venda iniciada");
            this.HabilitarCamposAdicionarCliente(true);
            this.eEditar = false;
            this.BotoesCliente();
            this.btnNovaVenda.Enabled = false;
            this.MostrarClientes();
        }

        private void cboBuscarClienteVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscarClienteVenda.Text = string.Empty;
        }

        private void txtBuscarClienteVenda_TextChanged(object sender, EventArgs e)
        {
            if (cboxBuscarClienteVenda.Text.Equals("Nome"))
            {
                this.BuscarNomeCliente();
            }
            else if (cboxBuscarClienteVenda.Text.Equals("CPF"))
            {
                this.BuscasCPFCliente();
            }
        }

        private void btnBuscarClienteVenda_Click(object sender, EventArgs e)
        {
            if (cboxBuscarClienteVenda.Text.Equals("Nome"))
            {
                this.BuscarNomeCliente();
            }
            else if (cboxBuscarClienteVenda.Text.Equals("CPF"))
            {
                this.BuscasCPFCliente();
            }
        }

        private void dgvClienteVenda_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigoClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["ID_Cliente"].Value);
            this.txtNomeClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["NM_Cliente"].Value);
            this.txtNascimentoClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["DT_Nascimento"].Value);
            this.txtSexoClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["DS_Sexo"].Value);
            this.txtCPFClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["NR_CPF"].Value);
            this.txtCEPClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["NR_CEP"].Value);
            this.txtRuaClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["NM_Rua"].Value);
            this.txtNumCasaClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["NR_Casa"].Value);
            this.txtBairroClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["NM_Bairro"].Value);
            this.txtComplementoClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["DS_Complemento"].Value);
            this.txtCidadeClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["NM_Cidade"].Value);
            this.txtUFClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["DS_UF"].Value);
            this.txtTelefoneClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["NR_Telefone"].Value);
            this.txtEmailClienteVenda.Text = Convert.ToString(this.dgvClienteVenda.CurrentRow.Cells["DS_Email"].Value);

            this.btnConfirmarClienteVenda.Enabled = true;
            this.btnAlterarClienteVenda.Enabled = true;
        }

        private void btnConfirmarClienteVenda_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show(
                    "Deseja selecionar o cliente:\n" + txtNomeClienteVenda.Text + "\npara realizar a venda?",
                    "PIZZA VINTAGE",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (Opcao == DialogResult.Yes)
                {
                    this.TranferirDadosCliente();

                    this.btnAlterarClienteVenda.Enabled = false;
                    this.btnConfirmarClienteVenda.Enabled = false;
                    this.HabilitarCamposAdicionarCliente(false);

                    this.eNovo = true;
                    this.InserirVenda();
                    this.HabilitarCamposAdicionarProduto(true);
                    this.MostrarTabProdutos();
                    this.tctrlVenda.SelectedIndex = 1;
                    this.MostrarProduto();
                    this.MostrarItemVenda();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAlterarClienteVenda_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult Opcao;
                Opcao = MessageBox.Show(
                    "Deseja alterar o cliente selecionado?",
                    "PIZZA VINTAGE",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (Opcao == DialogResult.Yes)
                {
                    this.LimparDadosCliente();

                    this.btnAlterarClienteVenda.Enabled = false;
                    this.btnConfirmarClienteVenda.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBuscarProdutoVenda_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNomeProduto();
        }

        private void btnBuscarProdutoVenda_Click(object sender, EventArgs e)
        {
            this.BuscarNomeProduto();
        }

        private void dgvProdutoVenda_DoubleClick(object sender, EventArgs e)
        {
            bool produtoInvalido = false;

            foreach (DataGridViewRow row in dgvItensVenda.Rows)
            {
                if (this.dgvProdutoVenda.CurrentRow.Cells["NM_Produto"].Value.Equals(row.Cells["NM_Produto"].Value))
                {
                    this.MensagemErro("Este produto já foi adicionado na venda");
                    this.LimparDadosProduto();
                    produtoInvalido = true;
                }
            }
            if (produtoInvalido == false)
            {
                this.txtCodigoProdutoVenda.Text = Convert.ToString(this.dgvProdutoVenda.CurrentRow.Cells["ID_Produto"].Value);
                this.txtNomeProdutoVenda.Text = Convert.ToString(this.dgvProdutoVenda.CurrentRow.Cells["NM_Produto"].Value);
                this.txtDescricaoProdutoVenda.Text = Convert.ToString(this.dgvProdutoVenda.CurrentRow.Cells["DS_Produto"].Value);
                this.txtPrecoProdutoVenda.Text = (Convert.ToDouble(this.dgvProdutoVenda.CurrentRow.Cells["PR_Unitario"].Value)).ToString("F2");
                this.txtCategoriaProdutoVenda.Text = Convert.ToString(this.dgvProdutoVenda.CurrentRow.Cells["NM_Categoria"].Value);
                byte[] imag;
                try
                {
                    if (dgvProdutoVenda.CurrentRow.Cells["IMG_Produto"].Value != DBNull.Value)
                    {
                        imag = (byte[])dgvProdutoVenda.CurrentRow.Cells["IMG_Produto"].Value;

                        MemoryStream ms = new MemoryStream(imag);

                        Image Imagem = Image.FromStream(ms);
                        this.pbProdutoVenda.Image = Imagem;
                        this.pbProdutoVenda.Visible = true;
                    }
                    else
                    {
                        imag = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                this.txtQuantidadeProdutoVenda.Enabled = true;
                this.btnCancelarProdutoVenda.Enabled = true;
                this.btnConfirmarProdutoVenda.Enabled = true;
            }
        }

        private void btnConfirmarProdutoVenda_Click(object sender, EventArgs e)
        {
            bool QuantidadeProdutoVendaOk = false;

            ValidarCampoNulo(txtQuantidadeProdutoVenda);
            if (myValidar.CampoValido == true)
            {
                ValidarNumero(txtQuantidadeProdutoVenda);
                if (myValidar.NumeroValido == true)
                {
                    if (Convert.ToInt32(txtQuantidadeProdutoVenda.Text) < 1)
                    {
                        errorIcone.SetError(txtQuantidadeProdutoVenda, "A quantidade não pode ser menor ou igual a 0 (zero)");
                    }
                    else
                    {
                        QuantidadeProdutoVendaOk = true;
                    }
                }
            }

            if (QuantidadeProdutoVendaOk == false)
            {
                MensagemErro("Por favor, preencha corretamente a quantidade a ser adicionada na venda");
            }
            else
            {
                errorIcone.Clear();
                this.eNovo = true;

                try
                {
                    this.ValidarQuantidadeInsumo(Convert.ToInt32(this.txtCodigoProdutoVenda.Text), Convert.ToInt32(this.txtQuantidadeProdutoVenda.Text));

                    if (ValidarInsumoOK == true)
                    {
                        DialogResult Opcao;
                        Opcao = MessageBox.Show("Deseja adicionar este produto na venda?",
                            "PIZZA VINTAGE",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (Opcao == DialogResult.Yes)
                        {
                            this.InserirItemVenda();

                            this.LimparDadosProduto();
                            this.btnConfirmarProdutoVenda.Enabled = false;
                            this.btnCancelarProdutoVenda.Enabled = false;
                            this.txtQuantidadeProdutoVenda.Enabled = false;
                            this.chkDeletarItemVenda.Enabled = true;

                            this.CalcularVenda();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnCancelarProdutoVenda_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja cancelar o produto selecionado?",
                    "PIZZA VINTAGE",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (Opcao == DialogResult.Yes)
                {
                    errorIcone.SetError(txtQuantidadeProdutoVenda, string.Empty);

                    this.LimparDadosProduto();

                    this.txtQuantidadeProdutoVenda.Enabled = false;

                    this.btnCancelarProdutoVenda.Enabled = false;
                    this.btnConfirmarProdutoVenda.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnExcluirItemVenda_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvItensVenda.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há itens selecionados para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Realmente deseja excluir o item da venda?",
                        "PIZZA VINTAGE",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        string Venda;
                        string Produto;
                        string resp = "";

                        this.RetornoEstoque();

                        foreach (DataGridViewRow row in dgvItensVenda.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Venda = Convert.ToString(row.Cells[1].Value);
                                Produto = Convert.ToString(row.Cells[2].Value);
                                resp = myItemVenda.ExcluirUmItemVenda(Convert.ToInt32(Venda), Convert.ToInt32(Produto));
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            this.MensagemOk("Item excluído com sucesso");
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }

                        this.chkDeletarItemVenda.Checked = false;
                        this.MostrarItemVenda();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvItensVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvItensVenda.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvItensVenda.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void chkDeletarItemVenda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarItemVenda.Checked)
            {
                this.dgvItensVenda.Columns[0].Visible = true;
                this.btnExcluirItemVenda.Enabled = true;
            }
            else
            {
                this.dgvItensVenda.Columns[0].Visible = false;
                this.btnExcluirItemVenda.Enabled = false;
            }
        }

        private void btnRealizarPagamentoVenda_Click(object sender, EventArgs e)
        {
            if (this.dgvItensVenda.Rows.Count == 0)
            {
                MensagemErro("Não há itens adicionados na venda");
            }
            else
            {
                this.btnRealizarPagamentoVenda.Enabled = false;
                this.HabilitarCamposFinalizarVenda(true);
                this.MostrarTabVenda();
                this.tctrlVenda.SelectedIndex = 2;

                this.MostrarItemVendaFinal();
            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Realmente deseja cancelar esta venda? \nTodos os dados serão excluídos.",
                "PIZZA VINTAGE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Opcao == DialogResult.Yes)
            {
                this.eNovo = false;
                this.eEditar = false;
                this.OcultarTabProdutos();
                this.OcultarTabVenda();
                this.LimparDadosCliente();
                this.LimparDadosProduto();
                this.LimparDadosVenda();
                this.HabilitarCamposAdicionarCliente(false);
                this.HabilitarCamposAdicionarProduto(false);
                this.HabilitarCamposFinalizarVenda(false);
                this.dgvClienteVenda.DataSource = "";
                this.dgvProdutoVenda.DataSource = "";
                this.dgvItensVenda.DataSource = "";
                this.dgvItensVendaF.DataSource = "";
                this.BotoesCliente();
                this.BotoesProdutos();

                this.tctrlVenda.SelectedIndex = 0;
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            this.MostrarItemVendaFinal();

            if (dgvItensVendaF.Rows.Count < 1)
            {
                MensagemErro("Não há itens na venda");
            }
            else
            {
                bool ObservacoesVendaFOK = false;
                bool TipoPagamentoVendaFOK = false;
                bool TaxaEntregaVendaFOK = false;

                if (txtObservacoesVendaF.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtObservacoesVendaF, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        ObservacoesVendaFOK = true;
                    }
                }

                if (cboxTipoPagamentoVendaF.Text == null)
                {
                    errorIcone.SetError(cboxTipoPagamentoVendaF, "Selecione o tipo de pagamento");
                }
                else
                {
                    errorIcone.SetError(cboxTipoPagamentoVendaF, string.Empty);
                    TipoPagamentoVendaFOK = true;
                }

                ValidarCampoNulo(txtTaxaEntregaVendaF);
                if (myValidar.CampoValido == true)
                {
                    ValidarValorComZero(txtTaxaEntregaVendaF);
                    if (myValidar.ValorValido == true)
                    {
                        TaxaEntregaVendaFOK = true;
                    }
                }

                if (ObservacoesVendaFOK == false ||
                    TipoPagamentoVendaFOK == false ||
                    TaxaEntregaVendaFOK == false)
                {
                    MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                }
                else
                {
                    errorIcone.Clear();
                    this.MostrarItemVendaFinal();

                    this.eNovo = false;
                    this.eEditar = true;
                    this.InserirVenda();

                    MensagemOk("Venda realizada! Retornando a tela inicial...");

                    this.eNovo = false;
                    this.eEditar = false;
                    this.OcultarTabProdutos();
                    this.OcultarTabVenda();
                    this.LimparDadosCliente();
                    this.LimparDadosProduto();
                    this.LimparDadosVenda();
                    this.HabilitarCamposAdicionarCliente(false);
                    this.HabilitarCamposAdicionarProduto(false);
                    this.HabilitarCamposFinalizarVenda(false);
                    this.dgvClienteVenda.DataSource = "";
                    this.dgvProdutoVenda.DataSource = "";
                    this.dgvItensVenda.DataSource = "";
                    this.dgvItensVendaF.DataSource = "";
                    this.BotoesCliente();
                    this.BotoesProdutos();

                    this.tctrlVenda.SelectedIndex = 0;
                }
            }
        }

        private void txtTaxaEntregaVendaF_TextChanged(object sender, EventArgs e)
        {
            ValidarValorComZero(txtTaxaEntregaVendaF);
            if (myValidar.ValorValido == true)
            {
                this.CalcularVenda();
            }
        }

        private void btnAtualizarItemVendaF_Click(object sender, EventArgs e)
        {
            this.dgvItensVendaF.DataSource = "";

            this.MostrarItemVendaFinal();
        }
    }
}
