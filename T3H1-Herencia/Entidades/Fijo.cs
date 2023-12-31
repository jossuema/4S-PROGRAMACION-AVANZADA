using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3H1_Herencia.Entidades
{
    internal class Fijo: Persona
    {
        public double SueldoMensual { get; set; }
        public double Anticipo { get; set; }

        public Fijo(double sueldoMensual, double anticipo)
        {
            SueldoMensual = sueldoMensual;
            Anticipo = anticipo;
        }

        public Fijo(string nombre, string apellido, string cedula, string sexo, DateTime fecha, double sueldoMensual, double anticipo) : base(nombre, apellido, cedula, sexo, fecha)
        {
            SueldoMensual = sueldoMensual;
            Anticipo = anticipo;
        }

        public Fijo()
        {
        }

        public override double Sueldo()
        {
            return SueldoMensual - Anticipo - (SueldoMensual * 0.0932);
        }
    }
}
