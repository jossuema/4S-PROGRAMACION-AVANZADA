using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set;}
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }

        public List<Compromiso> Compromisos { get; set; }

        public Persona(string cedula, string nombre, string apellidos, string direccion, string telefono, DateTime fechaNacimiento, string sexo, string estadoCivil)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            Compromisos = new List<Compromiso>();
        }

        public Persona()
        {
            Compromisos = new List<Compromiso>();
        }
    }
}
