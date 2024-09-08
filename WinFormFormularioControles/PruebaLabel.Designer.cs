namespace WinFormFormularioControles
{
    partial class PruebaLabel
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
            this.lblVerClave = new System.Windows.Forms.Label();
            this.txtDigitarClave = new System.Windows.Forms.TextBox();
            this.btnMostrarClave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(629, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblVerClave
            // 
            this.lblVerClave.AutoSize = true;
            this.lblVerClave.Location = new System.Drawing.Point(224, 246);
            this.lblVerClave.Name = "lblVerClave";
            this.lblVerClave.Size = new System.Drawing.Size(0, 13);
            this.lblVerClave.TabIndex = 1;
            // 
            // txtDigitarClave
            // 
            this.txtDigitarClave.Location = new System.Drawing.Point(203, 196);
            this.txtDigitarClave.Name = "txtDigitarClave";
            this.txtDigitarClave.PasswordChar = '*';
            this.txtDigitarClave.Size = new System.Drawing.Size(257, 20);
            this.txtDigitarClave.TabIndex = 2;
            // 
            // btnMostrarClave
            // 
            this.btnMostrarClave.Location = new System.Drawing.Point(329, 300);
            this.btnMostrarClave.Name = "btnMostrarClave";
            this.btnMostrarClave.Size = new System.Drawing.Size(131, 28);
            this.btnMostrarClave.TabIndex = 3;
            this.btnMostrarClave.Text = "Mostrar Clave";
            this.btnMostrarClave.UseVisualStyleBackColor = true;
            this.btnMostrarClave.Click += new System.EventHandler(this.btnMostrarClave_Click);
            // 
            // PruebaLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 465);
            this.Controls.Add(this.btnMostrarClave);
            this.Controls.Add(this.txtDigitarClave);
            this.Controls.Add(this.lblVerClave);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PruebaLabel";
            this.Text = "PruebaLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblVerClave;
        private System.Windows.Forms.TextBox txtDigitarClave;
        private System.Windows.Forms.Button btnMostrarClave;
    }
}