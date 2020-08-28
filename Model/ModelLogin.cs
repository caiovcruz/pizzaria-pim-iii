using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelLogin
    {
        private int _IDUnidadeRede;
        private int _IDLogin;
        private int _IDFuncionario;
        private int _IDNivelAcesso;
        private string _Usuario;
        private string _Senha;
        private string _TextoBuscar;

        public int IDUnidadeRede { get => _IDUnidadeRede; set => _IDUnidadeRede = value; }
        public int IDLogin { get => _IDLogin; set => _IDLogin = value; }
        public int IDFuncionario { get => _IDFuncionario; set => _IDFuncionario = value; }
        public int IDNivelAcesso { get => _IDNivelAcesso; set => _IDNivelAcesso = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Senha { get => _Senha; set => _Senha = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelLogin()
        {

        }

        public ModelLogin(int id_login, int id_funcionario, int id_nivelacesso, string usuario, string senha)
        {
            this.IDLogin = id_login;
            this.IDFuncionario = id_funcionario;
            this.IDNivelAcesso = id_nivelacesso;
            this.Usuario = usuario;
            this.Senha = senha;
        }

        public string InserirLogin(ModelLogin Login)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDLogin = new SqlParameter();
                ParIDLogin.ParameterName = "@ID_Login";
                ParIDLogin.SqlDbType = SqlDbType.Int;
                ParIDLogin.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDLogin);

                SqlParameter ParIDFuncionario = new SqlParameter();
                ParIDFuncionario.ParameterName = "@ID_Funcionario";
                ParIDFuncionario.SqlDbType = SqlDbType.Int;
                ParIDFuncionario.Value = Login.IDFuncionario;
                SqlCmd.Parameters.Add(ParIDFuncionario);

                SqlParameter ParIDNivelAcesso = new SqlParameter();
                ParIDNivelAcesso.ParameterName = "@ID_NivelAcesso";
                ParIDNivelAcesso.SqlDbType = SqlDbType.Int;
                ParIDNivelAcesso.Value = Login.IDNivelAcesso;
                SqlCmd.Parameters.Add(ParIDNivelAcesso);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Login.IDUnidadeRede;
                SqlCmd.Parameters.Add(ParIDUnidadeRede);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@DS_Usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Login.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@DS_Senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 20;
                ParSenha.Value = Login.Senha;
                SqlCmd.Parameters.Add(ParSenha);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "O registro não foi inserido";

                SqlCmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return resp;
        }

        public string EditarLogin(ModelLogin Login)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDLogin = new SqlParameter();
                ParIDLogin.ParameterName = "@ID_Login";
                ParIDLogin.SqlDbType = SqlDbType.Int;
                ParIDLogin.Value = Login.IDLogin;
                SqlCmd.Parameters.Add(ParIDLogin);

                SqlParameter ParIDNivelAcesso = new SqlParameter();
                ParIDNivelAcesso.ParameterName = "@ID_NivelAcesso";
                ParIDNivelAcesso.SqlDbType = SqlDbType.Int;
                ParIDNivelAcesso.Value = Login.IDNivelAcesso;
                SqlCmd.Parameters.Add(ParIDNivelAcesso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@DS_Usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Login.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@DS_Senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 20;
                ParSenha.Value = Login.Senha;
                SqlCmd.Parameters.Add(ParSenha);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A edição não foi realizada";

                SqlCmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return resp;
        }

        public string ExcluirLogin(ModelLogin Login)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDLogin = new SqlParameter();
                ParIDLogin.ParameterName = "@ID_Login";
                ParIDLogin.SqlDbType = SqlDbType.Int;
                ParIDLogin.Value = Login.IDLogin;
                SqlCmd.Parameters.Add(ParIDLogin);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão não foi realizada";

                SqlCmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return resp;
        }

        public DataTable MostrarLogin(ModelLogin Login)
        {
            DataTable DtResultado = new DataTable("TB_Login");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Login.IDUnidadeRede;
                SqlCmd.Parameters.Add(ParIDUnidadeRede);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                SqlCmd.Parameters.Clear();
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public DataTable BuscarNomeFuncionarioLogin(ModelLogin Login)
        {
            DataTable DtResultado = new DataTable("TB_Login");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nome_funcionario_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Login.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Login.IDUnidadeRede;
                SqlCmd.Parameters.Add(ParIDUnidadeRede);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                SqlCmd.Parameters.Clear();
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public string InserirRegistroLogin(ModelLogin Login)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_registro_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDLogin = new SqlParameter();
                ParIDLogin.ParameterName = "@ID_Login";
                ParIDLogin.SqlDbType = SqlDbType.Int;
                ParIDLogin.Value = Login.IDLogin;
                SqlCmd.Parameters.Add(ParIDLogin);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "O registro não foi inserido";

                SqlCmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return resp;
        }

        public string EditarRegistroLogin(ModelLogin Login)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_registro_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdLogin = new SqlParameter();
                ParIdLogin.ParameterName = "@ID_Login";
                ParIdLogin.SqlDbType = SqlDbType.Int;
                ParIdLogin.Value = Login.IDLogin;
                SqlCmd.Parameters.Add(ParIdLogin);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A edição não foi realizada";

                SqlCmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return resp;
        }

        public DataTable MostrarRegistroLogin(ModelLogin Login)
        {
            DataTable DtResultado = new DataTable("TB_RegistroLogin");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_registro_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                SqlCmd.Parameters.Clear();
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public bool ValidaLogin(ModelLogin Login)
        {
            SqlConnection SqlCon = new SqlConnection();

            SqlCon.ConnectionString = ModelConexao.Conexao;
            SqlCon.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "spvalidar_login";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ParID = new SqlParameter();
            ParID.ParameterName = "@ID_UnidadeRede";
            ParID.SqlDbType = SqlDbType.Int;
            ParID.Value = Login.IDUnidadeRede;
            SqlCmd.Parameters.Add(ParID);

            SqlParameter PArUsuario = new SqlParameter();
            PArUsuario.ParameterName = "@DS_Usuario";
            PArUsuario.SqlDbType = SqlDbType.VarChar;
            PArUsuario.Size = 20;
            PArUsuario.Value = Login.Usuario;
            SqlCmd.Parameters.Add(PArUsuario);

            SqlParameter ParSenha = new SqlParameter();
            ParSenha.ParameterName = "@DS_Senha";
            ParSenha.SqlDbType = SqlDbType.VarChar;
            ParSenha.Size = 20;
            ParSenha.Value = Login.Senha;
            SqlCmd.Parameters.Add(ParSenha);

            SqlDataReader reader = SqlCmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
