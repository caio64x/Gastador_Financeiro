﻿using Dapper;

using Gastador.Negocios.Mapeamento;
using Gastador;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Gastador.Negocios.DAL
{
    public class FinanceiroTipoDAO : Conexao
    {
        MySqlConnection banco;

        public FinanceiroTipoDAO()
        {
            this.banco = Conexao.getConnection();
        }

        public List<FinanceiroTipo> ListarParaCombo()
        {
            return banco.Query<FinanceiroTipo>(@"SELECT * FROM FinanceiroTipos Order By Nome").ToList();
        }
    }
}