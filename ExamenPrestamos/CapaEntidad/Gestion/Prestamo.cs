using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Gestion
{
    public class Prestamo
    {
        public int Codigo { get; set; }
        public string CedulaCliente { get; set; }
        public string CodigoMaquinaria { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaTentativa { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string Estado { get; set; }

        public Prestamo(int codigo, string cedulaCliente, string codigoMaquinaria, DateTime fechaPrestamo, DateTime fechaTentativa, DateTime fechaDevolucion, string estado)
        {
            Codigo = codigo;
            CedulaCliente = cedulaCliente;
            CodigoMaquinaria = codigoMaquinaria;
            FechaEntrega = fechaPrestamo;
            FechaTentativa = fechaTentativa;
            FechaDevolucion = fechaDevolucion;
            Estado = estado;
        }

        public Prestamo()
        {
        }

    }
}
