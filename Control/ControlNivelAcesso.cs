using Model;
using System.Data;

namespace Control
{
    public class ControlNivelAcesso
    {
        ModelNivelAcesso myNivelAcesso = new ModelNivelAcesso();

        // Metodo Mostrar
        public DataTable MostrarNivelAcesso()
        {
            return myNivelAcesso.MostrarNivelAcesso();
        }
    }
}
