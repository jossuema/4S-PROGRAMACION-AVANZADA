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
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
              
        }

        public Vehiculo crearVehiculo()
        {
            var vehiculo = new Vehiculo();
            vehiculo.Placa = textBox1.Text;
            vehiculo.Marca = textBox2.Text;
            vehiculo.Modelo = comboBox1.SelectedItem.ToString()[0];
            return vehiculo;
        }

        private bool validar() 
        {             
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la placa");
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la marca");
                textBox2.Focus();
                return false;
            }
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el modelo");
                comboBox1.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
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
