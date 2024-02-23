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
            this.librosNoSelec = ln.ListaLibrosDisponibles();
            this.librosSelec = new Dictionary<int, string>();
            cargarDatos();
        }

        CapaLogica.Gestion.PrestamoLN ln;
        Dictionary<int, string> librosNoSelec;
        Dictionary<int, string> librosSelec;

        public void cargarDatos()
        {
            var estudiantes = ln.ListaEstudiantes();
            cbEstudiante.DataSource = new BindingSource(estudiantes, null);
            cbEstudiante.DisplayMember = "Value";
            cbEstudiante.ValueMember = "Key";
            cargarListas();
        }

        public void cargarListas()
        {
            if(librosNoSelec.Count > 0)
            {
                lbNoSelec.DisplayMember = null;
                lbNoSelec.ValueMember = null;
                lbNoSelec.DataSource = new BindingSource(librosNoSelec, null);
                lbNoSelec.DisplayMember = "Value";
                lbNoSelec.ValueMember = "Key";
            }
            if(librosSelec.Count > 0)
            {
                lbSelec.DisplayMember = null;
                lbSelec.ValueMember = null;
                lbSelec.DataSource = new BindingSource(librosSelec, null);
                lbSelec.DisplayMember = "Value";
                lbSelec.ValueMember = "Key";
            }
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
            op.Estado = cbEstado.Text;
            op.Fecha_devolucion = dateFechaDevolucion.Value;
            op.Fecha_entrega = dateFechaEntrega.Value;
            op.Fecha_tentativa = dateFechaTentativa.Value;
            op.Id_estudiante = (int)cbEstudiante.SelectedValue;
            return op;
        }

        public List<int> getLibros()
        {
            List<int> estudiantes = new List<int>();
            foreach (var item in librosSelec)
            {
                estudiantes.Add(item.Key);
            }
            return estudiantes;
        }

        public void setDatos(int codigoPrestamo, List<int> codigosLibros)
        {
            txtCodigo.Text = codigoPrestamo.ToString();
            var prestamo = ln.BuscarPrestamo(codigoPrestamo);
            cbEstado.Text = prestamo.Estado;
            dateFechaDevolucion.Value = prestamo.Fecha_devolucion;
            dateFechaEntrega.Value = prestamo.Fecha_entrega;
            dateFechaTentativa.Value = prestamo.Fecha_tentativa;
            cbEstudiante.SelectedValue = prestamo.Id_estudiante;
            foreach (var item in codigosLibros)
            {
                librosSelec.Add(item, librosNoSelec[item]);
                librosNoSelec.Remove(item);
            }
            cargarListas();
        }

        private bool validar()
        {
            if (lbSelec.Items.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un libro");
                return false;
            }
            if(txtCodigo.Enabled && txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un codigo");
                return false;
            }
            if(cbEstado.Text == "")
            {
                MessageBox.Show("Debe seleccionar un estado");
                return false;
            }
            if(cbEstudiante.Text == "")
            {
                MessageBox.Show("Debe seleccionar un estudiante");
                return false;
            }
            if(dateFechaDevolucion.Value == null)
            {
                MessageBox.Show("Debe seleccionar una fecha de devolucion");
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
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AggLibro();
        }

        public void AggLibro()
        {
            if (lbNoSelec.SelectedIndex != -1)
            {
                librosSelec.Add((int)lbNoSelec.SelectedValue, lbNoSelec.Text);
                librosNoSelec.Remove((int)lbNoSelec.SelectedValue);
                cargarListas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un libro");
            }
        }
        
        public void QuitarLibro()
        {
            if (lbSelec.SelectedIndex != -1)
            {
                librosNoSelec.Add((int)lbSelec.SelectedValue, lbSelec.Text);
                librosSelec.Remove((int)lbSelec.SelectedValue);
                cargarListas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un libro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuitarLibro();
        }
    }
}
