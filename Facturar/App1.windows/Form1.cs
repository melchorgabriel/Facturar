using Facturar.CFDI;
using Facturar.CFDI.Catalogos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App1.windows
{
    public partial class Form1 : Form
    {

        Comprobante comprobante;
        
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            c_FormaPago cfp = new c_FormaPago();
            this.comboBox1.DataSource = cfp.Lista();
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.ValueMember = "Id";

            C_Aduana ca = new C_Aduana();
            this.comboBox2.DataSource = ca.Lista();
            this.comboBox2.DisplayMember = "Descripcion";
            this.comboBox2.ValueMember = "Id";

            C_ClaveProdServ ccps = new C_ClaveProdServ();
            this.comboBox3.DataSource = ccps.Lista();
            this.comboBox3.DisplayMember = "Descripcion";
            this.comboBox3.ValueMember = "Id";

            C_ClaveUnidad ccu = new C_ClaveUnidad();
            this.comboBox4.DataSource = ccu.Lista();
            this.comboBox4.DisplayMember = "Nombre";
            this.comboBox4.ValueMember = "Id";


        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            comprobante = new Comprobante();
            comprobante.Serie=
        }
    }
}
