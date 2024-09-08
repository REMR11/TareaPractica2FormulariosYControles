using System;

namespace WinFormFormularioControles
{
    partial class calculadoraIntereses
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtIntereses = new System.Windows.Forms.TextBox();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMostrarResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal:";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrincipal.Location = new System.Drawing.Point(235, 74);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(216, 20);
            this.txtPrincipal.TabIndex = 1;
            this.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalcular.Location = new System.Drawing.Point(457, 74);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtIntereses
            // 
            this.txtIntereses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIntereses.Location = new System.Drawing.Point(235, 117);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.Size = new System.Drawing.Size(216, 20);
            this.txtIntereses.TabIndex = 4;
            this.txtIntereses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIntereses
            // 
            this.lblIntereses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIntereses.AutoSize = true;
            this.lblIntereses.Location = new System.Drawing.Point(144, 120);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(68, 13);
            this.lblIntereses.TabIndex = 3;
            this.lblIntereses.Text = "Tasa interés:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Años:";
            // 
            // numAnio
            // 
            this.numAnio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numAnio.Location = new System.Drawing.Point(235, 160);
            this.numAnio.Name = "numAnio";
            this.numAnio.ReadOnly = true;
            this.numAnio.Size = new System.Drawing.Size(216, 20);
            this.numAnio.TabIndex = 6;
            this.numAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saldo anual de la cuenta:";
            // 
            // txtMostrarResultado
            // 
            this.txtMostrarResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMostrarResultado.Location = new System.Drawing.Point(147, 234);
            this.txtMostrarResultado.Multiline = true;
            this.txtMostrarResultado.Name = "txtMostrarResultado";
            this.txtMostrarResultado.ReadOnly = true;
            this.txtMostrarResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrarResultado.Size = new System.Drawing.Size(385, 156);
            this.txtMostrarResultado.TabIndex = 8;
            // 
            // calculadoraIntereses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 465);
            this.Controls.Add(this.txtMostrarResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numAnio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIntereses);
            this.Controls.Add(this.lblIntereses);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calculadoraIntereses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculadoraIntereses";
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtIntereses;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMostrarResultado;
    }
}