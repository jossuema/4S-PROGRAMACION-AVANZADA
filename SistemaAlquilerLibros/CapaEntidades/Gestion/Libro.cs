using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Estado { get; set; }
        public DateTime Anio_publicacion { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public int IdCategoria { get; set; }
        public int IdEditorial { get; set; }

        public Libro()
        {
        }

        public Libro(int idLibro, string estado, DateTime anio_publicacion, string tipo, string nombre, int idCategoria, int idEditorial)
        {
            IdLibro = idLibro;
            Estado = estado;
            Anio_publicacion = anio_publicacion;
            Tipo = tipo;
            Nombre = nombre;
            IdCategoria = idCategoria;
            IdEditorial = idEditorial;
        }
    }
}
