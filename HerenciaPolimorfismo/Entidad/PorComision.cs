using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo.Entidad
{
    public class PorComision : Empleado
    {
        public double PorcentajeComision { get; set; }
        public double TotalVentas { get; set; }

        public override double Salario()
        {
            return TotalVentas * PorcentajeComision;
        }
        public PorComision()
        {
        }
        public PorComision(int codigo, string cedula, string nombre, string apellido, DateTime fechaNacimiento, char sexo, string estadoCivil, double porcentajeComision, double totalVentas) : base(codigo, cedula, nombre, apellido, fechaNacimiento, sexo, estadoCivil)
        {
            PorcentajeComision = porcentajeComision;
            TotalVentas = totalVentas;
        }
    }
}
