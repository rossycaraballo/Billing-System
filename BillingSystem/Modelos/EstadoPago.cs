using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Modelos
{
    public class EstadoPago
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Estado { get; set; }
    }
}
