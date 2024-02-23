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
    public partial class frmAdminLibro : Form
    {
        public frmAdminLibro()
        {
            InitializeComponent();
            ln = new CapaLogica.Gestion.LibroLN();
            Listar();
            
        }

        CapaLogica.Gestion.LibroLN ln;

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            try
            {
                dtgProducto.DataSource = ln.ViewLibroFiltro(txtBuscar.Text);
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

        private void Nuevo()
        {
            try
            {
                frmLibro frm = new frmLibro();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    var libro = frm.getDatos();
                    var autores = frm.getAutores();
                    ln.InsertarLibro(libro, autores);
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
                frmLibro frm = new frmLibro();
                var id = Convert.ToInt32(dtgProducto.CurrentRow.Cells[0].Value);
                var autores = ln.AutoresLibro(id);
                frm.setDatos(id, autores);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    var libro = frm.getDatos();
                    var autoresNuevos = frm.getAutores();
                    ln.ModificarLibro(libro, autoresNuevos);
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en editar (VISTA)" + ex.Message);
            }
        }

        private void Eliminar()
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    var id = Convert.ToInt32(dtgProducto.CurrentRow.Cells[0].Value);
                    ln.EliminarLibro(id);
                    Listar();
                }
                else
                {
                    MessageBox.Show("Seleccione un libro para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en eliminar (VISTA)" + ex.Message);
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
