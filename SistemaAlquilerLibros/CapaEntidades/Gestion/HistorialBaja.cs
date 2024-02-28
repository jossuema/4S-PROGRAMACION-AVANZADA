using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class HistorialBaja
    {
        public int IdBaja { get; set; }
        public int IdLibro { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Motivo { get; set; }
        public int DecrementoStock { get; set; }

        public HistorialBaja()
        {
        }

        public HistorialBaja(int idBaja, int idLibro, DateTime fechaBaja, string motivo, int stock)
        {
            IdBaja = idBaja;
            IdLibro = idLibro;
            FechaBaja = fechaBaja;
            Motivo = motivo;
            DecrementoStock = stock;
        }
    }
}
