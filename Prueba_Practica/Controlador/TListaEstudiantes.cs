using Prueba_Practica.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Practica.Controlador
{
    public class TListaEstudiantes
    {
        public static List<Estudiante> listaEstudiantes = new List<Estudiante>();

        public static void AgregarEstudiante(Estudiante estudiante)
        {
            listaEstudiantes.Add(estudiante);
        }

        public static void EditarEstudiante(Estudiante estudiante, int index)
        {
            listaEstudiantes[index] = estudiante;
        }

        public static int BuscarEstudiante(string cedula)
        {
            int index = -1;
            for (int i = 0; i < listaEstudiantes.Count; i++)
            {
                if (listaEstudiantes[i].Cedula == cedula)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
