using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gastador.Properties;
using MySql.Data.MySqlClient;

namespace Gastador
{
    public class Conexao
    {
        //metodo para conectar o banco de dados
        public static MySqlConnection getConnection()
        {
            //acessando a string de conexão
            string banco = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;
            
            return new MySqlConnection(banco);
        }

    }
}
