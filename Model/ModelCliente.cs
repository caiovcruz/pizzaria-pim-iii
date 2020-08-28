using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelCliente : ModelPessoa
    {
        private string _TextoBuscar;

        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelCliente()
        {

        }

        public ModelCliente(
            int id,
            string nome,
            string sexo,
            string cpf,
            DateTime datanascimento,
            string telefone, 
            string email, 
            string cep, 
            string rua,
            string numcasa,
            string bairro,
            string complemento,
            string cidade,
            string estado,
            string textobuscar)
        {
            this.ID = id;
            this.Nome = nome;
            this.Sexo = sexo;
            this.CPF = cpf;
            this.DataNascimento = datanascimento;
            this.Telefone = telefone;
            this.Email = email;
            this.CEP = cep;
            this.Rua = rua;
            this.NumCasa = numcasa;
            this.Bairro = bairro;
            this.Complemento = complemento;
            this.Cidade = cidade;
            this.Estado = estado;
            this.TextoBuscar = textobuscar;
        }

        // Método inserir
        public string InserirCliente(ModelCliente Cliente)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID_Cliente";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@NM_Cliente";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Cliente.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@DS_Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Cliente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParCPF = new SqlParameter();
                ParCPF.ParameterName = "@NR_CPF";
                ParCPF.SqlDbType = SqlDbType.VarChar;
                ParCPF.Size = 11;
                ParCPF.Value = Cliente.CPF;
                SqlCmd.Parameters.Add(ParCPF);

                SqlParameter ParDataNascimento = new SqlParameter();
                ParDataNascimento.ParameterName = "@DT_Nascimento";
                ParDataNascimento.SqlDbType = SqlDbType.Date;

                if (Cliente.DataNascimento.HasValue)
                {
                    ParDataNascimento.Value = Cliente.DataNascimento;
                    SqlCmd.Parameters.Add(ParDataNascimento);
                }
                else
                {

                    ParDataNascimento.Value = DBNull.Value;
                    SqlCmd.Parameters.Add(ParDataNascimento);
                }

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@NR_Telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 11;
                ParTelefone.Value = Cliente.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@DS_Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 35;
                ParEmail.Value = Cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParCEP = new SqlParameter();
                ParCEP.ParameterName = "@NR_CEP";
                ParCEP.SqlDbType = SqlDbType.VarChar;
                ParCEP.Size = 10;
                ParCEP.Value = Cliente.CEP;
                SqlCmd.Parameters.Add(ParCEP);

                SqlParameter ParRua = new SqlParameter();
                ParRua.ParameterName = "@NM_Rua";
                ParRua.SqlDbType = SqlDbType.VarChar;
                ParRua.Size = 50;
                ParRua.Value = Cliente.Rua;
                SqlCmd.Parameters.Add(ParRua);

                SqlParameter ParNumCasa = new SqlParameter();
                ParNumCasa.ParameterName = "@NR_Casa";
                ParNumCasa.SqlDbType = SqlDbType.VarChar;
                ParNumCasa.Size = 5;
                ParNumCasa.Value = Cliente.NumCasa;
                SqlCmd.Parameters.Add(ParNumCasa);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@NM_Bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Cliente.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParComplemento = new SqlParameter();
                ParComplemento.ParameterName = "@DS_Complemento";
                ParComplemento.SqlDbType = SqlDbType.VarChar;
                ParComplemento.Size = 50;
                ParComplemento.Value = Cliente.Complemento;
                SqlCmd.Parameters.Add(ParComplemento);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@NM_Cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 30;
                ParCidade.Value = Cliente.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@DS_UF";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 2;
                ParEstado.Value = Cliente.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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
        public string EditarCliente(ModelCliente Cliente)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID_Cliente";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = Cliente.ID;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@NM_Cliente";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Cliente.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@DS_Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Cliente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParCPF = new SqlParameter();
                ParCPF.ParameterName = "@NR_CPF";
                ParCPF.SqlDbType = SqlDbType.VarChar;
                ParCPF.Size = 11;
                ParCPF.Value = Cliente.CPF;
                SqlCmd.Parameters.Add(ParCPF);

                SqlParameter ParDataNascimento = new SqlParameter();
                ParDataNascimento.ParameterName = "@DT_Nascimento";
                ParDataNascimento.SqlDbType = SqlDbType.Date;

                if (Cliente.DataNascimento.HasValue)
                {
                    ParDataNascimento.Value = Cliente.DataNascimento;
                    SqlCmd.Parameters.Add(ParDataNascimento);
                }
                else
                {

                    ParDataNascimento.Value = DBNull.Value;
                    SqlCmd.Parameters.Add(ParDataNascimento);
                }

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@NR_Telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 11;
                ParTelefone.Value = Cliente.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@DS_Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 35;
                ParEmail.Value = Cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParCEP = new SqlParameter();
                ParCEP.ParameterName = "@NR_CEP";
                ParCEP.SqlDbType = SqlDbType.VarChar;
                ParCEP.Size = 10;
                ParCEP.Value = Cliente.CEP;
                SqlCmd.Parameters.Add(ParCEP);

                SqlParameter ParRua = new SqlParameter();
                ParRua.ParameterName = "@NM_Rua";
                ParRua.SqlDbType = SqlDbType.VarChar;
                ParRua.Size = 50;
                ParRua.Value = Cliente.Rua;
                SqlCmd.Parameters.Add(ParRua);

                SqlParameter ParNumCasa = new SqlParameter();
                ParNumCasa.ParameterName = "@NR_Casa";
                ParNumCasa.SqlDbType = SqlDbType.VarChar;
                ParNumCasa.Size = 5;
                ParNumCasa.Value = Cliente.NumCasa;
                SqlCmd.Parameters.Add(ParNumCasa);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@NM_Bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Cliente.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParComplemento = new SqlParameter();
                ParComplemento.ParameterName = "@DS_Complemento";
                ParComplemento.SqlDbType = SqlDbType.VarChar;
                ParComplemento.Size = 50;
                ParComplemento.Value = Cliente.Complemento;
                SqlCmd.Parameters.Add(ParComplemento);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@NM_Cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 30;
                ParCidade.Value = Cliente.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@DS_UF";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 2;
                ParEstado.Value = Cliente.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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
        public string ExcluirCliente(ModelCliente Cliente)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID_Cliente";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = Cliente.ID;
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
        public DataTable MostrarCliente()
        {
            DataTable DtResultado = new DataTable("TB_cliente");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cliente";
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

        // Método buscar cliente por nome
        public DataTable BuscarNomeCliente(ModelCliente Cliente)
        {
            DataTable DtResultado = new DataTable("TB_Cliente");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nome_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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

        // Metodo buscar cliente por cpf
        public DataTable BuscarCPFCliente(ModelCliente Cliente)
        {
            DataTable DtResultado = new DataTable("TB_Cliente");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cpf_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 11;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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
