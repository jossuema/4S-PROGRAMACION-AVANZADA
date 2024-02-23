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

namespace capavista.Formularios
{
    public partial class frmAdminEditorial : Form
    {
        public frmAdminEditorial()
        {
            InitializeComponent();
            ln = new EditorialLN();
            Listar();
        }

        EditorialLN ln;

        public void Listar()
        {
            dtgProducto.DataSource = ln.ViewEditorialFiltro(txtBuscar.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo()
        {
            try
            {
                frmEditorial frm = new frmEditorial();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    ln.InsertarEditorial(frm.getDatos());
                    Listar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Editar()
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    frmEditorial frm = new frmEditorial();
                    frm.setDatos((CapaEntidades.Gestion.Editorial)dtgProducto.CurrentRow.DataBoundItem);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        ln.ModificarEditorial(frm.getDatos());
                        Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Eliminar()
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    ln.EliminarEditorial(((CapaEntidades.Gestion.Editorial)dtgProducto.CurrentRow.DataBoundItem).Id_editorial);
                    Listar();
                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
