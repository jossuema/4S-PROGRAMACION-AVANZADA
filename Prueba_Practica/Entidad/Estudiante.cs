using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Practica.Entidad
{
    public class Estudiante
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Sancionado { get; set; }

        public Estudiante()
        {
        }

        public Estudiante(string cedula, string nombre, string apellido, char sexo, DateTime fechaNacimiento, bool sancion)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            FechaNacimiento = fechaNacimiento;
            Sancionado = sancion;
        }

        
    }
}
