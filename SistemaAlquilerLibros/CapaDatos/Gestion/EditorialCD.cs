using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class EditorialCD
    {
        public static List<CP_ListarEditorialesResult> ListarEditorialFiltro(string val)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarEditoriales(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar editorial en CD", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static void InsertarEditorial(CapaEntidades.Gestion.Editorial oc)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_InsertarEditorial(oc.Id_editorial, oc.Nombre, oc.Pais);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error insertar editorial en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarEditorial(CapaEntidades.Gestion.Editorial oc)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_ActualizarEditorial(oc.Id_editorial, oc.Nombre, oc.Pais);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error modificar editorial en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarEditorial(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_EliminarEditorial(id);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar editorial en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<CP_BuscarEditorialResult> BuscarEditorial(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_BuscarEditorial(id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error buscar editorial en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
