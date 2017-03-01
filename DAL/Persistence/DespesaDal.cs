using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSource;
using DAL.Model;

namespace DAL.Persistence
{
    public class DespesaDal
    {
        public Conexao con;

        public DespesaDal()
        {
            con = new Conexao();
        }

        public void addDespesa(Despesa D)
        {
            if(D != null)
            {
                con.despesa.Add(D);
                con.SaveChanges();
            }
            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            con.Dispose();
        }
    }
}
