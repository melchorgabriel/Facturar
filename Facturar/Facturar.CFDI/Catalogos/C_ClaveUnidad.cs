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
    public class C_ClaveUnidad
    {
        [Required]
        [Key]
        [StringLength(2)]
        public String Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Nota { get; set; }
        public String Simbolo { get; set; }
        public DateTime FechaDeInicioDeVigencia { get; set; }
        public DateTime? FechaDeFinDeVigencia { get; set; }
        public xEstatus Estatus { get; set; }



        public List<C_ClaveUnidad> Lista()
        {
            List<C_ClaveUnidad> resultado = new List<C_ClaveUnidad>();
            string json = File.ReadAllText(Environment.CurrentDirectory + "\\jSon\\c_ClaveUnidad.json");

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(new C_ClaveUnidad
                {
                    Id = row["id"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    Nota = row["nota"].ToString(),
                    Simbolo = row["simbolo"].ToString(),
                    FechaDeInicioDeVigencia = DateTime.Parse(row["fechaDeInicioDeVigencia"].ToString()),
                    FechaDeFinDeVigencia = (row["fechaDeFinDeVigencia"].ToString() == "") ? DateTime.Now : DateTime.Parse(row["fechaFinDeVigencia"].ToString()),
                    Estatus = enums.xEstatus.Activo,
                });
            }

            return resultado;
        }
    }
}
