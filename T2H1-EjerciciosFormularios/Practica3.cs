using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2H1_EjerciciosFormularios
{
    public partial class Practica3 : Form
    {
        public Practica3()
        {
            InitializeComponent();
        }

        Dictionary<string, Dictionary<string, int>> cursos = new Dictionary<string, Dictionary<string, int>>();

        private void Practica3_Load(object sender, EventArgs e)
        {
            cargarDatosCursos();
        }

        private void cargarDatosCursos()
        {
            var cursosBackend = new Dictionary<string, int>();
            var cursosFrontend = new Dictionary<string, int>();
            var cursosDiGrafico = new Dictionary<string, int>();

            cursosBackend.Add("C#", 1000);
            cursosBackend.Add("Java", 1200);
            cursosBackend.Add("Python", 800);
            cursosBackend.Add("PHP", 600);
            cursosBackend.Add("Ruby", 900);

            cursosFrontend.Add("HTML", 500);
            cursosFrontend.Add("CSS", 500);
            cursosFrontend.Add("JavaScript", 700);
            cursosFrontend.Add("TypeScript", 800);
            cursosFrontend.Add("Angular", 1000);

            cursosDiGrafico.Add("Photoshop", 800);
            cursosDiGrafico.Add("Illustrator", 800);
            cursosDiGrafico.Add("InDesign", 800);
            cursosDiGrafico.Add("Premiere", 800);
            cursosDiGrafico.Add("After Effects", 800);

            cursos.Add("Backend", cursosBackend);
            cursos.Add("Frontend", cursosFrontend);
            cursos.Add("Diseño Grafico", cursosDiGrafico);
        }

        private bool validar()
        {
            if (listaCursosSeleccionados.Items.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un curso");
                return false;
            }
            if (txtAlumno.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return false;
            }
            if (cbFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una forma de pago");
                return false;
            }

            return true;
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaCostos.Items.Clear();
            listaCursos.Items.Clear();
            foreach (KeyValuePair<string, int> curso in cursos[cbCategorias.SelectedItem.ToString()])
            {
                listaCursos.Items.Add(curso.Key);
                listaCostos.Items.Add(curso.Value);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int pos = listaCursos.SelectedIndex;
            if (pos != -1 && listaCursosSeleccionados.Items.Contains(listaCursos.SelectedItem))
            {
                MessageBox.Show("El curso ya fue agregado");
            }
            else if (pos == -1)
            {
                MessageBox.Show("Debe seleccionar un curso a ser agregado");
            }
            else
            {
                string curso = listaCursos.SelectedItem.ToString();
                int costo = int.Parse(listaCostos.Items[pos].ToString());
                listaCursosSeleccionados.Items.Add(curso);
                listaCostosSeleccionados.Items.Add(costo);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pos = listaCursosSeleccionados.SelectedIndex;
            if (pos == -1)
            {
                MessageBox.Show("Debe seleccionar un curso a ser eliminado");
            }
            else
            {
                string curso = listaCursosSeleccionados.SelectedItem.ToString();
                int costo = int.Parse(listaCostosSeleccionados.Items[pos].ToString());
                listaCursosSeleccionados.Items.RemoveAt(pos);
                listaCostosSeleccionados.Items.RemoveAt(pos);
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                double matricula = 0;
                double total = 0;
                double pagoMensual = 0;

                foreach (int costo in listaCostosSeleccionados.Items)
                {
                    total += costo;
                }

                if(listaCostosSeleccionados.Items.Count == 1)
                {
                    matricula = total * 0.8;
                }
                else if(listaCostosSeleccionados.Items.Count == 2)
                {
                    matricula = total * 0.6;
                }else if(listaCostosSeleccionados.Items.Count >= 3)
                {
                    matricula = total * 0.5;
                }

                if (cbFormaPago.SelectedItem.ToString() == "Contado")
                {
                    total -= total * 0.1;
                }
                else
                {
                    total += total * 0.1;
                    pagoMensual = total / 4;
                }

                txtMatricula.Text = matricula.ToString();
                txtCostoTotal.Text = total.ToString();
                txtPagoMensual.Text = pagoMensual.ToString();
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
