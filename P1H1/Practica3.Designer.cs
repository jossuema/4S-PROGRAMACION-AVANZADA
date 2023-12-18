namespace T2H1_EjerciciosFormularios
{
    partial class Practica3
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
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnidad1 = new System.Windows.Forms.TextBox();
            this.txtUnidad2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnidad3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALIFICACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alumno:";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(137, 70);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(473, 22);
            this.txtAlumno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota de la Unidad 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota de la Unidad 2:";
            // 
            // txtUnidad1
            // 
            this.txtUnidad1.Location = new System.Drawing.Point(179, 119);
            this.txtUnidad1.Name = "txtUnidad1";
            this.txtUnidad1.Size = new System.Drawing.Size(100, 22);
            this.txtUnidad1.TabIndex = 5;
            // 
            // txtUnidad2
            // 
            this.txtUnidad2.Location = new System.Drawing.Point(510, 119);
            this.txtUnidad2.Name = "txtUnidad2";
            this.txtUnidad2.Size = new System.Drawing.Size(100, 22);
            this.txtUnidad2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nota de la Unidad 3:";
            // 
            // txtUnidad3
            // 
            this.txtUnidad3.Location = new System.Drawing.Point(179, 161);
            this.txtUnidad3.Name = "txtUnidad3";
            this.txtUnidad3.Size = new System.Drawing.Size(100, 22);
            this.txtUnidad3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Turno:";
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Diurno",
            "Nocturno"});
            this.cbTurno.Location = new System.Drawing.Point(426, 161);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(184, 24);
            this.cbTurno.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(345, 212);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 12;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alumno,
            this.Unidad1,
            this.Unidad2,
            this.Unidad3,
            this.Promedio,
            this.Turno});
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 263);
            this.dataGridView1.TabIndex = 13;
            // 
            // Alumno
            // 
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.MinimumWidth = 6;
            this.Alumno.Name = "Alumno";
            this.Alumno.ReadOnly = true;
            this.Alumno.Width = 125;
            // 
            // Unidad1
            // 
            this.Unidad1.HeaderText = "Unidad 1";
            this.Unidad1.MinimumWidth = 6;
            this.Unidad1.Name = "Unidad1";
            this.Unidad1.ReadOnly = true;
            this.Unidad1.Width = 125;
            // 
            // Unidad2
            // 
            this.Unidad2.HeaderText = "Unidad 2";
            this.Unidad2.MinimumWidth = 6;
            this.Unidad2.Name = "Unidad2";
            this.Unidad2.ReadOnly = true;
            this.Unidad2.Width = 125;
            // 
            // Unidad3
            // 
            this.Unidad3.HeaderText = "Unidad 3";
            this.Unidad3.MinimumWidth = 6;
            this.Unidad3.Name = "Unidad3";
            this.Unidad3.ReadOnly = true;
            this.Unidad3.Width = 125;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.MinimumWidth = 6;
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            this.Promedio.Width = 125;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.MinimumWidth = 6;
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            this.Turno.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total de alumnos:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(589, 532);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 15;
            // 
            // Practica4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 569);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUnidad3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnidad2);
            this.Controls.Add(this.txtUnidad1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Practica4";
            this.Text = "Practica4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnidad1;
        private System.Windows.Forms.TextBox txtUnidad2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnidad3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
    }
}