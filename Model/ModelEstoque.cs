using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelEstoque
    {
        private int _IDUnidadeRede;
        private int _IDInsumo;
        private double _QuantidadeEstoque;
        private string _TextoBuscar;

        public int IDUnidadeRede { get => _IDUnidadeRede; set => _IDUnidadeRede = value; }
        public int IDInsumo { get => _IDInsumo; set => _IDInsumo = value; }
        public double QuantidadeEstoque { get => _QuantidadeEstoque; set => _QuantidadeEstoque = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelEstoque()
        {

        }

        public ModelEstoque(int id_unidaderede, int id_insumo, double qtde_estoque)
        {
            this.IDUnidadeRede = id_unidaderede;
            this.IDInsumo = id_insumo;
            this.QuantidadeEstoque = qtde_estoque;
        }

        // Método inserir
        public string InserirEstoque(ModelEstoque Estoque)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_estoque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDInsumo = new SqlParameter();
                ParIDInsumo.ParameterName = "@ID_Insumo";
                ParIDInsumo.SqlDbType = SqlDbType.Int;
                ParIDInsumo.Value = Estoque.IDInsumo;
                SqlCmd.Parameters.Add(ParIDInsumo);

                SqlParameter ParQTDEEstoque = new SqlParameter();
                ParQTDEEstoque.ParameterName = "@QTDE_Estoque";
                ParQTDEEstoque.SqlDbType = SqlDbType.Decimal;
                ParQTDEEstoque.Value = Estoque.QuantidadeEstoque;
                SqlCmd.Parameters.Add(ParQTDEEstoque);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Estoque.IDUnidadeRede;
                SqlCmd.Parameters.Add(ParIDUnidadeRede);

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

        public string EditarEstoque(ModelEstoque Estoque)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_estoque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDInsumo = new SqlParameter();
                ParIDInsumo.ParameterName = "@ID_Insumo";
                ParIDInsumo.SqlDbType = SqlDbType.Int;
                ParIDInsumo.Value = Estoque.IDInsumo;
                SqlCmd.Parameters.Add(ParIDInsumo);

                SqlParameter ParQTDEEstoque = new SqlParameter();
                ParQTDEEstoque.ParameterName = "@QTDE_Estoque";
                ParQTDEEstoque.SqlDbType = SqlDbType.Decimal;
                ParQTDEEstoque.Value = Estoque.QuantidadeEstoque;
                SqlCmd.Parameters.Add(ParQTDEEstoque);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Estoque.IDUnidadeRede;
                SqlCmd.Parameters.Add(ParIDUnidadeRede);

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

        public string BaixaEstoque(ModelEstoque Estoque)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbaixa_estoque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDInsumo = new SqlParameter();
                ParIDInsumo.ParameterName = "@ID_Insumo";
                ParIDInsumo.SqlDbType = SqlDbType.Int;
                ParIDInsumo.Value = Estoque.IDInsumo;
                SqlCmd.Parameters.Add(ParIDInsumo);

                SqlParameter ParQTDEEstoque = new SqlParameter();
                ParQTDEEstoque.ParameterName = "@QTDE_Estoque";
                ParQTDEEstoque.SqlDbType = SqlDbType.Decimal;
                ParQTDEEstoque.Value = Estoque.QuantidadeEstoque;
                SqlCmd.Parameters.Add(ParQTDEEstoque);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Estoque.IDUnidadeRede;
                SqlCmd.Parameters.Add(ParIDUnidadeRede);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A baixa não foi realizada";

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
        public string ExcluirEstoque(ModelEstoque Estoque)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_estoque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDInsumo = new SqlParameter();
                ParIDInsumo.ParameterName = "@ID_Insumo";
                ParIDInsumo.SqlDbType = SqlDbType.Int;
                ParIDInsumo.Value = Estoque.IDInsumo;
                SqlCmd.Parameters.Add(ParIDInsumo);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Estoque.IDUnidadeRede;
                SqlCmd.Parameters.Add(ParIDUnidadeRede);

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
        public DataTable MostrarEstoque(ModelEstoque Estoque)
        {
            DataTable DtResultado = new DataTable("TB_Estoque");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_estoque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Estoque.IDUnidadeRede;
                SqlCmd.Parameters.Add(ParIDUnidadeRede);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public DataTable BuscarNomeInsumoEstoque(ModelEstoque Estoque)
        {
            DataTable DtResultado = new DataTable("TB_Estoque");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_insumo_estoque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Estoque.IDUnidadeRede;
                SqlCmd.Parameters.Add(ParIDUnidadeRede);

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Estoque.TextoBuscar;
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
