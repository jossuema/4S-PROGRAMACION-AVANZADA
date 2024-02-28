using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesPersonalizadas
{
    public class PrestamoLibroListar
    {
        public int IdPrestamo { get; set; }
        public string EstadoPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int IdLibro { get; set; }
        public string EstadoLibro { get; set; }
        public string NombreLibro { get; set; }
        public string TipoLibro { get; set; }

        public PrestamoLibroListar()
        {
        }

        public PrestamoLibroListar(int idPrestamo, string estadoPrestamo, DateTime fechaPrestamo, DateTime fechaDevolucion, int idLibro, string estadoLibro, string nombreLibro, string tipoLibro)
        {
            IdPrestamo = idPrestamo;
            EstadoPrestamo = estadoPrestamo;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            IdLibro = idLibro;
            EstadoLibro = estadoLibro;
            NombreLibro = nombreLibro;
            TipoLibro = tipoLibro;
        }
    }
}
