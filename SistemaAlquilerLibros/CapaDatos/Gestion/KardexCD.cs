using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class KardexCD
    {
        public static List<CP_ListarKardexResult> ListarKardexFiltro()
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarKardex().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar kardex en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarKardex(CapaEntidades.Gestion.Kardex op)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_InsertarKardex(op.Id_libro, op.Fecha, op.Detalle, op.Entrada, op.Salida, op.Total);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error insertar kardex en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarKardex(CapaEntidades.Gestion.Kardex op)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_ActualizarKardex(op.Id_kardex, op.Id_libro, op.Fecha, op.Detalle, op.Entrada, op.Salida, op.Total);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error modificar kardex en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarKardex(int val)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_EliminarKardex(val);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar kardex en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<CP_BuscarKardexPorLibroResult> ListarKardexLibro(int val)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_BuscarKardexPorLibro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar kardex libro en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static CP_BuscarKardexResult BuscarKardex(int val)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_BuscarKardex(val).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error buscar kardex en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
