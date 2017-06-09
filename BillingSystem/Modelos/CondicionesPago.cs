using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Modelos
{
    public class CondicionesPago
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descripcion { get; set; }

        
        [Required]
        public int CantidadDias { get; set; }

        [Required]
        public int IdFactura { get; set; }

        [ForeignKey("IdFactura")]
        public virtual Factura Factura { get; set; }

        [Required]
        public int IdEstadoPago { get; set; }

        [ForeignKey("IdEstadoPago")]
        public virtual EstadoPago EstadoPago { get; set; }
    }
}
