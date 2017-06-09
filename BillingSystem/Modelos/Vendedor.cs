using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Modelos
{
   public class Vendedor
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Nombre { get; set; }

        [Required]
        public decimal PorcientoComision { get; set; }

    
        [Required]
        public string Estado { get; set; }

    }
}
