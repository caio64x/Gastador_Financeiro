using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gastador.Negocios.Mapeamento
{
    public class Financeiro
    {
        public int ID { get; set; }
        public int IDFinanceiroTipo { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        //
        public string FinanceiroTipoNome { get; set; }
        
    }
}