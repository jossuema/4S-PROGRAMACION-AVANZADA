using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Kardex
    {
        public int Id_kardex { get; set; }
        public int Id_libro { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public int Entrada { get; set; }
        public int Salida { get; set; }
        public int Total { get; set; }

        public Kardex()
        {
        }

        public Kardex(int id_kardex, int id_libro, DateTime fecha, string detalle, int entrada, int salida, int total)
        {
            Id_kardex = id_kardex;
            Id_libro = id_libro;
            Fecha = fecha;
            Detalle = detalle;
            Entrada = entrada;
            Salida = salida;
            Total = total;
        }
    }
}
