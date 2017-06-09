using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Modelos
{
   
    public class Factura
    {
        public int Id { get; set; }

        [Required]
        public int IdFormaPago { get; set; }

        [ForeignKey("IdFormaPago")]
        public virtual  FormaPago FormaPago { get; set; }

        [Required]
        public int IdVendedor { get; set; }

        [ForeignKey("IdVendedor")]
        public virtual Vendedor Vendedor { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [MaxLength(500)]
        public string Comentario { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }

    }
}
