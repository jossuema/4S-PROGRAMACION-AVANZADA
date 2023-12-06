namespace T2H1_EjerciciosFormularios
{
    partial class Practica1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAudio = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbLinea = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chkContado = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.txtMontoIGV = new System.Windows.Forms.TextBox();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "COSTO DEL ARTEFACTO:";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(355, 46);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(158, 22);
            this.txtCosto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipos de artefactos:";
            // 
            // rbAudio
            // 
            this.rbAudio.AutoSize = true;
            this.rbAudio.Location = new System.Drawing.Point(73, 124);
            this.rbAudio.Name = "rbAudio";
            this.rbAudio.Size = new System.Drawing.Size(63, 20);
            this.rbAudio.TabIndex = 3;
            this.rbAudio.TabStop = true;
            this.rbAudio.Text = "Audio";
            this.rbAudio.UseVisualStyleBackColor = true;
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(234, 124);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(64, 20);
            this.rbVideo.TabIndex = 4;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            // 
            // rbLinea
            // 
            this.rbLinea.AutoSize = true;
            this.rbLinea.Location = new System.Drawing.Point(408, 124);
            this.rbLinea.Name = "rbLinea";
            this.rbLinea.Size = new System.Drawing.Size(105, 20);
            this.rbLinea.TabIndex = 5;
            this.rbLinea.TabStop = true;
            this.rbLinea.Text = "Linea blanca";
            this.rbLinea.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forma de pago:";
            // 
            // chkContado
            // 
            this.chkContado.AutoSize = true;
            this.chkContado.Location = new System.Drawing.Point(201, 170);
            this.chkContado.Name = "chkContado";
            this.chkContado.Size = new System.Drawing.Size(80, 20);
            this.chkContado.TabIndex = 7;
            this.chkContado.Text = "Contado";
            this.chkContado.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(102, 221);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 26);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(236, 220);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 27);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(379, 220);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 27);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descuento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Incremento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monto de IGV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Monto a pagar:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(295, 274);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(149, 22);
            this.txtDescuento.TabIndex = 15;
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(296, 311);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.ReadOnly = true;
            this.txtIncremento.Size = new System.Drawing.Size(147, 22);
            this.txtIncremento.TabIndex = 16;
            // 
            // txtMontoIGV
            // 
            this.txtMontoIGV.Location = new System.Drawing.Point(295, 351);
            this.txtMontoIGV.Name = "txtMontoIGV";
            this.txtMontoIGV.ReadOnly = true;
            this.txtMontoIGV.Size = new System.Drawing.Size(147, 22);
            this.txtMontoIGV.TabIndex = 17;
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(296, 386);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.ReadOnly = true;
            this.txtMontoPago.Size = new System.Drawing.Size(147, 22);
            this.txtMontoPago.TabIndex = 18;
            // 
            // Practica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.txtMontoPago);
            this.Controls.Add(this.txtMontoIGV);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chkContado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbLinea);
            this.Controls.Add(this.rbVideo);
            this.Controls.Add(this.rbAudio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label1);
            this.Name = "Practica1";
            this.Text = "Practica1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAudio;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbLinea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkContado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.TextBox txtMontoIGV;
        private System.Windows.Forms.TextBox txtMontoPago;
    }
}