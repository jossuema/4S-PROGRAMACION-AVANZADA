using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Practica.Entidad
{
    public class Registro
    {
        public string CedulaEstudiante { get; set; }
        public string CodigoLibro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool Devuelto { get; set; }

        public Registro()
        {
        }

        public Registro(string cedulaEstudiante, string codigoLibro, DateTime fechaPrestamo, DateTime fechaEntrega, bool devuelto)
        {
            CedulaEstudiante = cedulaEstudiante;
            CodigoLibro = codigoLibro;
            FechaPrestamo = fechaPrestamo;
            FechaEntrega = fechaEntrega;
            Devuelto = devuelto;
        }

        public int diasRetraso(DateTime fechaDevolucion)
        {
            int dias = 0;
            DateTime fechaActual = DateTime.Now;
            if (fechaActual > fechaDevolucion)
            {
                dias = (fechaActual - fechaDevolucion).Days;
            }
            return dias;
        }
    }
}
