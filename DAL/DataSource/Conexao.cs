using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using DAL.Model;

namespace DAL.DataSource
{
    public class Conexao : DbContext
    {
        public Conexao() : base(ConfigurationManager.ConnectionStrings["Orcamento"].ConnectionString)
        {
            var ensureDLLIsCopied =
               System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Orcamento> orcamento { get; set; }
        public DbSet<Despesa> despesa { get; set; }
    }
}
