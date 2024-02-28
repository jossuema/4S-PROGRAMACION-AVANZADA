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
    public partial class frmAdminLibrosBaja : Form
    {
        public frmAdminLibrosBaja()
        {
            InitializeComponent();
            ln = new CapaLogica.Gestion.HistorialBajaLN();
            Listar();
        }

        CapaLogica.Gestion.HistorialBajaLN ln;

        private void Listar()
        {
            try
            {
                dtgProducto.DataSource = ln.historialBajaListar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nuevo()
        {
            try
            {
                frmLibrosBaja frmLibrosBaja = new frmLibrosBaja();
                frmLibrosBaja.ShowDialog();
                if (frmLibrosBaja.DialogResult == DialogResult.OK)
                {
                    var historialBaja = frmLibrosBaja.getDatos();
                    ln.DarDeBajaLibro(historialBaja);
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Editar()
        {
            try
            {
                if(dtgProducto.SelectedRows.Count > 0)
                {
                    frmLibrosBaja frmLibrosBaja = new frmLibrosBaja();
                    frmLibrosBaja.setDatos(Convert.ToInt32(dtgProducto.SelectedRows[0].Cells[0].Value));
                    frmLibrosBaja.ShowDialog();
                    if (frmLibrosBaja.DialogResult == DialogResult.OK)
                    {
                        var historialBaja = frmLibrosBaja.getDatos();
                        ln.ModificarHistorialBaja(historialBaja);
                        Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro para poder editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Eliminar()
        {
            try
            {
                if(dtgProducto.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ln.EliminarHistorialBaja(Convert.ToInt32(dtgProducto.SelectedRows[0].Cells[0].Value));
                        Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro para poder eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
