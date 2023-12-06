namespace T2H1_EjerciciosFormularios
{
    partial class Practica2
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
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaCursos = new System.Windows.Forms.ListBox();
            this.listaCostos = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listaCursosSeleccionados = new System.Windows.Forms.ListBox();
            this.listaCostosSeleccionados = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbContado = new System.Windows.Forms.RadioButton();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(244, 20);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(269, 22);
            this.txtAlumno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccionar cursos:";
            // 
            // listaCursos
            // 
            this.listaCursos.FormattingEnabled = true;
            this.listaCursos.ItemHeight = 16;
            this.listaCursos.Items.AddRange(new object[] {
            "Visual Basic",
            "Flutter",
            "Programacion Backend",
            "Programacion Frontend",
            ".NET"});
            this.listaCursos.Location = new System.Drawing.Point(90, 114);
            this.listaCursos.Name = "listaCursos";
            this.listaCursos.Size = new System.Drawing.Size(156, 148);
            this.listaCursos.TabIndex = 3;
            // 
            // listaCostos
            // 
            this.listaCostos.FormattingEnabled = true;
            this.listaCostos.ItemHeight = 16;
            this.listaCostos.Items.AddRange(new object[] {
            "180",
            "160",
            "200",
            "150",
            "100"});
            this.listaCostos.Location = new System.Drawing.Point(253, 114);
            this.listaCostos.Name = "listaCostos";
            this.listaCostos.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listaCostos.Size = new System.Drawing.Size(73, 148);
            this.listaCostos.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(347, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(347, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cursos seleccionados";
            // 
            // listaCursosSeleccionados
            // 
            this.listaCursosSeleccionados.FormattingEnabled = true;
            this.listaCursosSeleccionados.ItemHeight = 16;
            this.listaCursosSeleccionados.Location = new System.Drawing.Point(447, 114);
            this.listaCursosSeleccionados.Name = "listaCursosSeleccionados";
            this.listaCursosSeleccionados.Size = new System.Drawing.Size(151, 148);
            this.listaCursosSeleccionados.TabIndex = 8;
            // 
            // listaCostosSeleccionados
            // 
            this.listaCostosSeleccionados.FormattingEnabled = true;
            this.listaCostosSeleccionados.ItemHeight = 16;
            this.listaCostosSeleccionados.Location = new System.Drawing.Point(605, 114);
            this.listaCostosSeleccionados.Name = "listaCostosSeleccionados";
            this.listaCostosSeleccionados.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listaCostosSeleccionados.Size = new System.Drawing.Size(74, 148);
            this.listaCostosSeleccionados.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Forma de pago:";
            // 
            // rbContado
            // 
            this.rbContado.AutoSize = true;
            this.rbContado.Location = new System.Drawing.Point(93, 316);
            this.rbContado.Name = "rbContado";
            this.rbContado.Size = new System.Drawing.Size(79, 20);
            this.rbContado.TabIndex = 11;
            this.rbContado.TabStop = true;
            this.rbContado.Text = "Contado";
            this.rbContado.UseVisualStyleBackColor = true;
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Location = new System.Drawing.Point(202, 316);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(71, 20);
            this.rbCredito.TabIndex = 12;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Credito";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(620, 301);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(59, 22);
            this.txtTotal.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(251, 358);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(347, 358);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(447, 358);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Incremento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Monto a pagar:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(168, 409);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento.TabIndex = 21;
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(356, 409);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.ReadOnly = true;
            this.txtIncremento.Size = new System.Drawing.Size(100, 22);
            this.txtIncremento.TabIndex = 22;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(565, 409);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(100, 22);
            this.txtMonto.TabIndex = 23;
            // 
            // Practica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 508);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbCredito);
            this.Controls.Add(this.rbContado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listaCostosSeleccionados);
            this.Controls.Add(this.listaCursosSeleccionados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listaCostos);
            this.Controls.Add(this.listaCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label1);
            this.Name = "Practica2";
            this.Text = "Practica2";
            this.Load += new System.EventHandler(this.Practica2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listaCursos;
        private System.Windows.Forms.ListBox listaCostos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listaCursosSeleccionados;
        private System.Windows.Forms.ListBox listaCostosSeleccionados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbContado;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.TextBox txtMonto;
    }
}