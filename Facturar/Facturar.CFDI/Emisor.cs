using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Facturar.CFDI
{
   public class Emisor
    {
        public Emisor()
        {
        }

        public Emisor(string rfc, int regimenFiscal, string nombre = "")
        {
            Rfc = rfc;
            Nombre = nombre;
            RegimenFiscal = regimenFiscal;
        }

        [Required]
        public String Rfc { get; set; }

        [StringLength(254)]
        public String Nombre { get; set; }

        [Required]
        public int RegimenFiscal { get; set; }// catalogo codigo Postal

       
    }
}
