using EXAMEN_1HEMI.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1HEMI.Controlador
{
    internal class TListaBarcos
    {

        public static List<Barco> ListaBarcos = new List<Barco>();

        public static void AgregarBarco(Barco barco)
        {
            ListaBarcos.Add(barco);
        }

        public static List<Barco> ObtenerBarcos()
        {
            return ListaBarcos;
        }

        public static Barco ObtenerBarco(int numeroMatricula)
        {
            foreach (Barco barco in ListaBarcos)
            {
                if (barco.NumeroMatricula == numeroMatricula)
                {
                    return barco;
                }
            }
            return null;
        }

        public static void EliminarBarco(int numeroMatricula)
        {
            foreach (Barco barco in ListaBarcos)
            {
                if (barco.NumeroMatricula == numeroMatricula)
                {
                    ListaBarcos.Remove(barco);
                    break;
                }
            }
        }

        public static void ModificarBarco(Barco bar, int numeroMatricula)
        {
            foreach (Barco barco in ListaBarcos)
            {
                if (barco.NumeroMatricula == numeroMatricula)
                {
                    barco.NumeroMatricula = bar.NumeroMatricula;
                    barco.Nombre = bar.Nombre;
                    barco.NumeroAmarre = bar.NumeroAmarre;
                    barco.CuotaMensual = bar.CuotaMensual;
                    barco.CedulaSocio = bar.CedulaSocio;
                    break;
                }
            }
        }
    }
}
