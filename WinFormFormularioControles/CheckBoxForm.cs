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
    public partial class CheckBoxForm : Form
    {
        public CheckBoxForm()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Italic);
        }
    }
}
