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
    public partial class frmElectricidad : Form
    {
        public frmElectricidad()
        {
            InitializeComponent();
        }

        int consumo = 0;
        string cliente = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cliente = textBox1.Text;
            int consumo =+ int.Parse(textBox2.Text);
        }

        public void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            consumo = 0;
            cliente = "";
        }

        public void imprimir(string cliente, double pago)
        {
            MessageBox.Show("El cliente " + cliente + " debe pagar " + pago);
        }

        public double calcularPago(int consumo)
        {
            double pago = 0;
            if (consumo <= 100)
            {
                pago = consumo * 0.10;
            }
            else if (consumo > 100 && consumo <= 200)
            {
                pago = (100 * 0.10) + ((consumo - 200) * 0.12);
            }
            else if (consumo > 200)
            {
                pago = (100 * 0.10) + (100 * 0.12) + ((consumo - 200) * 0.15);
            }
            return pago;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imprimir(cliente, calcularPago(consumo));
            limpiar();
        }
    }
}
