using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PROGRAMACION_AVANZADA.Entidad
{
    public class Tarifa
    {
        public int id { get; set; }
        public char Nombre { get; set; }
        public double Valor { get; set; }

        public Tarifa()
        {
        }

        public Tarifa(int id, char nombre, double valor)
        {
            this.id = id;
            Nombre = nombre;
            Valor = valor;
        }
    }
}
