using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Facturar.CFDI
{
    public class Receptor
    {

        private string _rfc = "";
        private string _nombre = "";
        private string _residenciaFiscal = "";
        private string _numRegIdTrib = "";
        private string _usoCFDI = "";

        public Receptor(string rfc, string usoCFDI, string nombre="", string residenciaFiscal="", string numRegIdTrib="")
        {
            Rfc = rfc;
            Nombre = nombre;
            ResidenciaFiscal = residenciaFiscal;
            NumRegIdTrib = numRegIdTrib;
            UsoCFDI = usoCFDI;
        }

        [Required]
        [StringLength(13)]
        public string Rfc { get => _rfc; set => _rfc = value; }
        [StringLength(254)]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [StringLength(3)]
        public string ResidenciaFiscal { get => _residenciaFiscal; set => _residenciaFiscal = value; }
        [StringLength(40)]
        public string NumRegIdTrib { get => _numRegIdTrib; set => _numRegIdTrib = value; }
        [Required]
        [StringLength(3)]
        public string UsoCFDI { get => _usoCFDI; set => _usoCFDI = value; }




        


    }
}
