using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class LibroCD
    {
        public static List<CP_ListarLibrosResult> ListarLibroFiltro(string val)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarLibros(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void InsertarLibro(CapaEntidades.Gestion.Libro ol)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_InsertarLibro(ol.IdLibro, ol.Estado, ol.Anio_publicacion, ol.Tipo, ol.Nombre, ol.IdCategoria, ol.IdEditorial, ol.Stock);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error insertar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void ModificarLibro(CapaEntidades.Gestion.Libro ol)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_ActualizarLibro(ol.IdLibro, ol.Estado, ol.Anio_publicacion, ol.Tipo, ol.Nombre, ol.IdCategoria, ol.IdEditorial, ol.Stock);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error modificar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void EliminarLibro(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_EliminarLibro(id);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<CP_BuscarLibroResult> BuscarLibro(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_BuscarLibro(id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error buscar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<CP_ListarLibroAutorResult> BuscarLibroAutor(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarLibroAutor(id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error buscar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarLibroAutor(int idLibro, int idAutor)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_InsertarAutorLibro(idAutor, idLibro);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error insertar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarLibroAutor(int idLibro)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_EliminarLibroAutor(idLibro);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarLibroPrestamo(int idLibro)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_EliminarLibroPrestamo(idLibro);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static bool ExisteLibro(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    var libro = DB.CP_BuscarLibro(id).FirstOrDefault();
                    if (libro == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error buscar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<CP_ListarLibrosDisponiblesResult> ListarLibrosDisponibles()
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarLibrosDisponibles().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
