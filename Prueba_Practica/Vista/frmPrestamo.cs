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
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> diccionarioLibrosRevistas = new Dictionary<string, string>();

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            foreach (var estudiante in TListaEstudiantes.listaEstudiantes)
            {
                comboBox1.Items.Add(estudiante.Cedula);
            }
            foreach (var libro in TListaLibrosRevistas.listaLibros)
            {
                if(libro.Prestado == false)
                {
                    listBox1.Items.Add(libro.Titulo);
                    diccionarioLibrosRevistas.Add(libro.Titulo, libro.Codigo);
                }
            }
            foreach (var revista in TListaLibrosRevistas.listaRevistas)
            {
                if(revista.Prestado == false)
                {
                    listBox1.Items.Add(revista.Titulo);
                    diccionarioLibrosRevistas.Add(revista.Titulo, revista.Codigo);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void crearRegistros()
        {
            foreach (var item in listBox2.Items)
            {
                Registro registro = new Registro();
                registro.CedulaEstudiante = comboBox1.SelectedItem.ToString();
                registro.FechaPrestamo = dateTimePicker1.Value;
                registro.FechaEntrega = dateTimePicker2.Value;

                string codigo = diccionarioLibrosRevistas[item.ToString()];
                registro.CodigoLibro = codigo;
                registro.Devuelto = false;

                if(TListaLibrosRevistas.BuscarLibro(codigo) != -1)
                {
                    TListaLibrosRevistas.listaLibros[TListaLibrosRevistas.BuscarLibro(codigo)].Prestado = true;
                }
                else if(TListaLibrosRevistas.BuscarRevista(codigo) != -1)
                {
                    TListaLibrosRevistas.listaRevistas[TListaLibrosRevistas.BuscarRevista(codigo)].Prestado = true;
                }
                TListaRegistros.lista.Add(registro);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    crearRegistros();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool validar()
        {
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estudiante");
                return false;
            }
            if(listBox2.Items.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un libro o revista");
                return false;
            }
            if(dateTimePicker1 == null)
            {
                MessageBox.Show("Seleccione una fecha de prestamo");
                return false;
            }
            if(dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de prestamo no puede ser mayor a la fecha actual");
                return false;
            }
            if(dateTimePicker2 == null)
            {
                MessageBox.Show("Seleccione una fecha de devolucion");
                return false;
            }
            if(dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("La fecha de devolucion no puede ser menor a la fecha de prestamo");
                return false;
            }
            int index = TListaEstudiantes.BuscarEstudiante(comboBox1.SelectedItem.ToString());
            Estudiante estudiante = TListaEstudiantes.listaEstudiantes[index];
            if(estudiante.Sancionado == true)
            {
                MessageBox.Show("El estudiante esta sancionado");
                return false;
            }
            return true;

        }


    }
}
