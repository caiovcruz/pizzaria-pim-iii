using Model;
using System.Data;

namespace Control
{
    public class ControlCategoria
    {
        ModelCategoria myCategoria = new ModelCategoria();

        // Metodo inserir
        public string InserirCategoria(string nome, string descricao)
        {
            myCategoria.Nome = nome;
            myCategoria.Descricao = descricao;

            return myCategoria.InserirCategoria(myCategoria);
        }

        // Metodo Editar
        public string EditarCategoria(int id, string nome, string descricao)
        {
            myCategoria.IDCategoria = id;
            myCategoria.Nome = nome;
            myCategoria.Descricao = descricao;

            return myCategoria.EditarCategoria(myCategoria);
        }

        // Metodo Deletar
        public string ExcluirCategoria(int id, string nome)
        {
            myCategoria.IDCategoria = id;
            myCategoria.Nome = nome;

            return myCategoria.ExcluirCategoria(myCategoria);
        }

        // Metodo Mostrar
        public DataTable MostrarCategoria()
        {
            return myCategoria.MostrarCategoria();
        }

        // Metodo Buscar nome
        public DataTable BuscarNomeCategoria(string Textobuscar)
        {
            myCategoria.TextoBuscar = Textobuscar;

            return myCategoria.BuscarNomeCategoria(myCategoria);
        }
    }
}
