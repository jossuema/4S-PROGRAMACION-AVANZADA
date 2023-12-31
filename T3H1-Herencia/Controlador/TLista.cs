using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3H1_Herencia.Entidades;

namespace T3H1_Herencia.Controlador
{
    public class TLista
    {
        public static List<Persona> ListaPersonas = new List<Persona>();

        public static void Agregar(Persona persona)
        {
            ListaPersonas.Add(persona);
        }

        public static void Eliminar(Persona persona)
        {
            ListaPersonas.Remove(persona);
        }

        public static void Modificar(Persona persona)
        {
            for (int i = 0; i < ListaPersonas.Count; i++)
            {
                if (ListaPersonas[i].Cedula == persona.Cedula)
                {
                    ListaPersonas[i] = persona;
                }
            }
        }
    }
}
