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
    public partial class frmAdminPrestamo : Form
    {
        public frmAdminPrestamo()
        {
            InitializeComponent();
            ln = new PrestamoLN();
            Listar();
        }

        PrestamoLN ln = new PrestamoLN();

        private void Listar()
        {
            try
            {
                dtgProducto.DataSource = ln.ListarPrestamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al listar prestamos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevo()
        {
            frmPrestamo frm = new frmPrestamo();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void Eliminar()
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dtgProducto.SelectedRows[0].Cells[0].Value);
                    ln.EliminarPrestamo(id);
                    Listar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un prestamo", "Error al eliminar prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
