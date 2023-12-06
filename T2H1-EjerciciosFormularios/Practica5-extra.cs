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
    public partial class Practica5_extra : Form
    {
        public Practica5_extra(string nombre, int bien,int mal, string puntaje)
        {
            InitializeComponent();
            labelNombre.Text += nombre;
            labelBuenas.Text += bien.ToString();
            labelMalas.Text += mal.ToString();
            labelPuntaje.Text += puntaje;
        }

        private void Practica5_extra_Load(object sender, EventArgs e)
        {

        }
    }
}
