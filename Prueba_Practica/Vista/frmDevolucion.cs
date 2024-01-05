using Prueba_Practica.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Practica.Vista
{
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            var sql = from registro in TListaRegistros.lista
                      where registro.Devuelto == false
                      select registro;
            dataGridView1.DataSource = sql.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               if(validar())
                {
                    string libro = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string estudiante = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    DateTime fechaEntrega = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                    DateTime fechaDevolucion = dateTimePicker1.Value;

                    if(fechaDevolucion > fechaEntrega)
                    {
                        TListaEstudiantes.listaEstudiantes.Find(x => x.Cedula == estudiante).Sancionado = true;
                        MessageBox.Show("El estudiante ha sido multado");
                    }
                    else
                    {
                        TListaEstudiantes.listaEstudiantes.Find(x => x.Cedula == estudiante).Sancionado = false;
                        MessageBox.Show("El estudiante no debe pagar multa");
                    }

                    TListaRegistros.EliminarRegistro(estudiante, libro);
                    TListaLibrosRevistas.listaLibros.Find(x => x.Codigo == libro).Prestado = false;
                    TListaLibrosRevistas.listaRevistas.Find(x => x.Codigo == libro).Prestado = false;
                    listar();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validar()
        {
            if(dataGridView1.CurrentRow != null)
            {
                MessageBox.Show("Seleccione un registro");
                return false;
            }
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Seleccione una fecha de devolucion");
                return false;
            }
            DateTime fechaP = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            if(dateTimePicker1.Value < fechaP)
            {
                MessageBox.Show("La fecha de devolucion no puede ser menor a la fecha de prestamo");
                return false;
            }
            if(dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de devolucion no puede ser mayor a la fecha actual");
                return false;
            }
            
            return true;
        }
    }
}
