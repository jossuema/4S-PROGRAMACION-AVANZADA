using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T3H1_Herencia.Entidades;

namespace T3H1_Herencia.Vista
{
    public partial class frmInsertEmpleado : Form
    {
        public frmInsertEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public Persona getPersona()
        {
            Persona persona = null;
            if (comboBox1.SelectedIndex == 0)
            {
                persona = new Comision(txtCedula.Text, txtNombre.Text, txtApellido.Text, cbSexo.Text, dateTimePicker1.Value, double.Parse(txt1.Text), double.Parse(txt2.Text));
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                persona = new Comisionado(txtCedula.Text, txtNombre.Text, txtApellido.Text, cbSexo.Text, dateTimePicker1.Value, double.Parse(txt1.Text), double.Parse(txt2.Text), double.Parse(txt3.Text));
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                persona = new Contratado(txtCedula.Text, txtNombre.Text, txtApellido.Text, cbSexo.Text, dateTimePicker1.Value, double.Parse(txt1.Text), int.Parse(txt2.Text));
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                persona = new Fijo(txtCedula.Text, txtNombre.Text, txtApellido.Text, cbSexo.Text, dateTimePicker1.Value, double.Parse(txt1.Text), double.Parse(txt2.Text));
            }
            return persona;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    this.DialogResult = DialogResult.OK;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoEmpleados();
        }

        private bool Validar()
        {
            if (txtCedula.Text == "")
            {
                MessageBox.Show("Ingrese la cedula");
                txtCedula.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido");
                txtApellido.Focus();
                return false;
            }
            if(cbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el sexo");
                cbSexo.Focus();
                return false;
            }
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Seleccione la fecha de nacimiento");
                dateTimePicker1.Focus();
                return false;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de empleado");
                comboBox1.Focus();
                return false;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese el porcentaje de comision");
                    txt1.Focus();
                    return false;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese las ventas");
                    txt2.Focus();
                    return false;
                }
                try
                {
                    double.Parse(txt1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un porcentaje de comision valido");
                    txt1.Focus();
                    return false;
                }
                try
                {
                    double.Parse(txt2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un valor de ventas valido");
                    txt2.Focus();
                    return false;
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese el salario base");
                    txt1.Focus();
                    return false;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese el porcentaje de comision");
                    txt2.Focus();
                    return false;
                }
                if (txt3.Text == "")
                {
                    MessageBox.Show("Ingrese las ventas");
                    txt3.Focus();
                    return false;
                }
                try
                {
                    double.Parse(txt1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un salario base valido");
                    txt1.Focus();
                    return false;
                }
                try
                {
                    double.Parse(txt2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un porcentaje de comision valido");
                    txt2.Focus();
                    return false;
                }
                try
                {
                    double.Parse(txt3.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un valor de ventas valido");
                    txt3.Focus();
                    return false;
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese el sueldo por hora");
                    txt1.Focus();
                    return false;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese las horas trabajadas");
                    txt2.Focus();
                    return false;
                }
                try
                {
                    double.Parse(txt1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un sueldo por hora valido");
                    txt1.Focus();
                    return false;
                }
                try
                {
                    int.Parse(txt2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un valor de horas trabajadas valido");
                    txt2.Focus();
                    return false;
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese el sueldo mensual");
                    txt1.Focus();
                    return false;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese el anticipo");
                    txt2.Focus();
                    return false;
                }
                try
                {
                    double.Parse(txt1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un sueldo mensual valido");
                    txt1.Focus();
                    return false;
                }
                try
                {
                    double.Parse(txt2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un anticipo valido");
                    txt2.Focus();
                    return false;
                }
            }

            return true;
        }

        private void tipoEmpleados()
        {
            if(comboBox1.SelectedIndex == -1)
            {
                lbl1.Visible = false;
                txt1.Visible = false;
                lbl2.Visible = false;
                txt2.Visible = false;
                lbl3.Visible = false;
                txt3.Visible = false;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                lbl1.Text = "Porcentaje de Comision: ";
                lbl1.Visible = true;
                txt1.Visible = true;
                lbl2.Text = "Ventas: ";
                lbl2.Visible = true;
                txt2.Visible = true;

                lbl3.Visible = false;
                txt3.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                lbl1.Text = "Salario Base: ";
                lbl1.Visible = true;
                txt1.Visible = true;
                lbl2.Text = "Porcentaje de Comision: ";
                lbl2.Visible = true;
                txt2.Visible = true;
                lbl3.Text = "Ventas: ";
                lbl3.Visible = true;
                txt3.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                lbl1.Text = "Sueldo por Hora: ";
                lbl1.Visible = true;
                txt1.Visible = true;
                lbl2.Text = "Horas Trabajadas: ";
                lbl2.Visible = true;
                txt2.Visible = true;

                lbl3.Visible = false;
                txt3.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                lbl1.Text = "Sueldo Mensual: ";
                lbl1.Visible = true;
                txt1.Visible = true;
                lbl2.Text = "Anticipo: ";
                lbl2.Visible = true;
                txt2.Visible = true;

                lbl3.Visible = false;
                txt3.Visible = false;
            }
        }

        private void frmInsertEmpleado_Load(object sender, EventArgs e)
        {
            tipoEmpleados();
        }
    }
}
