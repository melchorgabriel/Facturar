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
   public  class C_Moneda
    {
        [Required]
        [Key]
        [StringLength(3)]
        public String Id { get; set; }
        public String Descripcion { get; set; }
        public String Decimales { get; set; }
        public String PorcentajeVariacion { get; set; }
        public DateTime FechaInicioDeVigencia { get; set; }
        public DateTime? FechaFinDeVigencia { get; set; }
        public xEstatus Estatus { get; set; }

        public List<C_Moneda> Lista()
        {
            List<C_Moneda> resultado = new List<C_Moneda>();
            string json = File.ReadAllText(Environment.CurrentDirectory + "\\jSon\\c_Moneda.json");

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(new C_Moneda
                {
                    Id = row["id"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    Decimales = row["decimales"].ToString(),
                    PorcentajeVariacion = row["porcentajeVariacion"].ToString(),
                    FechaInicioDeVigencia = DateTime.Parse(row["fechaInicioDeVigencia"].ToString()),
                    FechaFinDeVigencia = (row["fechaFinDeVigencia"].ToString() == "") ? DateTime.Now : DateTime.Parse(row["fechaFinDeVigencia"].ToString()),
                    Estatus = enums.xEstatus.Activo,
                });
            }

            return resultado;
        }
    }
}
