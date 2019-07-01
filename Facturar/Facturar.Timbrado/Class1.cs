using System;
using Facturar.CFDI;
namespace Facturar.Timbrado
{
    public class Class1
    {


        Comprobante comprobante;

        public Class1( )
        {
            comprobante = new Comprobante();

            comprobante.CfdiRelacionados(1);
            comprobante.CfdiRelacionados().CfdiRelacionado("1");
            comprobante.CfdiRelacionados().CfdiRelacionado("1");

        }



    }
}
