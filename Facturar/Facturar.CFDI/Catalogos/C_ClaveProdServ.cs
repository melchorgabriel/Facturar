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
   public  class C_ClaveProdServ
    {
        [Required]
        [Key]
        [StringLength(2)]
        public String Id { get; set; }
        public String Descripcion { get; set; }
        public String IncluirIVATrasladado { get; set; }
        public String IncluirIEPSTrasladado { get; set; }
        public String ComplementoQueDebeIncluir { get; set; }
        public String EstimuloFranjaFronteriza { get; set; }
        public String PalabrasSimilares { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }


        public xEstatus Estatus { get; set; }


        public List<C_ClaveProdServ> Lista()
        {
            List<C_ClaveProdServ> resultado = new List<C_ClaveProdServ>();
            string json = File.ReadAllText(Environment.CurrentDirectory + "\\jSon\\c_ClaveProdServ.json");

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(new C_ClaveProdServ
                {
                    Id = row["id"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    IncluirIVATrasladado = row["incluirIVATrasladado"].ToString(),
                    IncluirIEPSTrasladado = row["incluirIEPSTrasladado"].ToString(),
                    ComplementoQueDebeIncluir = row["complementoQueDebeIncluir"].ToString(),
                    EstimuloFranjaFronteriza = row["estimuloFranjaFronteriza"].ToString(),
                    PalabrasSimilares = row["palabrasSimilares"].ToString(),
                    FechaInicioVigencia = DateTime.Parse(row["fechaInicioVigencia"].ToString()),
                    FechaFinVigencia = (row["fechaFinVigencia"].ToString() == "") ? DateTime.Now : DateTime.Parse(row["fechaFinDeVigencia"].ToString()),
                    Estatus = enums.xEstatus.Activo,
                });
            }

            return resultado;
        }
    }
}
