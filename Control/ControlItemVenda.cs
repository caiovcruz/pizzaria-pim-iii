using Model;
using System.Data;

namespace Control
{
    public class ControlItemVenda
    {
        ModelItemVenda myItemVenda = new ModelItemVenda();


        // Metodo inserir item venda
        public string InserirItemVenda(int id_venda, int id_produto, int quantidade, double vl_subTotal)
        {
            myItemVenda.IDVenda = id_venda;
            myItemVenda.IDProduto = id_produto;
            myItemVenda.Quantidade = quantidade;
            myItemVenda.ValorSubTotal = vl_subTotal * quantidade;

            return myItemVenda.InserirItemVenda(myItemVenda);
        }


        // Metodo editar
        public string EditarItemVenda(int id_venda, int id_produto, int quantidade, double vl_subTotal)
        {
            myItemVenda.IDVenda = id_venda;
            myItemVenda.IDProduto = id_produto;
            myItemVenda.Quantidade = quantidade;
            myItemVenda.ValorSubTotal = vl_subTotal;

            return myItemVenda.EditarItemVenda(myItemVenda);
        }


        // Metodo excluir todos item venda
        public string ExcluirTodosItemVenda(int id_venda)
        {
            myItemVenda.IDVenda = id_venda;

            return myItemVenda.ExcluirTodosItemVenda(myItemVenda);
        }

        // Metodo excluir um item venda
        public string ExcluirUmItemVenda(int id_venda, int id_produto)
        {
            myItemVenda.IDVenda = id_venda;
            myItemVenda.IDProduto = id_produto;

            return myItemVenda.ExcluirUmItemVenda(myItemVenda);
        }

        // Metodo mostrar item venda
        public DataTable MostrarItemVenda(int id_venda)
        {
            myItemVenda.IDVenda = id_venda;

            return myItemVenda.MostrarItemVenda(myItemVenda);
        }

        public DataTable MostrarTodosItemVenda()
        {
            return myItemVenda.MostrarTodosItemVenda();
        }

        // Metodo buscar nome item venda
        public DataTable BuscarNomeItemVenda(string Textobuscar)
        {
            myItemVenda.TextoBuscar = Textobuscar;

            return myItemVenda.BuscarNomeItemVenda(myItemVenda);
        }
    }
}
