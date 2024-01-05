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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                nuevoVehiculo();
            }else if(comboBox1.SelectedIndex == 1)
            {
                nuevoCliente();
            }
        }

        private void nuevoCliente()
        {
            try
            {
                frmCliente frmCliente = new frmCliente();
                frmCliente.ShowDialog();
                if(frmCliente.DialogResult == DialogResult.OK)
                {
                    var cliente = frmCliente.crearCliente();
                    frmCliente.Close();
                    TListaCliente.Agregar(cliente);
                    MessageBox.Show("Cliente agregado correctamente");
                    Listar();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nuevoVehiculo()
        {
            try
            {
                frmVehiculo frmVehiculo = new frmVehiculo();
                frmVehiculo.ShowDialog();
                if (frmVehiculo.DialogResult == DialogResult.OK)
                {
                    var vehiculo = frmVehiculo.crearVehiculo();
                    frmVehiculo.Close();
                    TListaVehiculos.Agregar(vehiculo);
                    MessageBox.Show("Vehículo agregado correctamente");
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                eliminarVehiculo();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                 eliminarCliente();
            }
        }

        private void eliminarCliente()
        {
            try
            {
                var cliente = (Cliente)dataGridView1.CurrentRow.DataBoundItem;
                TListaCliente.Eliminar(cliente.Cedula);
                MessageBox.Show("Cliente eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarVehiculo()
        {
            try
            {
                var vehiculo = (Vehiculo)dataGridView1.CurrentRow.DataBoundItem;
                TListaVehiculos.Eliminar(vehiculo.Placa);
                MessageBox.Show("Vehículo eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Listar();
        }

        public void Listar()
        {
            dataGridView1.DataSource = null;
            if(comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = TListaVehiculos.Lista();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = TListaCliente.Lista();
            }else if(comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = TListaTarifas.ListaTarifas;
            }else if(comboBox1.SelectedIndex == 3)
            {
                dataGridView1.DataSource = TListalAlquiler.Lista();
            }
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmAlquiler frmAlquiler = new frmAlquiler();
                frmAlquiler.ShowDialog();

                if(frmAlquiler.DialogResult == DialogResult.OK)
                {
                    frmAlquiler.Close();
                    comboBox1.SelectedIndex = 3;
                    Listar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmDevolucion frmDevolucion = new frmDevolucion();
                frmDevolucion.ShowDialog();

                if (frmDevolucion.DialogResult == DialogResult.OK)
                {
                    frmDevolucion.Close();
                    comboBox1.SelectedIndex = 3;
                    Listar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
