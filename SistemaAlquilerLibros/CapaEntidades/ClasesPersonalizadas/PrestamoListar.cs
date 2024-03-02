using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesPersonalizadas
{
    public class PrestamoListar
    {
        public int IdPrestamo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaTentativa { get; set; }
        public string NombreLibro { get; set; }
        public string CedulaEstudiante { get; set; }
        public string NombreEstudiante { get; set; }

        public PrestamoListar()
        {
        }

        public PrestamoListar(int idPrestamo, string estado, DateTime fechaEntrega, DateTime fechaTentativa, string nombreLibro, string cedulaEstudiante, string nombreEstudiante)
        {
            IdPrestamo = idPrestamo;
            Estado = estado;
            FechaEntrega = fechaEntrega;
            FechaTentativa = fechaTentativa;
            NombreLibro = nombreLibro;
            CedulaEstudiante = cedulaEstudiante;
            NombreEstudiante = nombreEstudiante;
        }
    }
}
