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
    public partial class frmAutorLibro : Form
    {
        public frmAutorLibro()
        {
            InitializeComponent();
            this.ln = new CapaLogica.Gestion.AutorLibroLN();
            Listar();
        }

        CapaLogica.Gestion.AutorLibroLN ln;

        private void Listar()
        {
            Dictionary<int, string> libros = ln.ListarLibros();
            Dictionary<int, string> autores = ln.ListarAutores();
            cbAutor.DataSource = new BindingSource(autores, null);
            cbAutor.DisplayMember = "Value";
            cbAutor.ValueMember = "Key";
            cbLibro.DataSource = new BindingSource(libros, null);
            cbLibro.DisplayMember = "Value";
            cbLibro.ValueMember = "Key";
        }

        private bool verificar()
        {
            if (cbAutor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un autor");
                return false;
            }
            if (cbLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un libro");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(verificar())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public CapaEntidades.Gestion.AutorLibro getDatos()
        {
            CapaEntidades.Gestion.AutorLibro autorLibro = new CapaEntidades.Gestion.AutorLibro();
            autorLibro.IdAutor = ((KeyValuePair<int, string>)cbAutor.SelectedItem).Key;
            autorLibro.IDLibro = ((KeyValuePair<int, string>)cbLibro.SelectedItem).Key;
            return autorLibro;
        }
    }
}
