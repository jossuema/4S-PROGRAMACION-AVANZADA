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
    public partial class frmAdminDevolucion : Form
    {
        public frmAdminDevolucion()
        {
            InitializeComponent();
            ln = new PrestamoLN();
            listar();
        }

        PrestamoLN ln;

        private void listar()
        {
            try
            {
                dtgProducto.DataSource = ln.ListarDevoluciones();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al listar los prestamos: " + ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            try
            {
                if(dtgProducto.SelectedRows.Count > 0)
                {
                    int codigo = int.Parse(dtgProducto.SelectedRows[0].Cells[0].Value.ToString());
                    frmDevolver f = new frmDevolver();
                    f.setDatos(codigo);
                    if(f.ShowDialog() == DialogResult.OK)
                    {
                        listar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un prestamo");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al limpiar los campos: " + ex.Message);
            }
        }

        private void Eliminar()
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    int codigo = int.Parse(dtgProducto.SelectedRows[0].Cells[0].Value.ToString());
                    if (MessageBox.Show("¿Está seguro de eliminar el prestamo?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ln.EliminarPrestamo(codigo);
                        MessageBox.Show("Prestamo eliminado con éxito");
                        listar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un prestamo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el prestamo: " + ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
