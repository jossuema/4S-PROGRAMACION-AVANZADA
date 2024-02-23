using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Editorial
    {
        public int Id_editorial { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }

        public Editorial()
        {
        }

        public Editorial(int id_editorial, string nombre, string pais)
        {
            this.Id_editorial = id_editorial;
            this.Nombre = nombre;
            this.Pais = pais;
        }
    }
}
