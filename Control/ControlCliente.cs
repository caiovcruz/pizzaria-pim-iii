using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlCliente
    {
        ModelCliente myCliente = new ModelCliente();

        // Método inserir
        public string InserirCliente(
            string nome,
            string sexo,
            string cpf,
            DateTime? datanascimento,
            string telefone,
            string email,
            string cep,
            string rua,
            string numcasa,
            string bairro,
            string complemento,
            string cidade,
            string estado)
        {

            myCliente.Nome = nome;
            myCliente.Sexo = sexo;
            myCliente.CPF = cpf;
            myCliente.DataNascimento = datanascimento;
            myCliente.Telefone = telefone;
            myCliente.Email = email;
            myCliente.CEP = cep;
            myCliente.Rua = rua;
            myCliente.NumCasa = numcasa;
            myCliente.Bairro = bairro;
            myCliente.Complemento = complemento;
            myCliente.Cidade = cidade;
            myCliente.Estado = estado;

            return myCliente.InserirCliente(myCliente);
        }

        // Método editar
        public string EditarCliente(
            int id, 
            string nome,
            string sexo,
            string cpf,
            DateTime? datanascimento,
            string telefone,
            string email,
            string cep,
            string rua,
            string numcasa,
            string bairro,
            string complemento,
            string cidade,
            string estado)

        {
            myCliente.ID = id;
            myCliente.Nome = nome;
            myCliente.Sexo = sexo;
            myCliente.CPF = cpf;
            myCliente.DataNascimento = datanascimento;
            myCliente.Telefone = telefone;
            myCliente.Email = email;
            myCliente.CEP = cep;
            myCliente.Rua = rua;
            myCliente.NumCasa = numcasa;
            myCliente.Bairro = bairro;
            myCliente.Complemento = complemento;
            myCliente.Cidade = cidade;
            myCliente.Estado = estado;

            return myCliente.EditarCliente(myCliente);
        }

        // Metodo Deletar
        public string ExcluirCliente(int id)
        {
            myCliente.ID = id;

            return myCliente.ExcluirCliente(myCliente);
        }

        // Metodo Mostar
        public DataTable MostrarCliente()
        {
            return myCliente.MostrarCliente();
        }

        // Metodo Buscar nome
        public DataTable BuscarNomeCliente(string Textobuscar)
        {
            myCliente.TextoBuscar = Textobuscar;

            return myCliente.BuscarNomeCliente(myCliente);
        }

        // Metodo Buscar Documento
        public DataTable BuscarCPFCliente(string Textobuscar)
        {
            myCliente.TextoBuscar = Textobuscar;

            return myCliente.BuscarCPFCliente(myCliente);
        }
    }
}
