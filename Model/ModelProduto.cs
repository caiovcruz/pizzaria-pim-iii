using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelProduto
    {
        private int _IDProduto;
        private int _Categoria;
        private string _Nome;
        private double _Preco;
        private double _Custo;
        private string _Descricao;
        private byte[] _Imagem;
        private string _Imagem1;
        private string _TextoBuscar;

        public int IDProduto { get => _IDProduto; set => _IDProduto = value; }
        public int Categoria { get => _Categoria; set => _Categoria = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public double Preco { get => _Preco; set => _Preco = value; }
        public double Custo { get => _Custo; set => _Custo = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public byte[] Imagem { get => _Imagem; set => _Imagem = value; }
        public string Imagem1 { get => _Imagem1; set => _Imagem1 = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelProduto()
        {

        }

        public ModelProduto(int id, int categoria, string nome, double preco, double custo, string descricao, byte[] imagem, string imagem1, string textobuscar)
        {
            this.IDProduto = id;
            this.Categoria = categoria;
            this.Nome = nome;
            this.Preco = preco;
            this.Custo = custo;
            this.Descricao = descricao;
            this.Imagem = imagem;
            this.Imagem1 = imagem1;
            this.TextoBuscar = textobuscar;
        }

        // Método inserir
        public string InserirProduto(ModelProduto Produto)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_produto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID_Produto";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParCategoria = new SqlParameter();
                ParCategoria.ParameterName = "@ID_Categoria";
                ParCategoria.SqlDbType = SqlDbType.Int;
                ParCategoria.Value = Produto.Categoria;
                SqlCmd.Parameters.Add(ParCategoria);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@NM_Produto";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Produto.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParPreco = new SqlParameter();
                ParPreco.ParameterName = "@PR_Unitario";
                ParPreco.SqlDbType = SqlDbType.Decimal;
                ParPreco.Value = Produto.Preco;
                SqlCmd.Parameters.Add(ParPreco);

                SqlParameter ParCusto = new SqlParameter();
                ParCusto.ParameterName = "@PR_Custo";
                ParCusto.SqlDbType = SqlDbType.Decimal;
                ParCusto.Value = Produto.Custo;
                SqlCmd.Parameters.Add(ParCusto);

                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@DS_Produto";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 150;
                ParDescricao.Value = Produto.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                SqlParameter ParImagem = new SqlParameter();
                ParImagem.ParameterName = "@IMG_Produto";
                ParImagem.SqlDbType = SqlDbType.Image;
                ParImagem.Value = Produto.Imagem;
                SqlCmd.Parameters.Add(ParImagem);

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

        // Método Editar
        public string EditarProduto(ModelProduto Produto)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_produto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID_Produto";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = Produto.IDProduto;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParCategoria = new SqlParameter();
                ParCategoria.ParameterName = "@ID_Categoria";
                ParCategoria.SqlDbType = SqlDbType.Int;
                ParCategoria.Value = Produto.Categoria;
                SqlCmd.Parameters.Add(ParCategoria);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@NM_Produto";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Produto.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParPreco = new SqlParameter();
                ParPreco.ParameterName = "@PR_Unitario";
                ParPreco.SqlDbType = SqlDbType.Decimal;
                ParPreco.Value = Produto.Preco;
                SqlCmd.Parameters.Add(ParPreco);

                SqlParameter ParCusto = new SqlParameter();
                ParCusto.ParameterName = "@PR_Custo";
                ParCusto.SqlDbType = SqlDbType.Decimal;
                ParCusto.Value = Produto.Custo;
                SqlCmd.Parameters.Add(ParCusto);

                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@DS_Produto";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 150;
                ParDescricao.Value = Produto.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                SqlParameter ParImagem = new SqlParameter();
                ParImagem.ParameterName = "@IMG_Produto";
                ParImagem.SqlDbType = SqlDbType.Image;
                ParImagem.Value = Produto.Imagem;
                SqlCmd.Parameters.Add(ParImagem);

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
        public string ExcluirProduto(ModelProduto Produto)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_produto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID_Produto";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = Produto.IDProduto;
                SqlCmd.Parameters.Add(ParID);

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
        public DataTable MostrarProduto()
        {
            DataTable DtResultado = new DataTable("TB_Produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_produtos";
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

        // Método buscar produto por nome
        public DataTable BuscarNomeProduto(ModelProduto Produto)
        {
            DataTable DtResultado = new DataTable("TB_Produto");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_produto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Produto.TextoBuscar;
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
