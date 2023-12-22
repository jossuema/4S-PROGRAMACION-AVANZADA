using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using HerenciaPolimorfismo.Entidad;

namespace Herencia.Formularios
{
    public partial class FrmEditEmpleado : Form
    {

        public Empleado auxiliar;

        public int opcion;

        public void setDatosEmpleado()
        {
          
            textBox1.Text = auxiliar.Codigo.ToString();
            textBox2.Text = auxiliar.Cedula;
            textBox3.Text = auxiliar.Nombres;
            textBox4.Text = auxiliar.Apellidos;
            comboBox1.SelectedItem = auxiliar.Sexo.ToString();
            comboBox2.SelectedItem = auxiliar.Estado;
            dateTimePicker1.Value = auxiliar.FechaNacimiento;

            if(typeof (Asalariado) == auxiliar.GetType())
            {
                Asalariado asalariado = (Asalariado)auxiliar;
                comboBox3.SelectedIndex = 0;
                txt1.Text = asalariado.SalarioBase.ToString();
                txt2.Text = asalariado.Bonificacion.ToString();
            }

            if (typeof(AsalariadoPorComision) == auxiliar.GetType())
            {
                AsalariadoPorComision asalariadoPC = (AsalariadoPorComision)auxiliar;
                comboBox3.SelectedIndex = 1;
                txt1.Text = asalariadoPC.SalarioBase.ToString();
                txt2.Text = asalariadoPC.Bonificacion.ToString();
                txt3.Text = asalariadoPC.PorcentajeComision.ToString();
                txt4.Text = asalariadoPC.TotalVentas.ToString();
            }

            if (typeof(PorComision) == auxiliar.GetType())
            {
                PorComision porComision = (PorComision)auxiliar;
                comboBox3.SelectedIndex = 2;
                txt1.Text = porComision.PorcentajeComision.ToString();
                txt2.Text = porComision.TotalVentas.ToString();
            }

            if (typeof(PorHoras) == auxiliar.GetType())
            {
                PorHoras porHoras = (PorHoras)auxiliar;
                comboBox3.SelectedIndex = 3;
                txt1.Text = porHoras.HorasTrabajadas.ToString();
                txt2.Text = porHoras.ValorHora.ToString();
            }

        }

         public Empleado CrearObjetoEmpleado()
        {
            Empleado op = null;
            
            string codigo = textBox1.Text;
            string cedula = textBox2.Text;
            string nombres = textBox3.Text;
            string apellidos = textBox4.Text;
            char sexo = Convert.ToChar(comboBox1.SelectedItem);
            string estado = comboBox2.SelectedItem.ToString();
            DateTime dateTime = dateTimePicker1.Value;

            if (comboBox3.SelectedIndex == 0)
            {
                double salario = Convert.ToDouble(txt1.Text);
                double bonificacion = Convert.ToDouble(txt2.Text);
                op = new Asalariado(Convert.ToInt32(codigo), cedula, nombres, apellidos, dateTime, sexo, estado, salario, bonificacion);
            }
            if (comboBox3.SelectedIndex == 1)
            {
                double salario = Convert.ToDouble(txt1.Text);
                double bonificacion = Convert.ToDouble(txt2.Text);
                double porcentaje = Convert.ToDouble(txt3.Text);
                double total = Convert.ToDouble(txt4.Text);
                op = new AsalariadoPorComision(Convert.ToInt32(codigo), cedula, nombres, apellidos, dateTime, sexo, estado, salario, bonificacion, porcentaje, total);
            }
            if(comboBox3.SelectedIndex == 2)
            {
                double porcentaje = Convert.ToDouble(txt1.Text);
                double total = Convert.ToDouble(txt2.Text);
                op = new PorComision(Convert.ToInt32(codigo), cedula, nombres, apellidos, dateTime, sexo, estado, porcentaje, total);
            }
            if (comboBox3.SelectedIndex == 3)
            {
                int horas = Convert.ToInt32(txt1.Text);
                double tarifa = Convert.ToDouble(txt2.Text);
                op = new PorHoras(Convert.ToInt32(codigo), cedula, nombres, apellidos, dateTime, sexo, estado, horas, tarifa);
            }
            return op;
        }

