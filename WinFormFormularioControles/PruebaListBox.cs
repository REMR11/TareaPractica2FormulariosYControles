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
    public partial class PruebaListBox : Form
    {
        public PruebaListBox()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstMostrarListBox.Items.Add(txtEntrada.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lstMostrarListBox.Items.Clear();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstMostrarListBox.SelectedIndex != -1)
            {
                lstMostrarListBox.Items.RemoveAt(lstMostrarListBox.SelectedIndex);
            }
        }
    }
}
