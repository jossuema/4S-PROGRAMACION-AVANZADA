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
    public partial class frmAdminEstudiante : Form
    {
        public frmAdminEstudiante()
        {
            InitializeComponent();
            this.ln = new EstudianteLN();
            Listar();
        }

        EstudianteLN ln;

        public void Listar()
        {
            dtgProducto.DataSource = ln.ViewEstudianteFiltro(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo()
        {
            try
            {
                frmEstudiante frm = new frmEstudiante();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    ln.InsertarEstudiante(frm.getDatos());
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Editar()
        {
            try
            {
                if(dtgProducto.SelectedRows.Count > 0)
                {
                    frmEstudiante frm = new frmEstudiante();
                    frm.setDatos((CapaEntidades.Gestion.Estudiante)dtgProducto.SelectedRows[0].DataBoundItem);
                    frm.ShowDialog();
                    if(frm.DialogResult == DialogResult.OK)
                    {
                        ln.ModificarEstudiante(frm.getDatos());
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
                MessageBox.Show(ex.Message);
            }
        }

        public void Eliminar()
        {
            try
            {
                if(dtgProducto.SelectedRows.Count > 0)
                {
                    if(MessageBox.Show("¿Está seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ln.EliminarEstudiante(((CapaEntidades.Gestion.Estudiante)dtgProducto.SelectedRows[0].DataBoundItem).Id_estudiante);
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
