using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1HEMI.Entidad
{
    public class Barco
    {
        public int NumeroMatricula { get; set; }
        public string Nombre { get; set; }
        public int NumeroAmarre { get; set; }
        public double CuotaMensual { get; set; }
        public string CedulaSocio { get; set; }
        
        public Barco() { }

        public Barco(int numeroMatricula, string nombre, int numeroAmarre, double cuotaMensual, string cedulaSocio)
        {
            NumeroMatricula = numeroMatricula;
            Nombre = nombre;
            NumeroAmarre = numeroAmarre;
            CuotaMensual = cuotaMensual;
            CedulaSocio = cedulaSocio;
        }
    }
}
