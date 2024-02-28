using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class PrestamoLibro
    {
        public int id_libro { get; set; }
        public int id_prestamo { get; set; }

        public PrestamoLibro()
        {
        }

        public PrestamoLibro(int id_libro, int id_prestamo)
        {
            this.id_libro = id_libro;
            this.id_prestamo = id_prestamo;
        }
    }
}
