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
    public partial class frmAdminMaquinaria : Form
    {
        public frmAdminMaquinaria()
        {
            InitializeComponent();
            this.ln = new MaquinariaLN();
            Listar();
        }

        MaquinariaLN ln;

        private void Listar()
        {
            try
            {
                dtgProducto.DataSource = ln.ListarMaquinarias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void Nuevo()
        {
            frmMaquinaria frm = new frmMaquinaria();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ln.InsertarMaquinaria(frm.getDatos());
                    Listar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Editar()
        {
            if (dtgProducto.SelectedRows.Count > 0)
            {
                frmMaquinaria frm = new frmMaquinaria();
                frm.setDatos((Maquinaria)dtgProducto.CurrentRow.DataBoundItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Maquinaria maq = frm.getDatos();
                        maq.Disponible = ln.BuscarMaquinaria(maq.Codigo).Disponible;
                        ln.ActualizarMaquinaria(maq);
                        Listar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Eliminar()
        {
            if (dtgProducto.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        ln.EliminarMaquinaria(((Maquinaria)dtgProducto.CurrentRow.DataBoundItem).Codigo);
                        Listar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
