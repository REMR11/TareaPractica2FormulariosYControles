using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFormularioControles
{
    public partial class calculadoraIntereses : Form
    {
        public calculadoraIntereses()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarar las variables para guardar entrada del usuario
            decimal principal;
            double tasa;
            int anio;
            decimal monto;
            string salida;

            principal = Convert.ToDecimal(txtPrincipal.Text);
            tasa = Convert.ToDouble(txtIntereses.Text);
            anio = Convert.ToInt32(numAnio.Value);

            salida = "Año\tMonto en Deposito\r\n";

            for (int i = 1; i < anio; i++)
            {
                monto = principal * ((decimal)Math.Pow((1 + tasa / 100), i));
                salida += (i + "\t" + String.Format("{0:C}", monto) + "\r\n");
            }

            txtMostrarResultado.Text = salida;
        }
    }
}
