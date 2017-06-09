using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Modelos
{
    public  class TipoDocumento
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public string Tipo { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
