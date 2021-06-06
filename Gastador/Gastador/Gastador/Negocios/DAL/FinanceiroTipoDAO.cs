using Dapper;

using Gastador.Negocios.Mapeamento;
using Gastador;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace Gastador.Negocios.DAL
{
    public class FinanceiroTipoDAO : Conexao
    {
        SqlConnection banco;

        public FinanceiroTipoDAO()
        {
            this.banco = Conexao.getConnection();
        }

        public List<FinanceiroTipo> ListarParaCombo()
        {
            
                return banco.Query<FinanceiroTipo>(@"SELECT * FROM FinanceiroTipos Order By Nome").ToList();
        }
        //funciona
        //public List<FinanceiroTipo> Listar(string nome)
        //{
        //    return banco.Query<FinanceiroTipo>(@"SELECT * FROM FinanceiroTipos
        //    WHERE Nome LIKE '%" + nome + "%' Order By Nome").ToList();
        //}



        //public FinanceiroTipo Buscar(int id)
        //{
        //    return banco.Query<FinanceiroTipo>(@"SELECT * FROM FinanceiroTipos WHERE ID = @id", new { id }).SingleOrDefault();
        //}


        
    }
}