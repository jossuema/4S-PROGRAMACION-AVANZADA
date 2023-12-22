using HerenciaPolimorfismo.Controlador;
using HerenciaPolimorfismo.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia.Formularios
{
    public partial class FrmAdminEmpleado : Form
    {
        private Label label2;
        private ComboBox comboBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        public Label label1;

        public FrmAdminEmpleado()
        {
            InitializeComponent();
        }

        public void nuevo()
        {
            try
            {
                FrmEditEmpleado frm = new FrmEditEmpleado();
                frm.label1.Text = "Insertar Empleado";
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Empleado obp = frm.CrearObjetoEmpleado();
                    frm.Hide();
                    TLista.insert(obp);
                    MessageBox.Show("Trabajador Creado");
                    listarPersonas();
                }
            }catch (Exception ex)
            {
                     MessageBox.Show(ex.Message);
            }
        }

        public void modificar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    FrmEditEmpleado frm = new FrmEditEmpleado();
                    frm.opcion = 2;
                    int cod = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;
                    
                    frm.auxiliar = TLista.getEmpleado(TLista.buscar(cod));
                    frm.setDatosEmpleado();
                    frm.Text = "Actualizar Datos";
                    frm.ShowDialog();

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        Empleado op = frm.CrearObjetoEmpleado();
                        TLista.update(op, TLista.buscar(frm.auxiliar.Codigo));
                        frm.Close();
                        listarPersonas();
                    }

                }
                else
                    MessageBox.Show("Selecciona la fila a modificar");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: "+ex.Message);
            }
        }

        public void eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var res = MessageBox.Show("! Deseas eliminar empleado", "Eliminar Empleado", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        int op = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;
                        int pos = TLista.buscar(op);
                        TLista.delete(pos);
                        MessageBox.Show("Empleado eliminado");
                        listarPersonas();
                    }
                }
                else
                    MessageBox.Show("Seleccione la fila eliminar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void listarPersonas()
        {
            if(comboBox1.SelectedIndex==0)
            {
                ListaPersonas("Asalariado");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                ListaPersonas("Asalariado por comision");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                ListaPersonas("Por comision");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                ListaPersonas("Por horas");
            }
            if(comboBox1.SelectedIndex == -1 || comboBox1.SelectedIndex == 4)
            {
                ListaPersonas("Todos");
            }
        }

        public void ListaPersonas(string tipo)
        {
            dataGridView1.Rows.Clear();
            for (int i=0;TLista.listaEmpleados.Count>i;i++)
            {
                Empleado aux = TLista.listaEmpleados[i];
                if(tipo=="Todos")
                {
                    dataGridView1.Rows.Add(aux.Codigo, aux.Cedula, aux.Nombres, aux.Apellidos, aux.FechaNacimiento, aux.Sexo, aux.Estado, getTipo(aux.GetType().ToString()), aux.Salario());
                }
                if (tipo == "Asalariado" && aux is Asalariado)
                {
                    aux = (Asalariado)aux;
                    dataGridView1.Rows.Add(aux.Codigo, aux.Cedula, aux.Nombres, aux.Apellidos, aux.FechaNacimiento, aux.Sexo, aux.Estado, getTipo(aux.GetType().ToString()), aux.Salario());
                }
                if (tipo == "Asalariado por comision" && aux is AsalariadoPorComision)
                {
                    aux = (AsalariadoPorComision)aux;
                    dataGridView1.Rows.Add(aux.Codigo, aux.Cedula, aux.Nombres, aux.Apellidos, aux.FechaNacimiento, aux.Sexo, aux.Estado, getTipo(aux.GetType().ToString()), aux.Salario());
                }
                if (tipo == "Por comision" && aux is PorComision)
                {
                    aux = (PorComision)aux;
                    dataGridView1.Rows.Add(aux.Codigo, aux.Cedula, aux.Nombres, aux.Apellidos, aux.FechaNacimiento, aux.Sexo, aux.Estado, getTipo(aux.GetType().ToString()), aux.Salario());
                }
                if (tipo == "Por horas" && aux is PorHoras)
                {
                    aux = (PorHoras)aux;
                    dataGridView1.Rows.Add(aux.Codigo, aux.Cedula, aux.Nombres, aux.Apellidos, aux.FechaNacimiento, aux.Sexo, aux.Estado, getTipo(aux.GetType().ToString()), aux.Salario());
                }
                
            }
        }

        public string getTipo(string tipo)
        {
            string aux = "";
            if (tipo == typeof(Asalariado).ToString())
            {
                aux = "Asalariado";
            }
            if (tipo == typeof(AsalariadoPorComision).ToString())
            {
                aux = "Asalariado por comision";
            }
            if (tipo == typeof(PorComision).ToString())
            {
                aux = "Por comision";
            }
            if (tipo == typeof(PorHoras).ToString())
            {
                aux = "Por horas";
            }
            return aux;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminEmpleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Listar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Asalariado",
            "Asalariado por comision",
            "Por comision",
            "Por horas",
            "Todos"});
            this.comboBox1.Location = new System.Drawing.Point(781, 78);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 24);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Snow;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.toolStripButton6,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(80, 488);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.DoubleClickEnabled = true;
            this.toolStripButton1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 56);
            this.toolStripButton1.Text = "Insertar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(73, 6);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 56);
            this.toolStripButton2.Text = "Modificar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(73, 6);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.CheckOnClick = true;
            this.toolStripButton3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(73, 56);
            this.toolStripButton3.Text = "Eliminar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(73, 6);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(73, 56);
            this.toolStripButton5.Text = "Backup";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(73, 6);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(73, 56);
            this.toolStripButton6.Text = "Restaurar";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.CheckOnClick = true;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(73, 56);
            this.toolStripButton4.Text = "Salir";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(137, 135);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Size = new System.Drawing.Size(793, 256);
            this.dataGridView1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "ADMINISTRAR EMPLEADOS";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Codigo";
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Cedula";
            this.Column2.HeaderText = "Cedula";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "Nombres";
            this.Column3.HeaderText = "Nombres";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "Apellidos";
            this.Column4.HeaderText = "Apellidos";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "FechaNacimiento";
            this.Column6.HeaderText = "Fecha de nacimiento";
            this.Column6.MinimumWidth = 9;
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "Sexo";
            this.Column5.HeaderText = "Sexo";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            this.Column5.Width = 40;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.DataPropertyName = "Estado";
            this.Column7.HeaderText = "Estado";
            this.Column7.MinimumWidth = 9;
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.DataPropertyName = "Tipo";
            this.Column8.HeaderText = "Tipo";
            this.Column8.MinimumWidth = 9;
            this.Column8.Name = "Column8";
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Salario()";
            this.Column9.HeaderText = "Sueldo";
            this.Column9.MinimumWidth = 9;
            this.Column9.Name = "Column9";
            this.Column9.Width = 60;
            // 
            // FrmAdminEmpleado
            // 
            this.ClientSize = new System.Drawing.Size(964, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdminEmpleado";
            this.Load += new System.EventHandler(this.FrmAdminEmpleado_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmAdminEmpleado_Load(object sender, EventArgs e)
        {
            TLista.cargarLista();
            listarPersonas();
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            listarPersonas();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            nuevo();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            modificar();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            eliminar();
            TLista.guardarLista();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            TLista.guardarLista();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            TLista.cargarLista();
        }
    }
}
