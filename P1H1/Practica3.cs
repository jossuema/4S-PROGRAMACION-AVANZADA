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

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string alumno = txtAlumno.Text;
                double unidad1 = double.Parse(txtUnidad1.Text);
                double unidad2 = double.Parse(txtUnidad2.Text);
                double unidad3 = double.Parse(txtUnidad3.Text);
                string turno = cbTurno.SelectedItem.ToString();

                double promedio = (unidad1 + unidad2 + unidad3) / 3;

                dataGridView1.Rows.Add(alumno, unidad1, unidad2, unidad3, promedio.ToString("N2"), turno);

                txtTotal.Text = dataGridView1.Rows.Count.ToString();
            }
        }

        private bool validar()
        {
            double valor;
            if (txtAlumno.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el nombre del alumno");
                return false;
            }
            else if(txtUnidad1.Text == "" || !double.TryParse(txtUnidad1.Text, out valor))
            {
                MessageBox.Show("Debe ingresar un valor numérico en la unidad 1");
                return false;
            }
            else if (txtUnidad2.Text == "" || !double.TryParse(txtUnidad2.Text, out valor))
            {
                MessageBox.Show("Debe ingresar un valor numérico en la unidad 2");
                return false;
            }
            else if (txtUnidad3.Text == "" || !double.TryParse(txtUnidad3.Text, out valor))
            {
                MessageBox.Show("Debe ingresar un valor numérico en la unidad 3");
                return false;
            }
            else if(cbTurno.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un turno");
                return false;
            }
            return true;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == 0)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            else
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                txtTotal.Text = dataGridView1.Rows.Count.ToString();
            }
        }
    }
}
