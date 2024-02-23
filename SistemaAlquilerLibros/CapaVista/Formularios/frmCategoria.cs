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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        public CapaEntidades.Gestion.Categoria categoria = null;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void setDatos(CapaEntidades.Gestion.Categoria categoria)
        {
            this.categoria = categoria;
            txtID.Text = categoria.Id_categoria.ToString();
            txtID.Enabled = false;
            txtNombre.Text = categoria.Nombre;
            txtDescripcion.Text = categoria.Descripcion;
        }

        public bool validar()
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Ingrese el ID de la categoria");
                txtID.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la categoria");
                txtNombre.Focus();
                return false;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese la descripcion de la categoria");
                txtDescripcion.Focus();
                return false;
            }
            return true;
        }

        public CapaEntidades.Gestion.Categoria getDatos()
        {
            CapaEntidades.Gestion.Categoria categoria = new CapaEntidades.Gestion.Categoria();
            categoria.Id_categoria = Convert.ToInt32(txtID.Text);
            categoria.Nombre = txtNombre.Text;
            categoria.Descripcion = txtDescripcion.Text;
            return categoria;
        }
    }
}
