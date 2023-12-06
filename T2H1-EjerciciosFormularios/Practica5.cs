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
    public partial class Practica5 : Form
    {
        public Practica5()
        {
            InitializeComponent();
        }

        private void Practica5_Load(object sender, EventArgs e)
        {

        }

        private void txtNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtPostulante.Text = "";
            txtBien.Text = "";
            txtMal.Text = "";
            txtPostulante.Focus();
        }

        private bool validar()
        {
            double valor;
            if (txtPostulante.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de postulante");
                txtPostulante.Focus();
                return false;
            }
            else if (txtBien.Text == "" || !double.TryParse(txtBien.Text, out valor))
            {
                MessageBox.Show("Debe ingresar un valor numérico");
                txtBien.Focus();
                return false;
            }
            else if (txtMal.Text == "" || !double.TryParse(txtMal.Text, out valor))
            {
                MessageBox.Show("Debe ingresar un valor numérico");
                txtMal.Focus();
                return false;
            }
            
            int bien = int.Parse(txtBien.Text);
            int mal = int.Parse(txtMal.Text);

            if (bien + mal > 100)
            {
                MessageBox.Show("La suma de las respuestas no puede ser mayor a 100");
                return false;
            }
      
            return true;
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string postulante = txtPostulante.Text;
                double bien = int.Parse(txtBien.Text);
                double mal = int.Parse(txtMal.Text);

                listaPostulantes.Items.Add(postulante);
                listaBuenas.Items.Add(bien);
                listaMalas.Items.Add(mal);

                bien *= 4.08;
                mal *= 1.04;
                double puntaje = bien - mal;
                listaPuntajes.Items.Add(puntaje.ToString("N2"));
            }
        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            int posicion = listaPostulantes.SelectedIndex;
            if(posicion == -1)
            {
                MessageBox.Show("Debe seleccionar un postulante");
            }
            else
            {
                MessageBox.Show("Postulante eliminado");
                listaPostulantes.Items.RemoveAt(posicion);
                listaBuenas.Items.RemoveAt(posicion);
                listaMalas.Items.RemoveAt(posicion);
                listaPuntajes.Items.RemoveAt(posicion);
            }       
        }

        private void txtCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posicion = 0;
            double mayor = 0;
            foreach (string puntaje in listaPuntajes.Items)
            {
                if (double.Parse(puntaje) > mayor)
                {
                    mayor = double.Parse(puntaje);
                    posicion = listaPuntajes.Items.IndexOf(puntaje);
                }
            }

            string postulante = listaPostulantes.Items[posicion].ToString();
            int bien = int.Parse(listaBuenas.Items[posicion].ToString());
            int mal = int.Parse(listaMalas.Items[posicion].ToString());
            
            Practica5_extra form = new Practica5_extra(postulante, bien, mal, mayor.ToString("N2"));
            form.Show();
        }
    }
}
