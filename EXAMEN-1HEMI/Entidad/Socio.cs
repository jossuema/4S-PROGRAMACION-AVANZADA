using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1HEMI.Entidad
{
    public class Socio:Persona
    {
        public int NumeroSocio { get; set; }
        public List<int> BarcosMatricula { get; set; }

        public Socio() { }

        public Socio(int numeroSocio, string cedula, string nombre, string apellido, DateTime fechaNacimiento, char sexo, string estadoCivil, List<int> barcos): base(cedula, nombre, apellido, fechaNacimiento, sexo, estadoCivil)
        {
            NumeroSocio = numeroSocio;
            BarcosMatricula = barcos;
        }


    }
}
