using capavista.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capavista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            ln = new CapaLogica.Gestion.PrestamoLN();
        }

        CapaLogica.Gestion.PrestamoLN ln;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminAutor frm = new frmAdminAutor();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminCategoria frm = new frmAdminCategoria();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminEstudiante frm = new frmAdminEstudiante();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminEditorial frm = new frmAdminEditorial();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdminCategoria frm = new frmAdminCategoria();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminLibro frm = new frmAdminLibro();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminPrestamo frm = new frmAdminPrestamo();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void autorLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminAutorLibro frm = new frmAdminAutorLibro();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void bajaLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminLibrosBaja frm = new frmAdminLibrosBaja();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void kardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminKardex frm = new frmAdminKardex();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Libros prestados a hombres: "+ln.cantidadLibrosPrestadosHombres().ToString());
            MessageBox.Show("Libros prestados a mujeres: " + ln.cantidadLibrosPrestadosMujeres().ToString());
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ln.cantidadEstudiantesSancionados().ToString());
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Porcentaje prestado de Libros"+ln.PorcentajePrestamosLibro());
            MessageBox.Show("Porcentaje prestado de Revistas" + ln.PorcentajePrestamosRevista());
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad de libros prestados: "+ln.CantidadPrestamosLibros());
            MessageBox.Show("Cantidad de revistas prestadas: " + ln.CantidadPrestamosRevistas());
        }
    }
}
