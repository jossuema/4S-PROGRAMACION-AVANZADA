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
    public partial class frmAdminPrestamo : Form
    {
        public frmAdminPrestamo()
        {
            InitializeComponent();
            this.ln = new CapaLogica.Gestion.PrestamoLN();
            Listar();
        }

        CapaLogica.Gestion.PrestamoLN ln;

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            dtgProducto.DataSource = ln.ListarPrestamoFiltro(txtBuscar.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            try
            {
                frmPrestado frm = new frmPrestado();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    var prestamo = frm.getDatos();
                    var libros = frm.getLibros();
                    ln.InsertarPrestamo(prestamo, libros);
                    Listar();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el formulario de prestamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dtgProducto.SelectedRows[0].Cells[0].Value);
                    frmPrestado frm = new frmPrestado();
                    var libros = ln.ListaPrestamoLibros(id);
                    frm.setDatos(id, libros);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        var prestamo = frm.getDatos();
                        var libross = frm.getLibros();
                        ln.ModificarPrestamo(prestamo, libross);
                        Listar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el formulario de prestamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el prestamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
