using POO.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int opcion = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            guardar();
        }

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbSexo.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        public void guardar()
        {
            if (validar())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public void setDatos(Persona p)
        {
            txtCodigo.Text = p.Codigo.ToString();
            txtCedula.Text = p.Cedula;
            txtNombre.Text = p.Nombre;
            txtApellido.Text = p.Apellido;
            cbSexo.SelectedItem = p.Genero.ToString();
            dateTimePicker1.Value = p.FechaNacimiento;
            cbEstado.SelectedItem = p.Estado.ToString();
        }

        public Persona GetPersona()
        {
            int codigo = int.Parse(txtCodigo.Text);
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            char genero = char.Parse(cbSexo.SelectedItem.ToString());
            DateTime fechaNacimiento = dateTimePicker1.Value;
            string estado = cbEstado.SelectedItem.ToString();

            if(comboBox1.SelectedItem.ToString() == "Empleado")
            {
                double sueldo = double.Parse(textBox1.Text);
                double anticipo = double.Parse(textBox2.Text);
                double impuesto = double.Parse(textBox3.Text);

                Empleado empleado = new Empleado(codigo, cedula, nombre, apellido, genero, fechaNacimiento, estado, sueldo, anticipo, impuesto);
                TListaEmpleado.Agregar(empleado);

                return empleado;
            }
            else
            {
                double horas = double.Parse(textBox1.Text);
                double costo = double.Parse(textBox2.Text);

                Consultor consultor = new Consultor(codigo, cedula, nombre, apellido, genero, fechaNacimiento, estado, horas, costo);
                TListaConsultor.Agregar(consultor);

                return consultor;
            }
        }

        public bool validar()
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el codigo");
                txtCodigo.Focus();
                return false;
            }
            if (txtCedula.Text == "")
            {
                MessageBox.Show("Ingrese la cedula");
                txtCedula.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido");
                txtApellido.Focus();
                return false;
            }
            if (cbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el genero");
                cbSexo.Focus();
                return false;
            }
            if (cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el estado");
                cbEstado.Focus();
                return false;
            }
            if(dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual");
                dateTimePicker1.Focus();
                return false;
            }
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de persona");
                comboBox1.Focus();
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            estadoIngreso(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void estadoIngreso(bool ok)
        {
            label11.Visible = ok;
            label12.Visible = ok;
            label10.Visible = ok;
            textBox1.Visible = ok;
            textBox2.Visible = ok;
            textBox3.Visible = ok;
        }

        public void setEmpleado()
        {
            label10.Text = "Sueldo";
            label11.Text = "Anticipo";
            label12.Text = "Impuesto";
            estadoIngreso(true);
        }

        public void setConsultor()
        {
            label10.Text = "Horas";
            label11.Text = "Costo";
            estadoIngreso(true);
            label12.Visible = false;
            textBox3.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Empleado")
            {
                setEmpleado(); 
            }
            else if(comboBox1.SelectedItem.ToString() == "Consultor")
            {
                setConsultor();  
            }
            else
            {
                estadoIngreso(false);
            }
        }
    }
}
