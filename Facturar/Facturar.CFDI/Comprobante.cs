using System;
using System.Collections.Generic;
using System.Text;

namespace Facturar.CFDI
{
   public  class Comprobante
    {

        [StringLength]
        public string Version { get { return "3.3"; } }
        public int Serie { get; set; }
        public int Folio { get; set; }
        public int Fecha { get; set; }
        public int Sello { get; set; }
        public int FormaPago { get; set; }
        public int NoCertificado { get; set; }
        public int Certificado { get; set; }
        public int CondicionesDePago { get; set; }
        public int SubTotal { get; set; }
        public int Descuento { get; set; }
        public int Moneda { get; set; }
        public int TipoCambio { get; set; }
        public int Total { get; set; }
        public int TipoDeComprobante { get; set; }
        public int MetodoPago { get; set; }
        public int LugarExpedicion { get; set; }
        public int Confirmacion { get; set; }
    }
}
