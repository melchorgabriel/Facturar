using Facturar.CFDI.enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
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
        public String Bancarizado { get; set; }
        public String NumeroDeOperacion { get; set; }
        public String RFCDelEmisorDeLaCuentaOrdenante { get; set; }
        public String CuentaOrdenante { get; set; }
        public String PatronParaCuentaOrdenante { get; set; }
        public String RFCDelEmisorCuentaDeBeneficiario { get; set; }
        public String CuentaDeBenenficiario { get; set; }
        public String PatronParaCuentaBeneficiaria { get; set; }
        public String TipoCadenaPago { get; set; }
        public String NombreDelBancoEmisorDeLaCuentaOrdenanteEnCasoDeExtranjero { get; set; }
        public DateTime FechaInicioDeVigencia { get; set; }
        public DateTime? FechaFinDeVigencia { get; set; }
      

        public xEstatus Estatus { get; set; }


        public List<c_FormaPago> Lista()
        {
            List<c_FormaPago> resultado = new List<c_FormaPago>();
            string json = File.ReadAllText(Environment.CurrentDirectory + "\\jSon\\c_FormaPago.json");

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(new c_FormaPago
                {
                    Id = row["id"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    Bancarizado = row["bancarizado"].ToString(),
                    NumeroDeOperacion = row["numeroDeOperacion"].ToString(),
                    RFCDelEmisorDeLaCuentaOrdenante = row["rFCDelEmisorDeLaCuentaOrdenante"].ToString(),
                    CuentaOrdenante = row["cuentaOrdenante"].ToString(),
                    PatronParaCuentaOrdenante = row["patronParaCuentaOrdenante"].ToString(),
                    RFCDelEmisorCuentaDeBeneficiario = row["rFCDelEmisorCuentaDeBeneficiario"].ToString(),
                    CuentaDeBenenficiario = row["cuentaDeBenenficiario"].ToString(),
                    PatronParaCuentaBeneficiaria = row["patronParaCuentaBeneficiaria"].ToString(),
                    TipoCadenaPago = row["tipoCadenaPago"].ToString(),
                    NombreDelBancoEmisorDeLaCuentaOrdenanteEnCasoDeExtranjero = row["nombreDelBancoEmisorDeLaCuentaOrdenanteEnCasoDeExtranjero"].ToString(),
                    FechaInicioDeVigencia = DateTime.Parse( row["fechaInicioDeVigencia"].ToString()),
                    FechaFinDeVigencia = (row["fechaFinDeVigencia"].ToString() == "") ? DateTime.Now : DateTime.Parse( row["fechaFinDeVigencia"].ToString()),
                    Estatus = enums.xEstatus.Activo,
                });
            }

            return resultado;
        }


    }



   


}
