using Facturar.CFDI.Catalogos;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Data;

namespace Facturar.CFDI.Data
{
    public class C_FormaPagoAD
    {
     

        public C_FormaPagoAD()
        {
        }

        public List<c_FormaPago> ListaFormaPago ()
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
                    Estatus = enums.xEstatus.Activo,
                });
            }

            return resultado;
        }


    }
}
