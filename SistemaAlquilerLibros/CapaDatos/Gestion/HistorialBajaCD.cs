using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class HistorialBajaCD
    {
        public static List<CP_ListarHistorialBajasResult> ListarHistorialBajasResults()
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarHistorialBajas().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar historial bajas en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void DarDeBajaLibro(CapaEntidades.Gestion.HistorialBaja op)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.DarDeBajaLibro(op.IdLibro, op.FechaBaja, op.Motivo, op.DecrementoStock);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error dar de baja libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarHistorialBaja(CapaEntidades.Gestion.HistorialBaja op)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_ActualizarBajaLibro(op.IdBaja, op.IdLibro, op.FechaBaja, op.Motivo, op.DecrementoStock);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error actualizar historial baja en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarHistorialBaja(int op)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_EliminarHistorialBaja(op);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar historial baja en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static CP_BuscarHistorialBajaResult BuscarHistorialBaja(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_BuscarHistorialBaja(id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error buscar historial baja en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
