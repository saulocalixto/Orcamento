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
    [Table("Orcamento")]
    public class Orcamento1
    {
        private CultureInfo ptBR = CultureInfo.CreateSpecificCulture("pt-BR");
        public double bruto { get; set; }
        public double liquido = 0;
        [Key]
        public int mes { get; set; }
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
            double totalDespesa = 0;

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

        public void addReceita(double novaReceita)
        {
            bruto += novaReceita;
        }
    }
}
