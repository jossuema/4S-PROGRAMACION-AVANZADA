using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Controlador
{
    public class TLista
    {
        public static List<Entidades.Persona> lista = new List<Entidades.Persona>();

        public static void insert(Entidades.Persona obp)
        {
            lista.Add(obp);
        }
    }
}
