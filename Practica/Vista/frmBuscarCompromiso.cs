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
    public partial class frmBuscarCompromiso : Form
    {
        public frmBuscarCompromiso()
        {
            InitializeComponent();
        }

        Persona p;

        private void frmBuscarCompromiso_Load(object sender, EventArgs e)
        {

        }

        public void setDatos(Persona p)
        {
            labelNombre.Text = "Nombre: "+p.Nombre;
            lablApellido.Text = "Apellidos: " + p.Apellidos;
            labelDireccion.Text = "Direccion: " + p.Direccion;
            labelTelefono.Text = "Telefono: " + p.Telefono;
            labelFechaNacimiento.Text = "Fecha nacimiento: " + p.FechaNacimiento.ToString();
            labelSexo.Text = "Sexo: " + p.Sexo;
            labelEstadoCivil.Text = "Estado civil: " + p.EstadoCivil;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Ingrese una cedula");
            }
            else
            {
                p = Controlador.TLista.lista.Find(x => x.Cedula == textBox1.Text);
                if(p == null)
                {
                    MessageBox.Show("No se encontro la persona");
                }
                else
                {
                    setDatos(p);
                }
            }
        }

        public void nuevoCompromiso()
        {
            if(p == null)
            {
                MessageBox.Show("No se ha seleccionado una persona");
            }
            try
            {
                frmAddCompromiso frm = new frmAddCompromiso();
                frm.setCedula(p.Cedula);
                frm.ShowDialog();
                
                if (frm.DialogResult == DialogResult.OK)
                {
                    Compromiso obp = frm.crearCompromiso();
                    frm.Hide();
                  
                    Persona pe = Controlador.TLista.lista.Find(x => x.Cedula == obp.Cedula);
                  
                    pe.Compromisos.Add(obp);
                    MessageBox.Show("Compromiso creado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(p == null)
            {
                MessageBox.Show("No se ha seleccionado una persona");
            }
            else
            {
                nuevoCompromiso();
            }
        }
    }
}
