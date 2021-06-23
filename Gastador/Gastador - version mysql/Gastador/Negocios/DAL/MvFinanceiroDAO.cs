using Dapper;
using MySql.Data.MySqlClient;

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
        MySqlConnection banco;

        public MvFinanceiroDAO()
        {
            this.banco = Conexao.getConnection();
        }


        // consulta com filtro por mes
        public List<MvFinanceiro> Listar(string nome, string mes, int ano)
        {
            if (mes == "MÊ")
                mes = DateTime.Now.Month.ToString();

            return banco.Query<MvFinanceiro>(@"select mv.*, fi.Nome as NomeFinanceiroTipo, ti.Nome as NomeFinanceiro,ti.ID as IDFinanceiroTipo from MvFinanceiros mv join Financeiros fi on mv.IDFinanceiro = fi.ID 
            join FinanceiroTipos ti on fi.IDFinanceiroTipo = ti.ID
            WHERE  MONTH (mv.DataVencimento) = '" + mes + "' and YEAR (mv.DataVencimento) = '" + ano + "' and fi.Nome LIKE '%" + nome + "%' or mv.Descricao LIKE '%" + nome + "%' order by mv.id DESC, mv.DataVencimento ").ToList();
        }

        public List<MvFinanceiro> ListarPagos(string mes, int ano)
        {
            if (mes == "MÊ")
                mes = DateTime.Now.Month.ToString();

            return banco.Query<MvFinanceiro>(@"select mv.*, fi.Nome as NomeFinanceiroTipo, ti.Nome as NomeFinanceiro,ti.ID as IDFinanceiroTipo from MvFinanceiros mv join Financeiros fi on mv.IDFinanceiro = fi.ID 
            join FinanceiroTipos ti on fi.IDFinanceiroTipo = ti.ID
            WHERE  MONTH (mv.DataVencimento) = '" + mes + "' and YEAR (mv.DataVencimento) = '" + ano + "'  order by mv.id DESC, mv.DataVencimento").ToList();
        }


        //consulta geral
        public MvFinanceiro Buscar(int ID)
        {
            return banco.Query<MvFinanceiro>(@"SELECT * FROM MvFinanceiros WHERE ID = @id", new { id = ID }).SingleOrDefault();
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
                "(@IDFinanceiro, @Descricao, @DataVencimento, @Valor);" +
                "SELECT  LAST_INSERT_ID(); ", financeiro).SingleOrDefault();

            }
            else
            {
                //update se ja existir
                if (banco.Execute("UPDATE MvFinanceiros SET " +
                "IDFinanceiro = @IDFinanceiro, Descricao = @Descricao, DataVencimento = @DataVencimento, Valor = @Valor " +
                "WHERE ID = @ID", financeiro) == 1)
                    return financeiro.ID;
                else
                    return 0;
            }
        }

        public void Pagamento(MvFinanceiro mvFinanceiro)
        {
            //confirma pagamento
            if (mvFinanceiro.Pago == "N" || mvFinanceiro.Pago == null)
            {

                DateTime mes = DateTime.Now.Date;
                string data = DateTime.Now.Date.ToString("yyyy/MM/dd");
                //se o pagamento estiver atrasado atualiza data de vencimento e confirmação
                if (mvFinanceiro.DataVencimento < mes)
                {
                    string vencimento = mvFinanceiro.DataVencimento.ToString().Substring(0, 10);

                    mvFinanceiro.Descricao = (mvFinanceiro.Descricao + " " + "| Confirmação de pagamento atrasada " +
                    " Data de vencimento anterior: " + vencimento).ToString().Trim();

                    banco.Execute("UPDATE MvFinanceiros SET " +
                    "DataConfirmacao = '" + data + "', DataVencimento = '" + data + "', Descricao = '" + mvFinanceiro.Descricao + "', Pago = 'S' " +
                    "WHERE ID = @ID", mvFinanceiro);
                }
                else
                {
                    //se nao, atualiza somente a data de confirmação
                    banco.Execute("UPDATE MvFinanceiros SET " +
                    "DataConfirmacao = '" + data + "', Pago = 'S' " +
                    "WHERE ID = @ID", mvFinanceiro);
                }

            }

            //  estorna o pagamento
            if (mvFinanceiro.Pago == "S")
            {
                //update
                banco.Execute("UPDATE MvFinanceiros SET " +
                 "DataConfirmacao = null, Pago = 'N' " +
                 "WHERE ID = @ID", mvFinanceiro);
            }
        }
    }
}