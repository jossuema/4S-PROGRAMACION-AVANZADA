using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo.Entidad
{
    public class Asalariado : Empleado
    {
        public double SalarioBase { get; set; }
        public double Bonificacion { get; set; }

        public override double Salario()
        {
            return SalarioBase + Bonificacion - (SalarioBase * 0.0935);
        }

        public Asalariado(){}
        public Asalariado(int codigo, string cedula, string nombre, string apellido, DateTime fechaNacimiento, char sexo, string estadoCivil, double salarioBase, double bonificacion) : base(codigo, cedula, nombre, apellido, fechaNacimiento, sexo, estadoCivil)
        {
            SalarioBase = salarioBase;
            Bonificacion = bonificacion;
        }
    }
}
