using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesPersonalizadas
{
    public class LibroListar
    {
        public int Id_libro { get; set; }
        public string Estado { get; set; }
        public DateTime Anio_publicacion { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Editorial { get; set; }
        public String Autores { get; set; }

        public LibroListar()
        {
        }

        public LibroListar(int id_libro, string estado, DateTime anio_publicacion, string tipo, string nombre, string categoria, string editorial, string autores)
        {
            this.Id_libro = id_libro;
            this.Estado = estado;
            this.Anio_publicacion = anio_publicacion;
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Editorial = editorial;
            this.Autores = autores;
        }
    }
}
