using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3H1_Herencia.Entidades
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(string nombre, string apellido, string cedula, string sexo, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Sexo = sexo;
            FechaNacimiento = fechaNacimiento;
        }

        public Persona()
        {
        }

        public double Bonificaciones
        {
            get
            {
                double cantidad = 0;
                DateTime fechaActual = DateTime.Now;
                if (Edad > 60)
                {
                    cantidad += 50;
                }
                if (fechaActual.Month == FechaNacimiento.Month)
                {
                    cantidad += 100;
                }
                return cantidad;
            }
        }

        public int Edad
        {
            get
            {
                DateTime fechaActual = DateTime.Now;
                int edad = fechaActual.Year - FechaNacimiento.Year;
                if (fechaActual.Month < FechaNacimiento.Month)
                {
                    edad--;
                }
                else if (fechaActual.Month == FechaNacimiento.Month && fechaActual.Day < FechaNacimiento.Day)
                {
                    edad--;
                }
                return edad;
            }
        }

        public abstract double Sueldo();
    }
}
