using Prueba_Practica.Controlador;
using Prueba_Practica.Entidad;
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
    public partial class frmLibroRevista : Form
    {
        public frmLibroRevista()
        {
            InitializeComponent();
        }

        public string Opcion;
        public bool Editar = false;

        public void setOpcion(string op)
        {
            Opcion = op;
            label1.Text = "Insertar "+op;
        }

        public void setLibro(Libro libro)
        {
            txtTitulo.Text = libro.Titulo;
            txtAutor.Text = libro.Autor;
            txtCodigo.Text = libro.Codigo;
            txtEditorial.Text = libro.Editorial;
            cbCategoria.SelectedItem = libro.Categoria;
            dateTimePicker1.Value = libro.FechaPublicacion;
        }

        public void setRevista(Revista revista)
        {
            txtTitulo.Text = revista.Titulo;
            txtAutor.Text = revista.Autor;
            txtCodigo.Text = revista.Codigo;
            txtEditorial.Text = revista.Editorial;
            cbCategoria.SelectedItem = revista.Categoria;
            dateTimePicker1.Value = revista.FechaPublicacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    if (Opcion == "Libro")
                    {
                        Libro libro = crearLibro();
                        if (Editar)
                        {
                            int index = TListaLibrosRevistas.BuscarLibro(libro.Codigo);
                            TListaLibrosRevistas.EditarLibro(libro, index);
                        }
                        else
                        {
                            TListaLibrosRevistas.AgregarLibro(libro);
                        }                  
                    }
                    else if (Opcion == "Revista")
                    {
                        Revista revista = crearRevista();
                        if (Editar)
                        {
                            int index = TListaLibrosRevistas.BuscarRevista(revista.Codigo);
                            TListaLibrosRevistas.EditarRevista(revista, index);
                        }
                        else
                        {
                            TListaLibrosRevistas.AgregarRevista(revista);
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Libro crearLibro()
        {
            Libro crear = new Libro();
            crear.Titulo = txtTitulo.Text;
            crear.Autor = txtAutor.Text;
            crear.Codigo = txtCodigo.Text;
            crear.Editorial = txtEditorial.Text;
            crear.Categoria = cbCategoria.SelectedItem.ToString();
            crear.FechaPublicacion = dateTimePicker1.Value;
            crear.Prestado = false;
            return crear;
        }

        public Revista crearRevista()
        {
            Revista crear = new Revista();
            crear.Titulo = txtTitulo.Text;
            crear.Autor = txtAutor.Text;
            crear.Codigo = txtCodigo.Text;
            crear.Editorial = txtEditorial.Text;
            crear.Categoria = cbCategoria.SelectedItem.ToString();
            crear.FechaPublicacion = dateTimePicker1.Value;
            crear.Prestado = false;
            return crear;
        }

        private bool validar()
        {
            if(txtTitulo.Text == "")
            {
                MessageBox.Show("Debe ingresar un titulo");
                return false;
            }
            if(txtAutor.Text == "")
            {
                MessageBox.Show("Debe ingresar un autor");
                return false;
            }
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un codigo");
                return false;
            }
            if(txtEditorial.Text == "")
            {
                MessageBox.Show("Debe ingresar una editorial");
                return false;
            }
            if(cbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoria");
                return false;
            }
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Debe seleccionar una fecha");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLibroRevista_Load(object sender, EventArgs e)
        {

        }
    }
}
