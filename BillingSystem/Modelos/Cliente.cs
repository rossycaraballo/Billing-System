using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Modelos
{
    public  class Cliente
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Documento { get; set; }

        [Required]
        public string Cuenta { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public int IdTipoDocumento { get; set; }

        [ForeignKey("IdTipoDocumento")]
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}
