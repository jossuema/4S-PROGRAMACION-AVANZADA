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
    public partial class frmLibro : Form
    {
        public frmLibro()
        {
            InitializeComponent();
            this.lnLibro = new CapaLogica.Gestion.LibroLN();
            this.autoresNoSelec = lnLibro.ListaAutoresCB();
            this.autoresSelec = new Dictionary<int, string>();
            cargarDatos();
        }

        public void cargarDatos()
        {
            var categorias = lnLibro.ListaCategoriasCB();
            var editorial = lnLibro.ListaEditorialCB();
            cbCategoria.DataSource = new BindingSource(categorias, null);
            cbCategoria.DisplayMember = "Value";
            cbCategoria.ValueMember = "Key";
            cbEditorial.DataSource = new BindingSource(editorial, null);
            cbEditorial.DisplayMember = "Value";
            cbEditorial.ValueMember = "Key";
            cargarListas();
        }

        public void cargarListas()
        {
            if (autoresNoSelec.Count > 0)
            {
                lbNoSelec.DisplayMember = null;
                lbNoSelec.ValueMember = null;
                lbNoSelec.DataSource = new BindingSource(autoresNoSelec, null);
                lbNoSelec.DisplayMember = "Value";
                lbNoSelec.ValueMember = "Key";
            }
            if (autoresSelec.Count > 0)
            {
                lbSelec.DisplayMember = null;
                lbSelec.ValueMember = null;
                lbSelec.DataSource = new BindingSource(autoresSelec, null);
                lbSelec.DisplayMember = "Value";
                lbSelec.ValueMember = "Key";
            }
        }

        public void setDatos(int id, List<int> autores)
        {
            var libro = lnLibro.BuscarLibro(id);
            txtCodigo.Text = libro.IdLibro.ToString();
            txtCodigo.Enabled = false;
            txtNombre.Text = libro.Nombre;
            cbEstado.Text = libro.Estado;
            cbTipo.Text = libro.Tipo;
            cbCategoria.SelectedValue = libro.IdCategoria;
            cbEditorial.SelectedValue = libro.IdEditorial;
            dtpAnio.Value = libro.Anio_publicacion; 

            foreach (var item in autores)
            {
                autoresSelec.Add(item, autoresNoSelec[item]);
                autoresNoSelec.Remove(item);
            }
            cargarListas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        CapaLogica.Gestion.LibroLN lnLibro = new CapaLogica.Gestion.LibroLN();
        Dictionary<int, string> autoresNoSelec;
        Dictionary<int, string> autoresSelec;

        private void frmLibro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AggAutor();
        }

        private void AggAutor()
        {
            if (lbNoSelec.SelectedIndex != -1)
            {
                autoresSelec.Add(((KeyValuePair<int, string>)lbNoSelec.SelectedItem).Key, ((KeyValuePair<int, string>)lbNoSelec.SelectedItem).Value);
                autoresNoSelec.Remove(((KeyValuePair<int, string>)lbNoSelec.SelectedItem).Key);
                cargarListas();
            }
            else
            {
                MessageBox.Show("Seleccione un autor");
            }
        }

        private void QuitarAutor()
        {
            lbNoSelec.DataSource = null;
            lbSelec.DataSource = null;
            if (lbSelec.SelectedIndex != -1)
            {
                autoresNoSelec.Add(((KeyValuePair<int, string>)lbSelec.SelectedItem).Key, ((KeyValuePair<int, string>)lbSelec.SelectedItem).Value);
                autoresSelec.Remove(((KeyValuePair<int, string>)lbSelec.SelectedItem).Key);
                cargarListas();
            }
            else
            {
                MessageBox.Show("Seleccione un autor");
            }
        }

        public CapaEntidades.Gestion.Libro getDatos()
        {
            CapaEntidades.Gestion.Libro libro = new CapaEntidades.Gestion.Libro();
            libro.IdLibro = int.Parse(txtCodigo.Text);
            libro.Nombre = txtNombre.Text;
            libro.Estado = cbEstado.Text;
            libro.Tipo = cbTipo.Text;
            libro.IdCategoria = ((KeyValuePair<int, string>)cbCategoria.SelectedItem).Key;
            libro.IdEditorial = ((KeyValuePair<int, string>)cbEditorial.SelectedItem).Key;
            libro.Anio_publicacion = dtpAnio.Value;
            return libro;
        }

        public List<int> getAutores()
        {
            List<int> autores = new List<int>();
            foreach (var item in autoresSelec)
            {
                autores.Add(item.Key);
            }
            return autores;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuitarAutor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validar()
        {
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el codigo");
                return false;
            }
            if(txtCodigo.Enabled && lnLibro.ExisteLibro(int.Parse(txtCodigo.Text)) )
            {
                MessageBox.Show("El codigo ya existe");
                return false;
            }
            if(txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }
            if(cbEstado.Text == "")
            {
                MessageBox.Show("Seleccione el estado");
                return false;
            }
            if(cbTipo.Text == "")
            {
                MessageBox.Show("Seleccione el tipo");
                return false;
            }
            if(cbCategoria.Text == "")
            {
                MessageBox.Show("Seleccione la categoria");
                return false;
            }
            if(cbEditorial.Text == "")
            {
                MessageBox.Show("Seleccione la editorial");
                return false;
            }
            if(dtpAnio.Value == null)
            {
                MessageBox.Show("Seleccione el año de publicacion");
                return false;
            }
            if(autoresSelec.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un autor");
                return false;
            }
            return true;
        }
    }
}
