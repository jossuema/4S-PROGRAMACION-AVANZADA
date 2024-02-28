using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class AutorLibro
    {
        public int IdAutor { get; set; }
        public int IDLibro { get; set; }

        public AutorLibro()
        {
        }

        public AutorLibro(int iDLibro, int idAutor)
        {
            IDLibro = iDLibro;
            IdAutor = idAutor;
        }
    }
}
