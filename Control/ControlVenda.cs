using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlVenda
    {
        ModelVenda myVenda = new ModelVenda();

        // Metodo inserir
        public string InserirVenda(int id_funcionario, int id_cliente, int id_unidaderede)
        {
            myVenda.IDFuncionario = id_funcionario;
            myVenda.IDCliente = id_cliente;
            myVenda.IDUnidadeRede = id_unidaderede;

            return myVenda.InserirVenda(myVenda);
        }


        // Metodo Editar
        public string EditarVenda(
            int id_funcionario,
            int id_cliente,
            string obs_venda,
            string ds_tipopagamento,
            double vl_taxaentrega,
            double vl_total,
            int id_unidaderede)
        {
            myVenda.IDFuncionario = id_funcionario;
            myVenda.IDCliente = id_cliente;
            myVenda.ObservacaoVenda = obs_venda;
            myVenda.TipoPagamento = ds_tipopagamento;
            myVenda.ValorTaxaEntrega = vl_taxaentrega;
            myVenda.ValorTotal = vl_total;
            myVenda.IDUnidadeRede = id_unidaderede;

            return myVenda.EditarVenda(myVenda);
        }


        // Metodo Deletar
        public string ExcluirVenda(int id_unidaderede)
        {
            myVenda.IDUnidadeRede = id_unidaderede;

            return myVenda.ExcluirVenda(myVenda);
        }


        // Metodo Validar
        public string ValidarVenda()
        {
            return myVenda.ValidarVenda(myVenda);
        }


        // Metodo Mostar
        public DataTable MostrarVenda(int id_unidaderede)
        {
            myVenda.IDUnidadeRede = id_unidaderede;

            return myVenda.MostrarVenda(myVenda);
        }

        // Metodo Buscar nome
        public DataTable BuscarDataVenda(DateTime Textobuscar, int id_unidaderede)
        {
            myVenda.DataBuscar = Textobuscar;
            myVenda.IDUnidadeRede = id_unidaderede;

            return myVenda.BuscarDataVenda(myVenda);
        }
    }
}
