using Control;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class ViewMenu : Form
    {
        private IconButton iconBtn;
        private Panel pnlLeft;
        private Panel pnlLeftGerencia;
        private Form frmAtual;
        ControlLogin myLogin = new ControlLogin();

        private int _IDUnidade;
        private int _IDFuncionario;

        public int IDUnidade { get => _IDUnidade; set => _IDUnidade = value; }
        public int IDFuncionario { get => _IDFuncionario; set => _IDFuncionario = value; }

        private void ValidarBanco()
        {
            ViewVenda validarVenda = new ViewVenda();
            validarVenda.RetornoEstoqueVendaIncompleta();
            validarVenda.ValidarVenda();
        }

        public ViewMenu()
        {
            InitializeComponent();

            pnlLeft = new Panel();
            pnlLeftGerencia = new Panel();
            pnlLeft.Size = new Size(7, 45);
            pnlLeftGerencia.Size = new Size(7, 45);
            pnlMenuLateral.Controls.Add(pnlLeft);
            pnlGerencia.Controls.Add(pnlLeftGerencia);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(251, 68, 68); //VERMELHO CLARO
            public static Color color2 = Color.FromArgb(24, 161, 251); //AZUL
            public static Color color3 = Color.FromArgb(185, 0, 253); //ROXO
            public static Color color4 = Color.FromArgb(253, 253, 1); //AMARELO
            public static Color color5 = Color.FromArgb(30, 0, 255); //AZUL ESCURO
            public static Color color6 = Color.FromArgb(88, 242, 68); //VERDE CLARO
        }

        private void desativaBtn()
        {
            if (iconBtn != null)
            {
                iconBtn.BackColor = Color.FromArgb(26, 32, 40);
                iconBtn.ForeColor = Color.Gainsboro;
                iconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                iconBtn.IconColor = Color.Gainsboro;
                iconBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            }
        }

        private void ativaBtn(object senderBtn, Color color)
        {
            desativaBtn();

            iconBtn = (IconButton)senderBtn;
            iconBtn.BackColor = Color.FromArgb(37, 36, 81);
            iconBtn.ForeColor = color;
            iconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            iconBtn.IconColor = color;
            iconBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;

            pnlLeft.BackColor = color;
            pnlLeft.Location = new Point(0, iconBtn.Location.Y);
            pnlLeft.Visible = true;
            pnlLeft.BringToFront();
            iconeFrmFilho.IconChar = iconBtn.IconChar;
            iconeFrmFilho.IconColor = Color.Gainsboro;
        }

        private void ativaBtnGerencia(object senderBtn, Color color)
        {
            desativaBtn();

            iconBtn = (IconButton)senderBtn;
            iconBtn.BackColor = Color.FromArgb(37, 36, 81);
            iconBtn.ForeColor = color;
            iconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            iconBtn.IconColor = color;
            iconBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;

            pnlLeftGerencia.BackColor = color;
            pnlLeftGerencia.Location = new Point(0, iconBtn.Location.Y);
            pnlLeftGerencia.Visible = true;
            pnlLeftGerencia.BringToFront();
            iconeFrmFilho.IconChar = iconBtn.IconChar;
            iconeFrmFilho.IconColor = Color.Gainsboro;
        }

        private void abrirFormulario(Form frmFilho)
        {
            if (frmAtual != null)
            {
                frmAtual.Close();
            }

            frmAtual = frmFilho;
            frmFilho.TopLevel = false;
            frmFilho.FormBorderStyle = FormBorderStyle.None;
            frmFilho.Dock = DockStyle.Fill;
            pnlView.Controls.Add(frmFilho);
            pnlView.Tag = frmFilho;
            frmFilho.BringToFront();
            frmFilho.Show();
            lblTituloFrmFilho.Text = frmFilho.Text;
        }

        private void reiniciarFrm()
        {
            desativaBtn();
            pnlLeft.Visible = false;
            iconeFrmFilho.IconChar = IconChar.Home;
            iconeFrmFilho.IconColor = Color.Gainsboro;
            lblTituloFrmFilho.Text = "Início";
        }

        private void pboxMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pboxEncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.pnlView.Controls.Clear();

            this.pnlView.Controls.Add(lblHora);
            this.pnlView.Controls.Add(lblData);

            reiniciarFrm();
        }

        private void btnViewCliente_Click(object sender, EventArgs e)
        {
            this.pnlView.Controls.Clear();
            this.pnlLeftGerencia.Visible = false;

            ativaBtn(sender, RGBcolors.color2);
            abrirFormulario(new ViewCliente());

            if (pnlGerencia.Height >= 600)
            {
                pnlGerencia.Height = 45;
            }
        }

        private void btnViewVenda_Click(object sender, EventArgs e)
        {
            this.ValidarBanco();

            this.pnlView.Controls.Clear();
            this.pnlLeftGerencia.Visible = false;

            ativaBtn(sender, RGBcolors.color3);
            abrirFormulario(new ViewVenda(this.IDFuncionario, this.IDUnidade));

            if (pnlGerencia.Height >= 600)
            {
                pnlGerencia.Height = 45;
            }
        }

        private void btnGerencia_Click(object sender, EventArgs e)
        {

        }

        private void btnViewProduto_Click(object sender, EventArgs e)
        {
            this.pnlView.Controls.Clear();

            ativaBtnGerencia(sender, RGBcolors.color3);
            abrirFormulario(new ViewProduto());
        }

        private void btnViewCategoria_Click(object sender, EventArgs e)
        {
            this.pnlView.Controls.Clear();

            ativaBtnGerencia(sender, RGBcolors.color2);
            abrirFormulario(new ViewCategoria());
        }

        private void btnViewFuncionario_Click(object sender, EventArgs e)
        {
            this.pnlView.Controls.Clear();

            ativaBtnGerencia(sender, RGBcolors.color2);
            abrirFormulario(new ViewFuncionario(this.IDUnidade));
        }

        private void btnViewRelatorio_Click(object sender, EventArgs e)
        {
            this.pnlView.Controls.Clear();

            ativaBtnGerencia(sender, RGBcolors.color3);
            //abrirFormulario(new ViewRelatorio());
        }

        private void btnViewCompra_Click(object sender, EventArgs e)
        {
            this.pnlView.Controls.Clear();

            ativaBtnGerencia(sender, RGBcolors.color2);
            abrirFormulario(new ViewCompra(this.IDUnidade));
        }

        private void btnViewInsumo_Click(object sender, EventArgs e)
        {
            this.pnlView.Controls.Clear();

            ativaBtnGerencia(sender, RGBcolors.color3);
            abrirFormulario(new ViewInsumo(this.IDUnidade));
        }

        private void btnViewLogin_Click(object sender, EventArgs e)
        {
            this.pnlView.Controls.Clear();

            ativaBtnGerencia(sender, RGBcolors.color3);
            abrirFormulario(new ViewLogin(this.IDUnidade));
        }

        private void ViewMenu_Load(object sender, EventArgs e)
        {
            using (ViewLoginAcesso myLogin = new ViewLoginAcesso())
            {
                this.Visible = false;
                DialogResult = myLogin.ShowDialog();
                if (myLogin.DialogResult != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                else
                {
                    this.Visible = true;
                }
            }

            this.dgvRegistroLogin.DataSource = myLogin.MostrarRegistroLogin();

            for (int i = 0; i < this.dgvRegistroLogin.Rows.Count; i++)
            {
                if (Convert.ToString(this.dgvRegistroLogin.Rows[i].Cells["NM_Funcionario"].Value) != string.Empty)
                {
                    string NomeFuncionario = Convert.ToString(this.dgvRegistroLogin.Rows[i].Cells["NM_Funcionario"].Value);
                    string NivelAcesso = Convert.ToString(this.dgvRegistroLogin.Rows[i].Cells["DS_NivelAcesso"].Value);
                    string UnidadeRede = Convert.ToString(this.dgvRegistroLogin.Rows[i].Cells["DS_UnidadeRede"].Value);
                    this.IDUnidade = Convert.ToInt32(this.dgvRegistroLogin.Rows[i].Cells["ID_UnidadeRede"].Value);
                    this.IDFuncionario = Convert.ToInt32(this.dgvRegistroLogin.Rows[i].Cells["ID_Funcionario"].Value);

                    this.lblNomeFuncionario.Text = NomeFuncionario;
                    this.lblNivelAcesso.Text = NivelAcesso;
                    this.lblUnidadeRede.Text = UnidadeRede;
                }
            }

            if (this.lblNivelAcesso.Text != "Gerente")
            {
                this.pnlGerencia.Visible = false;
            }

            if (this.lblUnidadeRede.Text != "Matriz")
            {
                this.btnViewUnidadeRede.Visible = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show(
                "Realmente deseja fechar o programa ?",
                "PIZZA VINTAGE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Opcao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnViewUnidadeRede_Click(object sender, EventArgs e)
        {
            this.pnlView.Controls.Clear();

            ativaBtnGerencia(sender, RGBcolors.color2);
            abrirFormulario(new ViewUnidadeRede());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToString("dd : MMMM : yyyy");
        }

        private void btnGerencia_MouseHover(object sender, EventArgs e)
        {
            this.ValidarBanco();

            this.pnlView.Controls.Clear();
            this.pnlLeft.Visible = false;

            if (pnlGerencia.Height < 600)
            {
                ativaBtnGerencia(sender, RGBcolors.color2);
                this.lblTituloFrmFilho.Text = btnGerencia.Text;
                pnlGerencia.Height = 600;
            }
            else
            {
                pnlGerencia.Height = 45;
            }
        }
    }
}
