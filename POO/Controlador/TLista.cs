using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace POO.Controlador
{
    public class TLista
    {
        public static List<Persona> lista = new List<Persona>();

        public static void Agregar(Persona p)
        {
            lista.Add(p);
        }

        public static void Eliminar(Persona p)
        {
            lista.Remove(p);
        }

        public static void Modificar(int pos, Persona p)
        {
            lista[pos] = p;
        }

        public static int Buscar(Persona p)
        {
            return lista.IndexOf(p);
        }

        public static int BuscarPersona(int codigo)
        {
            int pos = -1;
            foreach (Persona p in lista)
            {
                if (p.Codigo == codigo)
                {
                    pos = lista.IndexOf(p);
                    break;
                }
            }
            return pos;
        }

        public static Persona getPersona(int pos)
        {
            return lista[pos];
        }

        
    }
}
