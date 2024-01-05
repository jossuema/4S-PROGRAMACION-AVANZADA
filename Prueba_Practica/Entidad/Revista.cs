using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Practica.Entidad
{
    public class Revista
    {
        public string Codigo { get; set; }
        public string Categoria { get; set; }
        public string Editorial { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public bool Prestado { get; set; }

        public Revista()
        {
        }

        public Revista(string codigo, string categoria, string editorial, string titulo, string autor, DateTime fechaPublicacion, bool prestado)
        {
            Codigo = codigo;
            Categoria = categoria;
            Editorial = editorial;
            Titulo = titulo;
            Autor = autor;
            FechaPublicacion = fechaPublicacion;
            Prestado = prestado;
        }
    }
}
