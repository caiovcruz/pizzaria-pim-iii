using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelCompra
    {
        private int _IDUnidadeRede;
        private int _IDCompra;
        private int _IDInsumo;
        private DateTime _DataCompra;
        private double _QuantidadeInsumoCompra;
        private DateTime _DataBuscar;

        public int IDUnidadeRede { get => _IDUnidadeRede; set => _IDUnidadeRede = value; }
        public int IDCompra { get => _IDCompra; set => _IDCompra = value; }
        public int IDInsumo { get => _IDInsumo; set => _IDInsumo = value; }
        public DateTime DataCompra { get => _DataCompra; set => _DataCompra = value; }
        public double QuantidadeInsumoCompra { get => _QuantidadeInsumoCompra; set => _QuantidadeInsumoCompra = value; }
        public DateTime DataBuscar { get => _DataBuscar; set => _DataBuscar = value; }

        public ModelCompra()
        {

        }

        public ModelCompra(int id_unidaderede, int id_compra, int id_insumo, DateTime dt_compra, double qtde_insumocompra, DateTime databuscar)
        {
            this.IDUnidadeRede = id_unidaderede;
            this.IDCompra = id_compra;
            this.IDInsumo = id_insumo;
            this.DataCompra = dt_compra;
            this.QuantidadeInsumoCompra = qtde_insumocompra;
            this.DataBuscar = databuscar;

        }

        // Método inserir
        public string InserirCompra(ModelCompra Compra)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_compra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDCompra = new SqlParameter();
                ParIDCompra.ParameterName = "@ID_Compra";
                ParIDCompra.SqlDbType = SqlDbType.Int;
                ParIDCompra.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDCompra);

                SqlParameter ParIDInsumo = new SqlParameter();
                ParIDInsumo.ParameterName = "@ID_Insumo";
                ParIDInsumo.SqlDbType = SqlDbType.Int;
                ParIDInsumo.Value = Compra.IDInsumo;
                SqlCmd.Parameters.Add(ParIDInsumo);

                SqlParameter ParQuantidadeInsumoCompra = new SqlParameter();
                ParQuantidadeInsumoCompra.ParameterName = "@QTDE_InsumoCompra";
                ParQuantidadeInsumoCompra.SqlDbType = SqlDbType.Decimal;
                ParQuantidadeInsumoCompra.Value = Compra.QuantidadeInsumoCompra;
                SqlCmd.Parameters.Add(ParQuantidadeInsumoCompra);

                SqlParameter ParDataCompra = new SqlParameter();
                ParDataCompra.ParameterName = "@DT_Compra";
                ParDataCompra.SqlDbType = SqlDbType.Date;
                ParDataCompra.Value = Compra.DataCompra;
                SqlCmd.Parameters.Add(ParDataCompra);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Compra.IDUnidadeRede;
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

        // Método excluir
        public string ExcluirCompra(ModelCompra Compra)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_compra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDCompra = new SqlParameter();
                ParIDCompra.ParameterName = "@ID_Compra";
                ParIDCompra.SqlDbType = SqlDbType.Int;
                ParIDCompra.Value = Compra.IDCompra;
                SqlCmd.Parameters.Add(ParIDCompra);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Compra.IDUnidadeRede;
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
        public DataTable MostrarCompra(ModelCompra Compra)
        {
            DataTable DtResultado = new DataTable("TB_Compra");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_compra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Compra.IDUnidadeRede;
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

        // Método buscar compra por data
        public DataTable BuscarDataCompra(ModelCompra Compra)
        {
            DataTable DtResultado = new DataTable("TB_Compra");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_data_compra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDataBuscar = new SqlParameter();
                ParDataBuscar.ParameterName = "@DataBuscar";
                ParDataBuscar.SqlDbType = SqlDbType.Date;
                ParDataBuscar.Value = Compra.DataBuscar;
                SqlCmd.Parameters.Add(ParDataBuscar);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Compra.IDUnidadeRede;
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
    }
}
