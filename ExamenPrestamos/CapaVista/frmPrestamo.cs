using CapaEntidad.Gestion;
using CapaLogica.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
            ln = new PrestamoLN();
            CargarDatos();
        }

        PrestamoLN ln;

        private void CargarDatos()
        {
            cbCliente.DataSource = null;
            cbCliente.Items.Clear();

            cbCliente.DisplayMember = "Value";
            cbCliente.ValueMember = "Key";
            cbCliente.DataSource = new BindingSource(ln.ComboBoxClientes(), null);

            cbMaquinaria.DataSource = null;
            cbMaquinaria.Items.Clear();

            cbMaquinaria.DisplayMember = "Value";
            cbMaquinaria.ValueMember = "Key";
            cbMaquinaria.DataSource = new BindingSource(ln.ComboBoxMaquinarias(), null);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                ln.InsertarPrestamo(getDatos());
                MessageBox.Show("Prestamo registrado con éxito");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private Prestamo getDatos() {
            Prestamo p = new Prestamo();
            p.Codigo = int.Parse(txtCodigo.Text);
            p.CedulaCliente = cbCliente.SelectedValue.ToString();
            p.CodigoMaquinaria = cbMaquinaria.SelectedValue.ToString();
            p.FechaEntrega = dtpEntrega.Value;
            p.FechaTentativa = dtpTentativa.Value;
            p.FechaDevolucion = null;
            p.Estado = "Alquilado";
            return p;
        }

        private bool Validar()
        {
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar el código del préstamo");
                txtCodigo.Focus();
                return false;
            }
            if(cbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                cbCliente.Focus();
                return false;
            }
            if(cbMaquinaria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una maquinaria");
                cbMaquinaria.Focus();
                return false;
            }
            if(dtpEntrega.Value == null)
            {
                MessageBox.Show("Debe seleccionar la fecha de entrega");
                dtpEntrega.Focus();
                return false;
            }
            if(dtpTentativa.Value == null)
            {
                MessageBox.Show("Debe seleccionar la fecha tentativa de devolución");
                dtpTentativa.Focus();
                return false;
            }
            return true;
        }
    }
}
