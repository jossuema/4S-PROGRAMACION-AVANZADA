using CapaDatos;
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
    public partial class frmAdminCategoria : Form
    {
        public frmAdminCategoria()
        {
            InitializeComponent();
            ln = new CategoriaLN();
            Listar();
        }

        CategoriaLN ln;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            dtgProducto.DataSource = ln.ViewCategoriaFiltro(txtBuscar.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            try
            {
                frmCategoria frm = new frmCategoria();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    ln.InsertarCategoria(frm.getDatos());
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
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    frmCategoria frm = new frmCategoria();
                    frm.setDatos((CapaEntidades.Gestion.Categoria)dtgProducto.SelectedRows[0].DataBoundItem);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        ln.ModificarCategoria(frm.getDatos());
                        Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila");
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
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ln.EliminarCategoria(((CapaEntidades.Gestion.Categoria)dtgProducto.SelectedRows[0].DataBoundItem).Id_categoria);
                        Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila");
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
    }
}
