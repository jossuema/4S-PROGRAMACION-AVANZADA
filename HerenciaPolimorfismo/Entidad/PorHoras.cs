using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo.Entidad
{
    public class PorHoras : Empleado
    {
        public double ValorHora { get; set; }
        public double HorasTrabajadas { get; set; }

        public override double Salario()
        {
            double Salario = ValorHora * HorasTrabajadas;
            if(HorasTrabajadas > 40)
            {
                Salario += (HorasTrabajadas - 40) * ValorHora * 0.5;
            }
            return Salario;
        }

        public PorHoras()
        {
        }

        public PorHoras(int codigo, string cedula, string nombre, string apellido, DateTime fechaNacimiento, char sexo, string estadoCivil, double valorHora, double horasTrabajadas) : base(codigo, cedula, nombre, apellido, fechaNacimiento, sexo, estadoCivil)
        {
            ValorHora = valorHora;
            HorasTrabajadas = horasTrabajadas;
        }
    }
}
