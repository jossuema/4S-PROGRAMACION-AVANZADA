using CapaDatos;
using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class EstudianteLN
    {
        public List<CapaEntidades.Gestion.Estudiante> ViewEstudianteFiltro(string val)
        {
            List<CapaEntidades.Gestion.Estudiante> ListaEstudiantes = new List<CapaEntidades.Gestion.Estudiante>();
            CapaEntidades.Gestion.Estudiante oe = null;
            try
            {
                List<CP_ListarEstudiantesResult> auxLista = EstudianteCD.ListarEstudianteFiltro(val);
                foreach (CP_ListarEstudiantesResult op in auxLista)
                {
                    oe = new CapaEntidades.Gestion.Estudiante(op.id_estudiante, op.estado, op.nombre, op.apellido, op.fecha_nacimiento, op.sexo, op.estado_civil, op.estado);
                    ListaEstudiantes.Add(oe);
                }
                return ListaEstudiantes;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar estudiante en CD", ex);
            }

        }
    }
}
