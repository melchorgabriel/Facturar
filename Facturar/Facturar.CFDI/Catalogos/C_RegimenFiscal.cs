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
    public class C_RegimenFiscal
    {

        [Required]
        [Key]
        [StringLength(3)]
        public String Id { get; set; }
        public String Descripcion { get; set; }
        public String Fisica { get; set; }
        public String Moral { get; set; }
        public DateTime FechaDeInicioDeVigencia { get; set; }
        public DateTime FechaDeFinDeVigencia { get; set; }
        public xEstatus Estatus { get; set; }


        public List<C_RegimenFiscal> Lista()
        {
            List<C_RegimenFiscal> resultado = new List<C_RegimenFiscal>();
            string json = File.ReadAllText(Environment.CurrentDirectory + "\\jSon\\c_RegimenFiscal.json");

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(new C_RegimenFiscal
                {
                    Id = row["id"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    Fisica = row["fisica"].ToString(),
                    Moral = row["moral"].ToString(),
                    FechaDeInicioDeVigencia = DateTime.Parse(row["fechaDeInicioDeVigencia"].ToString()),
                    FechaDeFinDeVigencia = (row["fechaDeFinDeVigencia"].ToString() == "") ? DateTime.Now : DateTime.Parse(row["fechaDeFinDeVigencia"].ToString()),
                    Estatus = enums.xEstatus.Activo,
                });
            }

            return resultado;
        }
    }
}
