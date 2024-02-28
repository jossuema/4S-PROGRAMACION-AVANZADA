using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesPersonalizadas
{
    public class AutorLibroListar
    {
        public int IdAutor { get; set; }
        public string NombreAutor { get; set; }
        public string ApellidoAutor { get; set; }
        public int IDLibro { get; set; }
        public string NombreLibro { get; set; }
        public string TipoLibro { get; set; }

        public AutorLibroListar()
        {
        }

        public AutorLibroListar(int idAutor, string nombreAutor, string apellidoAutor, int iDLibro, string nombreLibro, string tipoLibro)
        {
            IdAutor = idAutor;
            NombreAutor = nombreAutor;
            ApellidoAutor = apellidoAutor;
            IDLibro = iDLibro;
            NombreLibro = nombreLibro;
            TipoLibro = tipoLibro;
        }
    }
}
