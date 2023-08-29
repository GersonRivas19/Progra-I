using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcialPrograI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Gerson Geovanni Guevara Rivas USSS015323

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;

            de = cboDeConversor.SelectedIndex;

            a = cboAConversor.SelectedIndex;

            cantidad = double.Parse(txtCantidad.Text);

             double[] superficies = { 0.09290304, 0.698896,  0.836127, 1, 437.5, 7000, 10000, };


            respuesta = superficies[de] / superficies[a] * cantidad;

            lblRespuesta.Text = "La conversión es: " + Math.Round(respuesta, 2);

        
        }
    }
}