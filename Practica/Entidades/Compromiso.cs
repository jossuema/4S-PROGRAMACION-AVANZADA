using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    public class Compromiso
    {
        public string Cedula { get; set; }
        public string Hora { get; set; }
        public string Tipo { get; set; }
        public string Lugar { get; set; }
        public DateTime Fecha { get; set; }

        public Compromiso(string cedula, string hora, string tipo, string lugar, DateTime fecha)
        {
            Cedula = cedula;
            Hora = hora;
            Tipo = tipo;
            Lugar = lugar;
            Fecha = fecha;
        }

        public Compromiso()
        {

        }
    }
}
