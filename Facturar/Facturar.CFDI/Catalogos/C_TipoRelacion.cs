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
    public class C_TipoRelacion
    {
        [Required]
        [Key]
        [StringLength(1)]
        public String Id { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaInicioDeVigencia { get; set; }
        public DateTime? FechaFinDeVigencia { get; set; }
        public xEstatus Estatus { get; set; }



        public List<C_TipoRelacion> Lista()
        {
            List<C_TipoRelacion> resultado = new List<C_TipoRelacion>();
            string json = File.ReadAllText(Environment.CurrentDirectory + "\\jSon\\c_TipoDeComprobante.json");

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(new C_TipoRelacion
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
