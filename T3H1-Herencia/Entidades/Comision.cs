using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3H1_Herencia.Entidades
{
    internal class Comision : Persona
    {
        public double PorcentajeComision { get; set; }
        public double Ventas { get; set; }

        public Comision(string nombre, string apellido, string cedula, string sexo, DateTime fecha, double porcentajeComision, double ventas) : base(nombre, apellido, cedula, sexo, fecha)
        {
            PorcentajeComision = porcentajeComision;
            Ventas = ventas;
        }
        public Comision()
        {
        }

        public override double Sueldo()
        {
            return (PorcentajeComision * Ventas);
        }
    }
}
