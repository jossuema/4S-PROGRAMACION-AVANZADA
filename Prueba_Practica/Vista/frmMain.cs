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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            if(comboBox1.SelectedItem.ToString() == "Estudiantes")
            {
                var sql = from estudiante in TListaEstudiantes.listaEstudiantes
                          select estudiante;
                dataTable.DataSource = sql.ToList();
            }
            else if(comboBox1.SelectedItem.ToString() == "Libros")
            {
                var sql = from libro in TListaLibrosRevistas.listaLibros
                          select libro;
                dataTable.DataSource = sql.ToList();
            }
            else if(comboBox1.SelectedItem.ToString() == "Revistas")
            {
               var sql = from revista in TListaLibrosRevistas.listaRevistas
                          select revista;
                dataTable.DataSource = sql.ToList();
            }
            else if(comboBox1.SelectedItem.ToString() == "Registros")
            {
                var sql = from registro in TListaRegistros.lista
                          select registro;
                dataTable.DataSource = sql.ToList();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Estudiantes")
            {
                nuevoEstudiante();
            }
            else if(comboBox1.SelectedItem.ToString() == "Libros")
            {
                nuevoLibro();
            }
            else if(comboBox1.SelectedItem.ToString() == "Revistas")
            {
                nuevaRevista();
            }
        }

        private void nuevoEstudiante()
        {
            try
            {
                frmEstudiante frm = new frmEstudiante();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nuevoLibro()
        {
            try
            {
                frmLibroRevista frm = new frmLibroRevista();
                frm.setOpcion("Libro");
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Libro agregado correctamente");
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nuevaRevista()
        {
            try
            {
                frmLibroRevista frm = new frmLibroRevista();
                frm.setOpcion("Revista");
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                    MessageBox.Show("Revista agregada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Estudiantes")
            {
                editarEstudiante();
            }
            else if(comboBox1.SelectedItem.ToString() == "Libros")
            {
                editarLibro();
            }
            else if(comboBox1.SelectedItem.ToString() == "Revistas")
            {
                editarRevista();
            }
        }

        private void editarEstudiante()
        {
            try
            {
                if(dataTable.CurrentRow != null)
                {
                    frmEstudiante frm = new frmEstudiante();
                    frm.setEditar(true);
                    string cedula = dataTable.CurrentRow.Cells[0].Value.ToString();
                    frm.setEstudiante(TListaEstudiantes.listaEstudiantes[TListaEstudiantes.BuscarEstudiante(cedula)]);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Estudiante editado correctamente");
                        Listar();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editarLibro()
        {
            try
            {
                if(dataTable.CurrentRow != null)
                {
                    frmLibroRevista frm = new frmLibroRevista();
                    frm.setOpcion("Libro");
                    frm.ShowDialog();
                    string codigo = dataTable.CurrentRow.Cells[0].Value.ToString();
                    frm.setLibro(TListaLibrosRevistas.listaLibros[TListaLibrosRevistas.BuscarLibro(codigo)]);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Libro editado correctamente");
                        Listar();
                    } 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editarRevista()
        {
            try
            {
                if (dataTable.CurrentRow != null)
                {
                    frmLibroRevista frm = new frmLibroRevista();
                    frm.setOpcion("Revista");
                    frm.ShowDialog();
                    string codigo = dataTable.CurrentRow.Cells[0].Value.ToString();
                    frm.setRevista(TListaLibrosRevistas.listaRevistas[TListaLibrosRevistas.BuscarRevista(codigo)]);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        Listar();
                        MessageBox.Show("Revista editada correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarEstudiante()
        {
            try
            {
                if(dataTable.CurrentRow != null)
                {
                    string cedula = dataTable.CurrentRow.Cells[0].Value.ToString();
                    TListaEstudiantes.listaEstudiantes.RemoveAt(TListaEstudiantes.BuscarEstudiante(cedula));
                    Listar();
                    MessageBox.Show("Estudiante eliminado correctamente");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarLibro()
        {
            try
            {
                if(dataTable.CurrentRow != null)
                {
                    string codigo = dataTable.CurrentRow.Cells[0].Value.ToString();
                    TListaLibrosRevistas.listaLibros.RemoveAt(TListaLibrosRevistas.BuscarLibro(codigo));
                    Listar();
                    MessageBox.Show("Libro eliminado correctamente");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarRevista()
        {
            try
            {
                if(dataTable.CurrentRow != null)
                {
                    string codigo = dataTable.CurrentRow.Cells[0].Value.ToString();
                    TListaLibrosRevistas.listaRevistas.RemoveAt(TListaLibrosRevistas.BuscarRevista(codigo));
                    Listar();
                    MessageBox.Show("Revista eliminada correctamente");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Estudiantes")
            {
                eliminarEstudiante();
            }
            else if(comboBox1.SelectedItem.ToString() == "Libros")
            {
                eliminarLibro();
            }
            else if(comboBox1.SelectedItem.ToString() == "Revistas")
            {
                eliminarRevista();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrestamo frm = new frmPrestamo();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmDevolucion frm = new frmDevolucion();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
