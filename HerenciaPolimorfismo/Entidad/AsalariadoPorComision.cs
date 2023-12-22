using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo.Entidad
{
    public class AsalariadoPorComision: Empleado
    {
        public double SalarioBase { get; set; }
        public double Bonificacion { get; set; }
        public double PorcentajeComision { get; set; }
        public double TotalVentas { get; set; }
        public override double Salario()
        {
            return SalarioBase + Bonificacion + (TotalVentas * PorcentajeComision);
        }

        public AsalariadoPorComision()
        {
        }
        public AsalariadoPorComision(int codigo, string cedula, string nombre, string apellido, DateTime fechaNacimiento, char sexo, string estadoCivil, double salarioBase, double bonificacion, double porcentajeComision, double totalVentas) : base(codigo, cedula, nombre, apellido, fechaNacimiento, sexo, estadoCivil)
        {
            SalarioBase = salarioBase;
            Bonificacion = bonificacion;
            PorcentajeComision = porcentajeComision;
            TotalVentas = totalVentas;
        }
    }
}
