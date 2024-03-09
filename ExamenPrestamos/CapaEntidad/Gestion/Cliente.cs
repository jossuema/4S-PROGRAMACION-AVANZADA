using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Gestion
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }

        public Cliente(string cedula, string nombre, string apellido, int edad, char sexo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Sexo = sexo;
        }

        public Cliente()
        {
        }


    }
}
