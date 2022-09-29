using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengeFactura
{
    public partial class Form1 : Form
    {
        int orden = 1;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPaciente.Text) && !string.IsNullOrEmpty(txtServicios.Text) && !string.IsNullOrEmpty(txtImporte.Text))
            {
                Factura obj = new Factura() { Id = orden++, Fecha = dateTimePicker1.Value.ToString("MM-dd-yyyy"), Paciente = txtPaciente.Text, Servicios = txtServicios.Text, Importe = Convert.ToDouble(txtImporte.Text) };
                total += obj.Importe * 1;
                facturaBindingSource2.Add(obj);
                facturaBindingSource2.MoveLast();
                txtPaciente.Text = string.Empty;
                txtServicios.Text = string.Empty;
                txtImporte.Text = string.Empty;
                txtTotal.Text = string.Format("${0}", total);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            facturaBindingSource2.DataSource = new List<Factura>();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Factura obj = facturaBindingSource2.Current as Factura;
            if(obj != null)
            {
                total -= obj.Importe * 1;
                txtTotal.Text = string.Format("${0}", total);
            }
            facturaBindingSource2.RemoveCurrent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.oesteserviciossociales.com/");
        }

      
    }
}
