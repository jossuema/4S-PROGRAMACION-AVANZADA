namespace P1H1
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
            this.gbProcesador = new System.Windows.Forms.GroupBox();
            this.rbCore2Duo = new System.Windows.Forms.RadioButton();
            this.rbDualCore = new System.Windows.Forms.RadioButton();
            this.rbAMD = new System.Windows.Forms.RadioButton();
            this.rbP4 = new System.Windows.Forms.RadioButton();
            this.gbMemoria = new System.Windows.Forms.GroupBox();
            this.rb2TB = new System.Windows.Forms.RadioButton();
            this.rb1TB = new System.Windows.Forms.RadioButton();
            this.rb512GB = new System.Windows.Forms.RadioButton();
            this.rb256GB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btGenerarFactura = new System.Windows.Forms.Button();
            this.btCalcularTotal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbProcesador.SuspendLayout();
            this.gbMemoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProcesador
            // 
            this.gbProcesador.Controls.Add(this.rbCore2Duo);
            this.gbProcesador.Controls.Add(this.rbDualCore);
            this.gbProcesador.Controls.Add(this.rbAMD);
            this.gbProcesador.Controls.Add(this.rbP4);
            this.gbProcesador.Location = new System.Drawing.Point(57, 25);
            this.gbProcesador.Name = "gbProcesador";
            this.gbProcesador.Size = new System.Drawing.Size(182, 109);
            this.gbProcesador.TabIndex = 0;
            this.gbProcesador.TabStop = false;
            this.gbProcesador.Text = "Procesador";
            // 
            // rbCore2Duo
            // 
            this.rbCore2Duo.AutoSize = true;
            this.rbCore2Duo.Location = new System.Drawing.Point(80, 67);
            this.rbCore2Duo.Name = "rbCore2Duo";
            this.rbCore2Duo.Size = new System.Drawing.Size(93, 20);
            this.rbCore2Duo.TabIndex = 3;
            this.rbCore2Duo.TabStop = true;
            this.rbCore2Duo.Text = "Core 2 duo";
            this.rbCore2Duo.UseVisualStyleBackColor = true;
            // 
            // rbDualCore
            // 
            this.rbDualCore.AutoSize = true;
            this.rbDualCore.Location = new System.Drawing.Point(80, 30);
            this.rbDualCore.Name = "rbDualCore";
            this.rbDualCore.Size = new System.Drawing.Size(86, 20);
            this.rbDualCore.TabIndex = 2;
            this.rbDualCore.TabStop = true;
            this.rbDualCore.Text = "Dual core";
            this.rbDualCore.UseVisualStyleBackColor = true;
            // 
            // rbAMD
            // 
            this.rbAMD.AutoSize = true;
            this.rbAMD.Location = new System.Drawing.Point(6, 67);
            this.rbAMD.Name = "rbAMD";
            this.rbAMD.Size = new System.Drawing.Size(58, 20);
            this.rbAMD.TabIndex = 1;
            this.rbAMD.TabStop = true;
            this.rbAMD.Text = "AMD";
            this.rbAMD.UseVisualStyleBackColor = true;
            // 
            // rbP4
            // 
            this.rbP4.AutoSize = true;
            this.rbP4.Location = new System.Drawing.Point(6, 30);
            this.rbP4.Name = "rbP4";
            this.rbP4.Size = new System.Drawing.Size(44, 20);
            this.rbP4.TabIndex = 0;
            this.rbP4.TabStop = true;
            this.rbP4.Text = "P4";
            this.rbP4.UseVisualStyleBackColor = true;
            // 
            // gbMemoria
            // 
            this.gbMemoria.Controls.Add(this.rb2TB);
            this.gbMemoria.Controls.Add(this.rb1TB);
            this.gbMemoria.Controls.Add(this.rb512GB);
            this.gbMemoria.Controls.Add(this.rb256GB);
            this.gbMemoria.Location = new System.Drawing.Point(287, 25);
            this.gbMemoria.Name = "gbMemoria";
            this.gbMemoria.Size = new System.Drawing.Size(182, 109);
            this.gbMemoria.TabIndex = 1;
            this.gbMemoria.TabStop = false;
            this.gbMemoria.Text = "Memoria";
            this.gbMemoria.Enter += new System.EventHandler(this.gbMemoria_Enter);
            // 
            // rb2TB
            // 
            this.rb2TB.AutoSize = true;
            this.rb2TB.Location = new System.Drawing.Point(80, 67);
            this.rb2TB.Name = "rb2TB";
            this.rb2TB.Size = new System.Drawing.Size(56, 20);
            this.rb2TB.TabIndex = 3;
            this.rb2TB.TabStop = true;
            this.rb2TB.Text = "2 TB";
            this.rb2TB.UseVisualStyleBackColor = true;
            // 
            // rb1TB
            // 
            this.rb1TB.AutoSize = true;
            this.rb1TB.Location = new System.Drawing.Point(80, 30);
            this.rb1TB.Name = "rb1TB";
            this.rb1TB.Size = new System.Drawing.Size(56, 20);
            this.rb1TB.TabIndex = 2;
            this.rb1TB.TabStop = true;
            this.rb1TB.Text = "1 TB";
            this.rb1TB.UseVisualStyleBackColor = true;
            // 
            // rb512GB
            // 
            this.rb512GB.AutoSize = true;
            this.rb512GB.Location = new System.Drawing.Point(6, 67);
            this.rb512GB.Name = "rb512GB";
            this.rb512GB.Size = new System.Drawing.Size(71, 20);
            this.rb512GB.TabIndex = 1;
            this.rb512GB.TabStop = true;
            this.rb512GB.Text = "512 GB";
            this.rb512GB.UseVisualStyleBackColor = true;
            // 
            // rb256GB
            // 
            this.rb256GB.AutoSize = true;
            this.rb256GB.Location = new System.Drawing.Point(6, 30);
            this.rb256GB.Name = "rb256GB";
            this.rb256GB.Size = new System.Drawing.Size(71, 20);
            this.rb256GB.TabIndex = 0;
            this.rb256GB.TabStop = true;
            this.rb256GB.Text = "256 GB";
            this.rb256GB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Monitor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LG LCD 17 Plg",
            "LG LCD 20 Plg"});
            this.comboBox1.Location = new System.Drawing.Point(57, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione accesorios:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Tarjeta de video",
            "Tarjeta sonido 5.1",
            "Parlantes 5.1"});
            this.checkedListBox1.Location = new System.Drawing.Point(293, 187);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(176, 123);
            this.checkedListBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.Precio,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(31, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(459, 222);
            this.dataGridView1.TabIndex = 6;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // btGenerarFactura
            // 
            this.btGenerarFactura.Location = new System.Drawing.Point(93, 580);
            this.btGenerarFactura.Name = "btGenerarFactura";
            this.btGenerarFactura.Size = new System.Drawing.Size(130, 23);
            this.btGenerarFactura.TabIndex = 7;
            this.btGenerarFactura.Text = "Generar factura";
            this.btGenerarFactura.UseVisualStyleBackColor = true;
            this.btGenerarFactura.Click += new System.EventHandler(this.btGenerarFactura_Click);
            // 
            // btCalcularTotal
            // 
            this.btCalcularTotal.Location = new System.Drawing.Point(93, 620);
            this.btCalcularTotal.Name = "btCalcularTotal";
            this.btCalcularTotal.Size = new System.Drawing.Size(130, 23);
            this.btCalcularTotal.TabIndex = 8;
            this.btCalcularTotal.Text = "Calcular total";
            this.btCalcularTotal.UseVisualStyleBackColor = true;
            this.btCalcularTotal.Click += new System.EventHandler(this.btCalcularTotal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "IVA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 636);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(355, 567);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 12;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(355, 598);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 22);
            this.txtIVA.TabIndex = 13;
            this.txtIVA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(355, 630);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 14;
            // 
            // Practica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 686);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCalcularTotal);
            this.Controls.Add(this.btGenerarFactura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMemoria);
            this.Controls.Add(this.gbProcesador);
            this.Name = "Practica1";
            this.Text = "Armar computador";
            this.Load += new System.EventHandler(this.Practica1_Load);
            this.gbProcesador.ResumeLayout(false);
            this.gbProcesador.PerformLayout();
            this.gbMemoria.ResumeLayout(false);
            this.gbMemoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProcesador;
        private System.Windows.Forms.RadioButton rbCore2Duo;
        private System.Windows.Forms.RadioButton rbDualCore;
        private System.Windows.Forms.RadioButton rbAMD;
        private System.Windows.Forms.RadioButton rbP4;
        private System.Windows.Forms.GroupBox gbMemoria;
        private System.Windows.Forms.RadioButton rb2TB;
        private System.Windows.Forms.RadioButton rb1TB;
        private System.Windows.Forms.RadioButton rb512GB;
        private System.Windows.Forms.RadioButton rb256GB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btGenerarFactura;
        private System.Windows.Forms.Button btCalcularTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
    }
}