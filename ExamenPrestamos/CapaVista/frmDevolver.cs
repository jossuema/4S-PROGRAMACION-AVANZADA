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
    public partial class frmDevolver : Form
    {
        public frmDevolver()
        {
            InitializeComponent();
            ln = new PrestamoLN();
        }

        PrestamoLN ln;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void setDatos(int codigo)
        {
            Prestamo m = ln.BuscarPrestamo(codigo);
            txtCodigo.Text = m.Codigo.ToString();
            txtCodigo.Enabled = false;
            txtCliente.Text = m.CedulaCliente;
            txtCliente.Enabled = false;
            txtMaquinaria.Text = m.CodigoMaquinaria;
            txtMaquinaria.Enabled = false;
            dtpEntrega.Value = m.FechaEntrega;
            dtpEntrega.Enabled = false;
            dtptentativa.Value = m.FechaTentativa;
            dtptentativa.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                ln.ActualizarPrestamo(getDatos());
                MessageBox.Show("Prestamo devuelto con éxito");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool validar()
        {
            if (dtpDevolucion == null)
            {
                MessageBox.Show("Debe seleccionar una fecha de devolución");
                return false;
            }
            return true;
        }

        private Prestamo getDatos()
        {
            Prestamo p = new Prestamo();
            p = ln.BuscarPrestamo(int.Parse(txtCodigo.Text));
            p.FechaDevolucion = dtpDevolucion.Value;
            p.Estado = "Entregado";
            return p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
