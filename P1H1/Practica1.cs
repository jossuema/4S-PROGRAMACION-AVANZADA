using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace P1H1
{
    public partial class Practica1 : Form
    {
        public Practica1()
        {
            InitializeComponent();
        }

        Dictionary<string, int> diccionarioPrecios = new Dictionary<string, int>{
            {"P4", 100}, 
            {"AMD", 500},
            {"Dual core", 1000},
            {"Core 2 duo", 2000},
            {"256 GB", 15},
            {"512 GB", 35},
            {"1 TB", 70},
            {"2 TB", 140},
            {"LG LCD 17 Plg", 500},
            {"LG LCD 20 Plg", 100},
            {"Tarjeta de video", 530},
            {"Tarjeta sonido 5.1", 700},
            {"Parlantes 5.1", 900}
        };

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Practica1_Load(object sender, EventArgs e)
        {

        }

        private void gbMemoria_Enter(object sender, EventArgs e)
        {

        }

        private void btGenerarFactura_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                String memoria;
                String procesador;
                String monitor = comboBox1.SelectedItem.ToString();

                if (rb1TB.Checked)
                {
                    memoria = "1 TB";
                }
                else if (rb2TB.Checked)
                {
                    memoria = "2 TB";
                }
                else if (rb512GB.Checked)
                {
                    memoria = "512 GB";
                }
                else
                {
                    memoria = "256 GB";
                }

                if (rbP4.Checked)
                {
                    procesador = "P4";
                }
                else if (rbAMD.Checked)
                {
                    procesador = "AMD";
                }
                else if (rbDualCore.Checked)
                {
                    procesador = "Dual core";
                }
                else
                {
                    procesador = "Core 2 duo";
                }

                dataGridView1.Rows.Add("1", memoria, diccionarioPrecios[memoria], diccionarioPrecios[memoria]);
                dataGridView1.Rows.Add("1", procesador, diccionarioPrecios[procesador], diccionarioPrecios[procesador]);
                dataGridView1.Rows.Add("1", monitor, diccionarioPrecios[monitor], diccionarioPrecios[monitor]);


                if (checkedListBox1.GetItemChecked(0))
                {
                    dataGridView1.Rows.Add("1", "Tarjeta de video", diccionarioPrecios["Tarjeta de video"], diccionarioPrecios["Tarjeta de video"]);
                }
                else if (checkedListBox1.GetItemChecked(1))
                {
                    dataGridView1.Rows.Add("1", "Tarjeta sonido 5.1", diccionarioPrecios["Tarjeta sonido 5.1"], diccionarioPrecios["Tarjeta sonido 5.1"]);
                }
                else if (checkedListBox1.GetItemChecked(2))
                {
                    dataGridView1.Rows.Add("1", "Parlantes 5.1", diccionarioPrecios["Parlantes 5.1"], diccionarioPrecios["Parlantes 5.1"]);
                }
            }
        }

        //validar cosas seleccionadas
        private bool Validar()
        {
            bool validado = true;
            if(comboBox1.SelectedIndex == -1)
            {
                validado = false;
                MessageBox.Show("Debe seleccionar un monitor");
            }
            if(!rb1TB.Checked && !rb2TB.Checked && !rb512GB.Checked && !rb256GB.Checked)
            {
                validado = false;
                MessageBox.Show("Debe seleccionar una memoria");
            }
            if(!rbP4.Checked && !rbAMD.Checked && !rbDualCore.Checked && !rbCore2Duo.Checked)
            {
                validado = false;
                MessageBox.Show("Debe seleccionar un procesador");
            }
            if(!checkedListBox1.GetItemChecked(0) && !checkedListBox1.GetItemChecked(1) && !checkedListBox1.GetItemChecked(2))
            {
                validado = false;
                MessageBox.Show("Debe seleccionar una opcion de accesorios");
            }
            return validado;
        }

        private void btCalcularTotal_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                double subtotal = 0;
                double IVA;
                double total;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells[3].Value);
                }
                IVA = subtotal * 0.12;
                total = subtotal + IVA;
                txtSubtotal.Text = subtotal.ToString("N2");
                txtIVA.Text = IVA.ToString("N2");
                txtTotal.Text = total.ToString("N2");
            }
        }
    }
}
