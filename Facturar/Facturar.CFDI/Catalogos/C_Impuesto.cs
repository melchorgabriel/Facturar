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
    public class C_Impuesto
    {
        [Required]
        [Key]
        [StringLength(3)]
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string Retencion { get; set; }
        public string Traslado { get; set; }
        public string LocalOFederal { get; set; }
        public string EntidadEnLaQueAplica { get; set; }
        public xEstatus Estatus { get; set; }

        public List<C_Impuesto> Lista()
        {
            List<C_Impuesto> resultado = new List<C_Impuesto>();
            string json = File.ReadAllText(Environment.CurrentDirectory + "\\jSon\\c_Impuesto.json");

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(new C_Impuesto
                {
                    Id = row["id"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    Retencion = row["retencion"].ToString(),
                    Traslado = row["traslado"].ToString(),
                    LocalOFederal = row["localOFederal"].ToString(),
                    EntidadEnLaQueAplica = row["entidadEnLaQueAplica"].ToString(),
                    Estatus = enums.xEstatus.Activo,
                });
            }

            return resultado;
        }
    }
}
