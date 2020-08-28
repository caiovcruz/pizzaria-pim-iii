using Control;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace View
{
    public partial class ViewLoginAcesso : Form
    {
        ControlUnidadeRede myUnidadeRede = new ControlUnidadeRede();
        ControlLogin myLogin = new ControlLogin();
        Validar myValidar = new Validar();

        private int _IDLogin;

        public int IDLogin { get => _IDLogin; set => _IDLogin = value; }

        public ViewLoginAcesso()
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


        public int GetIDLogin(int id_unidade, string ds_usuario, string ds_senha)
        {
            this.dgvLogin.DataSource = myLogin.MostrarLogin(id_unidade);

            int idLogin = 0;

            for (int i = 0; i < dgvLogin.Rows.Count; i++)
            {
                if (ds_usuario == Convert.ToString(dgvLogin.Rows[i].Cells["DS_Usuario"].Value) &&
                  ds_senha == Convert.ToString(dgvLogin.Rows[i].Cells["DS_Senha"].Value))
                {
                    idLogin = Convert.ToInt32(dgvLogin.Rows[i].Cells["ID_Login"].Value);
                    break;
                }
            }

            return idLogin;
        }

        public void LoginRegistrado(int id_login)
        {
            this.dgvRegistroLogin.DataSource = myLogin.MostrarRegistroLogin();

            for (int i = 0; i < dgvLogin.Rows.Count; i++)
            {
                if (id_login == Convert.ToInt32(dgvLogin.Rows[i].Cells["ID_Login"].Value))
                {
                    myLogin.EditarRegistroLogin(GetIDLogin(Convert.ToInt32(cboxUnidadeRede.SelectedValue),
                                                             this.txtUsuario.Text,
                                                             this.txtSenha.Text));
                    i++;
                }
                if (id_login != Convert.ToInt32(dgvLogin.Rows[i].Cells["ID_Login"].Value))
                {
                    myLogin.InserirRegistroLogin(GetIDLogin(Convert.ToInt32(cboxUnidadeRede.SelectedValue),
                                                               this.txtUsuario.Text,
                                                               this.txtSenha.Text));

                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void ArredondaCantosForm()
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }

        private void ValidarUsuario(TextBox campo)
        {
            string campovalido = Convert.ToString(campo.Text);
            myValidar.UsuarioVazio(campovalido);

            if (myValidar.UsuarioValido == false)
            {
                errorIcone.SetError(campo, "Este campo é obrigatório");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }

        }
        private void ValidarSenha(TextBox campo)
        {
            string campovalido = Convert.ToString(campo.Text);
            myValidar.SenhaVazia(campovalido);

            if (myValidar.SenhaValida == false)
            {
                errorIcone.SetError(campo, "Este campo é obrigatório");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void MostrarUnidadeRede()
        {
            this.cboxUnidadeRede.DataSource = myUnidadeRede.MostrarUnidadeRede();
            this.cboxUnidadeRede.DisplayMember = "DS_UnidadeRede";
            this.cboxUnidadeRede.ValueMember = "ID_UnidadeRede";
        }

        private void ViewLoginAcesso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUÁRIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUÁRIO";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.White;
                txtSenha.UseSystemPasswordChar = true;
            }
            if (txtSenha.UseSystemPasswordChar == true)
            {
                this.btnVisualizaPassoword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.White;
                txtSenha.UseSystemPasswordChar = false;
            }
            if (txtSenha.UseSystemPasswordChar == false)
            {
                this.btnVisualizaPassoword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }

        private void btnVisualizaPassoword_Click_1(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                this.btnVisualizaPassoword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                this.btnVisualizaPassoword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void panelLateral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ViewLoginAcesso_Load(object sender, EventArgs e)
        {
            this.ArredondaCantosForm();
            this.MostrarUnidadeRede();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool LoginOK = false;
                bool UnidadeRedeOK = false;
                bool UsuarioLoginOK = false;
                bool SenhaLoginOK = false;

                if (cboxUnidadeRede.Text == null)
                {
                    errorIcone.SetError(cboxUnidadeRede, "Selecione o unidade");
                }
                else
                {
                    errorIcone.SetError(cboxUnidadeRede, string.Empty);
                    UnidadeRedeOK = true;
                }

                ValidarUsuario(txtUsuario);
                if (myValidar.UsuarioValido == true)
                {
                    UsuarioLoginOK = true;
                }

                ValidarSenha(txtSenha);
                if (myValidar.SenhaValida == true)
                {
                    SenhaLoginOK = true;
                }

                if (UnidadeRedeOK == false ||
                UsuarioLoginOK == false ||
                SenhaLoginOK == false)
                {
                    MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                }
                else
                {
                    errorIcone.Clear();

                    LoginOK = myLogin.ValidaLogin(Convert.ToInt32(cboxUnidadeRede.SelectedValue),
                                                   this.txtUsuario.Text,
                                                   this.txtSenha.Text);

                    if (LoginOK == true)

                    {
                        MensagemOk("Login efetuado com sucesso");

                        LoginRegistrado(GetIDLogin(Convert.ToInt32(cboxUnidadeRede.SelectedValue),
                                                                    this.txtUsuario.Text,
                                                                    this.txtSenha.Text));

                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.MensagemErro("Login inválido, por favor, verifique os dados e tente novamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
