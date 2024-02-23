using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaLogica.Gestion;

namespace capavista.Formularios
{
    public partial class frmAdminAutor : Form
    {
        public frmAdminAutor()
        {
            InitializeComponent();
            this.ln = new AutorLN();
            dtgProducto.DataSource = ln.ViewAutorFiltro("");
        }

        AutorLN ln;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tlsBarraPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAdminAutor_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtgProducto.DataSource = ln.ViewAutorFiltro(txtBuscar.Text);
        }

        private void Nuevo()
        {
            try
            {
                frmAutor frm = new frmAutor();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    ln.InsertarAutor(frm.getAutor());
                    dtgProducto.DataSource = ln.ViewAutorFiltro("");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    frmAutor frm = new frmAutor();
                    frm.setDatos((CapaEntidades.Gestion.Autor)dtgProducto.SelectedRows[0].DataBoundItem);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        ln.ModificarAutor(frm.getAutor());
                        dtgProducto.DataSource = ln.ViewAutorFiltro("");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un autor para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar()
        {
            try
            {
                if(dtgProducto.SelectedRows.Count > 0)
                {
                    ln.EliminarAutor(((CapaEntidades.Gestion.Autor)dtgProducto.SelectedRows[0].DataBoundItem).Id_autor);
                    dtgProducto.DataSource = ln.ViewAutorFiltro("");
                }
                else
                {
                    MessageBox.Show("Seleccione un autor para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el formulario de autor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
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
