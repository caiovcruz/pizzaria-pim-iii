using System;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelNivelAcesso
    {
        public ModelNivelAcesso()
        {

        }
            
        public DataTable MostrarNivelAcesso()
        {
            DataTable DtResultado = new DataTable("TB_NivelAcesso");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = ModelConexao.Conexao;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_nivel_acesso";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }
    }
}
