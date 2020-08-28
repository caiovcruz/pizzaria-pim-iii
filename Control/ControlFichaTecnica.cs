using Model;
using System.Data;

namespace Control
{
    public class ControlFichaTecnica
    {
        ModelFichaTecnica myFichaTecnica = new ModelFichaTecnica();

        public string InserirFichaTecnica(int id_produto, int id_insumo, double qtde_utilizada)
        {
            myFichaTecnica.IDProduto = id_produto;
            myFichaTecnica.IDInsumo = id_insumo;
            myFichaTecnica.QuantidadeUtilizada = qtde_utilizada;

            return myFichaTecnica.InserirFichaTecnica(myFichaTecnica);
        }

        public string EditarFichaTecnica(int id_produto, int id_insumo, double qtde_utilizada)
        {
            myFichaTecnica.IDProduto = id_produto;
            myFichaTecnica.IDInsumo = id_insumo;
            myFichaTecnica.QuantidadeUtilizada = qtde_utilizada;

            return myFichaTecnica.EditarFichaTecnica(myFichaTecnica);
        }

        public string ExcluirFichaTecnica(int id_produto, int id_insumo)
        {
            myFichaTecnica.IDProduto = id_produto;
            myFichaTecnica.IDInsumo = id_insumo;

            return myFichaTecnica.ExcluirFichaTecnica(myFichaTecnica);
        }

        public DataTable MostrarFichaTecnica(int id_busca)
        {
            myFichaTecnica.IDBusca = id_busca;
            return myFichaTecnica.MostrarFichaTecnica(myFichaTecnica);
        }
    }
}
