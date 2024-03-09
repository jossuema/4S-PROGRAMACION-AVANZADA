using CapaEntidad.Gestion;
using CapaLogica.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMaquinaria : Form
    {
        public frmMaquinaria()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Validar()
        {
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return false;
            }else if(comboBox1.Text == "")
            {
                MessageBox.Show("Seleccione el tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
                return false;
            }else if(txtTarifa.Text == "")
            {
                MessageBox.Show("Ingrese la tarifa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTarifa.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setDatos(Maquinaria maq)
        {
            txtCodigo.Text = maq.Codigo;
            txtCodigo.Enabled = false;
            comboBox1.Text = maq.Tipo;
            txtTarifa.Text = maq.Tarifa.ToString();
        }

        public Maquinaria getDatos()
        {
            Maquinaria maq = new Maquinaria();
            maq.Codigo = txtCodigo.Text;
            maq.Tipo = comboBox1.Text;
            maq.Tarifa = double.Parse(txtTarifa.Text);
            maq.Disponible = true;
            return maq;
        }
    }
}
