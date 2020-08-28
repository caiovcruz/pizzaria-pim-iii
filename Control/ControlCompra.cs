using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlCompra
    {
        ModelCompra myCompra = new ModelCompra();

        // Método inserir
        public string InserirCompra(int id_insumo, DateTime dt_compra, double qtde_insumocompra, int id_unidaderede)
        {
            myCompra.IDInsumo = id_insumo;
            myCompra.DataCompra = dt_compra;
            myCompra.QuantidadeInsumoCompra = qtde_insumocompra;
            myCompra.IDUnidadeRede = id_unidaderede;

            return myCompra.InserirCompra(myCompra);
        }

        // Método excluir
        public string ExcluirCompra(int id_compra, int id_unidaderede)
        {
            myCompra.IDCompra = id_compra;
            myCompra.IDUnidadeRede = id_unidaderede;

            return myCompra.ExcluirCompra(myCompra);
        }

        // Método mostrar
        public DataTable MostrarCompra(int id_unidaderede)
        {
            myCompra.IDUnidadeRede = id_unidaderede;

            return myCompra.MostrarCompra(myCompra);
        }

        // Método buscar compra por data
        public DataTable BuscarDataCompra(DateTime databuscar, int id_unidaderede)
        {
            myCompra.DataBuscar = databuscar;
            myCompra.IDUnidadeRede = id_unidaderede;

            return myCompra.BuscarDataCompra(myCompra);
        }
    }
}
