using EXAMEN_PROGRAMACION_AVANZADA.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_PROGRAMACION_AVANZADA.Vista
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(validar())
                {
                    this.DialogResult = DialogResult.OK;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Cliente crearCliente()
        {
            var cliente = new Cliente();
            cliente.Cedula = textBox1.Text;
            cliente.Nombre = textBox2.Text;
            cliente.Apellido = textBox3.Text;
            cliente.FechaNacimiento = dateTimePicker1.Value;
            return cliente;
        }

        private bool validar()
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la cédula");
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre");
                textBox2.Focus();
                return false;
            }
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el apellido");
                textBox3.Focus();
                return false;
            }
            if(dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual");
                dateTimePicker1.Focus();
                return false;
            }
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Debe ingresar la fecha de nacimiento");
                dateTimePicker1.Focus();
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
