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


        // consulta com filtro por mes
        public List<MvFinanceiro> Listar(string nome, string mes)
        {

            if (mes == "MÊ")
                mes = DateTime.Now.Month.ToString();

            return banco.Query<MvFinanceiro>(@"select mv.*, fi.Nome as NomeFinanceiroTipo, ti.Nome as NomeFinanceiro,ti.ID as IDFinanceiroTipo from MvFinanceiros mv join Financeiros fi on mv.IDFinanceiro = fi.ID 
            join FinanceiroTipos ti on fi.IDFinanceiroTipo = ti.ID
            WHERE  MONTH (mv.DataVencimento) = '" + mes + "' and fi.Nome LIKE '%" + nome + "%'").ToList();

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
                "(@IDFinanceiro, @Descricao, @DataVencimento, @Valor) " +
                "select @@Identity", financeiro).SingleOrDefault();

            }
            else
            {
                //update
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
            if (mvFinanceiro.Pago == "N")
            {

                DateTime mes = Convert.ToDateTime(DateTime.Now.Date.ToShortDateString());
                //se o pagamento estiver atrasado atualiza data de vencimento e confirmação
                if (mvFinanceiro.DataVencimento < mes)
                {
                    string vencimento = mvFinanceiro.DataVencimento.ToString().Substring(0, 10);

                    mvFinanceiro.Descricao = (mvFinanceiro.Descricao + " " + "| Confirmação de pagamento atrasada " +
                    " Data de vencimento anterior: " + vencimento).ToString().Trim();

                    banco.Execute("UPDATE MvFinanceiros SET " +
                    "DataConfirmacao = '" + mes + "', DataVencimento = '" + mes + "', Descricao = '" + mvFinanceiro.Descricao + "', Pago = 'S' " +
                    "WHERE ID = @ID", mvFinanceiro);
                }
                else
                {
                    //se nao, atualiza somente a data de confirmação
                    banco.Execute("UPDATE MvFinanceiros SET " +
                    "DataConfirmacao = '" + mes + "', Pago = 'S' " +
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