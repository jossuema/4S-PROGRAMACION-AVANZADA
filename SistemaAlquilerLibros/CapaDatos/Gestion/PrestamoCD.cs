using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class PrestamoCD
    {
        public static List<CP_ListarPrestamosResult> ListarPrestamoFiltro(string val)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarPrestamos(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar prestamo en CD", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static void InsertarPrestamo(CapaEntidades.Gestion.Prestamo op)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_InsertarPrestamo(op.Id_prestamo, op.Estado, op.Fecha_entrega, op.Fecha_tentativa, op.Fecha_devolucion, op.Id_estudiante);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error insertar prestamo en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarPrestamo(CapaEntidades.Gestion.Prestamo op)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_ActualizarPrestamo(op.Id_prestamo, op.Estado, op.Fecha_entrega, op.Fecha_tentativa, op.Fecha_devolucion, op.Id_estudiante);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error modificar prestamo en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarPrestamo(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_EliminarPrestamo(id);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar prestamo en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarPrestamoLibro(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_EliminarPrestamoLibro(id);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar prestamo libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static CP_BuscarPrestamoResult BuscarPrestamo(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_BuscarPrestamo(id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error buscar prestamo en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<CP_ListarPrestamoLibroResult> ListarPrestamoLibro(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarPrestamoLibro(id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar prestamo libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarPrestamoLibro(int id_prestamo, int id_libro)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_InsertarPrestamoLibro(id_prestamo, id_libro);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error insertar prestamo libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<CP_ListarPrestamoLibroResult> ListarPrestamoLibroResults(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarPrestamoLibro(id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar prestamo libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
