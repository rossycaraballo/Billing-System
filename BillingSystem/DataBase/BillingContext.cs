using BillingSystem.Modelos;
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
        public virtual DbSet<Vendedor> Vendedor { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<FormaPago> FormaPago { get; set; }
        public virtual DbSet<EstadoPago> EstadoPago { get; set; }
        public virtual DbSet<CondicionesPago> CondicionesPago { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
    }
}
