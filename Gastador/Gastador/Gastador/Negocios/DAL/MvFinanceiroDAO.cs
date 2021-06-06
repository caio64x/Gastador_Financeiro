using Dapper;

using Gastador.Negocios.Mapeamento;
using Gastador;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System;

namespace Gastador.Negocios.DAL
{
    public class MvFinanceiroDAO : Conexao
    {
        SqlConnection banco;

        public MvFinanceiroDAO()
        {
            this.banco = Conexao.getConnection();
        }


       // funciona
        public List<MvFinanceiro> Listar(string nome, string mes)
        {
            DateTime.Now.ToString("yyyy'-'MM'-'dd");
            //            return banco.Query<MvFinanceiro>(@"SELECT * FROM MvFinanceiros
            //WHERE Nome LIKE '%" + nome + "%' Order By Nome").ToList();
            if (mes == "MÊ")
                mes = DateTime.Now.Month.ToString();
            
            
            
            return banco.Query<MvFinanceiro>(@"select mv.*, fi.Nome as NomeFinanceiroTipo, ti.Nome as NomeFinanceiro,ti.ID as IDFinanceiroTipo from MvFinanceiros mv join Financeiros fi on mv.IDFinanceiro = fi.ID 
            join FinanceiroTipos ti on fi.IDFinanceiroTipo = ti.ID
            WHERE  MONTH (mv.DataVencimento) = '" + mes + "' and fi.Nome LIKE '%" + nome + "%'").ToList();

            // WHERE fi.Nome LIKE '%" + nome + "%' or ti.Nome LIKE '%" + nome + "%' or mv.Descricao LIKE '%" + nome + "%'Order By fi.Nome and MONTH (mv.DataVencimento) = '" + mes + "'").ToList();
        }



        public MvFinanceiro Buscar(int id)
        {
            return banco.Query<MvFinanceiro>(@"SELECT * FROM MvFinanceiros WHERE ID = @id", new { id }).SingleOrDefault();
        }



        public bool Excluir(int id)
        {
            return banco.Execute(@"DELETE FROM MvFinanceiros WHERE ID = @xxxxxx", new { xxxxxx = id }) == 1;
        }



        public int Salvar(MvFinanceiro financeiro)
        {
            if (financeiro.ID == 0)
            {
                //se o id for zero, é inclusão
                return banco.Query<int>(
                "INSERT INTO MvFinanceiros (IDFinanceiro, Descricao, DataVencimento, Valor) values " +
                "(@IDFinanceiro, @Descricao, @DataVencimento, @Valor) " +
                "select @@Identity", financeiro).SingleOrDefault();

            }
            else
            {
                //update
                if (banco.Execute("UPDATE MvFinanceiros SET " +
                "IDMvFinanceiroTipo = @IDMvFinanceiroTipo, Nome = @Nome, Ativo = @Ativo " +
                "WHERE ID = @ID", financeiro) == 1)
                    return financeiro.ID;
                else
                    return 0;
            }
        }
    }
}