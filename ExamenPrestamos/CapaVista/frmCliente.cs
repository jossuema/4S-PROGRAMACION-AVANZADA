using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }


        public void setDatos(CapaEntidad.Gestion.Cliente cl)
        {
            txtCedula.Text = cl.Cedula;
            txtCedula.Enabled = false;
            txtNombre.Text = cl.Nombre;
            txtApellido.Text = cl.Apellido;
            numericUpDown1.Value = cl.Edad;
            comboBox1.Text = cl.Sexo.ToString();
        }

        public CapaEntidad.Gestion.Cliente getCliente()
        {
                return new CapaEntidad.Gestion.Cliente(txtCedula.Text, txtNombre.Text, txtApellido.Text, (int)numericUpDown1.Value, char.Parse(comboBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Validar()){
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Validar()
        {
            if (txtCedula.Text == "")
            {
                MessageBox.Show("Ingrese la cédula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCedula.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }
            if(numericUpDown1.Value == 0)
            {
                MessageBox.Show("Ingrese la edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDown1.Focus();
                return false;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Ingrese el sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
                return false;
            }
            return true;
        }
    }
}
