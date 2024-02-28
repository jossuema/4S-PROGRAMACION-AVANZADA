using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class AutorLibroLN
    {
        public List<CapaEntidades.ClasesPersonalizadas.AutorLibroListar> ListarAutorLibro()
        {
            List<CapaEntidades.ClasesPersonalizadas.AutorLibroListar> lista = new List<CapaEntidades.ClasesPersonalizadas.AutorLibroListar>();
            CapaEntidades.ClasesPersonalizadas.AutorLibroListar autorLibro = null;
            try
            {

                var listaAL = CapaDatos.Gestion.AutorLibroCD.ListarAutorLibro();
                foreach (var item in listaAL)
                {
                    var Autor = CapaDatos.Gestion.AutorCD.BuscarAutor(item.id_autor).FirstOrDefault();
                    var Libro = CapaDatos.Gestion.LibroCD.BuscarLibro(item.id_libro).FirstOrDefault();
                    autorLibro = new CapaEntidades.ClasesPersonalizadas.AutorLibroListar(Autor.id_autor, Autor.nombre, Autor.apellido, Libro.id_libro, Libro.nombre, Libro.tipo);
                    lista.Add(autorLibro);
                }
                return lista;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroLN: " + ex.Message);
            }
        }

        public void InsertarAutorLibro(int idAutor, int idLibro)
        {
            try
            {
                CapaDatos.Gestion.AutorLibroCD.InsertarAutorLibro(idAutor, idLibro);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroLN: " + ex.Message);
            }
        }

        public void EliminarAutoryLibro(int idAutor, int idLibro)
        {
            try
            {
                CapaDatos.Gestion.AutorLibroCD.EliminarAutoryLibro(idAutor, idLibro);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroLN: " + ex.Message);
            }
        }

        public Dictionary<int, string> ListarAutores()
        {
            Dictionary<int, string> lista = new Dictionary<int, string>();
            try
            {
                var listaAutores = CapaDatos.Gestion.AutorCD.ListarAutorFiltro("");
                foreach (var item in listaAutores)
                {
                    lista.Add(item.id_autor, item.nombre + " " + item.apellido);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroLN: " + ex.Message);
            }
        }

        public Dictionary<int, string> ListarLibros()
        {
            Dictionary<int, string> lista = new Dictionary<int, string>();
            try
            {
                var listaLibros = CapaDatos.Gestion.LibroCD.ListarLibroFiltro("");
                foreach (var item in listaLibros)
                {
                    lista.Add(item.id_libro, item.nombre);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroLN: " + ex.Message);
            }
        }
    }
}
