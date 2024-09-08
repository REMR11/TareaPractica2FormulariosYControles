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
    public partial class PruebaComboBox : Form
    {
        public PruebaComboBox()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Crea objetos graphics, lapiz y pincel
            Graphics miGrafico = CreateGraphics();
            Pen miPen = new Pen(Color.DarkRed);
            SolidBrush miSolidBrush = new SolidBrush(Color.DarkRed);

            miGrafico.Clear(Color.White);

            switch (cmbImagen.SelectedIndex)
            {
                case 0:
                    miGrafico.DrawEllipse(miPen, 280, 200, 150, 150);
                    break;
                case 1:
                    miGrafico.DrawRectangle(miPen, 280, 200, 150, 150);
                    break;
                case 2:
                    miGrafico.DrawEllipse(miPen, 280, 205, 150, 115);
                    break;
                case 3:
                    miGrafico.DrawPie(miPen, 280, 200, 150, 150, 0, 40);
                    break;
                case 4:
                    miGrafico.FillEllipse(miSolidBrush, 280, 200, 150, 150);
                    break;
                case 5:
                    miGrafico.FillRectangle(miSolidBrush, 280, 200, 150, 150);
                    break;
                case 6:
                    miGrafico.FillEllipse(miSolidBrush, 280, 205, 150, 115);
                    break;
                case 7:
                    miGrafico.FillPie(miSolidBrush, 280, 200, 150, 150, 0, 40);
                    break;

            }
            
            miGrafico.Dispose();//Libera el objeto Graphics
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
