using System.Configuration;

namespace Model
{
    class ModelConexao
    {
        public static string Conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
    }
}
