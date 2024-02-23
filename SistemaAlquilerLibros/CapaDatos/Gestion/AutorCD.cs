using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades.Gestion;


namespace CapaDatos.Gestion
{
    public class AutorCD
    {
        public static List<CP_ListarAutoresResult> ListarAutorFiltro(string val)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarAutores(val).ToList();
                }
            } catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar autor en CD",ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void InsertarAutor(CapaEntidades.Gestion.Autor oa)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                   DB.CP_InsertarAutor(oa.Id_autor,oa.Estado,oa.Nombre,oa.Apellido,oa.Sexo,oa.Fecha_nacimiento);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error insertar autor en CD",ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void ModificarAutor(CapaEntidades.Gestion.Autor oa)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_ActualizarAutor(oa.Id_autor, oa.Estado, oa.Nombre, oa.Apellido, oa.Sexo, oa.Fecha_nacimiento);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error modificar autor en CD"+ex.Message+ex.ToString(), ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void EliminarAutor(int oa)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_EliminarAutor(oa);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar autor en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }
        //Buscar autor
        public static List<CP_BuscarAutorResult> BuscarAutor(int val)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_BuscarAutor(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error buscar autor en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }




    }
}
