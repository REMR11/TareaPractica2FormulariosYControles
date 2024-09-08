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
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();
        }

        private void btnPresiona_Click(object sender, EventArgs e)
        {
            TextBox txt1 = new TextBox();
            TextBox txt2 = new TextBox();

            txt1.Location = new Point(230, 170);
            txt2.Location = new Point(230, 200);

            this.Controls.Add(txt1);
            this.Controls.Add(txt2);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
