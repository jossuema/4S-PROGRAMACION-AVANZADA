using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Categoria
    {
        public int Id_categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Categoria()
        {
        }

        public Categoria(int id_categoria, string nombre, string descripcion)
        {
            this.Id_categoria = id_categoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
    }
}
