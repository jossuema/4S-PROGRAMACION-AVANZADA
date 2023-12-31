using Practica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.Vista
{
    public partial class frmIngresoPersona : Form
    {
        public frmIngresoPersona()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ingrese correctamente los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Persona crearPersona()
        {
            Persona obp = new Persona();
            obp.Nombre = txtNombre.Text;
            obp.Apellidos = txtApellido.Text;
            obp.Direccion = txtDireccion.Text;
            obp.Telefono = txtTelefono.Text;
            obp.Sexo = comboBox1.SelectedItem.ToString();
            obp.EstadoCivil = comboBox2.SelectedItem.ToString();
            obp.FechaNacimiento = dateTimePicker1.Value;
            obp.Cedula = txtCedula.Text;
            return obp;
        }

        private bool validar()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese Nombre");
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese Apellido");
                txtApellido.Focus();
                return false;
            }
         
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Ingrese Direccion");
                txtDireccion.Focus();
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingrese Telefono");
                txtTelefono.Focus();
                return false;
            }
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione sexo");
                comboBox1.Focus();
                return false;
            }
            if(comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione estado civil");
                comboBox2.Focus();
                return false;
            }
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Seleccione fecha de nacimiento");
                dateTimePicker1.Focus();
                return false;
            }
            return true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
