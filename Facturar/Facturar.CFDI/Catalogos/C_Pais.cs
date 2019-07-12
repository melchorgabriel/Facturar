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
    public class C_Pais
    {
        [Required]
        [Key]
        [StringLength(3)]
        public String Id { get; set; }
        public String Descripcion { get; set; }
        public String FormatoDeCodigoPostal { get; set; }
        public String FormatoDeRegistroDeIdentidadTributaria { get; set; }
        public String ValidacionDelRegistroDeIdentidadTributaria { get; set; }
        public String Agrupaciones { get; set; }
        public xEstatus Estatus { get; set; }

        public List<C_Pais> Lista()
        {
            List<C_Pais> resultado = new List<C_Pais>();
            string json = File.ReadAllText(Environment.CurrentDirectory + "\\jSon\\c_Pais.json");

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(new C_Pais
                {
                    Id = row["id"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    FormatoDeCodigoPostal = row["formatoDeCodigoPostal"].ToString(),
                    FormatoDeRegistroDeIdentidadTributaria = row["formatoDeRegistroDeIdentidadTributaria"].ToString(),
                    ValidacionDelRegistroDeIdentidadTributaria = row["validacionDelRegistroDeIdentidadTributaria"].ToString(),
                    Agrupaciones = row["agrupaciones"].ToString(),
                    Estatus = enums.xEstatus.Activo,
                });
            }

            return resultado;
        }
    }
}
