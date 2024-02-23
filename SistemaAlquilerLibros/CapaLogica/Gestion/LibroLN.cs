using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class LibroLN
    {
        public List<CapaEntidades.ClasesPersonalizadas.LibroListar> ViewLibroFiltro(string val)
        {
            List<CapaEntidades.ClasesPersonalizadas.LibroListar> ListaLibros = new List<CapaEntidades.ClasesPersonalizadas.LibroListar>();
            CapaEntidades.ClasesPersonalizadas.LibroListar ol = null;
            try
            {
                List<CP_ListarLibrosResult> auxLista = CapaDatos.Gestion.LibroCD.ListarLibroFiltro(val);
                foreach (CP_ListarLibrosResult op in auxLista)
                {
                    var categoria = CapaDatos.Gestion.CategoriaCD.BuscarCategoria(op.id_categoria).FirstOrDefault().nombre;
                    var editorial = CapaDatos.Gestion.EditorialCD.BuscarEditorial(op.id_editorial).FirstOrDefault().nombre;
                    var autores = CapaDatos.Gestion.LibroCD.BuscarLibroAutor(op.id_libro);
                    StringBuilder autoresList = new StringBuilder();
                    foreach (var item in autores)
                    {
                        var autor = CapaDatos.Gestion.AutorCD.BuscarAutor(item.id_autor).FirstOrDefault();
                        autoresList.Append(autor.nombre + " " + autor.apellido + ", ");
                    }
                    ol = new CapaEntidades.ClasesPersonalizadas.LibroListar(op.id_libro, op.estado, op.anio_publicacion, op.tipo, op.nombre, categoria, editorial, autoresList.ToString());
                    ListaLibros.Add(ol);
                }
                return ListaLibros;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar libro en CD", ex);
            }
        }

        public Dictionary<int, string> ListaAutoresCB()
        {
            Dictionary<int, string> ListaAutores = new Dictionary<int, string>();
            try
            {
                List<CP_ListarAutoresResult> auxLista = CapaDatos.Gestion.AutorCD.ListarAutorFiltro("");
                foreach (CP_ListarAutoresResult op in auxLista)
                {
                    ListaAutores.Add(op.id_autor, op.nombre + " " + op.apellido);
                }
                return ListaAutores;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar autores en CD", ex);
            }
        }

        public Dictionary<int, string> ListaCategoriasCB()
        {
            Dictionary<int, string> ListaCategorias = new Dictionary<int, string>();
            try
            {
                List<CP_ListarCategoriasResult> auxLista = CapaDatos.Gestion.CategoriaCD.ListarCategoriaFiltro("");
                foreach (CP_ListarCategoriasResult op in auxLista)
                {
                    ListaCategorias.Add(op.id_categoria, op.nombre);
                }
                return ListaCategorias;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar categorias en CD", ex);
            }
        }

        public Dictionary<int, string> ListaEditorialCB()
        {
            Dictionary<int, string> ListaEditorial = new Dictionary<int, string>();
            try
            {
                List<CP_ListarEditorialesResult> auxLista = CapaDatos.Gestion.EditorialCD.ListarEditorialFiltro("");
                foreach (CP_ListarEditorialesResult op in auxLista)
                {
                    ListaEditorial.Add(op.id_editorial, op.nombre);
                }
                return ListaEditorial;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar editoriales en CD", ex);
            }
        }

        public void InsertarLibro(CapaEntidades.Gestion.Libro libro, List<int> autoresClaves)
        {
            try
            {
                CapaDatos.Gestion.LibroCD.InsertarLibro(libro);
                foreach (var item in autoresClaves)
                {
                    CapaDatos.Gestion.LibroCD.InsertarLibroAutor(libro.IdLibro, item);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error insertar libro en CD", ex);
            }
        }

        public void ModificarLibro(CapaEntidades.Gestion.Libro libro, List<int> autoresClaves)
        {
            try
            {
                CapaDatos.Gestion.LibroCD.ModificarLibro(libro);
                CapaDatos.Gestion.LibroCD.EliminarLibroAutor(libro.IdLibro);
                foreach (var item in autoresClaves)
                {
                    CapaDatos.Gestion.LibroCD.InsertarLibroAutor(libro.IdLibro, item);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error modificar libro en CD", ex);
            }
        }


        public void EliminarLibro(int id)
        {
            try
            {
                CapaDatos.Gestion.LibroCD.EliminarLibroPrestamo(id);
                CapaDatos.Gestion.LibroCD.EliminarLibroAutor(id);
                CapaDatos.Gestion.LibroCD.EliminarLibro(id);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error eliminar libro en CD", ex);
            }
        }

        public CapaEntidades.Gestion.Libro BuscarLibro(int id)
        {
            try
            {
                var libro = CapaDatos.Gestion.LibroCD.BuscarLibro(id).FirstOrDefault();
                if (libro == null)
                {
                    throw new LogicaExcepciones("El libro no existe");
                }
                else
                {
                    return new CapaEntidades.Gestion.Libro(libro.id_libro, libro.estado, libro.anio_publicacion, libro.tipo, libro.nombre, libro.id_categoria, libro.id_editorial);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error buscar libro en CD", ex);
            }
        }

        public List<int> AutoresLibro(int id)
        {
            List<int> autores = new List<int>();
            try
            {
                var autoresList = CapaDatos.Gestion.LibroCD.BuscarLibroAutor(id);
                foreach (var item in autoresList)
                {
                    autores.Add(item.id_autor);
                }
                return autores;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error buscar autores en CD", ex);
            }
        }

        public bool ExisteLibro(int id)
        {
            try
            {
                var libro = CapaDatos.Gestion.LibroCD.BuscarLibro(id).FirstOrDefault();
                if (libro == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error buscar libro en CD", ex);
            }
        }
    }
}
