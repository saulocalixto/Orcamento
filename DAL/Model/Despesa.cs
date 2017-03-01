using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("despesa")]
    public class Despesa
    {
        private CultureInfo ptBR = CultureInfo.CreateSpecificCulture("pt-BR");

        [Column("Mes")]
        public int mes { get; set; }

        [Column("Tipo")]
        public String tipo { get; set; }

        [Column("Descrição")]
        public String descricao { get; set; }

        [Column("Data")]
        public String data { get; set; }

        [Column("Valor")]
        public double valor { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("numDespesa")]
        public int numDespesa { get; set; }

        public override string ToString()
        {
            return descricao + "  --  " + string.Format(ptBR, "{0:0,0.00}", valor);
        }
    }
}
