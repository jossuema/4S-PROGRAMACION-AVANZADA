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
    public partial class frmAdminPrestamoLibro : Form
    {
        public frmAdminPrestamoLibro()
        {
            InitializeComponent();
            this.prestamoLibroLN = new CapaLogica.Gestion.PrestamoLibroLN();
        }

        CapaLogica.Gestion.PrestamoLibroLN prestamoLibroLN;

        public void ListarPrestamoLibro()
        {
            try
            {
                var lista = prestamoLibroLN.ListarPrestamoLibro();
                dtgProducto.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en ListarPrestamoLibro: " + ex.Message);
            }
        }   

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Nuevo() 
        {                
            try
            {
                frmPrestamoLibro frm = new frmPrestamoLibro();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    var prestamoLibro = frm.getDatos();
                    prestamoLibroLN.InsertarPrestamoLibro(prestamoLibro.id_libro, prestamoLibro.id_prestamo);
                    ListarPrestamoLibro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Nuevo: " + ex.Message);
            }
        }

        private void Eliminar()
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    var prestamoLibro = (CapaEntidades.ClasesPersonalizadas.PrestamoLibroListar)dtgProducto.SelectedRows[0].DataBoundItem;
                    prestamoLibroLN.EliminarPrestamoLibro(prestamoLibro.IdLibro, prestamoLibro.IdPrestamo);
                    ListarPrestamoLibro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Eliminar: " + ex.Message);
            }
        }
    }
}
