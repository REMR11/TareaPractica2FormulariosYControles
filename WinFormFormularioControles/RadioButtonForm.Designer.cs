using System;

namespace WinFormFormularioControles
{
    partial class RadioButtonForm
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
            this.lblMostrar = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnReintentarCancelar = new System.Windows.Forms.RadioButton();
            this.rbtnSiNo = new System.Windows.Forms.RadioButton();
            this.rbtnSiNoCancelar = new System.Windows.Forms.RadioButton();
            this.rbtnAbortarReintentarIgnorar = new System.Windows.Forms.RadioButton();
            this.rbtnAceptarCancelar = new System.Windows.Forms.RadioButton();
            this.rbtnAceptar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnAdvertencia = new System.Windows.Forms.RadioButton();
            this.rbtnAlto = new System.Windows.Forms.RadioButton();
            this.rbtnPregunta = new System.Windows.Forms.RadioButton();
            this.rbtnInformacion = new System.Windows.Forms.RadioButton();
            this.rbtnMano = new System.Windows.Forms.RadioButton();
            this.rbtnExclamacion = new System.Windows.Forms.RadioButton();
            this.rbtnError = new System.Windows.Forms.RadioButton();
            this.rbtnAsterisco = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // lblMostrar
            // 
            this.lblMostrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(582, 177);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(35, 13);
            this.lblMostrar.TabIndex = 3;
            this.lblMostrar.Text = "label1";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMostrar.Location = new System.Drawing.Point(576, 87);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnReintentarCancelar);
            this.groupBox1.Controls.Add(this.rbtnSiNo);
            this.groupBox1.Controls.Add(this.rbtnSiNoCancelar);
            this.groupBox1.Controls.Add(this.rbtnAbortarReintentarIgnorar);
            this.groupBox1.Controls.Add(this.rbtnAceptarCancelar);
            this.groupBox1.Controls.Add(this.rbtnAceptar);
            this.groupBox1.Location = new System.Drawing.Point(56, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Botón ";
            // 
            // rbtnReintentarCancelar
            // 
            this.rbtnReintentarCancelar.AutoSize = true;
            this.rbtnReintentarCancelar.Location = new System.Drawing.Point(6, 212);
            this.rbtnReintentarCancelar.Name = "rbtnReintentarCancelar";
            this.rbtnReintentarCancelar.Size = new System.Drawing.Size(116, 17);
            this.rbtnReintentarCancelar.TabIndex = 5;
            this.rbtnReintentarCancelar.TabStop = true;
            this.rbtnReintentarCancelar.Text = "ReintentarCancelar";
            this.rbtnReintentarCancelar.UseVisualStyleBackColor = true;
            this.rbtnReintentarCancelar.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChanged);
            // 
            // rbtnSiNo
            // 
            this.rbtnSiNo.AutoSize = true;
            this.rbtnSiNo.Location = new System.Drawing.Point(6, 177);
            this.rbtnSiNo.Name = "rbtnSiNo";
            this.rbtnSiNo.Size = new System.Drawing.Size(51, 17);
            this.rbtnSiNo.TabIndex = 4;
            this.rbtnSiNo.TabStop = true;
            this.rbtnSiNo.Text = "Si No";
            this.rbtnSiNo.UseVisualStyleBackColor = true;
            this.rbtnSiNo.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChanged);
            // 
            // rbtnSiNoCancelar
            // 
            this.rbtnSiNoCancelar.AutoSize = true;
            this.rbtnSiNoCancelar.Location = new System.Drawing.Point(6, 142);
            this.rbtnSiNoCancelar.Name = "rbtnSiNoCancelar";
            this.rbtnSiNoCancelar.Size = new System.Drawing.Size(98, 17);
            this.rbtnSiNoCancelar.TabIndex = 3;
            this.rbtnSiNoCancelar.TabStop = true;
            this.rbtnSiNoCancelar.Text = "Sí No Cancelar";
            this.rbtnSiNoCancelar.UseVisualStyleBackColor = true;
            this.rbtnSiNoCancelar.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChanged);
            // 
            // rbtnAbortarReintentarIgnorar
            // 
            this.rbtnAbortarReintentarIgnorar.AutoSize = true;
            this.rbtnAbortarReintentarIgnorar.Location = new System.Drawing.Point(6, 107);
            this.rbtnAbortarReintentarIgnorar.Name = "rbtnAbortarReintentarIgnorar";
            this.rbtnAbortarReintentarIgnorar.Size = new System.Drawing.Size(147, 17);
            this.rbtnAbortarReintentarIgnorar.TabIndex = 2;
            this.rbtnAbortarReintentarIgnorar.TabStop = true;
            this.rbtnAbortarReintentarIgnorar.Text = "Abortar Reintentar Ignorar";
            this.rbtnAbortarReintentarIgnorar.UseVisualStyleBackColor = true;
            this.rbtnAbortarReintentarIgnorar.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChanged);
            // 
            // rbtnAceptarCancelar
            // 
            this.rbtnAceptarCancelar.AutoSize = true;
            this.rbtnAceptarCancelar.Location = new System.Drawing.Point(6, 72);
            this.rbtnAceptarCancelar.Name = "rbtnAceptarCancelar";
            this.rbtnAceptarCancelar.Size = new System.Drawing.Size(107, 17);
            this.rbtnAceptarCancelar.TabIndex = 1;
            this.rbtnAceptarCancelar.TabStop = true;
            this.rbtnAceptarCancelar.Text = "Aceptar Cancelar";
            this.rbtnAceptarCancelar.UseVisualStyleBackColor = true;
            this.rbtnAceptarCancelar.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChanged);
            // 
            // rbtnAceptar
            // 
            this.rbtnAceptar.AutoSize = true;
            this.rbtnAceptar.Location = new System.Drawing.Point(6, 37);
            this.rbtnAceptar.Name = "rbtnAceptar";
            this.rbtnAceptar.Size = new System.Drawing.Size(62, 17);
            this.rbtnAceptar.TabIndex = 0;
            this.rbtnAceptar.TabStop = true;
            this.rbtnAceptar.Text = "Aceptar";
            this.rbtnAceptar.UseVisualStyleBackColor = true;
            this.rbtnAceptar.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnAdvertencia);
            this.groupBox2.Controls.Add(this.rbtnAlto);
            this.groupBox2.Controls.Add(this.rbtnPregunta);
            this.groupBox2.Controls.Add(this.rbtnInformacion);
            this.groupBox2.Controls.Add(this.rbtnMano);
            this.groupBox2.Controls.Add(this.rbtnExclamacion);
            this.groupBox2.Controls.Add(this.rbtnError);
            this.groupBox2.Controls.Add(this.rbtnAsterisco);
            this.groupBox2.Location = new System.Drawing.Point(303, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 318);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Icono";
            // 
            // rbtnAdvertencia
            // 
            this.rbtnAdvertencia.AutoSize = true;
            this.rbtnAdvertencia.Location = new System.Drawing.Point(6, 289);
            this.rbtnAdvertencia.Name = "rbtnAdvertencia";
            this.rbtnAdvertencia.Size = new System.Drawing.Size(82, 17);
            this.rbtnAdvertencia.TabIndex = 7;
            this.rbtnAdvertencia.TabStop = true;
            this.rbtnAdvertencia.Text = "Advertencia";
            this.rbtnAdvertencia.UseVisualStyleBackColor = true;
            this.rbtnAdvertencia.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChanged);
            // 
            // rbtnAlto
            // 
            this.rbtnAlto.AutoSize = true;
            this.rbtnAlto.Location = new System.Drawing.Point(6, 253);
            this.rbtnAlto.Name = "rbtnAlto";
            this.rbtnAlto.Size = new System.Drawing.Size(43, 17);
            this.rbtnAlto.TabIndex = 6;
            this.rbtnAlto.TabStop = true;
            this.rbtnAlto.Text = "Alto";
            this.rbtnAlto.UseVisualStyleBackColor = true;
            this.rbtnAlto.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChanged);
            // 
            // rbtnPregunta
            // 
            this.rbtnPregunta.AutoSize = true;
            this.rbtnPregunta.Location = new System.Drawing.Point(6, 217);
            this.rbtnPregunta.Name = "rbtnPregunta";
            this.rbtnPregunta.Size = new System.Drawing.Size(68, 17);
            this.rbtnPregunta.TabIndex = 5;
            this.rbtnPregunta.TabStop = true;
            this.rbtnPregunta.Text = "Pregunta";
            this.rbtnPregunta.UseVisualStyleBackColor = true;
            this.rbtnPregunta.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChanged);
            // 
            // rbtnInformacion
            // 
            this.rbtnInformacion.AutoSize = true;
            this.rbtnInformacion.Location = new System.Drawing.Point(6, 181);
            this.rbtnInformacion.Name = "rbtnInformacion";
            this.rbtnInformacion.Size = new System.Drawing.Size(80, 17);
            this.rbtnInformacion.TabIndex = 4;
            this.rbtnInformacion.TabStop = true;
            this.rbtnInformacion.Text = "Informacion";
            this.rbtnInformacion.UseVisualStyleBackColor = true;
            this.rbtnInformacion.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChanged);
            // 
            // rbtnMano
            // 
            this.rbtnMano.AutoSize = true;
            this.rbtnMano.Location = new System.Drawing.Point(6, 145);
            this.rbtnMano.Name = "rbtnMano";
            this.rbtnMano.Size = new System.Drawing.Size(52, 17);
            this.rbtnMano.TabIndex = 3;
            this.rbtnMano.TabStop = true;
            this.rbtnMano.Text = "Mano";
            this.rbtnMano.UseVisualStyleBackColor = true;
            this.rbtnMano.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChanged);
            // 
            // rbtnExclamacion
            // 
            this.rbtnExclamacion.AutoSize = true;
            this.rbtnExclamacion.Location = new System.Drawing.Point(6, 109);
            this.rbtnExclamacion.Name = "rbtnExclamacion";
            this.rbtnExclamacion.Size = new System.Drawing.Size(85, 17);
            this.rbtnExclamacion.TabIndex = 2;
            this.rbtnExclamacion.TabStop = true;
            this.rbtnExclamacion.Text = "Exclamación";
            this.rbtnExclamacion.UseVisualStyleBackColor = true;
            this.rbtnExclamacion.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChanged);
            // 
            // rbtnError
            // 
            this.rbtnError.AutoSize = true;
            this.rbtnError.Location = new System.Drawing.Point(6, 73);
            this.rbtnError.Name = "rbtnError";
            this.rbtnError.Size = new System.Drawing.Size(47, 17);
            this.rbtnError.TabIndex = 1;
            this.rbtnError.TabStop = true;
            this.rbtnError.Text = "Error";
            this.rbtnError.UseVisualStyleBackColor = true;
            this.rbtnError.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChanged);
            // 
            // rbtnAsterisco
            // 
            this.rbtnAsterisco.AutoSize = true;
            this.rbtnAsterisco.Checked = true;
            this.rbtnAsterisco.Location = new System.Drawing.Point(6, 37);
            this.rbtnAsterisco.Name = "rbtnAsterisco";
            this.rbtnAsterisco.Size = new System.Drawing.Size(68, 17);
            this.rbtnAsterisco.TabIndex = 0;
            this.rbtnAsterisco.TabStop = true;
            this.rbtnAsterisco.Text = "Asterisco";
            this.rbtnAsterisco.UseVisualStyleBackColor = true;
            this.rbtnAsterisco.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChanged);
            // 
            // RadioButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RadioButtonForm";
            this.Text = "RadioButtonForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnReintentarCancelar;
        private System.Windows.Forms.RadioButton rbtnSiNo;
        private System.Windows.Forms.RadioButton rbtnSiNoCancelar;
        private System.Windows.Forms.RadioButton rbtnAbortarReintentarIgnorar;
        private System.Windows.Forms.RadioButton rbtnAceptarCancelar;
        private System.Windows.Forms.RadioButton rbtnAceptar;
        private System.Windows.Forms.RadioButton rbtnAdvertencia;
        private System.Windows.Forms.RadioButton rbtnAlto;
        private System.Windows.Forms.RadioButton rbtnPregunta;
        private System.Windows.Forms.RadioButton rbtnInformacion;
        private System.Windows.Forms.RadioButton rbtnMano;
        private System.Windows.Forms.RadioButton rbtnExclamacion;
        private System.Windows.Forms.RadioButton rbtnError;
        private System.Windows.Forms.RadioButton rbtnAsterisco;
    }
}