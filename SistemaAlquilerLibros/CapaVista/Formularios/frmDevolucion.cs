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
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
            ln = new CapaLogica.Gestion.PrestamoLN();
            ListarCB();
            Listar();
        }

        CapaLogica.Gestion.PrestamoLN ln;


        private void ListarCB()
        {
            cbEstudiante.DataSource = new BindingSource(ln.ListaEstudiantes(), null);
            cbEstudiante.DisplayMember = "Value";
            cbEstudiante.ValueMember = "Key";
        }
        private void Listar()
        {
            try
            {
                int id = ((KeyValuePair<int, string>)cbEstudiante.SelectedItem).Key;
                MessageBox.Show(id + "");
                dataGridView1.DataSource = ln.LibrosNoDevueltosEstudiante(id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDevolver_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int idEstudiante = int.Parse(cbEstudiante.SelectedValue.ToString());
                int idPrestamo = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DateTime fecha = dateTimePicker1.Value;
                ln.DevolverLibro(idPrestamo, idEstudiante, fecha);
                Listar();
            }
        }

        private bool validar()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un libro prestado");
                return false;
            }
            if(dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha de devolucion no puede ser menor a la fecha actual");
                return false;
            }
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Seleccione una fecha de devolucion");
                return false;
            }
            return true;
        }

        private void cbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
