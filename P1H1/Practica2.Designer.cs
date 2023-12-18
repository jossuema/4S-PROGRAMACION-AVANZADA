namespace P1H1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btAnadir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIngredienteEspecial = new System.Windows.Forms.Button();
            this.btNuevoPlato = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.rbParaLlevar = new System.Windows.Forms.RadioButton();
            this.rbComerAqui = new System.Windows.Forms.RadioButton();
            this.gbEnvase = new System.Windows.Forms.GroupBox();
            this.cbIsopor = new System.Windows.Forms.CheckBox();
            this.cbAluminio = new System.Windows.Forms.CheckBox();
            this.cbPlastico = new System.Windows.Forms.CheckBox();
            this.gbBebidas = new System.Windows.Forms.GroupBox();
            this.cbVino = new System.Windows.Forms.CheckBox();
            this.cbCerveza = new System.Windows.Forms.CheckBox();
            this.cbGaseosa = new System.Windows.Forms.CheckBox();
            this.cbJugo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbLocal.SuspendLayout();
            this.gbEnvase.SuspendLayout();
            this.gbBebidas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzas UTMACH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(92, 51);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(301, 22);
            this.txtCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingredientes:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Queso",
            "Tomate",
            "Mozzarella"});
            this.listBox1.Location = new System.Drawing.Point(36, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 132);
            this.listBox1.TabIndex = 4;
            // 
            // btAnadir
            // 
            this.btAnadir.Location = new System.Drawing.Point(181, 127);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(156, 23);
            this.btAnadir.TabIndex = 5;
            this.btAnadir.Text = "Añadir >>";
            this.btAnadir.UseVisualStyleBackColor = true;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(181, 156);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(156, 23);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "<< Excluir ";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btIngredienteEspecial
            // 
            this.btIngredienteEspecial.Location = new System.Drawing.Point(181, 185);
            this.btIngredienteEspecial.Name = "btIngredienteEspecial";
            this.btIngredienteEspecial.Size = new System.Drawing.Size(156, 23);
            this.btIngredienteEspecial.TabIndex = 7;
            this.btIngredienteEspecial.Text = "Ingrediente especial";
            this.btIngredienteEspecial.UseVisualStyleBackColor = true;
            this.btIngredienteEspecial.Click += new System.EventHandler(this.btIngredienteEspecial_Click);
            // 
            // btNuevoPlato
            // 
            this.btNuevoPlato.Location = new System.Drawing.Point(181, 214);
            this.btNuevoPlato.Name = "btNuevoPlato";
            this.btNuevoPlato.Size = new System.Drawing.Size(156, 23);
            this.btNuevoPlato.TabIndex = 8;
            this.btNuevoPlato.Text = "Nuevo plato";
            this.btNuevoPlato.UseVisualStyleBackColor = true;
            this.btNuevoPlato.Click += new System.EventHandler(this.btNuevoPlato_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(366, 127);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 132);
            this.listBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Plato:";
            // 
            // gbLocal
            // 
            this.gbLocal.Controls.Add(this.rbParaLlevar);
            this.gbLocal.Controls.Add(this.rbComerAqui);
            this.gbLocal.Location = new System.Drawing.Point(38, 289);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Size = new System.Drawing.Size(150, 121);
            this.gbLocal.TabIndex = 11;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "Local";
            // 
            // rbParaLlevar
            // 
            this.rbParaLlevar.AutoSize = true;
            this.rbParaLlevar.Location = new System.Drawing.Point(23, 47);
            this.rbParaLlevar.Name = "rbParaLlevar";
            this.rbParaLlevar.Size = new System.Drawing.Size(93, 20);
            this.rbParaLlevar.TabIndex = 1;
            this.rbParaLlevar.TabStop = true;
            this.rbParaLlevar.Text = "Para llevar";
            this.rbParaLlevar.UseVisualStyleBackColor = true;
            // 
            // rbComerAqui
            // 
            this.rbComerAqui.AutoSize = true;
            this.rbComerAqui.Location = new System.Drawing.Point(23, 21);
            this.rbComerAqui.Name = "rbComerAqui";
            this.rbComerAqui.Size = new System.Drawing.Size(97, 20);
            this.rbComerAqui.TabIndex = 0;
            this.rbComerAqui.TabStop = true;
            this.rbComerAqui.Text = "Comer aqui";
            this.rbComerAqui.UseVisualStyleBackColor = true;
            // 
            // gbEnvase
            // 
            this.gbEnvase.Controls.Add(this.cbIsopor);
            this.gbEnvase.Controls.Add(this.cbAluminio);
            this.gbEnvase.Controls.Add(this.cbPlastico);
            this.gbEnvase.Location = new System.Drawing.Point(204, 289);
            this.gbEnvase.Name = "gbEnvase";
            this.gbEnvase.Size = new System.Drawing.Size(133, 121);
            this.gbEnvase.TabIndex = 12;
            this.gbEnvase.TabStop = false;
            this.gbEnvase.Text = "Envase";
            // 
            // cbIsopor
            // 
            this.cbIsopor.AutoSize = true;
            this.cbIsopor.Location = new System.Drawing.Point(6, 73);
            this.cbIsopor.Name = "cbIsopor";
            this.cbIsopor.Size = new System.Drawing.Size(67, 20);
            this.cbIsopor.TabIndex = 2;
            this.cbIsopor.Text = "Isopor";
            this.cbIsopor.UseVisualStyleBackColor = true;
            // 
            // cbAluminio
            // 
            this.cbAluminio.AutoSize = true;
            this.cbAluminio.Location = new System.Drawing.Point(6, 47);
            this.cbAluminio.Name = "cbAluminio";
            this.cbAluminio.Size = new System.Drawing.Size(80, 20);
            this.cbAluminio.TabIndex = 1;
            this.cbAluminio.Text = "Aluminio";
            this.cbAluminio.UseVisualStyleBackColor = true;
            // 
            // cbPlastico
            // 
            this.cbPlastico.AutoSize = true;
            this.cbPlastico.Location = new System.Drawing.Point(6, 22);
            this.cbPlastico.Name = "cbPlastico";
            this.cbPlastico.Size = new System.Drawing.Size(77, 20);
            this.cbPlastico.TabIndex = 0;
            this.cbPlastico.Text = "Plastico";
            this.cbPlastico.UseVisualStyleBackColor = true;
            // 
            // gbBebidas
            // 
            this.gbBebidas.Controls.Add(this.cbVino);
            this.gbBebidas.Controls.Add(this.cbCerveza);
            this.gbBebidas.Controls.Add(this.cbGaseosa);
            this.gbBebidas.Controls.Add(this.cbJugo);
            this.gbBebidas.Location = new System.Drawing.Point(354, 289);
            this.gbBebidas.Name = "gbBebidas";
            this.gbBebidas.Size = new System.Drawing.Size(132, 121);
            this.gbBebidas.TabIndex = 13;
            this.gbBebidas.TabStop = false;
            this.gbBebidas.Text = "Bebidas";
            // 
            // cbVino
            // 
            this.cbVino.AutoSize = true;
            this.cbVino.Location = new System.Drawing.Point(6, 99);
            this.cbVino.Name = "cbVino";
            this.cbVino.Size = new System.Drawing.Size(56, 20);
            this.cbVino.TabIndex = 3;
            this.cbVino.Text = "Vino";
            this.cbVino.UseVisualStyleBackColor = true;
            // 
            // cbCerveza
            // 
            this.cbCerveza.AutoSize = true;
            this.cbCerveza.Location = new System.Drawing.Point(6, 73);
            this.cbCerveza.Name = "cbCerveza";
            this.cbCerveza.Size = new System.Drawing.Size(79, 20);
            this.cbCerveza.TabIndex = 2;
            this.cbCerveza.Text = "Cerveza";
            this.cbCerveza.UseVisualStyleBackColor = true;
            // 
            // cbGaseosa
            // 
            this.cbGaseosa.AutoSize = true;
            this.cbGaseosa.Location = new System.Drawing.Point(6, 47);
            this.cbGaseosa.Name = "cbGaseosa";
            this.cbGaseosa.Size = new System.Drawing.Size(85, 20);
            this.cbGaseosa.TabIndex = 1;
            this.cbGaseosa.Text = "Gaseosa";
            this.cbGaseosa.UseVisualStyleBackColor = true;
            // 
            // cbJugo
            // 
            this.cbJugo.AutoSize = true;
            this.cbJugo.Location = new System.Drawing.Point(6, 21);
            this.cbJugo.Name = "cbJugo";
            this.cbJugo.Size = new System.Drawing.Size(59, 20);
            this.cbJugo.TabIndex = 0;
            this.cbJugo.Text = "Jugo";
            this.cbJugo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCalcular);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(38, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 81);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago de pizza";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(339, 28);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 2;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(113, 29);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(148, 22);
            this.txtTotal.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total a pagar:";
            // 
            // Practica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBebidas);
            this.Controls.Add(this.gbEnvase);
            this.Controls.Add(this.gbLocal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btNuevoPlato);
            this.Controls.Add(this.btIngredienteEspecial);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Practica2";
            this.Text = "Practica2";
            this.gbLocal.ResumeLayout(false);
            this.gbLocal.PerformLayout();
            this.gbEnvase.ResumeLayout(false);
            this.gbEnvase.PerformLayout();
            this.gbBebidas.ResumeLayout(false);
            this.gbBebidas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btIngredienteEspecial;
        private System.Windows.Forms.Button btNuevoPlato;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.RadioButton rbParaLlevar;
        private System.Windows.Forms.RadioButton rbComerAqui;
        private System.Windows.Forms.GroupBox gbEnvase;
        private System.Windows.Forms.CheckBox cbIsopor;
        private System.Windows.Forms.CheckBox cbAluminio;
        private System.Windows.Forms.CheckBox cbPlastico;
        private System.Windows.Forms.GroupBox gbBebidas;
        private System.Windows.Forms.CheckBox cbCerveza;
        private System.Windows.Forms.CheckBox cbGaseosa;
        private System.Windows.Forms.CheckBox cbJugo;
        private System.Windows.Forms.CheckBox cbVino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCalcular;
    }
}