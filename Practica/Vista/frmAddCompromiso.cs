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
    public partial class frmAddCompromiso : Form
    {
        public frmAddCompromiso()
        {
            InitializeComponent();
        }

        public string cedula;

        public bool validar()
        {
            if(textLugar.Text == "")
            {
                MessageBox.Show("Ingrese un lugar");
                return false;
            }
            if(texHoraReunion.Text == "")
            {
                MessageBox.Show("Ingrese una hora");
                return false;
            }
            if(textTipo.Text == "")
            {
                MessageBox.Show("Ingrese un tipo de reunion");
                return false;
            }
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Ingrese una fecha");
                return false;
            }
            return true;
        }

        public void setCedula(string ced)
        {
            labelCedula.Text += ced;
            cedula = ced;
        }

        public Compromiso crearCompromiso()
        {
            Compromiso c = new Compromiso();
            c.Lugar = textLugar.Text;
            c.Hora = texHoraReunion.Text;
            c.Tipo = textTipo.Text;
            c.Fecha = dateTimePicker1.Value;
            c.Cedula = cedula;
            return c;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ingrese correctamente los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmAddCompromiso_Load(object sender, EventArgs e)
        {

        }
    }
}
