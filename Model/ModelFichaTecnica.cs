using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelFichaTecnica
    {
        private int _IDProduto;
        private int _IDInsumo;
        private double _QuantidadeUtilizada;
        private int _IDBusca;

        public int IDProduto { get => _IDProduto; set => _IDProduto = value; }
        public int IDInsumo { get => _IDInsumo; set => _IDInsumo = value; }
        public double QuantidadeUtilizada { get => _QuantidadeUtilizada; set => _QuantidadeUtilizada = value; }
        public int IDBusca { get => _IDBusca; set => _IDBusca = value; }

        public ModelFichaTecnica()
        {

        }

        public ModelFichaTecnica(int id_produto, int id_insumo, double qtde_utilizada, int id_busca)
        {
            this.IDProduto = id_produto;
            this.IDInsumo = id_insumo;
            this.QuantidadeUtilizada = qtde_utilizada;
            this.IDBusca = id_busca;
        }

        public string InserirFichaTecnica(ModelFichaTecnica FichaTecnica)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_ficha_tecnica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDProduto = new SqlParameter();
                ParIDProduto.ParameterName = "@ID_Produto";
                ParIDProduto.SqlDbType = SqlDbType.Int;
                ParIDProduto.Value = FichaTecnica.IDProduto;
                SqlCmd.Parameters.Add(ParIDProduto);

                SqlParameter ParIDInsumo = new SqlParameter();
                ParIDInsumo.ParameterName = "@ID_Insumo";
                ParIDInsumo.SqlDbType = SqlDbType.Int;
                ParIDInsumo.Value = FichaTecnica.IDInsumo;
                SqlCmd.Parameters.Add(ParIDInsumo);

                SqlParameter ParQTDEUtilizada = new SqlParameter();
                ParQTDEUtilizada.ParameterName = "@QTDE_Utilizada";
                ParQTDEUtilizada.SqlDbType = SqlDbType.Decimal;
                ParQTDEUtilizada.Value = FichaTecnica.QuantidadeUtilizada;
                SqlCmd.Parameters.Add(ParQTDEUtilizada);

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

        public string EditarFichaTecnica(ModelFichaTecnica FichaTecnica)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_ficha_tecnica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDProduto = new SqlParameter();
                ParIDProduto.ParameterName = "@ID_Produto";
                ParIDProduto.SqlDbType = SqlDbType.Int;
                ParIDProduto.Value = FichaTecnica.IDProduto;
                SqlCmd.Parameters.Add(ParIDProduto);

                SqlParameter ParIDInsumo = new SqlParameter();
                ParIDInsumo.ParameterName = "@ID_Insumo";
                ParIDInsumo.SqlDbType = SqlDbType.Int;
                ParIDInsumo.Value = FichaTecnica.IDInsumo;
                SqlCmd.Parameters.Add(ParIDInsumo);

                SqlParameter ParQTDEUtilizada = new SqlParameter();
                ParQTDEUtilizada.ParameterName = "@QTDE_Utilizada";
                ParQTDEUtilizada.SqlDbType = SqlDbType.Decimal;
                ParQTDEUtilizada.Value = FichaTecnica.QuantidadeUtilizada;
                SqlCmd.Parameters.Add(ParQTDEUtilizada);

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

        public string ExcluirFichaTecnica(ModelFichaTecnica FichaTecnica)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_ficha_tecnica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDProduto = new SqlParameter();
                ParIDProduto.ParameterName = "@ID_Produto";
                ParIDProduto.SqlDbType = SqlDbType.Int;
                ParIDProduto.Value = FichaTecnica.IDProduto;
                SqlCmd.Parameters.Add(ParIDProduto);

                SqlParameter ParIDInsumo = new SqlParameter();
                ParIDInsumo.ParameterName = "@ID_Insumo";
                ParIDInsumo.SqlDbType = SqlDbType.Int;
                ParIDInsumo.Value = FichaTecnica.IDInsumo;
                SqlCmd.Parameters.Add(ParIDInsumo);

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

        public DataTable MostrarFichaTecnica(ModelFichaTecnica FichaTecnica)
        {
            DataTable DtResultado = new DataTable("TB_FichaTecnica");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_ficha_tecnica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDBusca = new SqlParameter();
                ParIDBusca.ParameterName = "@ID_Produto";
                ParIDBusca.SqlDbType = SqlDbType.Int;
                ParIDBusca.Value = FichaTecnica.IDBusca;
                SqlCmd.Parameters.Add(ParIDBusca);

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
