﻿namespace WinFormFormularioControles
{
    partial class Controles
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnPresiona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(629, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPresiona
            // 
            this.btnPresiona.Location = new System.Drawing.Point(430, 270);
            this.btnPresiona.Name = "btnPresiona";
            this.btnPresiona.Size = new System.Drawing.Size(75, 23);
            this.btnPresiona.TabIndex = 1;
            this.btnPresiona.Text = "Presioname";
            this.btnPresiona.UseVisualStyleBackColor = true;
            this.btnPresiona.Click += new System.EventHandler(this.btnPresiona_Click);
            // 
            // Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 465);
            this.Controls.Add(this.btnPresiona);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Controles";
            this.Text = "Controles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPresiona;
    }
}