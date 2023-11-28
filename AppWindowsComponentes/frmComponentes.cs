using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindowsComponentes
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cedula = textBox1.Text;
            string nombre = textBox2.Text;
            char sexo;
            if (radioButton1.Checked)
            {
                sexo = 'M';
            }
            else
            {
                sexo = 'F';
            }
            DateTime fechaNacimiento = dateTimePicker1.Value;
            string estadoCivil = comboBox1.SelectedItem.ToString();
            string pasatiempo = "";
            if (checkBox1.Checked)
            {
                pasatiempo += checkBox1.Text;
                pasatiempo += "-";
            }
            if (checkBox2.Checked)
            {
                pasatiempo += checkBox2.Text;
                pasatiempo += "-";
            }
            if (checkBox3.Checked)
            {
                pasatiempo += checkBox3.Text;
                pasatiempo += "-";
            }
            if (checkBox4.Checked)
            {
                pasatiempo += checkBox4.Text;
                pasatiempo += "-";
            }
            MessageBox.Show($"Cedula: {cedula} \nNombre: {nombre} \nSexo: {sexo} \nEdad: {calcularEdad()} \nEstado Civil: {estadoCivil} \nPasatiempo: {pasatiempo}");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmComponentes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private int calcularEdad()
        {
            DateTime fechaNacimiento = dateTimePicker1.Value;
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            return edad;
        }
    }
}
