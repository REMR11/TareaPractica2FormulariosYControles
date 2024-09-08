using System;

namespace WinFormFormularioControles
{
    partial class PruebaComboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbImagen = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbImagen
            // 
            this.cmbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbImagen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImagen.FormattingEnabled = true;
            this.cmbImagen.Items.AddRange(new object[] {
            "Circulo",
            "Cuadrado",
            "Elipse",
            "Pastel",
            "Círculo relleno",
            "Cuadrado relleno",
            "Elipse relleno",
            "Pastel relleno"});
            this.cmbImagen.Location = new System.Drawing.Point(165, 97);
            this.cmbImagen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbImagen.Name = "cmbImagen";
            this.cmbImagen.Size = new System.Drawing.Size(399, 21);
            this.cmbImagen.TabIndex = 0;
            this.cmbImagen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(647, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PruebaComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 465);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PruebaComboBox";
            this.Text = "ComboBox";
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.ComboBox cmbImagen;
        private System.Windows.Forms.Button btnCerrar;
    }
}