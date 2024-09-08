using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFormularioControles
{
    public partial class PictureBoxForm : Form
    {
        private int numImagen = -1; //Determina cual imagen se va mostrar
        public PictureBoxForm()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            numImagen = (numImagen + 1) % 5;//Numero de imagen itera de 0 a 2
            try
            {
                string filePath = Path.Combine("IMG", "imagen" + numImagen + ".png");
                string fullPath = Path.GetFullPath(filePath);
                imagenPictureBox.Image = Image.FromFile(fullPath);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: Unable to find image file. " + ex.Message);
            }
        }
    }
}
