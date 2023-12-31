using Practica.Controlador;
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
    public partial class Cumpleaneros : Form
    {
        public Cumpleaneros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Debe seleccionar una fecha");
            }
            else
            {
                var sql = from p in TLista.lista
                          where p.FechaNacimiento.Month == dateTimePicker1.Value.Month
                          select p;
                dataGridView1.DataSource = sql.ToList();
            }
        }
    }
}
