using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PROGRAMACION_AVANZADA.Entidad
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public char Modelo { get; set; }
        public bool Prestado { get; set; }

        public Vehiculo() { }

        public Vehiculo(string placa, string marca, char modelo)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Prestado = false;
        }
    }
}
