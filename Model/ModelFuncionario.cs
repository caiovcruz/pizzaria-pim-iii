using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelFuncionario : ModelPessoa
    {
        private int _IDUnidadeRede;
        private string _Cargo;
        private double _Salario;
        private DateTime _Admissao;
        private string _TextoBuscar;

        public int IDUnidadeRede { get => _IDUnidadeRede; set => _IDUnidadeRede = value; }
        public string Cargo { get => _Cargo; set => _Cargo = value; }
        public double Salario { get => _Salario; set => _Salario = value; }
        public DateTime Admissao { get => _Admissao; set => _Admissao = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelFuncionario()
        {

        }

        public ModelFuncionario(
            int id_unidaderede,
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
            string cargo,
            double salario,
            DateTime admissao,
            string textobuscar)
        {
            this.IDUnidadeRede = id_unidaderede;
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
            this.Cargo = cargo;
            this.Salario = salario;
            this.Admissao = admissao;
            this.TextoBuscar = textobuscar;
        }

        // Método inserir
        public string InserirFuncionario(ModelFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID_Funcionario";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@NM_Funcionario";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Funcionario.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@DS_Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Funcionario.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParCPF = new SqlParameter();
                ParCPF.ParameterName = "@NR_CPF";
                ParCPF.SqlDbType = SqlDbType.VarChar;
                ParCPF.Size = 11;
                ParCPF.Value = Funcionario.CPF;
                SqlCmd.Parameters.Add(ParCPF);

                SqlParameter ParDataNascimento = new SqlParameter();
                ParDataNascimento.ParameterName = "@DT_Nascimento";
                ParDataNascimento.SqlDbType = SqlDbType.Date;
                ParDataNascimento.Value = Funcionario.DataNascimento;
                SqlCmd.Parameters.Add(ParDataNascimento);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@NR_Telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 11;
                ParTelefone.Value = Funcionario.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@DS_Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 35;
                ParEmail.Value = Funcionario.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParCEP = new SqlParameter();
                ParCEP.ParameterName = "@NR_CEP";
                ParCEP.SqlDbType = SqlDbType.VarChar;
                ParCEP.Size = 10;
                ParCEP.Value = Funcionario.CEP;
                SqlCmd.Parameters.Add(ParCEP);

                SqlParameter ParRua = new SqlParameter();
                ParRua.ParameterName = "@NM_Rua";
                ParRua.SqlDbType = SqlDbType.VarChar;
                ParRua.Size = 50;
                ParRua.Value = Funcionario.Rua;
                SqlCmd.Parameters.Add(ParRua);

                SqlParameter ParNumCasa = new SqlParameter();
                ParNumCasa.ParameterName = "@NR_Casa";
                ParNumCasa.SqlDbType = SqlDbType.VarChar;
                ParNumCasa.Size = 5;
                ParNumCasa.Value = Funcionario.NumCasa;
                SqlCmd.Parameters.Add(ParNumCasa);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@NM_Bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Funcionario.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParComplemento = new SqlParameter();
                ParComplemento.ParameterName = "@DS_Complemento";
                ParComplemento.SqlDbType = SqlDbType.VarChar;
                ParComplemento.Size = 50;
                ParComplemento.Value = Funcionario.Complemento;
                SqlCmd.Parameters.Add(ParComplemento);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@NM_Cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 30;
                ParCidade.Value = Funcionario.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@DS_UF";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 2;
                ParEstado.Value = Funcionario.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@DS_Cargo";
                ParCargo.SqlDbType = SqlDbType.VarChar;
                ParCargo.Size = 30;
                ParCargo.Value = Funcionario.Cargo;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter ParSalario = new SqlParameter();
                ParSalario.ParameterName = "@VL_Salario";
                ParSalario.SqlDbType = SqlDbType.Decimal;
                ParSalario.Value = Funcionario.Salario;
                SqlCmd.Parameters.Add(ParSalario);

                SqlParameter ParAdmissao = new SqlParameter();
                ParAdmissao.ParameterName = "@DT_Admissao";
                ParAdmissao.SqlDbType = SqlDbType.Date;
                ParAdmissao.Value = Funcionario.Admissao;
                SqlCmd.Parameters.Add(ParAdmissao);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Funcionario.IDUnidadeRede;
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
        public string EditarFuncionario(ModelFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID_Funcionario";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = Funcionario.ID;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@NM_Funcionario";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Funcionario.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@DS_Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Funcionario.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParCPF = new SqlParameter();
                ParCPF.ParameterName = "@NR_CPF";
                ParCPF.SqlDbType = SqlDbType.VarChar;
                ParCPF.Size = 11;
                ParCPF.Value = Funcionario.CPF;
                SqlCmd.Parameters.Add(ParCPF);

                SqlParameter ParDataNascimento = new SqlParameter();
                ParDataNascimento.ParameterName = "@DT_Nascimento";
                ParDataNascimento.SqlDbType = SqlDbType.Date;
                ParDataNascimento.Value = Funcionario.DataNascimento;
                SqlCmd.Parameters.Add(ParDataNascimento);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@NR_Telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 11;
                ParTelefone.Value = Funcionario.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@DS_Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 35;
                ParEmail.Value = Funcionario.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParCEP = new SqlParameter();
                ParCEP.ParameterName = "@NR_CEP";
                ParCEP.SqlDbType = SqlDbType.VarChar;
                ParCEP.Size = 10;
                ParCEP.Value = Funcionario.CEP;
                SqlCmd.Parameters.Add(ParCEP);

                SqlParameter ParRua = new SqlParameter();
                ParRua.ParameterName = "@NM_Rua";
                ParRua.SqlDbType = SqlDbType.VarChar;
                ParRua.Size = 50;
                ParRua.Value = Funcionario.Rua;
                SqlCmd.Parameters.Add(ParRua);

                SqlParameter ParNumCasa = new SqlParameter();
                ParNumCasa.ParameterName = "@NR_Casa";
                ParNumCasa.SqlDbType = SqlDbType.VarChar;
                ParNumCasa.Size = 5;
                ParNumCasa.Value = Funcionario.NumCasa;
                SqlCmd.Parameters.Add(ParNumCasa);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@NM_Bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Funcionario.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParComplemento = new SqlParameter();
                ParComplemento.ParameterName = "@DS_Complemento";
                ParComplemento.SqlDbType = SqlDbType.VarChar;
                ParComplemento.Size = 50;
                ParComplemento.Value = Funcionario.Complemento;
                SqlCmd.Parameters.Add(ParComplemento);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@NM_Cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 30;
                ParCidade.Value = Funcionario.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@DS_UF";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 2;
                ParEstado.Value = Funcionario.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@DS_Cargo";
                ParCargo.SqlDbType = SqlDbType.VarChar;
                ParCargo.Size = 30;
                ParCargo.Value = Funcionario.Cargo;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter ParSalario = new SqlParameter();
                ParSalario.ParameterName = "@VL_Salario";
                ParSalario.SqlDbType = SqlDbType.Decimal;
                ParSalario.Value = Funcionario.Salario;
                SqlCmd.Parameters.Add(ParSalario);

                SqlParameter ParAdmissao = new SqlParameter();
                ParAdmissao.ParameterName = "@DT_Admissao";
                ParAdmissao.SqlDbType = SqlDbType.Date;
                ParAdmissao.Value = Funcionario.Admissao;
                SqlCmd.Parameters.Add(ParAdmissao);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Funcionario.IDUnidadeRede;
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
        public string ExcluirFuncionario(ModelFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID_Funcionario";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = Funcionario.ID;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Funcionario.IDUnidadeRede;
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
        public DataTable MostrarFuncionario(ModelFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("TB_Funcionario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Funcionario.IDUnidadeRede;
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

        // Metodo buscar funcionário por nome
        public DataTable BuscarNomeFuncionario(ModelFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("TB_Funcionario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nome_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Funcionario.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Funcionario.IDUnidadeRede;
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

        // Método buscar funcionário por cpf
        public DataTable BuscarCPFFuncionario(ModelFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("TB_Funcionario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cpf_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 11;
                ParTextoBuscar.Value = Funcionario.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParIDUnidadeRede = new SqlParameter();
                ParIDUnidadeRede.ParameterName = "@ID_UnidadeRede";
                ParIDUnidadeRede.SqlDbType = SqlDbType.Int;
                ParIDUnidadeRede.Value = Funcionario.IDUnidadeRede;
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
