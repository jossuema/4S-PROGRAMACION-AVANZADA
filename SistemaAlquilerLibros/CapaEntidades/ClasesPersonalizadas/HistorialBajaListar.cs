using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesPersonalizadas
{
    public class HistorialBajaListar
    {
        public int IdBaja { get; set; }
        public string NombreLibro { get; set; }
        public string EstadoLibro { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Motivo { get; set; }
        public int DecrementoStock { get; set; }

        public HistorialBajaListar()
        {
        }

        public HistorialBajaListar(int idBaja, string nombreLibro, string estadoLibro, DateTime fechaBaja, string motivo, int stock)
        {
            IdBaja = idBaja;
            NombreLibro = nombreLibro;
            EstadoLibro = estadoLibro;
            FechaBaja = fechaBaja;
            Motivo = motivo;
            DecrementoStock = stock;
        }
    }
}
