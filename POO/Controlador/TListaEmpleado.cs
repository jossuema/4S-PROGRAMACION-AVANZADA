using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Controlador
{
    public class TListaEmpleado
    {
        public static List<Empleado> lista = new List<Empleado>();

        public static void Agregar(Empleado empleado)
        {
            lista.Add(empleado);
        }

        public static void Eliminar(Empleado empleado)
        {
            lista.Remove(empleado);
        }

        public static void Modificar(Empleado empleado, int indice)
        {
            lista[indice] = empleado;
        }

        public static int BuscarEmpleado(int codigo)
        {
            int pos = -1;
            foreach (Empleado empleado in lista)
            {
                if (empleado.Codigo == codigo)
                {
                    pos = lista.IndexOf(empleado);
                    break;
                }
            }
            return pos;
        }

        public static Empleado GetEmpleado(int pos)
        {
            return lista[pos];
        }
    }
}
