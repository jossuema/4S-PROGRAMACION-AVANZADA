using EXAMEN_PROGRAMACION_AVANZADA.Controlador;
using EXAMEN_PROGRAMACION_AVANZADA.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_PROGRAMACION_AVANZADA.Vista
{
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            foreach(AlquilerVehiculo alquiler in TListalAlquiler.Lista())
            {
                if(!alquiler.Devuelto)
                {
                    dataGridView1.DataSource = TListalAlquiler.Lista();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                var alquiler = (AlquilerVehiculo)dataGridView1.SelectedRows[0].DataBoundItem;
                Vehiculo vehiculo = TListaVehiculos.Buscar(alquiler.PlacaVehiculo);
                vehiculo.Prestado = true;
                alquiler.Devuelto = true;

                MessageBox.Show("Vehiculo devuelto correctamente");
                Listar();
            }
            else
            {
                MessageBox.Show("Seleccione un alquiler");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
