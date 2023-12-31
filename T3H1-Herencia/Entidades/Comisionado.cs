using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3H1_Herencia.Entidades
{
    public class Comisionado : Persona
    {
        public double SalarioBase { get; set; }
        public double PorcentajeComision { get; set; }
        public double Ventas { get; set; }

        public Comisionado(double salarioBase, double porcentajeComision, double ventas)
        {
            this.SalarioBase = salarioBase;
            PorcentajeComision = porcentajeComision;
            Ventas = ventas;
        }

        public Comisionado(string nombre, string apellido, string cedula, string sexo, DateTime fecha, double salarioBase, double porcentajeComision, double ventas) : base(nombre, apellido, cedula, sexo, fecha)
        {
            SalarioBase = salarioBase;
            PorcentajeComision = porcentajeComision;
            Ventas = ventas;
        }

        public Comisionado()
        {
        }

        public override double Sueldo()
        {
            return (SalarioBase + (PorcentajeComision * Ventas)) + (SalarioBase * 0.1);
        }
    }
}
