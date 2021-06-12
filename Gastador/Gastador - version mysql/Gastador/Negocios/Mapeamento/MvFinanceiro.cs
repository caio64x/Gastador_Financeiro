using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gastador.Negocios.Mapeamento
{
    public class MvFinanceiro
    {
        public int ID { get; set; }
        public int IDFinanceiro { get; set; }
        public string Pago { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataConfirmacao { get; set; }
        public decimal Valor { get; set; }

        //
        public int    IDFinanceiroTipo { get; set; }
        public string NomeFinanceiro { get; set; }
        public string NomeFinanceiroTipo { get; set; }
        public int Ano { get; set; }
    }
}
