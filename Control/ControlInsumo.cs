using Model;
using System.Data;

namespace Control
{
    public class ControlInsumo
    {
        ModelInsumo myInsumo = new ModelInsumo();

        // Método inserir
        public string InserirInsumo(string nome, string armazenamento, double preco)
        {
            myInsumo.Nome = nome;
            myInsumo.TipoArmazenamento = armazenamento;
            myInsumo.Preco = preco;

            return myInsumo.InserirInsumo(myInsumo);
        }

        // Método editar
        public string EditarInsumo(int id, string nome, string armazenamento, double preco)
        {
            myInsumo.IDInsumo = id;
            myInsumo.Nome = nome;
            myInsumo.TipoArmazenamento = armazenamento;
            myInsumo.Preco = preco;

            return myInsumo.EditarInsumo(myInsumo);
        }

        // Método deletar
        public string ExcluirInsumo(int id)
        {
            myInsumo.IDInsumo = id;

            return myInsumo.ExcluirInsumo(myInsumo);
        }

        // Método mostrar
        public DataTable MostrarInsumo()
        {
            return myInsumo.MostrarInsumo();
        }

        // Método buscar
        public DataTable BuscarNomeInsumo(string textobuscar)
        {
            myInsumo.TextoBuscar = textobuscar;

            return myInsumo.BuscarNomeInsumo(myInsumo);
        }
    }
}
