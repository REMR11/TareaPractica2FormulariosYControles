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
    public partial class RadioButtonForm : Form
    {
        private MessageBoxIcon tipoIcono;
        private MessageBoxButtons tipoBoton;
        public RadioButtonForm()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Muestra MessageBox y Almacena el valor del control Button que se oprimió
            DialogResult resultado = MessageBox.Show("Este es su MessageBox personalizado.", "MessageBox personalizado", tipoBoton, tipoIcono, 0, 0);
            //Comprueba qué control Button se oprimió en el MessageBox y cambia el texto mostrado
            switch (resultado)
            {
                case DialogResult.OK:
                    lblMostrar.Text = "Se oprimió Aceptar";
                    break;
                case DialogResult.Cancel:
                    lblMostrar.Text = "Se oprimió Cancelar";
                    break;
                case DialogResult.Abort:
                    lblMostrar.Text = "Se oprimió Abortar";
                    break;
                case DialogResult.Retry:
                    lblMostrar.Text = "Se oprimió Reintentar";
                    break;
                case DialogResult.Ignore:
                    lblMostrar.Text = "Se oprimió Ignorar";
                    break;
                case DialogResult.Yes:
                    lblMostrar.Text = "Se oprimió Sí";
                    break;
                case DialogResult.No:
                    lblMostrar.Text = "Se oprimió No";
                    break;
            }
        }

        private void tipoBoton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == rbtnAceptar) //Muestra el botón de Aceptar
            {
                tipoBoton = MessageBoxButtons.OK;
            }
            else if (sender == rbtnAceptarCancelar)
            {
                tipoBoton = MessageBoxButtons.OKCancel;
            }
            else if (sender == rbtnAbortarReintentarIgnorar)
            {
                tipoBoton = MessageBoxButtons.AbortRetryIgnore;
            }
            else if (sender == rbtnSiNoCancelar)
            {
                tipoBoton = MessageBoxButtons.YesNoCancel;
            }
            else if (sender == rbtnSiNo)
            {
                tipoBoton = MessageBoxButtons.YesNo;
            }
            else//Solo queda una opción y es la de reintentar y cancelar
            {
                tipoBoton = MessageBoxButtons.RetryCancel;
            };
        }

        private void tipoIcono_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == rbtnAsterisco)
            {
                tipoIcono = MessageBoxIcon.Asterisk;
            }
            else if (sender == rbtnError)
            {
                tipoIcono = MessageBoxIcon.Error;
            }
            else if (sender == rbtnExclamacion)
            {
                tipoIcono = MessageBoxIcon.Exclamation;
            }
            else if (sender == rbtnMano)
            {
                tipoIcono = MessageBoxIcon.Hand;
            }
            else if (sender == rbtnInformacion)
            {
                tipoIcono = MessageBoxIcon.Information;
            }
            else if (sender == rbtnPregunta)
            {
                tipoIcono = MessageBoxIcon.Question;
            }
            else if (sender == rbtnAlto)
            {
                tipoIcono = MessageBoxIcon.Stop;
            }
            else
            {
                tipoIcono = MessageBoxIcon.Warning;
            }
        }
    }
}
