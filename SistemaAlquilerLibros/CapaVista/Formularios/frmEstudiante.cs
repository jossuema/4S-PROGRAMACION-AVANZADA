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
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }

        public CapaEntidades.Gestion.Estudiante estudiante = null;

        public void setDatos(CapaEntidades.Gestion.Estudiante estudiante)
        {
            this.estudiante = estudiante;
            txtID.Text = estudiante.Id_estudiante.ToString();
            txtID.Enabled = false;
            txtCedula.Text = estudiante.Cedula;
            txtNombre.Text = estudiante.Nombre;
            txtApellido.Text = estudiante.Apellido;
            dateTimePicker1.Value = estudiante.Fecha_nacimiento;
            cbSexo.Text = estudiante.Sexo.ToString();
            cbEstadoCivil.Text = estudiante.Estado_civil;
            cbEstado.Text = estudiante.Estado;
        }

        public CapaEntidades.Gestion.Estudiante getDatos()
        {
            if (estudiante == null) estudiante = new CapaEntidades.Gestion.Estudiante();
            estudiante.Id_estudiante = int.Parse(txtID.Text);
            estudiante.Cedula = txtCedula.Text;
            estudiante.Nombre = txtNombre.Text;
            estudiante.Apellido = txtApellido.Text;
            estudiante.Fecha_nacimiento = dateTimePicker1.Value;
            estudiante.Sexo = char.Parse(cbSexo.Text);
            estudiante.Estado_civil = cbEstadoCivil.Text;
            estudiante.Estado = cbEstado.Text;
            return estudiante;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            bool ok = true;
            if (txtCedula.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar la cedula");
                txtCedula.Focus();
            }
            else if (txtNombre.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar el nombre");
                txtNombre.Focus();
            }
            else if (txtApellido.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar el apellido");
                txtApellido.Focus();
            }else if(txtCedula.Text.Length < 10)
            {
                ok = false;
                MessageBox.Show("La cedula debe tener 10 digitos");
                txtCedula.Focus();
            }
            if(dateTimePicker1.Value > DateTime.Now)
            {
                ok = false;
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual");
                dateTimePicker1.Focus();
            }
            if(cbEstadoCivil.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe seleccionar el estado civil");
                cbEstadoCivil.Focus();
            }
            if(cbSexo.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe seleccionar el sexo");
                cbSexo.Focus();
            }
            if(cbEstado.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe seleccionar el estado");
                cbEstado.Focus();
            }
            return ok;

        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            
        }
    }
}
