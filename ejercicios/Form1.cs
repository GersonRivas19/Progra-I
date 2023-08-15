using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ConvertirConversores_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0 , respuesta = 0;
            de = CboDeConversor.SelectedIndex;
            a = CboAConversores.SelectedIndex;

            cantidad = double.Parse(TxtCantidadConversores.Text);

            double [] monedas = {1, 0.92, 7.86, 24.66, 8.75, 36.58, 535.14, 145.47, 0.79, 83.29};
            respuesta = monedas[a] / monedas[de] * cantidad;

            LblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta,3);
        }
    }
}
