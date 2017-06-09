using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Modelos
{
    public class Producto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public decimal CostoUnitario { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }

        [Required]
        public bool Estado { get; set; }
    }
}
