namespace T2H1_EjerciciosFormularios
{
    partial class Practica5_extra
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelBuenas = new System.Windows.Forms.Label();
            this.labelMalas = new System.Windows.Forms.Label();
            this.labelPuntaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(24, 58);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre: ";
            // 
            // labelBuenas
            // 
            this.labelBuenas.AutoSize = true;
            this.labelBuenas.Location = new System.Drawing.Point(24, 94);
            this.labelBuenas.Name = "labelBuenas";
            this.labelBuenas.Size = new System.Drawing.Size(59, 16);
            this.labelBuenas.TabIndex = 1;
            this.labelBuenas.Text = "Buenas: ";
            // 
            // labelMalas
            // 
            this.labelMalas.AutoSize = true;
            this.labelMalas.Location = new System.Drawing.Point(24, 127);
            this.labelMalas.Name = "labelMalas";
            this.labelMalas.Size = new System.Drawing.Size(50, 16);
            this.labelMalas.TabIndex = 2;
            this.labelMalas.Text = "Malas: ";
            // 
            // labelPuntaje
            // 
            this.labelPuntaje.AutoSize = true;
            this.labelPuntaje.Location = new System.Drawing.Point(24, 160);
            this.labelPuntaje.Name = "labelPuntaje";
            this.labelPuntaje.Size = new System.Drawing.Size(58, 16);
            this.labelPuntaje.TabIndex = 3;
            this.labelPuntaje.Text = "Puntaje: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Postulante con mayor puntaje";
            // 
            // Practica5_extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPuntaje);
            this.Controls.Add(this.labelMalas);
            this.Controls.Add(this.labelBuenas);
            this.Controls.Add(this.labelNombre);
            this.Name = "Practica5_extra";
            this.Text = "Practica5_extra";
            this.Load += new System.EventHandler(this.Practica5_extra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelBuenas;
        private System.Windows.Forms.Label labelMalas;
        private System.Windows.Forms.Label labelPuntaje;
        private System.Windows.Forms.Label label1;
    }
}