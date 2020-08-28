using Model;
using System.Data;

namespace Control
{
    public class ControlEstoque
    {
        ModelEstoque myEstoque = new ModelEstoque();

        public string InserirEstoque(int id_insumo, double qtde_estoque, int id_unidaderede)
        {
            myEstoque.IDInsumo = id_insumo;
            myEstoque.QuantidadeEstoque = qtde_estoque;
            myEstoque.IDUnidadeRede = id_unidaderede;

            return myEstoque.InserirEstoque(myEstoque);
        }

        public string EditarEstoque(int id_insumo, double qtde_estoque, int id_unidaderede)
        {
            myEstoque.IDInsumo = id_insumo;
            myEstoque.QuantidadeEstoque = qtde_estoque;
            myEstoque.IDUnidadeRede = id_unidaderede;

            return myEstoque.EditarEstoque(myEstoque);
        }

        public string BaixaEstoque(int id_insumo, double qtde_estoque, int id_unidaderede)
        {
            myEstoque.IDInsumo = id_insumo;
            myEstoque.QuantidadeEstoque = qtde_estoque;
            myEstoque.IDUnidadeRede = id_unidaderede;

            return myEstoque.BaixaEstoque(myEstoque);
        }

        public string ExcluirEstoque(int id_insumo, int id_unidaderede)
        {
            myEstoque.IDInsumo = id_insumo;
            myEstoque.IDUnidadeRede = id_unidaderede;

            return myEstoque.ExcluirEstoque(myEstoque);
        }

        public DataTable MostrarEstoque(int id_unidaderede)
        {
            myEstoque.IDUnidadeRede = id_unidaderede;

            return myEstoque.MostrarEstoque(myEstoque);
        }

        public DataTable BuscarNomeInsumoEstoque(int id_unidaderede, string Textobuscar)
        {
            myEstoque.IDUnidadeRede = id_unidaderede;
            myEstoque.TextoBuscar = Textobuscar;

            return myEstoque.BuscarNomeInsumoEstoque(myEstoque);
        }
    }
}
