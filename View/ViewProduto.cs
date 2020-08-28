using Control;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace View
{
    public partial class ViewProduto : Form
    {
        ControlProduto myProduto = new ControlProduto();
        ControlCategoria myCategoria = new ControlCategoria();
        ControlInsumo myInsumo = new ControlInsumo();
        ControlFichaTecnica myFichaTecnica = new ControlFichaTecnica();

        Validar myValidar = new Validar();

        private bool eNovo = false;
        private bool eEditar = false;
        public byte[] foto1;
        string foto = "";
        Bitmap bmp;

        public ViewProduto()
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
            this.txtCodigoProduto.Text = string.Empty;
            this.txtNomeProduto.Text = string.Empty;
            this.txtDescricaoProduto.Text = string.Empty;
            this.txtPrecoProduto.Text = string.Empty;
            this.txtCustoProduto.Text = string.Empty;
            this.cboxCategoriaProduto.Text = null;
            this.pboxProduto.Image = null;
        }

        // Habilitar os text box
        private void Habilitar(bool Valor)
        {
            this.txtCodigoProduto.Enabled = false;
            this.txtNomeProduto.Enabled = Valor;
            this.txtDescricaoProduto.Enabled = Valor;
            this.txtPrecoProduto.Enabled = Valor;
            this.txtCustoProduto.Enabled = Valor;
            this.cboxCategoriaProduto.Enabled = Valor;
            this.pboxProduto.Visible = Valor;

            this.dgvInsumoProduto.Enabled = Valor;
        }

        // Habilitar os botões
        private void Botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovoProduto.Enabled = false;
                this.btnSalvarProduto.Enabled = true;
                this.btnEditarProduto.Enabled = false;
                this.btnCancelarProduto.Enabled = true;
                this.btnCarregarFotoProduto.Enabled = true;
                this.btnExcluirFotoProduto.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovoProduto.Enabled = true;
                this.btnSalvarProduto.Enabled = false;
                this.btnEditarProduto.Enabled = true;
                this.btnCancelarProduto.Enabled = false;
                this.btnCarregarFotoProduto.Enabled = false;
                this.btnExcluirFotoProduto.Enabled = false;
            }
        }

        private void LimparDadosInsumoProduto()
        {
            this.txtCodigoInsumoProduto.Text = string.Empty;
            this.txtNomeInsumoProduto.Text = string.Empty;
            this.txtArmazenamentoInsumoProduto.Text = string.Empty;
            this.txtPrecoInsumoProduto.Text = string.Empty;
            this.txtQuantidadeInsumoProduto.Text = string.Empty;
        }

        private void LimparDadosFichaTecnica()
        {
            this.txtCodigoInsumoProdutoFT.Text = string.Empty;
            this.txtNomeInsumoProdutoFT.Text = string.Empty;
            this.txtQuantidadeInsumoProdutoFT.Text = string.Empty;
        }

        private void HabilitarCamposFichaTecnica(bool Valor)
        {
            this.txtCodigoInsumoProduto.Enabled = false;
            this.txtNomeInsumoProduto.Enabled = false;
            this.txtArmazenamentoInsumoProduto.Enabled = false;
            this.txtPrecoInsumoProduto.Enabled = false;
            this.txtQuantidadeInsumoProduto.Enabled = false;
            this.txtBuscarNomeInsumoProduto.Enabled = Valor;
            this.btnAdicionarInsumoProduto.Enabled = false;

            this.dgvInsumoProduto.Enabled = Valor;

            this.txtCodigoInsumoProdutoFT.Enabled = false;
            this.txtNomeInsumoProdutoFT.Enabled = false;
            this.txtQuantidadeInsumoProdutoFT.Enabled = false;
            this.btnAlterarInsumoProdutoFT.Enabled = false;

            this.dgvFichaTecnicaProduto.Enabled = Valor;
        }

        private void OcultarDeletarProduto()
        {
            this.dgvProduto.Columns[0].Visible = false;
        }

        private void OcultarDeletarFichaTecnica()
        {
            this.dgvFichaTecnicaProduto.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (this.dgvProduto.Rows.Count == 0)
            {
                this.chkDeletarProduto.Enabled = false;
                this.btnDeletarProduto.Enabled = false;
                this.txtBuscarProduto.Enabled = false;
                this.btnBuscarProduto.Enabled = false;
                this.dgvProduto.Enabled = false;
            }
            else
            {
                this.chkDeletarProduto.Enabled = true;
                this.btnDeletarProduto.Enabled = true;
                this.txtBuscarProduto.Enabled = true;
                this.btnBuscarProduto.Enabled = true;
                this.dgvProduto.Enabled = true;
            }


            if (this.dgvInsumoProduto.Rows.Count == 0)
            {
                this.txtBuscarNomeInsumoProduto.Enabled = false;
                this.dgvInsumoProduto.Enabled = false;
            }
            else
            {
                this.txtBuscarNomeInsumoProduto.Enabled = true;
                this.dgvInsumoProduto.Enabled = true;
            }


            if (this.dgvFichaTecnicaProduto.Rows.Count == 0)
            {
                this.chkDeletarFT.Enabled = false;
                this.btnDeletarInsumoFT.Enabled = false;
                this.dgvFichaTecnicaProduto.Enabled = false;
            }
            else
            {
                this.chkDeletarFT.Enabled = true;
                this.btnDeletarInsumoFT.Enabled = true;
                this.dgvFichaTecnicaProduto.Enabled = true;
            }
        }

        private void MostrarProduto()
        {
            this.dgvProduto.DataSource = myProduto.MostrarProduto();
            this.OcultarDeletarProduto();
            lblTotalProduto.Text = "Total de Registros:  " + Convert.ToString(dgvProduto.Rows.Count);

            this.dgvProduto.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dgvProduto.Columns[1].HeaderText = "CÓDIGO";
            this.dgvProduto.Columns[2].HeaderText = "CATEGORIA";
            this.dgvProduto.Columns[3].HeaderText = "NOME";
            this.dgvProduto.Columns[4].HeaderText = "PREÇO";
            this.dgvProduto.Columns[5].HeaderText = "CUSTO";
            this.dgvProduto.Columns[6].HeaderText = "DESCRIÇÃO";
            this.dgvProduto.Columns[7].Visible = false;

            this.dgvProduto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridView();
        }

        private void MostrarCategoria()
        {
            this.cboxCategoriaProduto.DataSource = myCategoria.MostrarCategoria();
            this.cboxCategoriaProduto.DisplayMember = "NM_Categoria";
            this.cboxCategoriaProduto.ValueMember = "ID_Categoria";
        }

        private void MostrarInsumo()
        {
            this.dgvInsumoProduto.DataSource = myInsumo.MostrarInsumo();

            this.dgvInsumoProduto.Columns[0].Visible = false;
            this.dgvInsumoProduto.Columns[1].HeaderText = "NOME";
            this.dgvInsumoProduto.Columns[2].HeaderText = "ARMAZENAMENTO";
            this.dgvInsumoProduto.Columns[3].HeaderText = "PREÇO";

            this.dgvInsumoProduto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInsumoProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridView();
        }

        private void MostrarFichaTecnica(int id_busca)
        {
            this.dgvFichaTecnicaProduto.DataSource = myFichaTecnica.MostrarFichaTecnica(id_busca);
            this.OcultarDeletarFichaTecnica();

            this.dgvFichaTecnicaProduto.Columns[1].Visible = false;
            this.dgvFichaTecnicaProduto.Columns[2].HeaderText = "CÓDIGO";
            this.dgvFichaTecnicaProduto.Columns[3].HeaderText = "INSUMO";
            this.dgvFichaTecnicaProduto.Columns[4].HeaderText = "QUANTIDADE";

            this.dgvFichaTecnicaProduto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFichaTecnicaProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.HabilitarDataGridView();
        }

            private void InserirFichaTecnicaProduto()
            {
                try
                {
                    string resp = "";

                    if (this.eNovo)
                    {
                        resp = myFichaTecnica.InserirFichaTecnica(
                            Convert.ToInt32(this.txtCodigoProduto.Text),
                            Convert.ToInt32(this.txtCodigoInsumoProduto.Text),
                            Convert.ToDouble(this.txtQuantidadeInsumoProduto.Text));
                    }
                    else
                    {
                        resp = myFichaTecnica.EditarFichaTecnica(
                            Convert.ToInt32(this.txtCodigoProduto.Text),
                            Convert.ToInt32(this.txtCodigoInsumoProdutoFT.Text),
                            Convert.ToDouble(this.txtQuantidadeInsumoProdutoFT.Text));
                    }

                    if (resp.Equals("OK"))
                    {
                        this.MostrarFichaTecnica(Convert.ToInt32(this.txtCodigoProduto.Text));
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eNovo = false;
                    this.eEditar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }

        private void BuscarNomeProduto()
        {
            this.dgvProduto.DataSource = myProduto.BuscarNomeProduto(this.txtBuscarProduto.Text);
            lblTotalProduto.Text = "Total de Registros:  " + Convert.ToString(dgvProduto.Rows.Count);
        }

        private void BuscarNomeInsumoProduto()
        {
            this.dgvInsumoProduto.DataSource = myInsumo.BuscarNomeInsumo(this.txtBuscarNomeInsumoProduto.Text);
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter convert = new ImageConverter();
            return (byte[])convert.ConvertTo(img, typeof(byte[]));
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

        private void ViewProduto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.tctrlProduto.TabPages.Remove(tpgFichaTecnica);
            this.MostrarProduto();
            this.Habilitar(false);
            this.Botoes();
            this.MostrarCategoria();
            this.BuscarNomeProduto();
            this.cboxCategoriaProduto.Text = null;

            this.btnHabilitarFichaTecnica.Enabled = false;
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigoProduto.Text = Convert.ToString(this.dgvProduto.CurrentRow.Cells["ID_Produto"].Value);
            this.cboxCategoriaProduto.Text = Convert.ToString(this.dgvProduto.CurrentRow.Cells["NM_Categoria"].Value);
            this.txtNomeProduto.Text = Convert.ToString(this.dgvProduto.CurrentRow.Cells["NM_Produto"].Value);
            this.txtPrecoProduto.Text = Convert.ToString(this.dgvProduto.CurrentRow.Cells["PR_Unitario"].Value);
            this.txtCustoProduto.Text = Convert.ToString(this.dgvProduto.CurrentRow.Cells["PR_Custo"].Value);
            this.txtDescricaoProduto.Text = Convert.ToString(this.dgvProduto.CurrentRow.Cells["DS_Produto"].Value);
            this.foto = Convert.ToString(this.dgvProduto.CurrentRow.Cells["IMG_Produto"].Value);
            byte[] imag;

            try
            {
                if (dgvProduto.CurrentRow.Cells["IMG_Produto"].Value != DBNull.Value)
                {
                    imag = (byte[])dgvProduto.CurrentRow.Cells["IMG_Produto"].Value;

                    MemoryStream ms = new MemoryStream(imag);

                    Image Imagem = Image.FromStream(ms);
                    this.pboxProduto.Image = Imagem;
                    this.pboxProduto.Visible = true;
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

            this.btnHabilitarFichaTecnica.Enabled = false;

            this.tctrlProduto.SelectedIndex = 1;
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProduto.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvProduto.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void txtBuscarProduto_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNomeProduto();
        }

        private void btnCarregarFotoProduto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "JPG Files (*.jpg) |*.jpg|GIF Files (*.gif) |*.gif|All Files (*.*) |*.*";
                od.Title = "Selecione a imagem a ser inserida";
                if (od.ShowDialog() == DialogResult.OK)
                {
                    foto = od.FileName.ToString();
                    pboxProduto.ImageLocation = foto;
                    string nome = od.FileName;
                    bmp = new Bitmap(nome);
                    pboxProduto.Image = bmp;
                    pboxProduto.Name = "IMAGEM";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluirFotoProduto_Click(object sender, EventArgs e)
        {
            this.foto = "";

            this.pboxProduto.Image = null;
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (this.txtNomeProduto.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para editar");
            }
            else
            {
                this.eNovo = false;
                this.eEditar = true;
                this.Botoes();
                this.Habilitar(true);
                this.btnHabilitarFichaTecnica.Enabled = true;
            }
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.Botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtNomeProduto.Focus();
            this.btnHabilitarFichaTecnica.Enabled = false;
        }

        private void chkDeletarProduto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarProduto.Checked)
            {
                this.dgvProduto.Columns[0].Visible = true;
            }
            else
            {
                this.dgvProduto.Columns[0].Visible = false;
            }
        }

        private void btnDeletarProduto_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvProduto.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há produtos selecionados para excluir");
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

                        foreach (DataGridViewRow row in dgvProduto.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                resp = myProduto.ExcluirProduto(Convert.ToInt32(Codigo));
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

                        this.MostrarProduto();
                        chkDeletarProduto.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Bmp);
                foto1 = memory.ToArray();
            }

            if (this.foto1 == null)
            {
                pboxProduto.Image = Properties.Resources.no_image;

                Image img2 = pboxProduto.Image;
                this.foto1 = ImageToByte(img2);
            }

            try
            {
                bool NomeProdutoOK = false;
                bool PrecoProdutoOK = false;
                bool CustoProdutoOK = false;
                bool CategoriaProdutoOK = false;
                bool DescricaoProdutoOK = false;
                bool FichaTecnicaOK = false;

                string resp = "";

                ValidarCampoNulo(txtNomeProduto);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNomeProduto, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        NomeProdutoOK = true;
                    }
                }

                ValidarCampoNulo(txtPrecoProduto);
                if (myValidar.CampoValido == true)
                {
                    ValidarValor(txtPrecoProduto);
                    if (myValidar.ValorValido == true)
                    {
                        PrecoProdutoOK = true;
                    }
                }

                ValidarCampoNulo(txtCustoProduto);
                if (myValidar.CampoValido == true)
                {
                    ValidarValor(txtCustoProduto);
                    if (myValidar.ValorValido == true)
                    {
                        CustoProdutoOK = true;
                    }
                }

                if (cboxCategoriaProduto.Text == string.Empty)
                {
                    errorIcone.SetError(cboxCategoriaProduto, "Selecione a categoria do produto");
                }
                else
                {
                    errorIcone.SetError(cboxCategoriaProduto, string.Empty);
                    CategoriaProdutoOK = true;
                }

                ValidarCampoNulo(txtDescricaoProduto);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtDescricaoProduto, 150);
                    if (myValidar.TamanhoValido == true)
                    {
                        DescricaoProdutoOK = true;
                    }
                }

                if (this.dgvFichaTecnicaProduto.Rows.Count == 0)
                {
                    if(this.btnHabilitarFichaTecnica.Enabled == true)
                    {
                        errorIcone.SetError(btnHabilitarFichaTecnica, "Por favor, insira os insumos que compõe \na ficha técnica do produto");
                    }
                    else
                    {
                        this.tctrlProduto.SelectedIndex = 2;
                        errorIcone.SetError(dgvFichaTecnicaProduto, "Por favor, insira os insumos que compõe \na ficha técnica do produto");
                    }                 
                }
                else
                {
                    errorIcone.SetError(dgvFichaTecnicaProduto, string.Empty);
                    FichaTecnicaOK = true;
                }

                bool PRODcadastrado = false;

                foreach (DataGridViewRow row in dgvProduto.Rows)
                {
                    if (txtCodigoProduto.Text != Convert.ToString(row.Cells["ID_Produto"].Value))
                    {
                        if (txtNomeProduto.Text == Convert.ToString(row.Cells["NM_Produto"].Value))
                        {
                            PRODcadastrado = true;
                        }
                    }
                }

                if (PRODcadastrado == true)
                {
                    MensagemErro("Produto já cadastrado na base de dados");
                }
                else
                {
                    if (NomeProdutoOK == false ||
                        PrecoProdutoOK == false ||
                        CustoProdutoOK == false ||
                        CategoriaProdutoOK == false ||
                        DescricaoProdutoOK == false ||
                        FichaTecnicaOK == false)
                    {
                        MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                    }
                    else
                    {
                        errorIcone.Clear();

                        if (this.eNovo)
                        {
                            resp = myProduto.InserirProduto(
                                Convert.ToInt32(this.cboxCategoriaProduto.SelectedValue.ToString()),
                                this.txtNomeProduto.Text.Trim(),
                                Convert.ToDouble(this.txtPrecoProduto.Text),
                                Convert.ToDouble(this.txtCustoProduto.Text),
                                this.txtDescricaoProduto.Text.Trim(),
                                this.foto1);
                        }
                        else
                        {
                            resp = myProduto.EditarProduto(
                                Convert.ToInt32(this.txtCodigoProduto.Text),
                                Convert.ToInt32(this.cboxCategoriaProduto.SelectedValue.ToString()),
                                this.txtNomeProduto.Text.Trim(),
                                Convert.ToDouble(this.txtPrecoProduto.Text),
                                Convert.ToDouble(this.txtCustoProduto.Text),
                                this.txtDescricaoProduto.Text.Trim(),
                                this.foto1
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

                            this.eNovo = false;
                            this.eEditar = false;
                            this.Botoes();
                            this.Habilitar(false);
                            this.MostrarProduto();
                            this.MostrarCategoria();

                            foreach (DataGridViewRow row in dgvProduto.Rows)
                            {
                                if (this.txtNomeProduto.Text == Convert.ToString(row.Cells["NM_Produto"].Value))
                                {
                                    txtCodigoProduto.Text = Convert.ToString(row.Cells["ID_Produto"].Value);
                                }
                            }

                            this.btnHabilitarFichaTecnica.Enabled = true;
                        }
                        else
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

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            this.eNovo = false;
            this.eEditar = false;
            this.Botoes();
            this.Habilitar(false);
            this.Limpar();

            this.HabilitarCamposFichaTecnica(false);
            this.LimparDadosInsumoProduto();
            this.LimparDadosFichaTecnica();

            this.dgvInsumoProduto.DataSource = "";
            this.dgvFichaTecnicaProduto.DataSource = "";

            this.btnHabilitarFichaTecnica.Enabled = false;
        }

        private void tctrlProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlProduto.SelectedIndex == 0)
            {
                this.eNovo = false;
                this.eEditar = false;
                this.Botoes();
                this.Habilitar(false);
                this.HabilitarCamposFichaTecnica(false);
                this.Limpar();
                this.LimparDadosInsumoProduto();
                this.LimparDadosFichaTecnica();

                this.dgvInsumoProduto.DataSource = "";
                this.dgvFichaTecnicaProduto.DataSource = "";

                this.btnHabilitarFichaTecnica.Enabled = false;
                this.tctrlProduto.TabPages.Remove(tpgFichaTecnica);
            }
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            this.BuscarNomeProduto();
        }

        private void btnHabilitarFichaTecnica_Click(object sender, EventArgs e)
        {
            this.tctrlProduto.TabPages.Add(tpgFichaTecnica);
            this.tctrlProduto.SelectedIndex = 2;
            this.btnHabilitarFichaTecnica.Enabled = false;

            this.HabilitarCamposFichaTecnica(true);
            this.MostrarInsumo();
            this.MostrarFichaTecnica(Convert.ToInt32(this.txtCodigoProduto.Text));
        }

        private void dgvInsumoProduto_DoubleClick(object sender, EventArgs e)
        {
            bool insumoInvalido = false;

            foreach (DataGridViewRow row in dgvFichaTecnicaProduto.Rows)
            {
                if (this.dgvInsumoProduto.CurrentRow.Cells["NM_Insumo"].Value.Equals(row.Cells["NM_Insumo"].Value))
                {
                    this.MensagemErro("Este insumo já foi adicionado na composição");
                    this.LimparDadosInsumoProduto();
                    insumoInvalido = true;
                }
            }
            if (insumoInvalido == false)
            {
                this.txtCodigoInsumoProduto.Text = Convert.ToString(this.dgvInsumoProduto.CurrentRow.Cells["ID_Insumo"].Value);
                this.txtNomeInsumoProduto.Text = Convert.ToString(this.dgvInsumoProduto.CurrentRow.Cells["NM_Insumo"].Value);
                this.txtArmazenamentoInsumoProduto.Text = Convert.ToString(this.dgvInsumoProduto.CurrentRow.Cells["DS_TipoArmazenamento"].Value);
                this.txtPrecoInsumoProduto.Text = (Convert.ToDouble(this.dgvInsumoProduto.CurrentRow.Cells["PR_Insumo"].Value)).ToString("N2");

                this.txtQuantidadeInsumoProduto.Enabled = true;
                this.btnAdicionarInsumoProduto.Enabled = true;
            }
        }

        private void btnAdicionarInsumoProduto_Click(object sender, EventArgs e)
        {
            bool QuantidadeInsumoProdutoOk = false;

            ValidarCampoNulo(txtQuantidadeInsumoProduto);
            if (myValidar.CampoValido == true)
            {
                ValidarValor(txtQuantidadeInsumoProduto);
                if (myValidar.ValorValido == true)
                {
                    if (Convert.ToDouble(txtQuantidadeInsumoProduto.Text) < 1)
                    {
                        errorIcone.SetError(txtQuantidadeInsumoProduto, "A quantidade não pode ser menor ou igual a 0 (zero)");
                    }
                    else
                    {
                        QuantidadeInsumoProdutoOk = true;
                    }
                }
            }

            if (QuantidadeInsumoProdutoOk == false)
            {
                MensagemErro("Por favor, preencha corretamente a quantidade a ser adicionada na composição");
            }
            else
            {
                errorIcone.Clear();
                this.eNovo = true;
                this.eEditar = false;

                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Deseja adicionar este insumo na composição?",
                        "PIZZA VINTAGE",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        this.InserirFichaTecnicaProduto();

                        this.LimparDadosInsumoProduto();
                        this.txtQuantidadeInsumoProduto.Enabled = false;
                        this.btnAdicionarInsumoProduto.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void txtBuscarNomeInsumoProduto_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNomeInsumoProduto();
        }

        private void btnAlterarInsumoProdutoFT_Click(object sender, EventArgs e)
        {
            bool QuantidadeInsumoProdutoOk = false;

            ValidarCampoNulo(txtQuantidadeInsumoProdutoFT);
            if (myValidar.CampoValido == true)
            {
                ValidarValor(txtQuantidadeInsumoProdutoFT);
                if (myValidar.ValorValido == true)
                {
                    if (Convert.ToDouble(txtQuantidadeInsumoProdutoFT.Text) < 1)
                    {
                        errorIcone.SetError(txtQuantidadeInsumoProdutoFT, "A quantidade não pode ser menor ou igual a 0 (zero)");
                    }
                    else
                    {
                        QuantidadeInsumoProdutoOk = true;
                    }
                }
            }

            if (QuantidadeInsumoProdutoOk == false)
            {
                MensagemErro("Por favor, preencha corretamente a quantidade a ser adicionada na composição");
            }
            else
            {
                errorIcone.Clear();
                this.eNovo = false;
                this.eEditar = true;

                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Deseja alterar este insumo na composição?",
                        "PIZZA VINTAGE",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        this.InserirFichaTecnicaProduto();

                        this.LimparDadosFichaTecnica();
                        this.txtQuantidadeInsumoProdutoFT.Enabled = false;
                        this.btnAlterarInsumoProdutoFT.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvFichaTecnicaProduto_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvFichaTecnicaProduto.Rows.Count == 0)
            {
                MensagemErro("Ainda não há insumos inseridos nessa ficha técnica");
            }
            else
            {
                this.txtCodigoInsumoProdutoFT.Text = Convert.ToString(this.dgvFichaTecnicaProduto.CurrentRow.Cells["ID_Insumo"].Value);
                this.txtNomeInsumoProdutoFT.Text = Convert.ToString(this.dgvFichaTecnicaProduto.CurrentRow.Cells["NM_Insumo"].Value);
                this.txtQuantidadeInsumoProdutoFT.Text = Convert.ToString(this.dgvFichaTecnicaProduto.CurrentRow.Cells["QTDE_Utilizada"].Value);

                this.txtQuantidadeInsumoProdutoFT.Enabled = true;
                this.btnAlterarInsumoProdutoFT.Enabled = true;
            }
        }

        private void dgvFichaTecnicaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFichaTecnicaProduto.Columns["DeletarFT"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvFichaTecnicaProduto.Rows[e.RowIndex].Cells["DeletarFT"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void chkDeletarFT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletarFT.Checked)
            {
                this.dgvFichaTecnicaProduto.Columns[0].Visible = true;
            }
            else
            {
                this.dgvFichaTecnicaProduto.Columns[0].Visible = false;
            }
        }

        private void btnDeletarInsumoFT_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvFichaTecnicaProduto.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há fichas técnicas selecionadas para excluir");
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
                        string Insumo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvFichaTecnicaProduto.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                Insumo = Convert.ToString(row.Cells[2].Value);
                                resp = myFichaTecnica.ExcluirFichaTecnica(Convert.ToInt32(Codigo), Convert.ToInt32(Insumo));
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

                        this.MostrarFichaTecnica(Convert.ToInt32(txtCodigoProduto.Text));
                        chkDeletarFT.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }
    }
}
