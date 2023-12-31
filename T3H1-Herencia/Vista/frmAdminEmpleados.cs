using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T3H1_Herencia.Controlador;
using T3H1_Herencia.Entidades;

namespace T3H1_Herencia.Vista
{
    public partial class frmAdminEmpleados : Form
    {
        public frmAdminEmpleados()
        {
            InitializeComponent();
        }

        private void frmAdminEmpleados_Load(object sender, EventArgs e)
        {
            cargarDatos();
            comboBox1.SelectedIndex = 0;
            listar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            nuevaPersona();
        }

        private void nuevaPersona()
        {
            try
            {
                frmInsertEmpleado frm = new frmInsertEmpleado();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    TLista.Agregar(frm.getPersona());
                    dataGridView1.DataSource = null;
                    listar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = null;
                    var sql = from p in TLista.ListaPersonas
                              select new
                              {
                                  p.Nombre,
                                  p.Apellido,
                                  p.Cedula,
                                  p.Sexo,
                                  p.FechaNacimiento,
                                  p.Edad,
                                  p.Bonificaciones,
                                  Sueldo = p.Sueldo().ToString("C2")
                              };
                    dataGridView1.DataSource = sql.ToList();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    dataGridView1.DataSource = null;
                    var sql = from p in TLista.ListaPersonas
                              where p.GetType() == typeof(Comision)
                              select new {
                                    p.Nombre,
                                    p.Apellido,
                                    p.Cedula,
                                    p.Sexo,
                                    p.FechaNacimiento,
                                    p.Edad,
                                    p.Bonificaciones,
                                    Sueldo = p.Sueldo().ToString("C2")
                              };
                    dataGridView1.DataSource = sql.ToList();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    dataGridView1.DataSource = null;
                    var sql = from p in TLista.ListaPersonas
                              where p.GetType() == typeof(Comisionado)
                              select new
                              {
                                  p.Nombre,
                                  p.Apellido,
                                  p.Cedula,
                                  p.Sexo,
                                  p.FechaNacimiento,
                                  p.Edad,
                                  p.Bonificaciones,
                                  Sueldo = p.Sueldo().ToString("C2")
                              };
                    dataGridView1.DataSource = sql.ToList();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    dataGridView1.DataSource = null;
                    var sql = from p in TLista.ListaPersonas
                              where p.GetType() == typeof(Contratado)
                              select new
                              {
                                  p.Nombre,
                                  p.Apellido,
                                  p.Cedula,
                                  p.Sexo,
                                  p.FechaNacimiento,
                                  p.Edad,
                                  p.Bonificaciones,
                                  Sueldo = p.Sueldo().ToString("C2")
                              };
                    dataGridView1.DataSource = sql.ToList();
                }else if (comboBox1.SelectedIndex == 4)
                {
                    dataGridView1.DataSource = null;
                    var sql = from p in TLista.ListaPersonas
                              where p.GetType() == typeof(Fijo)
                              select new
                              {
                                  p.Nombre,
                                  p.Apellido,
                                  p.Cedula,
                                  p.Sexo,
                                  p.FechaNacimiento,
                                  p.Edad,
                                  p.Bonificaciones,
                                  Sueldo = p.Sueldo().ToString("C2")
                              };
                    dataGridView1.DataSource = sql.ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDatos()
        {
            TLista.Agregar(new Comisionado("Juan", "Perez", "123456789", "Masculino", new DateTime(2004, 12, 12), 1000, 0.1, 10000));
            TLista.Agregar(new Comisionado("Maria", "Perez", "1764536789", "Femenino", new DateTime(2002, 3, 6), 1000, 0.1, 10000));
            TLista.Agregar(new Comisionado("Pedro", "Perez", "1265456789", "Masculino", new DateTime(2003, 5, 18), 1000, 0.1, 10000));
            TLista.Agregar(new Comision("Josue", "Perez", "1534456789", "Masculino", new DateTime(2004, 5, 6), 0.1, 10000));
            TLista.Agregar(new Comision("Karla", "Perez", "54326356789", "Femenino", new DateTime(2002, 3, 6), 0.1, 10000));
            TLista.Agregar(new Comision("Luis", "Perez", "3463456789", "Masculino", new DateTime(2003, 5, 18), 0.1, 10000));
            TLista.Agregar(new Contratado("Carlos", "Martinez", "178565789", "Masculino", new DateTime(2004, 12, 12), 1000, 100));
            TLista.Agregar(new Contratado("Luis", "Martinez", "34634356789", "Masculino", new DateTime(2002, 3, 6), 1000, 100));
            TLista.Agregar(new Contratado("Maria", "Martinez", "5665323789", "Femenino", new DateTime(2003, 5, 18), 1000, 100));
            TLista.Agregar(new Fijo("Juan", "Martinez", "213456789", "Masculino", new DateTime(2004, 12, 12), 1000, 100));
            TLista.Agregar(new Fijo("Pedro", "Martinez", "7634456789", "Masculino", new DateTime(2002, 3, 6), 1000, 100));
            TLista.Agregar(new Fijo("Luis", "Martinez", "4532556789", "Masculino", new DateTime(2003, 5, 18), 1000, 100));
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            eliminarPersona();
        }

        private void eliminarPersona()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var res = MessageBox.Show("! Deseas eliminar empleado", "Eliminar Empleado", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        string op = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                        int pos = TLista.ListaPersonas.FindIndex(p => p.Cedula == op);
                        TLista.ListaPersonas.RemoveAt(pos);
                        MessageBox.Show("Empleado eliminado");
                        listar();
                    }
                }
                else
                    MessageBox.Show("Seleccione la fila eliminar");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
