using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelVenda
    {
        private int _IDUnidadeRede;
        private int _IDVenda;
        private int _IDFuncionario;
        private int _IDCliente;
        private DateTime _DataVenda;
        private string _ObservacaoVenda;
        private string _TipoPagamento;
        private double _ValorTaxaEntrega;
        private double _ValorTotal;
        private DateTime _DataBuscar;

        public int IDUnidadeRede { get => _IDUnidadeRede; set => _IDUnidadeRede = value; }
        public int IDVenda { get => _IDVenda; set => _IDVenda = value; }
        public int IDFuncionario { get => _IDFuncionario; set => _IDFuncionario = value; }
        public int IDCliente { get => _IDCliente; set => _IDCliente = value; }
        public DateTime DataVenda { get => _DataVenda; set => _DataVenda = value; }
        public string ObservacaoVenda { get => _ObservacaoVenda; set => _ObservacaoVenda = value; }
        public string TipoPagamento { get => _TipoPagamento; set => _TipoPagamento = value; }
        public double ValorTaxaEntrega { get => _ValorTaxaEntrega; set => _ValorTaxaEntrega = value; }
        public double ValorTotal { get => _ValorTotal; set => _ValorTotal = value; }
        public DateTime DataBuscar { get => _DataBuscar; set => _DataBuscar = value; }

        public ModelVenda()
        {

        }

        public ModelVenda(
            int id_unidaderede,
            int id_venda, 
            int id_cliente, 
            int id_funcionario, 
            string obs_venda, 
            DateTime dt_venda, 
            double vl_taxaentrega, 
            double vl_total, 
            DateTime textobuscar)
        {
            this.IDUnidadeRede = id_unidaderede;
            this.IDVenda = id_venda;
            this.IDCliente = id_cliente;
            this.IDFuncionario = id_funcionario;
            this.ObservacaoVenda = obs_venda;
            this.DataVenda = dt_venda;
            this.ValorTaxaEntrega = vl_taxaentrega;
            this.ValorTotal = vl_total;
            this.DataBuscar = textobuscar;
        }


        // Método inserir
        public string InserirVenda(ModelVenda Venda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDVenda = new SqlParameter();
                ParIDVenda.ParameterName = "@ID_Venda";
                ParIDVenda.SqlDbType = SqlDbType.Int;
                ParIDVenda.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDVenda);

                SqlParameter ParIDFuncionario = new SqlParameter();
                ParIDFuncionario.ParameterName = "@ID_Funcionario";
                ParIDFuncionario.SqlDbType = SqlDbType.Int;
                ParIDFuncionario.Value = Venda.IDFuncionario;
                SqlCmd.Parameters.Add(ParIDFuncionario);

                SqlParameter ParIDCliente = new SqlParameter();
                ParIDCliente.ParameterName = "@ID_Cliente";
                ParIDCliente.SqlDbType = SqlDbType.Int;
                ParIDCliente.Value = Venda.IDCliente;
                SqlCmd.Parameters.Add(ParIDCliente);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Venda.IDUnidadeRede;
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


        // Método editar
        public string EditarVenda(ModelVenda Venda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDFuncionario = new SqlParameter();
                ParIDFuncionario.ParameterName = "@ID_Funcionario";
                ParIDFuncionario.SqlDbType = SqlDbType.Int;
                ParIDFuncionario.Value = Venda.IDFuncionario;
                SqlCmd.Parameters.Add(ParIDFuncionario);

                SqlParameter ParIDCliente = new SqlParameter();
                ParIDCliente.ParameterName = "@ID_Cliente";
                ParIDCliente.SqlDbType = SqlDbType.Int;
                ParIDCliente.Value = Venda.IDCliente;
                SqlCmd.Parameters.Add(ParIDCliente);

                SqlParameter ParOBSVenda = new SqlParameter();
                ParOBSVenda.ParameterName = "@OBS_Venda";
                ParOBSVenda.SqlDbType = SqlDbType.VarChar;
                ParOBSVenda.Value = Venda.ObservacaoVenda;
                SqlCmd.Parameters.Add(ParOBSVenda);

                SqlParameter ParDSTipoPagamento = new SqlParameter();
                ParDSTipoPagamento.ParameterName = "@DS_TipoPagamento";
                ParDSTipoPagamento.SqlDbType = SqlDbType.VarChar;
                ParDSTipoPagamento.Size = 20;
                ParDSTipoPagamento.Value = Venda.TipoPagamento;
                SqlCmd.Parameters.Add(ParDSTipoPagamento);

                SqlParameter ParVLTaxaEntrega = new SqlParameter();
                ParVLTaxaEntrega.ParameterName = "@VL_TaxaEntrega";
                ParVLTaxaEntrega.SqlDbType = SqlDbType.Decimal;
                ParVLTaxaEntrega.Value = Venda.ValorTaxaEntrega;
                SqlCmd.Parameters.Add(ParVLTaxaEntrega);

                SqlParameter ParVLTotal = new SqlParameter();
                ParVLTotal.ParameterName = "@VL_Total";
                ParVLTotal.SqlDbType = SqlDbType.Decimal;
                ParVLTotal.Value = Venda.ValorTotal;
                SqlCmd.Parameters.Add(ParVLTotal);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Venda.IDUnidadeRede;
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


        // Método excluir
        public string ExcluirVenda(ModelVenda Venda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Venda.IDUnidadeRede;
                SqlCmd.Parameters.Add(ParIDUnidadeRede);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão nâo foi realizada";
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


        // Método validar vendas não finalizadas
        public string ValidarVenda(ModelVenda Venda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spvalidar_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A validacão não foi realizada";
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
        public DataTable MostrarVenda(ModelVenda Venda)
        {
            DataTable DtResultado = new DataTable("TB_Venda");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Venda.IDUnidadeRede;
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

        // Método venda por data
        public DataTable BuscarDataVenda(ModelVenda Venda)
        {
            DataTable DtResultado = new DataTable("TB_Venda");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_data_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParDataBuscar = new SqlParameter();
                ParDataBuscar.ParameterName = "@DataBuscar";
                ParDataBuscar.SqlDbType = SqlDbType.Date;
                ParDataBuscar.Value = Venda.DataBuscar;
                SqlCmd.Parameters.Add(ParDataBuscar);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Venda.IDUnidadeRede;
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
