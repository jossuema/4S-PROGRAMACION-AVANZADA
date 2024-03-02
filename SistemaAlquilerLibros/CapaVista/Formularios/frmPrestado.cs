using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capavista.Formularios
{
    public partial class frmPrestado : Form
    {
        public frmPrestado()
        {
            InitializeComponent();
            this.ln = new CapaLogica.Gestion.PrestamoLN();
            cargarDatos();
        }

        CapaLogica.Gestion.PrestamoLN ln;

        public void cargarDatos()
        {
            var estudiantes = ln.ListaEstudiantesPendientes();
            cbEstudiante.DataSource = new BindingSource(estudiantes, null);
            cbEstudiante.DisplayMember = "Value";
            cbEstudiante.ValueMember = "Key";
            cargarTabla();
        }

        public void cargarTabla()
        {
            dataGridView1.DataSource = ln.Lista4ColumnasLibro();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar");
            }
        }

        public CapaEntidades.Gestion.Prestamo getDatos()
        {
            CapaEntidades.Gestion.Prestamo op = new CapaEntidades.Gestion.Prestamo();
            op.Id_prestamo = int.Parse(txtCodigo.Text);
            op.Estado = "En curso";
            op.Fecha_entrega = dateFechaEntrega.Value;
            op.Fecha_tentativa = dateFechaTentativa.Value;
            op.Id_estudiante = (int)cbEstudiante.SelectedValue;
            return op;
        }

        public List<int> getLibros()
        {
            List<int> lista = new List<int>();
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                if (item.Cells[0].Value != null)
                {
                    lista.Add((int)item.Cells[0].Value);
                }
            }
            return lista;
        }
        

        public void setDatos(int codigoPrestamo, List<int> codigosLibros)
        {
            txtCodigo.Text = codigoPrestamo.ToString();
            MessageBox.Show(codigoPrestamo.ToString());
            var prestamo = ln.BuscarPrestamo(codigoPrestamo);
            dateFechaEntrega.Value = prestamo.Fecha_entrega;
            dateFechaTentativa.Value = prestamo.Fecha_tentativa;
            cbEstudiante.SelectedValue = prestamo.Id_estudiante;
            int a = 0;
            dataGridView1.ClearSelection();
            foreach(DataGridViewRow item in dataGridView1.Rows)
            {
                if (codigosLibros.Contains((int)item.Cells[0].Value))
                {
                    dataGridView1.Rows[a].Selected = true;
                }
                a++;
            }
        }

        private bool validar()
        {
            if(txtCodigo.Enabled && txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un codigo");
                return false;
            }
            if(cbEstudiante.Text == "")
            {
                MessageBox.Show("Debe seleccionar un estudiante");
                return false;
            }
            if(dateFechaEntrega.Value == null)
            {
                MessageBox.Show("Debe seleccionar una fecha de entrega");
                return false;
            }
            if(dateFechaTentativa.Value == null)
            {
                MessageBox.Show("Debe seleccionar una fecha tentativa");
                return false;
            }
            int cont = 0;
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                if (item.Cells[0].Value != null)
                {
                    cont++;
                }
            }
            if (cont == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un libro");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
