using Prueba_Practica.Controlador;
using Prueba_Practica.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Practica.Vista
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }

        public bool Editar = false;
        public Estudiante estudiante;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void setEstudiante(Estudiante estudiante)
        {
            this.estudiante = estudiante;
            txtNombre.Text = estudiante.Nombre;
            txtApellido.Text = estudiante.Apellido;
            txtCedula.Text = estudiante.Cedula;
            cbSexo.SelectedItem = estudiante.Sexo;
            dateTimePicker1.Value = estudiante.FechaNacimiento;
        }

        public void setEditar(bool editar)
        {
            Editar = editar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(validar())
                {
                    Estudiante estudiante = crearEstudiante();
                    if(Editar)
                    {
                        TListaEstudiantes.EditarEstudiante(estudiante, TListaEstudiantes.BuscarEstudiante(this.estudiante.Cedula));
                    }
                    else
                    {
                        TListaEstudiantes.AgregarEstudiante(estudiante);
                    }
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Estudiante crearEstudiante()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = txtNombre.Text;
            estudiante.Apellido = txtApellido.Text;
            estudiante.Cedula = txtCedula.Text;
            estudiante.Sexo = cbSexo.SelectedItem.ToString().ToCharArray()[0];
            estudiante.FechaNacimiento = dateTimePicker1.Value;
            estudiante.Sancionado = false;
            return estudiante;
        }

        private bool validar()
        {
            if(txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return false;
            }
            if(txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido");
                return false;
            }
            if(txtCedula.Text == "")
            {
                MessageBox.Show("Debe ingresar una cedula");
                return false;
            }
            if(cbSexo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un sexo");
                return false;
            }
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Debe seleccionar una fecha de nacimiento");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
