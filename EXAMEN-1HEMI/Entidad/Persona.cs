using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1HEMI.Entidad
{
    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public string EstadoCivil { get; set; }

        public Persona(){}

        public Persona(string cedula, string nombre, string apellido, DateTime fechaNacimiento, char sexo, string estadoCivil)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }

        public int Edad
        {
            get
            {
                int edad = DateTime.Now.Year - FechaNacimiento.Year;
                if (DateTime.Now.Month < FechaNacimiento.Month || (DateTime.Now.Month == FechaNacimiento.Month && DateTime.Now.Day < FechaNacimiento.Day))
                    edad--;
                return edad;
            }
        }
    }
}
