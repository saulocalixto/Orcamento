using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentoSaulo
{
    [Table("Despesas")]
    public class Despesa
    {
        private CultureInfo ptBR = CultureInfo.CreateSpecificCulture("pt-BR");
        public String tipo { get; set; }
        public String descricao { get; set; }
        public String data { get; set; }
        public double valor { get; set; }
        [Key]
        public int mes { get; set; }

        public override string ToString()
        {
            return descricao + "  --  R$" + string.Format(ptBR, "{0:0,0.00}", valor);
        }
    }
}
