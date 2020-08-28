using Model;
using System.Data;

namespace Control
{
    public class ControlProduto
    {
        ModelProduto myProduto = new ModelProduto();

        // Método inserir
        public string InserirProduto(int categoria, string nome, double preco, double custo, string descricao, byte[] imagem)
        {
            myProduto.Categoria = categoria;
            myProduto.Nome = nome;
            myProduto.Preco = preco;
            myProduto.Custo = custo;
            myProduto.Descricao = descricao;
            myProduto.Imagem = imagem;

            return myProduto.InserirProduto(myProduto);
        }

        // Método Editar
        public string EditarProduto(int id, int categoria, string nome, double preco, double custo, string descricao, byte[] imagem)
        {
            myProduto.IDProduto = id;
            myProduto.Categoria = categoria;
            myProduto.Nome = nome;
            myProduto.Preco = preco;
            myProduto.Custo = custo;
            myProduto.Descricao = descricao;
            myProduto.Imagem = imagem;

            return myProduto.EditarProduto(myProduto);
        }

        // Metodo Deletar
        public string ExcluirProduto(int id)
        {
            myProduto.IDProduto = id;

            return myProduto.ExcluirProduto(myProduto);
        }

        // Metodo Mostrar Produto
        public DataTable MostrarProduto()
        {
            return myProduto.MostrarProduto();
        }

        // Metodo Buscar Produto por Nome
        public DataTable BuscarNomeProduto(string Textobuscar)
        {
            myProduto.TextoBuscar = Textobuscar;
            return myProduto.BuscarNomeProduto(myProduto);
        }
    }
}
