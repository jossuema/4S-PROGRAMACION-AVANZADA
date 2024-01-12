using EXAMEN_1HEMI.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1HEMI.Entidad
{
    public class Alquiler
    {
        public int Id { get; set; }
        public string CedulaArrendatario { get; set; }
        public string CedulaConductor { get; set; }
        public int NumeroMatricula { get; set; }
        public DateTime FechaSalida { get; set; }
        
        public string Destino { get; set; }

        public Alquiler() { }

        public Alquiler(int id, string cedulaConductor, int numeroMatricula, DateTime fechaSalida, string destino)
        {
            Id = id;
            CedulaConductor = cedulaConductor;
            NumeroMatricula = numeroMatricula;
            FechaSalida = fechaSalida;
            Destino = destino;
        }

        public double CostoAlquiler
        {
            get
            {
                if(CedulaConductor == TListaBarcos.ObtenerBarco(NumeroMatricula).CedulaSocio)
                {
                    return 0;
                }
                else
                {
                    return Destinos.DiccionarioDestino[Destino];
                }
            }
        }
    }
}
