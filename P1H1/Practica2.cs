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
    public partial class Practica2 : Form
    {
        public Practica2()
        {
            InitializeComponent();
        }

        Dictionary<string, double> ingredientes = new Dictionary<string, double> {
            {"Queso", 10}
            ,{"Tomate", 5}
            ,{"Mozzarella", 5}
        };
        Dictionary<string, double> envases = new Dictionary<string, double>
        {
            {"Plastico", 5}
            ,{"Aluminio", 3}
            ,{"Isopor", 2}
        };
        Dictionary<string, double> bebidas = new Dictionary<string, double>
        {
            {"Jugo", 15}
            ,{"Gaseosa", 10}
            ,{"Cerveza", 20}
            ,{"Vino", 25}
        };

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                double costo = 0;

                foreach (string item in listBox2.Items)
                {
                    costo += ingredientes[item];
                }

                if (cbAluminio.Checked)
                {
                    costo += envases["Aluminio"];
                }
                else if (cbIsopor.Checked)
                {
                    costo += envases["Isopor"];
                }
                else if (cbPlastico.Checked)
                {
                    costo += envases["Plastico"];
                }

                if (cbJugo.Checked)
                {
                    costo += bebidas["Jugo"];
                }
                else if (cbGaseosa.Checked)
                {
                    costo += bebidas["Gaseosa"];
                }
                else if (cbCerveza.Checked)
                {
                    costo += bebidas["Cerveza"];
                }
                else if (cbVino.Checked)
                {
                    costo += bebidas["Vino"];
                }

                txtTotal.Text = costo.ToString("N2");
            }
        }

        private bool Validar()
        {
            bool ok = true;

            if(listBox2.Items.Count < 0) {
                ok = false;
                MessageBox.Show("Seleccione ingredientes");
            }

            if(cbAluminio.Checked == false && cbIsopor.Checked == false && cbPlastico.Checked == false)
            {
                ok = false;
                MessageBox.Show("Seleccione un envase");
            }

            if(cbJugo.Checked == false && cbGaseosa.Checked == false && cbVino.Checked == false && cbCerveza.Checked == false)
            {
                ok = false;
                MessageBox.Show("Seleccione una bebida");
            }
            return ok;
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Seleccione un ingrediente de la lista.");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Seleccione un ingrediente de la lista.");
            }
        }

        private void btIngredienteEspecial_Click(object sender, EventArgs e)
        {
            try
            {
                Practica2_extra frm = new Practica2_extra();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    listBox1.Items.Add(frm.ingrediente);
                    ingredientes.Add(frm.ingrediente, frm.costo);
                    frm.Close();
                    MessageBox.Show("Ingrediente añadido.");
                }
                else
                {
                    MessageBox.Show("No se ha añadido ningún ingrediente.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al añadir el ingrediente.");
            }
            
        }

        private void btNuevoPlato_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach(KeyValuePair<string, double> item in ingredientes)
            {
                listBox1.Items.Add(item.Key);
            }
        }
    }
}
