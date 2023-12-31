using Practica.Controlador;
using Practica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.Vista
{
    public partial class Compromisos : Form
    {
        public Compromisos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar una cedula");
            }
            else
            {
                Persona persona = TLista.lista.Find(x => x.Cedula == textBox1.Text);
                if(persona == null)
                {
                    MessageBox.Show("No se encontro la persona");
                }
                else
                {
                    dataGridView1.DataSource = persona.Compromisos;
                }
            }
        }

        private void Compromisos_Load(object sender, EventArgs e)
        {

        }
    }
}
