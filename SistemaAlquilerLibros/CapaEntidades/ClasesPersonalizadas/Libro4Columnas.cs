using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesPersonalizadas
{
    public class Libro4Columnas
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public int Stock { get; set; }

        public Libro4Columnas(int idLibro, string titulo, string tipo, int stock)
        {
            IdLibro = idLibro;
            Titulo = titulo;
            Tipo = tipo;
            Stock = stock;
        }

        public Libro4Columnas()
        {
        }
    }
}
