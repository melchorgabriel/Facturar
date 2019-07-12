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
    public class C_MetodoPago
    {
        [Required]
        [Key]
        [StringLength(3)]
        public String Id { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaInicioDeVigencia { get; set; }
        public DateTime? FechaFinDeVigencia { get; set; }
        public xEstatus Estatus { get; set; }

        public List<C_MetodoPago> Lista()
        {
            List<C_MetodoPago> resultado = new List<C_MetodoPago>();
            string json = File.ReadAllText(Environment.CurrentDirectory + "\\jSon\\c_MetodoPago.json");

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(new C_MetodoPago
                {
                    Id = row["id"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    FechaInicioDeVigencia = DateTime.Parse(row["fechaInicioDeVigencia"].ToString()),
                    FechaFinDeVigencia = (row["fechaFinDeVigencia"].ToString() == "") ? DateTime.Now : DateTime.Parse(row["fechaFinDeVigencia"].ToString()),
                    Estatus = enums.xEstatus.Activo,
                });
            }

            return resultado;
        }
    }
}
