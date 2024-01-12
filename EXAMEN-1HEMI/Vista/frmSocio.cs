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
    public partial class frmSocio : Form
    {
        public frmSocio()
        {
            InitializeComponent();
        }

        public string Modo { get; set; }
        public string Cedula { get; set; }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void setSocio(Socio socio)
        {
            txtCedula.Text = socio.Cedula;
            txtNombre.Text = socio.Nombre;
            txtApellido.Text = socio.Apellido;
            dateTimePicker1.Value = socio.FechaNacimiento;
            comboBox1.SelectedItem = socio.Sexo;
            comboBox2.SelectedItem = socio.EstadoCivil;
            foreach(int matricula in socio.BarcosMatricula)
            {
                listBox2.Items.Add(matricula);
                listBox1.Items.Remove(matricula);
            }
        }

        private Socio crearSocio()
        {
            Socio socio = new Socio();
            socio.Cedula = txtCedula.Text;
            socio.Nombre = txtNombre.Text;
            socio.Apellido = txtApellido.Text;
            socio.FechaNacimiento = dateTimePicker1.Value;
            socio.Sexo = char.Parse(comboBox1.SelectedItem.ToString());
            socio.EstadoCivil = comboBox2.SelectedItem.ToString();
            socio.BarcosMatricula = new List<int>();
            socio.NumeroSocio = TListaSocios.ListaSocios.Count + 1;
            foreach (string matricula in listBox2.Items)
            {
                socio.BarcosMatricula.Add(int.Parse(matricula));
            }
            return socio;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                string matricula = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(matricula);
                listBox2.Items.Add(matricula);
            }
        }

        private void frmSocio_Load(object sender, EventArgs e)
        {
            ListarBarcos(); 
        }

        private void ListarBarcos()
        {
            foreach (Barco barco in TListaBarcos.ListaBarcos)
            {
                listBox1.Items.Add(barco.NumeroMatricula);
            }
        }

        private void btQuitar_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox1.Items.Add(listBox2.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(Validar())
                {
                    Socio socio = crearSocio();
                    if(Modo == "EDITAR")
                    {
                        TListaSocios.ModificarSocio(socio, Cedula);
                        MessageBox.Show("Socio editado correctamente");
                    }
                    else
                    {
                        TListaSocios.AgregarSocio(socio);
                        MessageBox.Show("Socio agregado correctamente");
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Validar()
        {
            bool ok = true;

            if(txtCedula.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar la cédula");
                txtCedula.Focus();
            }else if(txtNombre.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar el nombre");
                txtNombre.Focus();
            }else if(txtApellido.Text == "")
            {
                ok = false;
                MessageBox.Show("Debe ingresar el apellido");
                txtApellido.Focus();
            }else if(comboBox1.SelectedIndex == -1)
            {
                ok = false;
                MessageBox.Show("Debe seleccionar el sexo");
                comboBox1.Focus();
            }else if(comboBox2.SelectedIndex == -1)
            {
                ok = false;
                MessageBox.Show("Debe seleccionar el estado civil");
                comboBox2.Focus();
            }else if(dateTimePicker1.Value == null)
            {
                ok = false;
                MessageBox.Show("Debe seleccionar la fecha de nacimiento");
                dateTimePicker1.Focus();
            }
            return ok;
        }
    }
}
