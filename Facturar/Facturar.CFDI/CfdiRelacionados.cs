using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Facturar.CFDI
{
    public class CfdiRelacionados
    {
        public CfdiRelacionados(int tipoRelacion)
        {
            TipoRelacion = tipoRelacion;
        }
        public CfdiRelacionados()
        {
        }

        private List<CfdiRelacionado> _CfdiRelacionado = new List<CfdiRelacionado>();

        [Required]
        public int TipoRelacion { get; set; } // catalogo forma de pago

        public void CfdiRelacionado(string UUID)
        {
             _CfdiRelacionado.Add(new CFDI.CfdiRelacionado(UUID));
        }
        public void CfdiRelacionado(CfdiRelacionado cfdiRelacionado)
        {
            _CfdiRelacionado.Add(cfdiRelacionado);
        }
        public CfdiRelacionado CfdiRelacionado(int index)
        {
            return _CfdiRelacionado[index];
        }
        public List<CfdiRelacionado> CfdiRelacionado()
        {
            return _CfdiRelacionado;
        }
    }
    public class CfdiRelacionado
    {
        public CfdiRelacionado()
        {
        }

        public CfdiRelacionado(string uUID)
        {
            UUID = uUID ?? throw new ArgumentNullException(nameof(uUID));
        }

        [Required]
        [StringLength(36, MinimumLength = 36)]
        public String UUID { get; set; }
    }

}
