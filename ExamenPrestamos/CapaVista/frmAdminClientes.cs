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
    public partial class frmAdminClientes : Form
    {
        public frmAdminClientes()
        {
            InitializeComponent();
            ln = new CapaLogica.Gestion.ClienteLN();
            ListarClientes();
        }

        CapaLogica.Gestion.ClienteLN ln;

        public void ListarClientes()
        {
            try
            {
                dtgProducto.DataSource = ln.ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void Nuevo() 
        {             
            frmCliente frm = new frmCliente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ln.InsertarCliente(frm.getCliente());
                    ListarClientes();
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
                frmCliente frm = new frmCliente();
                frm.setDatos((CapaEntidad.Gestion.Cliente)dtgProducto.SelectedRows[0].DataBoundItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ln.ActualizarCliente(frm.getCliente());
                        ListarClientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar()
        {
            if (dtgProducto.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        ln.EliminarCliente(((CapaEntidad.Gestion.Cliente)dtgProducto.SelectedRows[0].DataBoundItem).Cedula);
                        ListarClientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
