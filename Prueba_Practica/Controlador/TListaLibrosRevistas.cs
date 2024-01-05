using Prueba_Practica.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Practica.Controlador
{
    public class TListaLibrosRevistas
    {
        public static List<Libro> listaLibros = new List<Libro>();
        public static List<Revista> listaRevistas = new List<Revista>();

        public static void AgregarLibro(Libro libro)
        {
            listaLibros.Add(libro);
        }

        public static void AgregarRevista(Revista revista)
        {
            listaRevistas.Add(revista);
        }

        public static void EditarLibro(Libro libro, int index)
        {
            listaLibros[index] = libro;
        }

        public static void EditarRevista(Revista revista, int index)
        {
            listaRevistas[index] = revista;
        }

        public static int BuscarLibro(string codigo)
        {
            int index = -1;
            for (int i = 0; i < listaLibros.Count; i++)
            {
                if (listaLibros[i].Codigo == codigo)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int BuscarRevista(string codigo)
        {
            int index = -1;
            for (int i = 0; i < listaRevistas.Count; i++)
            {
                if (listaRevistas[i].Codigo == codigo)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
