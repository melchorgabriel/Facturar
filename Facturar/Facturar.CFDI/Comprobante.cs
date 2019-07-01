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

        [StringLength(1000)]
        public String CondicionesDePago { get; set; }

        [Required]
        public Double SubTotal { get; set; }

        public Double Descuento { get; set; }

        [Required]
        public int Moneda { get; set; } // catalogo monedas

        public Double TipoCambio { get; set; }

        [Required]
        public Double Total { get; set; }

        [Required]
        public int TipoDeComprobante { get; set; } // catalogo tipo comprobante

        public int MetodoPago { get; set; } // catalogo metodo pago

        [Required]
        public int LugarExpedicion { get; set; } // catalogo codigo Postal

        [StringLength(5)]
        public String Confirmacion { get; set; }
   

        private CfdiRelacionados _CfdiRelacionados;
        private Emisor _emisor;
        
        public void CfdiRelacionados(int tipoRelacion)
        {
            _CfdiRelacionados = new  CfdiRelacionados(tipoRelacion);
        }
        public CfdiRelacionados CfdiRelacionados()
        {
            return _CfdiRelacionados;
        }

        public void Emisor()
        {

        }


    }
}
