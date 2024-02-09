using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class EstudianteCD
    {
        public static List<CP_ListarEstudiantesResult> ListarEstudianteFiltro(string val)
        {
            BibliotecaDataContext bd = null;
            try
            {
                using (bd = new BibliotecaDataContext())
                {
                    return bd.CP_ListarEstudiantes(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error listar estudiante en CD", ex);
            }
            finally
            {
                bd = null;
            }
        }
        public static void InsertarEstudiante(CapaEntidades.Gestion.Estudiante oe)
        {
            BibliotecaDataContext bd = null;
            try
            {
                using (bd = new BibliotecaDataContext())
                {
                    bd.CP_InsertarEstudiante(oe.Id_estudiante, oe.Cedula, oe.Nombre, oe.Apellido, oe.Fecha_nacimiento, oe.Sexo, oe.Estado_civil, oe.Estado);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error insertar estudiante en CD", ex);
            }
            finally
            {
                bd = null;
            }
        }
        public static void ModificarEstudiante(CapaEntidades.Gestion.Estudiante oe)
        {
            BibliotecaDataContext bd = null;
            try
            {
                using (bd = new BibliotecaDataContext())
                {
                    bd.CP_ActualizarEstudiante(oe.Id_estudiante, oe.Cedula, oe.Nombre, oe.Apellido, oe.Fecha_nacimiento, oe.Sexo, oe.Estado_civil, oe.Estado);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error modificar estudiante en CD", ex);
            }
            finally
            {
                bd = null;
            }
        }
        public static void EliminarEstudiante(int id)
        {
            BibliotecaDataContext bd = null;
            try
            {
                using (bd = new BibliotecaDataContext())
                {
                    bd.CP_EliminarEstudiante(id);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error eliminar estudiante en CD", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
