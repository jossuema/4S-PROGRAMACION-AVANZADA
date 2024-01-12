using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1HEMI.Entidad
{
    public class Cliente:Persona
    {
        public List<int> AlquileresId { get; set; }

        public Cliente() { }

        public Cliente(string cedula, string nombre, string apellido, DateTime fechaNacimiento, char sexo, string estadoCivil, List<int> alquileres): base(cedula, nombre, apellido, fechaNacimiento, sexo, estadoCivil)
        {
            AlquileresId = alquileres;
        }
    }
}
