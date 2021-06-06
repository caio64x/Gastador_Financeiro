using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gastador.Properties;


namespace Gastador
{
    public class Conexao
    {
        //metodo para conectar o banco de dados
        public static SqlConnection getConnection()
        {
            //acessando a string de conexão
            string banco = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;

            return new SqlConnection(banco);
        }

    }
}
