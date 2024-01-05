using EXAMEN_PROGRAMACION_AVANZADA.Controlador;
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
    public partial class frmAlquiler : Form
    {
        public frmAlquiler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            foreach (string placa in Controlador.TListaVehiculos.Placas())
            {
                cbVehiculo.Items.Add(placa);
            }
            foreach (string cedula in Controlador.TListaCliente.Cedulas())
            {
                cbCliente.Items.Add(cedula);
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cedula = cbCliente.SelectedItem.ToString();
            Cliente cliente = TListaCliente.Buscar(cedula);
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            dateTimePicker1.Value = cliente.FechaNacimiento;
        }

        private void cbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string placa = cbVehiculo.SelectedItem.ToString();
            Vehiculo vehiculo = TListaVehiculos.Buscar(placa);
            txtMarca.Text = vehiculo.Marca;
            txtModelo.Text = "Modelo "+vehiculo.Modelo.ToString();
            txtPrestado.Text = vehiculo.Prestado ? "Si" : "No";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(validar())
                {
                    var alquiler = crearAlquiler();
                    TListalAlquiler.Agregar(alquiler);
                    MessageBox.Show("Alquiler agregado correctamente");
                    this.DialogResult = DialogResult.OK;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validar()
        {
            if (cbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente");
                return false;
            }
            if (cbVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un vehiculo");
                return false;
            }
            
            string placa = cbVehiculo.SelectedItem.ToString();
            Vehiculo vehiculo = TListaVehiculos.Buscar(placa);
            if (vehiculo.Prestado)
            {
                MessageBox.Show("El vehiculo ya esta prestado");
                return false;
            }

            if(dateTimePicker2.Value == null)
            {
                MessageBox.Show("Seleccione una fecha de alquiler");
                return false;
            }

            return true;
        }

        public AlquilerVehiculo crearAlquiler()
        {
            string cedula = cbCliente.SelectedItem.ToString();
            string placa = cbVehiculo.SelectedItem.ToString();
            DateTime fechaEntrega = DateTime.Now;
            DateTime fechaRecogida = dateTimePicker2.Value;
            int id = TListalAlquiler.Lista().Count + 1;
            return new AlquilerVehiculo(id, cedula, placa, fechaEntrega, fechaRecogida);
        }
    }
}
