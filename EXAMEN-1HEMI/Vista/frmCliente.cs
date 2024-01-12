using EXAMEN_1HEMI.Controlador;
using EXAMEN_1HEMI.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_1HEMI.Vista
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        public string Modo { get; set; }
        public string Cedula { get; set; }

        public void setCliente(Cliente cliente)
        {
            txtCedula.Text = cliente.Cedula;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            dateTimePicker1.Value = cliente.FechaNacimiento;
            comboBox1.Text = cliente.Sexo.ToString();
            comboBox2.Text = cliente.EstadoCivil;
        }

        public bool Validar()
        {
            bool ok = true;
            if (txtCedula.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar la cedula");
                txtCedula.Focus();
            }else if(txtNombre.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar el nombre");
                txtNombre.Focus();
            }else if(txtApellido.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar el apellido");
                txtApellido.Focus();
            }else if(dateTimePicker1.Value == null)
            {
                ok = false;
                MessageBox.Show("Debe ingresar la fecha de nacimiento");
                dateTimePicker1.Focus();
            }else if(comboBox1.SelectedIndex == -1)
            {
                ok = false;
                MessageBox.Show("Debe seleccionar el sexo");
                comboBox1.Focus();
            }else if(comboBox2.SelectedIndex == -1)
            {
                ok = false;
                MessageBox.Show("Debe seleccionar el estado civil");
                comboBox2.Focus();
            }
            return ok;
        }

        private Cliente crearCliente()
        {
            Cliente cliente = new Cliente();
            cliente.Cedula = txtCedula.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.FechaNacimiento = dateTimePicker1.Value;
            cliente.Sexo = Convert.ToChar(comboBox1.SelectedItem.ToString());
            cliente.EstadoCivil = comboBox2.SelectedItem.ToString();
            cliente.AlquileresId = new List<int>();
            return cliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Cliente cliente = crearCliente();
                    if(Modo == "EDITAR")
                    {
                        TlistaClientes.ModificarCliente(Cedula, cliente);
                        MessageBox.Show("Cliente modificado correctamente");
                    }
                    else
                    {
                        TlistaClientes.AgregarCliente(cliente);
                        MessageBox.Show("Cliente agregado correctamente");
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
