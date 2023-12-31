using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3H1_Herencia.Entidades
{
    public class Contratado: Persona
    {
        public double SueldoHora { get; set; }
        public int HorasTrabajadas { get; set; }

        public Contratado(double sueldoHora, int horasTrabajadas)
        {
            SueldoHora = sueldoHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public Contratado(string nombre, string apellido, string cedula, string sexo, DateTime fecha, double sueldoHora, int horasTrabajadas) : base(nombre, apellido, cedula, sexo, fecha)
        {
            SueldoHora = sueldoHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public Contratado()
        {
        }

        public override double Sueldo()
        {
            double sueldo = HorasTrabajadas * SueldoHora;
            if (HorasTrabajadas > 160)
            {
                sueldo += sueldo * 0.0932;
            }
            return sueldo;
        }
    }
}
