using POO.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class frmAdminPersona : Form
    {
        public frmAdminPersona()
        {
            InitializeComponent();
        }

        //metodo cargar personas en TLista
        private void cargarPersonas()
        {
            //limpiar lista
            TLista.lista.Clear();


            //cargar personas
            TLista.Agregar(new Persona(1, "0706209905", "Josue", "Malla", 'M', new DateTime(2002, 10, 28), "Soltero"));
            TLista.Agregar(new Persona(2, "0706209906", "Manuel", "Malla", 'M', new DateTime(2004, 10, 28), "Soltero"));
            TLista.Agregar(new Persona(3, "0706209907", "Jairo", "Malla", 'M', new DateTime(2008, 10, 28), "Soltero"));
        }
        private void frmAdminPersona_Load(object sender, EventArgs e)
        {
            //cargarPersonas();
            comboBox1.SelectedItem = "Todos";
            listar();
            

        }

        public void listar()
        {
            if(comboBox1.SelectedItem.ToString() == "Empleado")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = TListaEmpleado.lista;
            }

            if (comboBox1.SelectedItem.ToString() == "Todos")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = TLista.lista;
            }

            if(comboBox1.SelectedItem.ToString() == "Consultor")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = TListaConsultor.lista;
            }
        }

        public void Nuevo()
        {
            try
            {
                Form1 fep = new Form1();
                fep.Text = "Ingresar Persona";
                fep.label1.Text = "Ingresar Persona";

                // fep.opc = 1;
                fep.ShowDialog();
                if (fep.DialogResult == DialogResult.OK)
                {
                    Persona op = fep.GetPersona();
                    TLista.Agregar(op);
                    fep.Close();
                    MessageBox.Show("Se ha ingresado la persona...");
                }
                else
                {
                    fep.Close();
                    MessageBox.Show("Ingreso cancelado...");
                }
                listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar persona " + ex.Message);
                MessageBox.Show("Error al insertar persona " + ex.StackTrace);
            }
        }

        public void Modificar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Form1 fep = new Form1();
                    fep.Text = "Actualizar Persona";
                    fep.label1.Text = "Actualizar Persona";
                    fep.button1.Text = "Actualizar";
                    fep.opcion = 1;
                    Persona persona = dataGridView1.CurrentRow.DataBoundItem as Persona;
                    fep.setDatos(persona);
                    fep.ShowDialog();
                    if (fep.DialogResult == DialogResult.OK)
                    {
                        Persona op = fep.GetPersona();
                        TLista.Modificar(TLista.BuscarPersona(op.Codigo), op);
                        fep.Close();
                        listar();
                        MessageBox.Show("Se ha actualizado la persona...");
                    }
                    else
                    {
                        fep.Close();
                        listar();
                        MessageBox.Show("Actualizacion cancelada...");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar persona " + ex.Message);
            }
        }

        public void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var result = MessageBox.Show("Esta seguro de eliminar la persona?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Persona persona = dataGridView1.CurrentRow.DataBoundItem as Persona;
                        TLista.Eliminar(persona);
                        listar();
                        MessageBox.Show("Se ha eliminado la persona...");
                    }
                    else {
                        MessageBox.Show("Eliminacion cancelada...");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar persona " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar();
        }
    }
}
