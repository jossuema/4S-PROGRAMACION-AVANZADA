using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1H1
{
    public partial class Practica2_extra : Form
    {
        public Practica2_extra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                ingrediente = textBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Introduzca un ingrediente.");
            }

            if (textBox2.Text != "")
            {
                try
                {
                    costo = Convert.ToDouble(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Introduzca un valor numérico.");
                }
            }

        }

        public string ingrediente;
        public double costo;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
