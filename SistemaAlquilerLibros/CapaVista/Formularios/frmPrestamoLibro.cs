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
    public partial class frmPrestamoLibro : Form
    {
        public frmPrestamoLibro()
        {
            InitializeComponent();
            ln = new CapaLogica.Gestion.PrestamoLibroLN();
            ListarComboBox();
        }

        CapaLogica.Gestion.PrestamoLibroLN ln;

        public void ListarComboBox()
        {
            var lista = ln.ListarPrestamo();
            cbPrestamo.DataSource = new BindingSource(lista, null);
            cbPrestamo.DisplayMember = "Value";
            cbPrestamo.ValueMember = "Key";
            var lista2 = ln.ListarLibros();
            cbLibro.DataSource = new BindingSource(lista2, null);
            cbLibro.DisplayMember = "Value";
            cbLibro.ValueMember = "Key";
        }

        private bool verificar()
        {
            if (cbPrestamo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un prestamo");
                return false;
            }
            if (cbLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un libro");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en InsertarPrestamoLibro: " + ex.Message);
            }

        }

        public CapaEntidades.Gestion.PrestamoLibro getDatos()
        {
            CapaEntidades.Gestion.PrestamoLibro prestamoLibro = new CapaEntidades.Gestion.PrestamoLibro();
            prestamoLibro.id_libro = ((KeyValuePair<int, string>)cbLibro.SelectedItem).Key;
            prestamoLibro.id_prestamo = ((KeyValuePair<int, string>)cbPrestamo.SelectedItem).Key;
            return prestamoLibro;
        }   
    }
}
