using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Facturar.CFDI
{
   public  class Comprobante
    {

        
        public string Version { get { return "3.3"; } }

        [StringLength(25,MinimumLength =1)]
        public String Serie { get; set; }

        [StringLength(40, MinimumLength = 1)]
        public String Folio { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public String Sello { get; set; }


        public int FormaPago { get; set; }// catalogo forma de pago

        [Required]
        [StringLength(40)]
        public String NoCertificado { get; set; }

        [Required]
        public String Certificado { get; set; }

        public int CondicionesDePago { get; set; }
        [Required]
        public int SubTotal { get; set; }
        public int Descuento { get; set; }
        [Required]
        public int Moneda { get; set; }
        public int TipoCambio { get; set; }
        [Required]
        public int Total { get; set; }
        [Required]
        public int TipoDeComprobante { get; set; }
        public int MetodoPago { get; set; }
        [Required]
        public int LugarExpedicion { get; set; }
        public int Confirmacion { get; set; }
    }
}
