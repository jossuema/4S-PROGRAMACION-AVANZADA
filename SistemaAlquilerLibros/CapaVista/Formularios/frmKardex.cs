using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capavista.Formularios
{
    public partial class frmKardex : Form
    {
        public frmKardex()
        {
            InitializeComponent();
            ln = new CapaLogica.Gestion.KardexLN();
            cargarCombo();

        }

        public void cargarCombo()
        {
            var libros = ln.LibrosCB();
            comboBox1.DataSource = new BindingSource(libros, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        CapaLogica.Gestion.KardexLN ln;

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public void setDatos(int id)
        {
            CapaEntidades.Gestion.Kardex kardex = ln.BuscarKardex(id);
            comboBox1.SelectedValue = kardex.Id_libro;
            dateTimePicker1.Value = kardex.Fecha;
            txtDetalle.Text = kardex.Detalle;
            nudEntrada.Value = kardex.Entrada;
            nudSalida.Value = kardex.Salida;
            txtTotal.Text = kardex.Total + "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1)
            {
                int id = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
                int stock = ln.stockLibro(id);
                txtTotal.Text = stock + nudEntrada.Value - nudSalida.Value + "";
            }
        }

        private bool validar()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un libro");
                return false;
            }
            if (nudEntrada.Value == 0 && nudSalida.Value == 0)
            {
                MessageBox.Show("Ingrese un valor de entrada o salida");
                return false;
            }
            if(txtDetalle.Text == "")
            {
                MessageBox.Show("Ingrese el detalle");
                return false;
            }
            if(dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser mayor a la actual");
                return false;
            }
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Ingrese la fecha");
                return false;
            }
            int total = int.Parse(txtTotal.Text);
            if(total < 0)
            {
                MessageBox.Show("No puede sacar mas libros de los que hay en stock");
                return false;
            }
            return true;
        }

        public CapaEntidades.Gestion.Kardex getKardex()
        {
            int id_libro = (int)comboBox1.SelectedValue;
            DateTime fecha = dateTimePicker1.Value;
            string detalle = txtDetalle.Text;
            int entrada = (int)nudEntrada.Value;
            int salida = (int)nudSalida.Value;
            int total = int.Parse(txtTotal.Text) + entrada - salida;
            return new CapaEntidades.Gestion.Kardex(0, id_libro, fecha, detalle, entrada, salida, total);
        }
    }
}
