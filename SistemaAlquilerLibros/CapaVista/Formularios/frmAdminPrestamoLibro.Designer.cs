namespace capavista.Formularios
{
    partial class frmAdminPrestamoLibro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPrestamoLibro));
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsBarraPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.idPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tlsBarraPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgProducto
            // 
            this.dtgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPrestamo,
            this.estadoPrestamo,
            this.fechaPrestamo,
            this.fechaDevolucion,
            this.idLibro,
            this.nombreLibro,
            this.tipoLibro,
            this.estadoLibro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProducto.Location = new System.Drawing.Point(78, 48);
            this.dtgProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dtgProducto.MultiSelect = false;
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.ReadOnly = true;
            this.dtgProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgProducto.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProducto.Size = new System.Drawing.Size(722, 373);
            this.dtgProducto.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(78, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 48);
            this.panel1.TabIndex = 25;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(159, 11);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(332, 26);
            this.txtBuscar.TabIndex = 27;
            this.txtBuscar.Tag = "d";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Buscar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(78, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(722, 29);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 23);
            this.lblEstado.Text = "Listo...";
            // 
            // tlsBarraPrincipal
            // 
            this.tlsBarraPrincipal.AutoSize = false;
            this.tlsBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlsBarraPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsBarraPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3});
            this.tlsBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraPrincipal.Name = "tlsBarraPrincipal";
            this.tlsBarraPrincipal.Size = new System.Drawing.Size(78, 450);
            this.tlsBarraPrincipal.TabIndex = 26;
            this.tlsBarraPrincipal.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 56);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(76, 56);
            this.toolStripButton3.Text = "Eliminar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // idPrestamo
            // 
            this.idPrestamo.DataPropertyName = "idPrestamo";
            this.idPrestamo.HeaderText = "ID Prestamo";
            this.idPrestamo.MinimumWidth = 6;
            this.idPrestamo.Name = "idPrestamo";
            this.idPrestamo.ReadOnly = true;
            this.idPrestamo.Width = 132;
            // 
            // estadoPrestamo
            // 
            this.estadoPrestamo.DataPropertyName = "estadoPrestamo";
            this.estadoPrestamo.HeaderText = "Estado Prestamo";
            this.estadoPrestamo.MinimumWidth = 6;
            this.estadoPrestamo.Name = "estadoPrestamo";
            this.estadoPrestamo.ReadOnly = true;
            this.estadoPrestamo.Width = 153;
            // 
            // fechaPrestamo
            // 
            this.fechaPrestamo.DataPropertyName = "fechaPrestamo";
            this.fechaPrestamo.HeaderText = "Fecha Prestamo";
            this.fechaPrestamo.MinimumWidth = 6;
            this.fechaPrestamo.Name = "fechaPrestamo";
            this.fechaPrestamo.ReadOnly = true;
            this.fechaPrestamo.Width = 147;
            // 
            // fechaDevolucion
            // 
            this.fechaDevolucion.DataPropertyName = "fechaDevolucion";
            this.fechaDevolucion.HeaderText = "Fecha Devolucion";
            this.fechaDevolucion.MinimumWidth = 6;
            this.fechaDevolucion.Name = "fechaDevolucion";
            this.fechaDevolucion.ReadOnly = true;
            this.fechaDevolucion.Width = 157;
            // 
            // idLibro
            // 
            this.idLibro.DataPropertyName = "idLibro";
            this.idLibro.HeaderText = "ID Libro";
            this.idLibro.MinimumWidth = 6;
            this.idLibro.Name = "idLibro";
            this.idLibro.ReadOnly = true;
            this.idLibro.Width = 91;
            // 
            // nombreLibro
            // 
            this.nombreLibro.DataPropertyName = "nombreLibro";
            this.nombreLibro.HeaderText = "Nombre Libro";
            this.nombreLibro.MinimumWidth = 6;
            this.nombreLibro.Name = "nombreLibro";
            this.nombreLibro.ReadOnly = true;
            this.nombreLibro.Width = 128;
            // 
            // tipoLibro
            // 
            this.tipoLibro.DataPropertyName = "tipoLibro";
            this.tipoLibro.HeaderText = "Tipo Libro";
            this.tipoLibro.MinimumWidth = 6;
            this.tipoLibro.Name = "tipoLibro";
            this.tipoLibro.ReadOnly = true;
            this.tipoLibro.Width = 104;
            // 
            // estadoLibro
            // 
            this.estadoLibro.DataPropertyName = "estadoLibro";
            this.estadoLibro.HeaderText = "Estado Libro";
            this.estadoLibro.MinimumWidth = 6;
            this.estadoLibro.Name = "estadoLibro";
            this.estadoLibro.ReadOnly = true;
            this.estadoLibro.Width = 122;
            // 
            // frmAdminPrestamoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tlsBarraPrincipal);
            this.Name = "frmAdminPrestamoLibro";
            this.Text = "frmAdminPrestamoLibro";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlsBarraPrincipal.ResumeLayout(false);
            this.tlsBarraPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStrip tlsBarraPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoLibro;
    }
}