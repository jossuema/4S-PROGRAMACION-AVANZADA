namespace capavista.Formularios
{
    partial class frmPrestado
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dateFechaTentativa = new System.Windows.Forms.DateTimePicker();
            this.dateFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEstudiante = new System.Windows.Forms.ComboBox();
            this.lbNoSelec = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbSelec = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(112, 59);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(312, 22);
            this.txtCodigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "En curso",
            "Finalizado"});
            this.cbEstado.Location = new System.Drawing.Point(112, 96);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(312, 24);
            this.cbEstado.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha tentativa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha devolucion:";
            // 
            // dateFechaEntrega
            // 
            this.dateFechaEntrega.Location = new System.Drawing.Point(162, 138);
            this.dateFechaEntrega.Name = "dateFechaEntrega";
            this.dateFechaEntrega.Size = new System.Drawing.Size(262, 22);
            this.dateFechaEntrega.TabIndex = 8;
            // 
            // dateFechaTentativa
            // 
            this.dateFechaTentativa.Location = new System.Drawing.Point(162, 176);
            this.dateFechaTentativa.Name = "dateFechaTentativa";
            this.dateFechaTentativa.Size = new System.Drawing.Size(262, 22);
            this.dateFechaTentativa.TabIndex = 9;
            // 
            // dateFechaDevolucion
            // 
            this.dateFechaDevolucion.Location = new System.Drawing.Point(162, 213);
            this.dateFechaDevolucion.Name = "dateFechaDevolucion";
            this.dateFechaDevolucion.Size = new System.Drawing.Size(262, 22);
            this.dateFechaDevolucion.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estudiante:";
            // 
            // cbEstudiante
            // 
            this.cbEstudiante.FormattingEnabled = true;
            this.cbEstudiante.Location = new System.Drawing.Point(134, 260);
            this.cbEstudiante.Name = "cbEstudiante";
            this.cbEstudiante.Size = new System.Drawing.Size(290, 24);
            this.cbEstudiante.TabIndex = 12;
            // 
            // lbNoSelec
            // 
            this.lbNoSelec.FormattingEnabled = true;
            this.lbNoSelec.ItemHeight = 16;
            this.lbNoSelec.Location = new System.Drawing.Point(43, 314);
            this.lbNoSelec.Name = "lbNoSelec";
            this.lbNoSelec.Size = new System.Drawing.Size(142, 148);
            this.lbNoSelec.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSelec
            // 
            this.lbSelec.FormattingEnabled = true;
            this.lbSelec.ItemHeight = 16;
            this.lbSelec.Location = new System.Drawing.Point(272, 314);
            this.lbSelec.Name = "lbSelec";
            this.lbSelec.Size = new System.Drawing.Size(152, 148);
            this.lbSelec.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(241, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmPrestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 537);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbSelec);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbNoSelec);
            this.Controls.Add(this.cbEstudiante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateFechaDevolucion);
            this.Controls.Add(this.dateFechaTentativa);
            this.Controls.Add(this.dateFechaEntrega);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrestado";
            this.Text = "frmPrestado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateFechaEntrega;
        private System.Windows.Forms.DateTimePicker dateFechaTentativa;
        private System.Windows.Forms.DateTimePicker dateFechaDevolucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEstudiante;
        private System.Windows.Forms.ListBox lbNoSelec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbSelec;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}