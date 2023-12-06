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
    public partial class Practica2 : Form
    {
        public Practica2()
        {
            InitializeComponent();
        }

        private void Practica2_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int pos = listaCursos.SelectedIndex;
            if (pos == -1)
            {
                MessageBox.Show("Debe seleccionar un curso a ser agregado");
            }
            else
            {
                string curso = listaCursos.SelectedItem.ToString();
                int costo = int.Parse(listaCostos.Items[pos].ToString());
                listaCursos.Items.RemoveAt(pos);
                listaCostos.Items.RemoveAt(pos);
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
                listaCursos.Items.Add(curso);
                listaCostos.Items.Add(costo);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                double total = 0;
                double descuento = 0;
                double incremento = 0;
                foreach (int costo in listaCostosSeleccionados.Items)
                {
                    total += costo;
                }
                if (rbContado.Checked)
                {
                    descuento = total * 0.05;
                }
                else
                {
                    incremento = total * 0.07;
                }

                txtTotal.Text = total.ToString();
                txtDescuento.Text = descuento.ToString();
                txtIncremento.Text = incremento.ToString();
                txtMonto.Text = (total + incremento - descuento).ToString();
            }   
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
            if(!rbContado.Checked && !rbCredito.Checked)
            {
                MessageBox.Show("Debe seleccionar una forma de pago");
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtAlumno.Text = "";
            txtDescuento.Text = "";
            txtIncremento.Text = "";
            txtMonto.Text = "";
            txtTotal.Text = "";
            rbContado.Checked = false;
            rbCredito.Checked = false;
            foreach (string curso in listaCursosSeleccionados.Items)
            {
                listaCursos.Items.Add(curso);
            }
            foreach (int costo in listaCostosSeleccionados.Items)
            {
                listaCostos.Items.Add(costo);
            }
            listaCursosSeleccionados.Items.Clear();
            listaCostosSeleccionados.Items.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
