using Facturar.CFDI.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Facturar.CFDI.Catalogos
{
    public class c_FormaPago
    {
        [Required]
        [Key]
        [StringLength(2)]
        public String Id { get; set; }
        public String Descripcion { get; set; }
        public xEstatus Estatus { get; set; }
    }
}
