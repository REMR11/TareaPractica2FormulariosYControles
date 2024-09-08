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
    public partial class ListBoxyComboBox : Form
    {
        public ListBoxyComboBox()
        {
            InitializeComponent();
        }

        private void ListBoxyComboBox_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Libros de programación");
            comboBox1.Items.Add("Libros de literatura");
            comboBox1.Items.Add("Cómic Books");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op = comboBox1.Text;

            switch (op)
            {
                case "Libros de programación":
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Visual Basic 2010");
                    listBox1.Items.Add("Visual C# 2010");
                    listBox1.Items.Add("Visual C++");
                    break;
                case "Libros de literatura":
                    listBox1.Items.Clear();
                    listBox1.Items.Add("La caída de los gigantes");
                    listBox1.Items.Add("Las legiones malditas");
                    listBox1.Items.Add("El sueño del celta");
                    break;
                case "Cómic Books":
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Spiderman");
                    listBox1.Items.Add("Superman");
                    listBox1.Items.Add("Batman");
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
