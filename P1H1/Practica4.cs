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
    public partial class Practica4 : Form
    {
        public Practica4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string pelicula = txtPelicula.Text;
                string categoria = "";
                if (rbAccion.Checked)
                {
                    categoria = "Accion";
                }
                else if (rbComedia.Checked)
                {
                    categoria = "Comedia";
                }
                else if (rbDibujos.Checked)
                {
                    categoria = "Dibujos";
                }
                else if (rbDrama.Checked)
                {
                    categoria = "Drama";
                }
                int duracion = int.Parse(txtDuracion.Text);
                string actor = txtActor.Text;

                dataGridView1.Rows.Add(pelicula, categoria, duracion, actor);

                txtTotal.Text = (dataGridView1.Rows.Count - 1).ToString();
            }
        }

        private bool validar()
        {
            int valor;
            if(txtPelicula.Text == "")
            {
                MessageBox.Show("El campo pelicula no puede estar vacio");
                txtPelicula.Focus();
                return false;
            }
            else if (!rbAccion.Checked && !rbComedia.Checked && !rbDibujos.Checked && !rbDrama.Checked)
            {
                MessageBox.Show("Debe seleccionar una categoria");
                return false;
            }
            else if (txtDuracion.Text == "" || !int.TryParse(txtDuracion.Text, out valor) )
            {
                MessageBox.Show("Debe ingresar un valor numerico");
                txtDuracion.Focus();
                return false;
            }
            else if (txtActor.Text == "")
            {
                MessageBox.Show("El campo actor no puede estar vacio");
                txtActor.Focus();
                return false;
            }
            return true;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            limpia();
        }

        private void limpia()
        {
            txtPelicula.Text = "";
            txtDuracion.Text = "";
            txtActor.Text = "";
            rbAccion.Checked = false;
            rbComedia.Checked = false;
            rbDibujos.Checked = false;
            rbDrama.Checked = false;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int posicion = dataGridView1.CurrentRow.Index;
            if (posicion == -1)
            {
                MessageBox.Show("Debe seleccionar una pelicula");
            }
            else
            {
                dataGridView1.Rows.RemoveAt(posicion);
                txtTotal.Text = (dataGridView1.Rows.Count - 1).ToString();
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
