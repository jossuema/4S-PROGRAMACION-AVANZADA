using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Prestamo
    {
        public int Id_prestamo { get; set; }
        public int Id_estudiante { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_entrega { get; set; }
        public DateTime Fecha_tentativa { get; set; }
        public DateTime Fecha_devolucion { get; set; }

        public Prestamo()
        {
        }

        public Prestamo(int id_prestamo, int id_estudiante, string estado, DateTime fecha_entrega, DateTime fecha_tentativa, DateTime fecha_devolucion)
        {
            this.Id_prestamo = id_prestamo;
            this.Id_estudiante = id_estudiante;
            this.Estado = estado;
            this.Fecha_entrega = fecha_entrega;
            this.Fecha_tentativa = fecha_tentativa;
            this.Fecha_devolucion = fecha_devolucion;
        }
    }
}
