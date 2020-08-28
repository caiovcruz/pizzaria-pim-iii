using Model;
using System.Data;

namespace Control
{
    public class ControlLogin
    {
        ModelLogin myLogin = new ModelLogin();

        // Metodo inserir
        public string InserirLogin(int id_funcionario, int id_nivelacesso, int id_unidaderede, string usuario, string senha)
        {
            myLogin.IDFuncionario = id_funcionario;
            myLogin.IDNivelAcesso = id_nivelacesso;
            myLogin.IDUnidadeRede = id_unidaderede;
            myLogin.Usuario = usuario;
            myLogin.Senha = senha;

            return myLogin.InserirLogin(myLogin);
        }

        // Metodo Editar
        public string EditarLogin(int id_login, int id_nivelacesso, string usuario, string senha)
        {
            myLogin.IDLogin = id_login;
            myLogin.IDNivelAcesso = id_nivelacesso;
            myLogin.Usuario = usuario;
            myLogin.Senha = senha;

            return myLogin.EditarLogin(myLogin);
        }

        // Metodo Deletar
        public string ExcluirLogin(int id_login)
        {
            myLogin.IDLogin = id_login;

            return myLogin.ExcluirLogin(myLogin);
        }

        // Metodo Mostrar
        public DataTable MostrarLogin(int id_unidaderede)
        {
            myLogin.IDUnidadeRede = id_unidaderede;

            return myLogin.MostrarLogin(myLogin);
        }

        // Metodo buscar nome funcionario login
        public DataTable BuscarNomeFuncionarioLogin(string Textobuscar, int id_unidaderede)
        {
            myLogin.TextoBuscar = Textobuscar;
            myLogin.IDUnidadeRede = id_unidaderede;

            return myLogin.BuscarNomeFuncionarioLogin(myLogin);
        }

        public string InserirRegistroLogin(int id_login)
        {
            myLogin.IDLogin = id_login;

            return myLogin.InserirRegistroLogin(myLogin);
        }

        public DataTable MostrarRegistroLogin()
        {
            return myLogin.MostrarRegistroLogin(myLogin);
        }

        public bool ValidaLogin(int id_unidadeRede, string ds_usuario, string ds_senha)
        {
            myLogin.IDUnidadeRede = id_unidadeRede;
            myLogin.Usuario = ds_usuario;
            myLogin.Senha = ds_senha;
            return myLogin.ValidaLogin(myLogin);
        }

        public string EditarRegistroLogin(int id_login)
        {
            myLogin.IDLogin = id_login;

            return myLogin.EditarRegistroLogin(myLogin);
        }
    }
}
