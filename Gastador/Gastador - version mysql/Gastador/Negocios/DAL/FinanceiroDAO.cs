using Dapper;

using Gastador.Negocios.Mapeamento;
using Gastador;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Gastador.Negocios.DAL
{
    public class FinanceiroDAO : Conexao
    {
        MySqlConnection banco;

        public FinanceiroDAO()
        {
            this.banco = Conexao.getConnection();
        }

        public List<Financeiro> ListarParaCombo()
        {
            return banco.Query<Financeiro>(@"SELECT fi.ID, concat(ti.Nome, ' | ', fi.Nome) 
            as Nome FROM Financeiros fi join FinanceiroTipos ti on fi.IDFinanceiroTipo = ti.ID where fi.Ativo = 1 Order By ti.Nome").ToList();
        }

        // funciona
        public List<Financeiro> Listar(string nome)
        {
            return banco.Query<Financeiro>(@"SELECT fi.*, ft.Nome as FinanceiroTipoNome FROM Financeiros fi join FinanceiroTipos ft on fi.IDFinanceiroTipo = ft.ID
            WHERE fi.Nome LIKE '%" + nome + "%' Order By ft.Nome").ToList();
        }



        public Financeiro Buscar(int id)
        {
            return banco.Query<Financeiro>(@"SELECT * FROM Financeiros WHERE ID = @id", new { id }).SingleOrDefault();
        }

        public int Salvar(Financeiro financeiro)
        {
            if (financeiro.ID == 0)
            {
                //se o id for zero, é inclusão
                return banco.Query<int>(
                "INSERT INTO Financeiros (IDFinanceiroTipo, Nome, Ativo) values " +
                "(@IDFinanceiroTipo, @Nome, @Ativo); " +
                "SELECT  LAST_INSERT_ID(); ", financeiro).SingleOrDefault();

            }
            else
            {
                //update
                if (banco.Execute("UPDATE Financeiros SET " +
                "IDFinanceiroTipo = @IDFinanceiroTipo, Nome = @Nome, Ativo = @Ativo " +
                "WHERE ID = @ID", financeiro) == 1)
                    return financeiro.ID;
                else
                    return 0;
            }
        }
    }
}