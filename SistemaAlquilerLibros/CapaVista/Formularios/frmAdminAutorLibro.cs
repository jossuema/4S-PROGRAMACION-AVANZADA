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
    public partial class frmAdminAutorLibro : Form
    {
        public frmAdminAutorLibro()
        {
            InitializeComponent();
            this.ln = new CapaLogica.Gestion.AutorLibroLN();
            Listar();
        }

        CapaLogica.Gestion.AutorLibroLN ln;

        private void Listar()
        {
            try
            {
                dtgProducto.DataSource = ln.ListarAutorLibro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            try
            {
                frmAutorLibro frm = new frmAutorLibro();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    var autorLibro = frm.getDatos();
                    ln.InsertarAutorLibro(autorLibro.IdAutor, autorLibro.IDLibro);
                    Listar();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Eliminar()
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    var autorLibro = (CapaEntidades.ClasesPersonalizadas.AutorLibroListar)dtgProducto.SelectedRows[0].DataBoundItem;
                    ln.EliminarAutoryLibro(autorLibro.IdAutor, autorLibro.IDLibro);
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
