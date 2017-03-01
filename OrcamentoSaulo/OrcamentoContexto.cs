using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentoSaulo
{
    class OrcamentoContexto : DbContext
    {
        public OrcamentoContexto() : base ("orcamentos")
        {

        }

        public DbSet<Orcamento1> orcamentos { get; set; }
        public DbSet<Despesa> despesas { get; set; }
    }
}
