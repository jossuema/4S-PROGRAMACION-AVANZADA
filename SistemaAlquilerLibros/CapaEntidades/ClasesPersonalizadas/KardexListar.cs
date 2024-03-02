using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesPersonalizadas
{
    public class KardexListar
    {
        public int IdKardex { get; set; }
        public string NombreLibro { get; set; }
        public string EstadoLibro { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public int Entrada { get; set; }
        public int Salida { get; set; }
        public int Total { get; set; }

        public KardexListar()
        {
        }

        public KardexListar(int idKardex, string nombreLibro, string estadoLibro, DateTime fecha, string detalle, int entrada, int salida, int total)
        {
            IdKardex = idKardex;
            NombreLibro = nombreLibro;
            EstadoLibro = estadoLibro;
            Fecha = fecha;
            Detalle = detalle;
            Entrada = entrada;
            Salida = salida;
            Total = total;
        }
    }
}
