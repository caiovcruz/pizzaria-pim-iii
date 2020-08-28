using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelInsumo
    {
        private int _IDInsumo;
        private string _Nome;
        private string _TipoArmazenamento;
        private double _Preco;
        private string _TextoBuscar;

        public int IDInsumo { get => _IDInsumo; set => _IDInsumo = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string TipoArmazenamento { get => _TipoArmazenamento; set => _TipoArmazenamento = value; }
        public double Preco { get => _Preco; set => _Preco = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelInsumo()
        {

        }

        public ModelInsumo(int id, string nome, string armazenamento, double preco, string textobuscar)
        {
            this.IDInsumo = id;
            this.Nome = nome;
            this.TipoArmazenamento = armazenamento;
            this.Preco = preco;
            this.TextoBuscar = textobuscar;
        }

        // Método inserir
        public string InserirInsumo(ModelInsumo Insumo)
        {
            string resp = "";

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDInsumo = new SqlParameter();
                ParIDInsumo.ParameterName = "@ID_Insumo";
                ParIDInsumo.SqlDbType = SqlDbType.Int;
                ParIDInsumo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDInsumo);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@NM_Insumo";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Insumo.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParArmazenamento = new SqlParameter();
                ParArmazenamento.ParameterName = "@DS_TipoArmazenamento";
                ParArmazenamento.SqlDbType = SqlDbType.VarChar;
                ParArmazenamento.Size = 50;
                ParArmazenamento.Value = Insumo.TipoArmazenamento;
                SqlCmd.Parameters.Add(ParArmazenamento);

                SqlParameter ParPreco = new SqlParameter();
                ParPreco.ParameterName = "@PR_Insumo";
                ParPreco.SqlDbType = SqlDbType.Decimal;
                ParPreco.Value = Insumo.Preco;
                SqlCmd.Parameters.Add(ParPreco);

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

        // Método editar
        public string EditarInsumo(ModelInsumo Insumo)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID_Insumo";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = Insumo.IDInsumo;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@NM_Insumo";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Insumo.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParArmazenamento = new SqlParameter();
                ParArmazenamento.ParameterName = "@DS_TipoArmazenamento";
                ParArmazenamento.SqlDbType = SqlDbType.VarChar;
                ParArmazenamento.Size = 50;
                ParArmazenamento.Value = Insumo.TipoArmazenamento;
                SqlCmd.Parameters.Add(ParArmazenamento);

                SqlParameter ParPreco = new SqlParameter();
                ParPreco.ParameterName = "@PR_Insumo";
                ParPreco.SqlDbType = SqlDbType.Decimal;
                ParPreco.Value = Insumo.Preco;
                SqlCmd.Parameters.Add(ParPreco);

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

        // Método excluir
        public string ExcluirInsumo(ModelInsumo Insumo)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@ID_Insumo";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Insumo.IDInsumo;
                SqlCmd.Parameters.Add(ParIdcategoria);

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

        // Método mostrar
        public DataTable MostrarInsumo()
        {
            DataTable DtResultado = new DataTable("TB_Insumo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        // Método buscar insumo por nome
        public DataTable BuscarNomeInsumo(ModelInsumo Insumo)
        {
            DataTable DtResultado = new DataTable("TB_Insumo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Insumo.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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
    }
}
