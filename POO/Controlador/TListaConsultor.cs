using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Controlador
{
    public class TListaConsultor
    {
        public static List<Consultor> lista = new List<Consultor>();

        public static void Agregar(Consultor consultor)
        {
            lista.Add(consultor);
        }

        public static void Eliminar(Consultor consultor)
        {
            lista.Remove(consultor);
        }

        public static void Modificar(Consultor consultor, int indice)
        {
            lista[indice] = consultor;
        }

        public static int buscarConsultor(int codigo)
        {
            int pos = -1;
            foreach (Consultor consultor in lista)
            {
                if (consultor.Codigo == codigo)
                {
                    pos = lista.IndexOf(consultor);
                    break;
                }
            }
            return pos;
        }

        public static Consultor getConsultor(int pos)
        {
            return lista[pos];
        }
    }
}
