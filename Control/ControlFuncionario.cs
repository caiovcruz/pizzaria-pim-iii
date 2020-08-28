using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlFuncionario
    {
        ModelFuncionario myFuncionario = new ModelFuncionario();

        public string InserirFuncionario(
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
            int id_unidaderede)
        {

            myFuncionario.Nome = nome;
            myFuncionario.Sexo = sexo;
            myFuncionario.CPF = cpf;
            myFuncionario.DataNascimento = datanascimento;
            myFuncionario.Telefone = telefone;
            myFuncionario.Email = email;
            myFuncionario.CEP = cep;
            myFuncionario.Rua = rua;
            myFuncionario.NumCasa = numcasa;
            myFuncionario.Bairro = bairro;
            myFuncionario.Complemento = complemento;
            myFuncionario.Cidade = cidade;
            myFuncionario.Estado = estado;
            myFuncionario.Cargo = cargo;
            myFuncionario.Salario = salario;
            myFuncionario.Admissao = admissao;
            myFuncionario.IDUnidadeRede = id_unidaderede;

            return myFuncionario.InserirFuncionario(myFuncionario);
        }

        // Método editar
        public string EditarFuncionario(
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
            int id_unidaderede)

        {
            myFuncionario.ID = id;
            myFuncionario.Nome = nome;
            myFuncionario.Sexo = sexo;
            myFuncionario.CPF = cpf;
            myFuncionario.DataNascimento = datanascimento;
            myFuncionario.Telefone = telefone;
            myFuncionario.Email = email;
            myFuncionario.CEP = cep;
            myFuncionario.Rua = rua;
            myFuncionario.NumCasa = numcasa;
            myFuncionario.Bairro = bairro;
            myFuncionario.Complemento = complemento;
            myFuncionario.Cidade = cidade;
            myFuncionario.Estado = estado;
            myFuncionario.Cargo = cargo;
            myFuncionario.Salario = salario;
            myFuncionario.Admissao = admissao;
            myFuncionario.IDUnidadeRede = id_unidaderede;

            return myFuncionario.EditarFuncionario(myFuncionario);
        }

        // Metodo Deletar
        public string ExcluirFuncionario(int id, int id_unidaderede)
        {
            myFuncionario.ID = id;
            myFuncionario.IDUnidadeRede = id_unidaderede;

            return myFuncionario.ExcluirFuncionario(myFuncionario);
        }

        // Metodo Mostar
        public DataTable MostrarFuncionario(int id_unidaderede)
        {
            myFuncionario.IDUnidadeRede = id_unidaderede;

            return myFuncionario.MostrarFuncionario(myFuncionario);
        }

        // Metodo Buscar nome
        public DataTable BuscarNomeFuncionario(string Textobuscar, int id_unidaderede)
        {
            myFuncionario.TextoBuscar = Textobuscar;
            myFuncionario.IDUnidadeRede = id_unidaderede;

            return myFuncionario.BuscarNomeFuncionario(myFuncionario);
        }

        // Metodo Buscar cpf
        public DataTable BuscarCPFFuncionario(string Textobuscar, int id_unidaderede)
        {
            myFuncionario.TextoBuscar = Textobuscar;
            myFuncionario.IDUnidadeRede = id_unidaderede;

            return myFuncionario.BuscarCPFFuncionario(myFuncionario);
        }
    }
}
