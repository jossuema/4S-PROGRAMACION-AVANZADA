using EXAMEN_1HEMI.Controlador;
using EXAMEN_1HEMI.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_1HEMI.Vista
{
    public partial class frmBarco : Form
    {
        public frmBarco()
        {
            InitializeComponent();
        }

        public string Modo { get; set; }
        public int NumeroMatricula { get; set; }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void setBarco(Barco barco)
        {
            txtMatricula.Text = barco.NumeroMatricula.ToString();
            txtNombre.Text = barco.Nombre;
            txtAmarre.Text = barco.NumeroAmarre.ToString();
            txtCuota.Text = barco.CuotaMensual.ToString();
            comboBox1.SelectedItem = barco.CedulaSocio;
        }

        private void frmBarco_Load(object sender, EventArgs e)
        {
            listarPropietarios();
        }

        public void listarPropietarios()
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            foreach(Socio socio in TListaSocios.ObtenerSocios())
            {
                comboBox1.Items.Add(socio.Cedula);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Barco barco = ObtenerBarco();
                    if(Modo == "EDITAR")
                    {
                        TListaBarcos.ModificarBarco(barco, NumeroMatricula);
                        MessageBox.Show("Barco editado correctamente");
                    }
                    else
                    {
                        TListaBarcos.AgregarBarco(barco);
                        MessageBox.Show("Barco agregado correctamente");
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Validar()
        {
            bool ok = true;
            if(txtMatricula.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar una matricula");
                txtMatricula.Focus();
            }else if(txtNombre.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar un nombre");
                txtNombre.Focus();
            }else if(txtAmarre.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar un amarre");
                txtAmarre.Focus();
            }else if(txtCuota.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar una cuota");
                txtCuota.Focus();
            }else if(comboBox1.SelectedIndex == -1)
            {
                ok = false;
                MessageBox.Show("Debe seleccionar un propietario");
                comboBox1.Focus();
            }
            return ok;
        }

        private Barco ObtenerBarco()
        {
            Barco barco = new Barco();
            barco.NumeroMatricula = int.Parse(txtMatricula.Text);
            barco.Nombre = txtNombre.Text;
            barco.NumeroAmarre = int.Parse(txtAmarre.Text);
            barco.CuotaMensual = Convert.ToDouble(txtCuota.Text);
            barco.CedulaSocio = comboBox1.SelectedItem.ToString();
            return barco;
        }
    }
}
