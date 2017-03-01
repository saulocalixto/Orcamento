using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace DAL.Model
{
    [Table("orcamento")]
    public class Orcamento
    {
        private CultureInfo ptBR = CultureInfo.CreateSpecificCulture("pt-BR");

        
        [Column("Mes")]
        public int mes { get; set; }

        [Column("Bruto")]
        public double bruto { get; set; }

        [Column("Liquido")]
        public double liquido { get; private set; }

        [Column("TotalDespesa")]
        public double totalDespesa { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("NumeroOrc")]
        public int numeroOrc { get; set; }

        private string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril",
        "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
        private List<Despesa> despesas = new List<Despesa>();


        public void setDespesas(Despesa despesa)
        {
            this.despesas.Add(despesa);
        }

        public double getLiquido()
        {
            return liquido = bruto - getDespesasTotal();
        }

        public double getDespesasTotal()
        {

            foreach (Despesa despesa in despesas)
            {
                totalDespesa += despesa.valor;
            }

            return totalDespesa;
        }

        public List<Despesa> getDespesa()
        {
            return despesas;
        }

        public override string ToString()
        {
            return meses[mes] + " -- " + "R$ " + string.Format(ptBR, "{0:0,0.00}", bruto);
        }
    }
}
