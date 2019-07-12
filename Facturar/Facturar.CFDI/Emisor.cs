using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Facturar.CFDI
{
   public class Emisor
    {
        private string _Rfc="";
        private string _nombre="";
        private string _regimenFiscal;

        public Emisor(string rfc, string regimenFiscal, string nombre="")
        {
            Rfc = rfc;
            Nombre = nombre;
            RegimenFiscal = regimenFiscal;
        }

        [Required]
        [StringLength(13)]
        public string Rfc { get => _Rfc; set => _Rfc = value; }
        [StringLength(254)]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [Required]
        [StringLength(3)]
        public string RegimenFiscal { get => _regimenFiscal; set => _regimenFiscal = value; }

       


    }
}
