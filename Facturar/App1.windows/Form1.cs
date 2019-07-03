using Facturar.CFDI;
using Facturar.CFDI.Catalogos;
using Facturar.CFDI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1.windows
{
    public partial class Form1 : Form
    {

        //Comprobante comprobante;
        List<c_FormaPago> formaPagos = new List<c_FormaPago>();
        C_FormaPagoAD ad;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formaPagos = new List<c_FormaPago>();
            ad = new C_FormaPagoAD();
            formaPagos = ad.ListaFormaPago();


            this.comboBox1.DataSource = formaPagos;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.ValueMember = "Id";

        }
    }
}
