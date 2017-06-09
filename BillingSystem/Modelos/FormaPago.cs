using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Modelos
{
    public class FormaPago
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string TipoFormaPago { get; set; }

    }
}
