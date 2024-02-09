using CapaDatos;
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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        public bool Editar = false;
        public CapaEntidades.Gestion.Autor autor = null;

        public void setDatos(CapaEntidades.Gestion.Autor autor)
        {
            this.autor = autor;
            txtID.Text = autor.Id_autor.ToString();
            txtNombre.Text = autor.Nombre;
            txtApellido.Text = autor.Apellido;
            cbSexo.Text = autor.Sexo.ToString();
            txtEstado.Text = autor.Estado;
            dateTimePicker1.Value = autor.Fecha_nacimiento;
            this.Editar = true;
        }

        public bool validar()
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Ingrese el ID del autor");
                txtID.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del autor");
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido del autor");
                txtApellido.Focus();
                return false;
            }
            if (cbSexo.Text == "")
            {
                MessageBox.Show("Ingrese el sexo del autor");
                cbSexo.Focus();
                return false;
            }
            if (dateTimePicker1.Value == null)
            {
                MessageBox.Show("Ingrese la fecha de nacimiento del autor");
                dateTimePicker1.Focus();
                return false;
            }
            if(cbSexo.Text != "M" && cbSexo.Text != "F")
            {
                MessageBox.Show("Ingrese un sexo valido");
                cbSexo.Focus();
                return false;
            }
            return true;
        }

        private void frmAutor_Load(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error al guardar el autor: " + ex.Message);
            }
        }

        public CapaEntidades.Gestion.Autor getAutor()
        {
            CapaEntidades.Gestion.Autor autor = new CapaEntidades.Gestion.Autor();
            autor.Id_autor = Convert.ToInt32(txtID.Text);
            autor.Nombre = txtNombre.Text;
            autor.Apellido = txtApellido.Text;
            autor.Sexo = Convert.ToChar(cbSexo.Text);
            autor.Estado = txtEstado.Text;
            autor.Fecha_nacimiento = dateTimePicker1.Value;
            return new CapaEntidades.Gestion.Autor(Convert.ToInt32(txtID.Text), txtEstado.Text, txtNombre.Text, txtApellido.Text, Convert.ToChar(cbSexo.Text), dateTimePicker1.Value); 
        }
    }
}
