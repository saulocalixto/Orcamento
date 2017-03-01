using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSource;
using DAL.Model;

namespace DAL.Persistence
{
    public class OrcamentoDal : IDisposable
    {

        public Conexao con;

        public OrcamentoDal()
        {
            con = new Conexao();
        }

        public void addOrcamento(Orcamento O)
        {
            con.orcamento.Add(O);
            con.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            con.Dispose();
        }
    }
}
