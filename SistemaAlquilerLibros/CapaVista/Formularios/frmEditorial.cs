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
    public partial class frmEditorial : Form
    {
        public frmEditorial()
        {
            InitializeComponent();
        }

        public CapaEntidades.Gestion.Editorial editorial = null;

        public void setDatos(CapaEntidades.Gestion.Editorial editorial)
        {
            this.editorial = editorial;
            txtID.Text = editorial.Id_editorial.ToString();
            txtID.Enabled = false;
            txtNombre.Text = editorial.Nombre;
            txtPais.Text = editorial.Pais;
        }

        public bool validar()
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Ingrese el ID de la editorial");
                txtID.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la editorial");
                txtNombre.Focus();
                return false;
            }
            if (txtPais.Text == "")
            {
                MessageBox.Show("Ingrese el país de la editorial");
                txtPais.Focus();
                return false;
            }
            return true;
        }

        public CapaEntidades.Gestion.Editorial getDatos()
        {
            if (editorial == null) editorial = new CapaEntidades.Gestion.Editorial();
            editorial.Id_editorial = Convert.ToInt32(txtID.Text);
            editorial.Nombre = txtNombre.Text;
            editorial.Pais = txtPais.Text;
            return editorial;
        }

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
    }
}
