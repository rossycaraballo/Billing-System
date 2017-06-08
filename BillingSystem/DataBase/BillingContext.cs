using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.DataBase
{
    public class BillingContext : DbContext
    {

        public BillingContext()
            : base("name=Default")
        {

            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
        }


        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
    }
}