        public bool validar()
        {
            bool ok = true;
            
            if(textBox1.Text == "")
            {
                MessageBox.Show("Ingrese el codigo");
                textBox1.Focus();
                ok = false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ingrese la cedula");
                textBox2.Focus();
                ok = false;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                textBox3.Focus();
                ok = false;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Ingrese el apellido");
                textBox4.Focus();
                ok = false;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el sexo");
                comboBox1.Focus();
                ok = false;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el estado civil");
                comboBox2.Focus();
                ok = false;
            }
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de empleado");
                comboBox3.Focus();
                ok = false;
            }
            if(comboBox3.SelectedIndex == 0)
            {
                if(txt1.Text == "")
                {
                    MessageBox.Show("Ingrese el salario base");
                    txt1.Focus();
                    ok = false;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese la bonificacion");
                    txt2.Focus();
                    ok = false;
                }
            }
            if (comboBox3.SelectedIndex == 1)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese el salario base");
                    txt1.Focus();
                    ok = false;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese la bonificacion");
                    txt2.Focus();
                    ok = false;
                }
                if (txt3.Text == "")
                {
                    MessageBox.Show("Ingrese el porcentaje de comision");
                    txt3.Focus();
                    ok = false;
                }
                if (txt4.Text == "")
                {
                    MessageBox.Show("Ingrese el total de ventas");
                    txt4.Focus();
                    ok = false;
                }
            }
            if (comboBox3.SelectedIndex == 2)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese el porcentaje de comision");
                    txt1.Focus();
                    ok = false;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese el total de ventas");
                    txt2.Focus();
                    ok = false;
                }
            }
            if (comboBox3.SelectedIndex == 3)
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show("Ingrese las horas trabajadas");
                    txt1.Focus();
                    ok = false;
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show("Ingrese la tarifa");
                    txt2.Focus();
                    ok = false;
                }
            }

                

            return ok;
        }
        public FrmEditEmpleado()
        {
            InitializeComponent();
        }

        public void guardarArchivo()
        {


        }
        private void FrmEditPersona_Load(object sender, EventArgs e)
        {
            if (opcion == 2 && auxiliar != null)
            {
                setDatosEmpleado();
            }

            
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            activacionCampos();
        }

        private void activacionCampos()
        {
            if(comboBox3.SelectedIndex == -1)
            {
                labeltxt1.Visible = false;
                labeltxt2.Visible = false;
                labeltxt3.Visible = false;
                labeltxt4.Visible = false;
                txt1.Visible = false;
                txt2.Visible = false;
                txt3.Visible = false;
                txt4.Visible = false;
            }
            if(comboBox3.SelectedIndex==0)
            {
                labeltxt1.Text = "Salario Base:";
                txt1.Visible = true;
                labeltxt1.Visible = true;
                labeltxt2.Text = "Bonificacion:";
                txt2.Visible = true;
                labeltxt2.Visible = true;

                labeltxt3.Visible = false;
                labeltxt4.Visible = false;
                txt3.Visible = false;
                txt4.Visible = false;
            }
            if (comboBox3.SelectedIndex == 1)
            {
                labeltxt1.Text = "Salario Base:";
                labeltxt2.Text = "Bonificacion:";
                labeltxt3.Text = "Porcentaje Comision:";
                labeltxt4.Text = "Total Ventas:";
                labeltxt1.Visible = true;
                labeltxt2.Visible = true;
                labeltxt3.Visible = true;
                labeltxt4.Visible = true;
                txt1.Visible = true;
                txt2.Visible = true;
                txt3.Visible = true;
                txt4.Visible = true;
            }
            if (comboBox3.SelectedIndex == 2)
            {
                labeltxt1.Text = "Porcentaje Comision:";
                labeltxt1.Visible = true;
                txt1.Visible = true;
                labeltxt2.Text = "Total Ventas:";
                labeltxt2.Visible = true;
                txt2.Visible = true;
                labeltxt3.Visible = false;
                labeltxt4.Visible = false;
                txt3.Visible = false;
                txt4.Visible = false;
            }
            if (comboBox3.SelectedIndex == 3)
            {
                labeltxt1.Text = "Horas:";
                labeltxt1.Visible = true;
                txt1.Visible = true;
                labeltxt2.Text = "Tarifa:";
                labeltxt2.Visible = true;
                txt2.Visible = true;
                labeltxt3.Visible = false;
                labeltxt4.Visible = false;
                txt3.Visible = false;
                txt4.Visible = false;
            }
        }
    }
}
