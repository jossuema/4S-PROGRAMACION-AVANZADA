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
    public partial class frmLibrosBaja : Form
    {
        public frmLibrosBaja()
        {
            InitializeComponent();
            ln = new CapaLogica.Gestion.HistorialBajaLN();
            ListarComboBox();
        }

        CapaLogica.Gestion.HistorialBajaLN ln;

        private void ListarComboBox()
        {
            try
            {
                var lista = ln.ListarLibros();
                cbLibro.DataSource = new BindingSource(lista, null);
                cbLibro.DisplayMember = "Value";
                cbLibro.ValueMember = "Key";
                cbLibro.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void setDatos(int id)
        {
            var op = ln.BuscarHistorialBaja(id);
            cbLibro.SelectedValue = op.IdLibro;
            dtgFecha.Value = op.FechaBaja;
            txtMotivo.Text = op.Motivo;
            txtDecremento.Text = op.DecrementoStock.ToString();
        }

        private bool verificar()
        {
            if (cbLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un libro");
                return false;
            }
            if (txtMotivo.Text == "")
            {
                MessageBox.Show("Ingrese un motivo");
                return false;
            }
            if (txtDecremento.Text == "")
            {
                MessageBox.Show("Ingrese un decremento");
                return false;
            }
            if(dtgFecha.Value == null)
            {
                MessageBox.Show("Ingrese una fecha");
                return false;
            }
            return true;
        }

        public CapaEntidades.Gestion.HistorialBaja getDatos()
        {
            var op = new CapaEntidades.Gestion.HistorialBaja();
            op.IdBaja = 0;
            op.IdLibro = ((KeyValuePair<int, string>)cbLibro.SelectedItem).Key;
            op.FechaBaja = dtgFecha.Value;
            op.Motivo = txtMotivo.Text;
            op.DecrementoStock = Convert.ToInt32(txtDecremento.Text);
            return op;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }   
        }
    }
}
