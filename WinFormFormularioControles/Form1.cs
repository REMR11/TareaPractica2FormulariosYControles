using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFormularioControles
{
    public partial class panelLogo : Form
    {
        public panelLogo()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        #region configuracionMenu
        /// <summary>
        /// Método para personalizar el diseño ocultando submenús
        /// Oculta subMenus, utilizado en eventos click
        /// </summary>
        private void CustomizeDesing()
        {
            panelSubMenu1.Visible = false;
            panelSubMenu2.Visible = false;
        }

        /// <summary>
        /// Método para ocultar todos los submenús
        /// Verificar si los submenú estan visibles y ocultarlos si estan true
        /// </summary>
        private void HideSubMenu()
        {
            if (panelSubMenu1.Visible)
                panelSubMenu1.Visible = false;
            if (panelSubMenu2.Visible)
                panelSubMenu2.Visible = false;
        }

        /// <summary>
        /// Método para mostrar o ocultar un submenú específico. Verificar si el submenú pasado 
        /// como parametro no está visible. Oculta todos los submenús antes de mostrar el actual
        /// 
        /// En caso de que el menu actual este visible sera ocultado
        /// </summary>
        /// <param name="pSubMenu">Panel seleccionado, normalmente mediante un evento click</param>
        private void ShowSubMenu(Panel pSubMenu)
        {
            if (!pSubMenu.Visible)
            {
                HideSubMenu();
                pSubMenu.Visible = true;
            }
            else
            {
                pSubMenu.Visible = false;
            }
        }

        private Form activeForm = null;

        /// <summary>
        /// Metodo que se encarga de abrir un formulario hijo dentro de un contenedor principal
        /// </summary>
        /// <param name="pChildForm"></param>
        private void OpenChildForm(Form pChildForm)
        {
            if (activeForm != null) { 
                activeForm.Close();
            }

            activeForm = pChildForm;

            pChildForm.TopLevel = false;
            pChildForm.FormBorderStyle = FormBorderStyle.None;
            pChildForm.Dock = DockStyle.Fill;
            panelContainerForm.Controls.Add(activeForm);
            panelContainerForm.Tag = activeForm;
            pChildForm.BringToFront();
            pChildForm.Show();
        }
        #endregion

        #region EjerciciosPart1
        private void btnMenuEjercicios1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu1);
        }
        private void btnControles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Controles());
            HideSubMenu();
        }

        private void btnPruebaLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PruebaLabel());
            HideSubMenu();
        }
        private void btnListBoxComboBox_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListBoxyComboBox());
            HideSubMenu();
        }
        private void btnPanel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PanelForm());
            HideSubMenu();
        }
        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckBoxForm());
            HideSubMenu();
        }
        #endregion

        #region EjerciciosPart2
        private void btnMenuEjercicios2_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu2);
        }
        private void btnRadioButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RadioButtonForm());
            HideSubMenu();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        #endregion

        
    }
}
