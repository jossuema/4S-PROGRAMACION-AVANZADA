namespace T2H1_EjerciciosFormularios
{
    partial class Practica6
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
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbComedia = new System.Windows.Forms.RadioButton();
            this.rbAccion = new System.Windows.Forms.RadioButton();
            this.rbDibujos = new System.Windows.Forms.RadioButton();
            this.rbDrama = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PELICULA: ";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(212, 31);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(253, 22);
            this.txtPelicula.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDrama);
            this.groupBox1.Controls.Add(this.rbDibujos);
            this.groupBox1.Controls.Add(this.rbAccion);
            this.groupBox1.Controls.Add(this.rbComedia);
            this.groupBox1.Location = new System.Drawing.Point(54, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias de peliculas";
            // 
            // rbComedia
            // 
            this.rbComedia.AutoSize = true;
            this.rbComedia.Location = new System.Drawing.Point(25, 31);
            this.rbComedia.Name = "rbComedia";
            this.rbComedia.Size = new System.Drawing.Size(83, 20);
            this.rbComedia.TabIndex = 0;
            this.rbComedia.TabStop = true;
            this.rbComedia.Text = "Comedia";
            this.rbComedia.UseVisualStyleBackColor = true;
            // 
            // rbAccion
            // 
            this.rbAccion.AutoSize = true;
            this.rbAccion.Location = new System.Drawing.Point(144, 31);
            this.rbAccion.Name = "rbAccion";
            this.rbAccion.Size = new System.Drawing.Size(69, 20);
            this.rbAccion.TabIndex = 1;
            this.rbAccion.TabStop = true;
            this.rbAccion.Text = "Accion";
            this.rbAccion.UseVisualStyleBackColor = true;
            // 
            // rbDibujos
            // 
            this.rbDibujos.AutoSize = true;
            this.rbDibujos.Location = new System.Drawing.Point(256, 31);
            this.rbDibujos.Name = "rbDibujos";
            this.rbDibujos.Size = new System.Drawing.Size(137, 20);
            this.rbDibujos.TabIndex = 2;
            this.rbDibujos.TabStop = true;
            this.rbDibujos.Text = "Dibujos animados";
            this.rbDibujos.UseVisualStyleBackColor = true;
            // 
            // rbDrama
            // 
            this.rbDrama.AutoSize = true;
            this.rbDrama.Location = new System.Drawing.Point(431, 31);
            this.rbDrama.Name = "rbDrama";
            this.rbDrama.Size = new System.Drawing.Size(69, 20);
            this.rbDrama.TabIndex = 3;
            this.rbDrama.TabStop = true;
            this.rbDrama.Text = "Drama";
            this.rbDrama.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "DURACION:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(133, 182);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 22);
            this.txtDuracion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ACTOR PRINCIPAL:";
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(426, 182);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(193, 22);
            this.txtActor.TabIndex = 7;
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(139, 236);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 8;
            this.btNuevo.Text = "NUEVO";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(220, 236);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(94, 23);
            this.btAgregar.TabIndex = 9;
            this.btAgregar.Text = "AGREGAR";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(320, 236);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(90, 23);
            this.btEliminar.TabIndex = 10;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(416, 236);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 11;
            this.btCerrar.Text = "CERRAR";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pelicula,
            this.Categoria,
            this.Duracion,
            this.Actor});
            this.dataGridView1.Location = new System.Drawing.Point(54, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 192);
            this.dataGridView1.TabIndex = 12;
            // 
            // Pelicula
            // 
            this.Pelicula.HeaderText = "PELICULA";
            this.Pelicula.MinimumWidth = 6;
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "CATEGORIA";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "DURACION";
            this.Duracion.MinimumWidth = 6;
            this.Duracion.Name = "Duracion";
            this.Duracion.Width = 125;
            // 
            // Actor
            // 
            this.Actor.HeaderText = "ACTOR PRINCIPAL";
            this.Actor.MinimumWidth = 6;
            this.Actor.Name = "Actor";
            this.Actor.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total de peliculas:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(504, 509);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 14;
            // 
            // Practica6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 557);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.label1);
            this.Name = "Practica6";
            this.Text = "Practica6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDrama;
        private System.Windows.Forms.RadioButton rbDibujos;
        private System.Windows.Forms.RadioButton rbAccion;
        private System.Windows.Forms.RadioButton rbComedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
    }
}