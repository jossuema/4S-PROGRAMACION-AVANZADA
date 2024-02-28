using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class AutorLibroCD
    {
        public static List<CP_ListarAutorLibroResult> ListarAutorLibro()
        {
            try
            {
                using (BibliotecaDataContext db = new BibliotecaDataContext())
                {
                    return db.CP_ListarAutorLibro(null).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroCD: " + ex.Message);
            }
        }

        public static List<CP_ListarAutorLibroResult> ListarAutorLibro(int id)
        {
            try
            {
                using (BibliotecaDataContext db = new BibliotecaDataContext())
                {
                    return db.CP_ListarAutorLibro(id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroCD: " + ex.Message);
            }
        }

        public static void InsertarAutorLibro(int idAutor, int idLibro)
        {
            try
            {
                using (BibliotecaDataContext db = new BibliotecaDataContext())
                {
                    db.CP_InsertarAutorLibro(idAutor, idLibro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroCD: " + ex.Message);
            }
        }

        public static void EliminarAutoryLibro(int idAutor, int idLibro)
        {
            try
            {
                using (BibliotecaDataContext db = new BibliotecaDataContext())
                {
                    db.CP_EliminarAutoryLibro(idAutor, idLibro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroCD: " + ex.Message);
            }
        }

        public static void EliminarAutorLibro(int idLibro)
        {
            try
            {
                using (BibliotecaDataContext db = new BibliotecaDataContext())
                {
                    db.CP_EliminarAutorLibro(idLibro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroCD: " + ex.Message);
            }
        }

        public static void EliminarLibroAutor(int idAutor)
        {
            try
            {
                using (BibliotecaDataContext db = new BibliotecaDataContext())
                {
                    db.CP_EliminarLibroAutor(idAutor);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AutorLibroCD: " + ex.Message);
            }
        }
    }
}
