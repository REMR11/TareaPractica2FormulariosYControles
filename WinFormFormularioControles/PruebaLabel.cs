﻿using System;
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
    public partial class PruebaLabel : Form
    {
        public PruebaLabel()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarClave_Click(object sender, EventArgs e)
        {
            lblVerClave.Text = txtDigitarClave.Text;
        }
    }
}
