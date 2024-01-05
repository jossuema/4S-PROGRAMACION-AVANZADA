using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PROGRAMACION_AVANZADA.Entidad
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Cliente() { }

        public Cliente(string cedula, string nombre, string apellido, DateTime fechaNacimiento)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
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
