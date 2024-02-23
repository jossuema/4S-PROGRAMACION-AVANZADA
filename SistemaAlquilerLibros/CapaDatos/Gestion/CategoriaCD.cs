using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class CategoriaCD
    {
        public static List<CP_ListarCategoriasResult> ListarCategoriaFiltro(string val)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_ListarCategorias(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar categoria en CD", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static void InsertarCategoria(CapaEntidades.Gestion.Categoria oc)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_InsertarCategoria(oc.Id_categoria, oc.Nombre, oc.Descripcion);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error insertar categoria en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarCategoria(CapaEntidades.Gestion.Categoria oc)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_ActualizarCategoria(oc.Id_categoria, oc.Nombre, oc.Descripcion);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error modificar categoria en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarCategoria(int oc)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    DB.CP_EliminarCategoria(oc);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar categoria en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static List<CP_BuscarCategoriaResult> BuscarCategoria(int id)
        {
            BibliotecaDataContext DB = null;
            try
            {
                using (DB = new BibliotecaDataContext())
                {
                    return DB.CP_BuscarCategoria(id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error buscar categoria en CD", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
