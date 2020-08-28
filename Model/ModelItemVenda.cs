using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelItemVenda
    {
        private int _IDVenda;
        private int _IDProduto;
        private int _Quantidade;
        private double _ValorSubTotal;
        private string _TextoBuscar;

        public int IDVenda { get => _IDVenda; set => _IDVenda = value; }
        public int IDProduto { get => _IDProduto; set => _IDProduto = value; }
        public int Quantidade { get => _Quantidade; set => _Quantidade = value; }
        public double ValorSubTotal { get => _ValorSubTotal; set => _ValorSubTotal = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }


        public ModelItemVenda()
        {

        }


        public ModelItemVenda(int id_pedido, int id_produto, int quantidade, double vl_subTotal, string textobuscar)
        {
            this.IDVenda = id_pedido;
            this.IDProduto = id_produto;
            this.Quantidade = quantidade;
            this.ValorSubTotal = vl_subTotal;
            this.TextoBuscar = textobuscar;
        }


        // Metodo inserir item venda
        public string InserirItemVenda(ModelItemVenda ItemVenda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_item_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDVenda = new SqlParameter();
                ParIDVenda.ParameterName = "@ID_Venda";
                ParIDVenda.SqlDbType = SqlDbType.Int;
                ParIDVenda.Value = ItemVenda.IDVenda;
                SqlCmd.Parameters.Add(ParIDVenda);

                SqlParameter ParIDProduto = new SqlParameter();
                ParIDProduto.ParameterName = "@ID_Produto";
                ParIDProduto.SqlDbType = SqlDbType.Int;
                ParIDProduto.Value = ItemVenda.IDProduto;
                SqlCmd.Parameters.Add(ParIDProduto);

                SqlParameter ParQTDEItem = new SqlParameter();
                ParQTDEItem.ParameterName = "@QTDE_ItemVenda";
                ParQTDEItem.SqlDbType = SqlDbType.Int;
                ParQTDEItem.Value = ItemVenda.Quantidade;
                SqlCmd.Parameters.Add(ParQTDEItem);

                SqlParameter ParVLSubTotal = new SqlParameter();
                ParVLSubTotal.ParameterName = "@VL_SubTotal";
                ParVLSubTotal.SqlDbType = SqlDbType.Decimal;
                ParVLSubTotal.Value = ItemVenda.ValorSubTotal;
                SqlCmd.Parameters.Add(ParVLSubTotal);

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


        // Metodo editar item venda
        public string EditarItemVenda(ModelItemVenda ItemVenda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_item_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDVenda = new SqlParameter();
                ParIDVenda.ParameterName = "@ID_Venda";
                ParIDVenda.SqlDbType = SqlDbType.Int;
                ParIDVenda.Value = ItemVenda.IDVenda;
                SqlCmd.Parameters.Add(ParIDVenda);

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@ID_Produto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = ItemVenda.IDProduto;
                SqlCmd.Parameters.Add(ParIdProduto);

                SqlParameter ParQTDEItem = new SqlParameter();
                ParQTDEItem.ParameterName = "@QTDE_ItemVenda";
                ParQTDEItem.SqlDbType = SqlDbType.Int;
                ParQTDEItem.Value = ItemVenda.Quantidade;
                SqlCmd.Parameters.Add(ParQTDEItem);

                SqlParameter ParVLSubTotal = new SqlParameter();
                ParVLSubTotal.ParameterName = "@VL_SubTotal";
                ParVLSubTotal.SqlDbType = SqlDbType.Decimal;
                ParVLSubTotal.Value = ItemVenda.ValorSubTotal;
                SqlCmd.Parameters.Add(ParVLSubTotal);

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


        // Metodo excluir todos item venda
        public string ExcluirTodosItemVenda(ModelItemVenda ItemVenda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_item_venda_todos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDVenda = new SqlParameter();
                ParIDVenda.ParameterName = "@ID_Venda";
                ParIDVenda.SqlDbType = SqlDbType.Int;
                ParIDVenda.Value = ItemVenda.IDVenda;
                SqlCmd.Parameters.Add(ParIDVenda);

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


        // Metodo excluir um item venda
        public string ExcluirUmItemVenda(ModelItemVenda ItemVenda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_item_venda_um";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDVenda = new SqlParameter();
                ParIDVenda.ParameterName = "@ID_Venda";
                ParIDVenda.SqlDbType = SqlDbType.Int;
                ParIDVenda.Value = ItemVenda.IDVenda;
                SqlCmd.Parameters.Add(ParIDVenda);

                SqlParameter ParIDProduto = new SqlParameter();
                ParIDProduto.ParameterName = "@ID_Produto";
                ParIDProduto.SqlDbType = SqlDbType.Int;
                ParIDProduto.Value = ItemVenda.IDProduto;
                SqlCmd.Parameters.Add(ParIDProduto);

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


        // Metodo mostrar item venda
        public DataTable MostrarItemVenda(ModelItemVenda ItemVenda)
        {
            DataTable DtResultado = new DataTable("TB_ItemVenda");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_item_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDVenda = new SqlParameter();
                ParIDVenda.ParameterName = "@ID_Venda";
                ParIDVenda.SqlDbType = SqlDbType.Int;
                ParIDVenda.Value = ItemVenda.IDVenda;
                SqlCmd.Parameters.Add(ParIDVenda);

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

        public DataTable MostrarTodosItemVenda()
        {
            DataTable DtResultado = new DataTable("TB_ItemVenda");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_todos_item_venda";
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

        // Metodo buscar nome item venda
        public DataTable BuscarNomeItemVenda(ModelItemVenda ItemVenda)
        {
            DataTable DtResultado = new DataTable("TB_ItemVenda");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nome_item_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = ItemVenda.TextoBuscar;
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
