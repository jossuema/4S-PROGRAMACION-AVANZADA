using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Gestion
{
    public class Maquinaria
    {
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public double Tarifa { get; set; }
        public bool Disponible{ get; set; }

        public Maquinaria(string codigo, string tipo, double tarifa, bool pr)
        {
            Codigo = codigo;
            Tipo = tipo;
            Tarifa = tarifa;
            Disponible = pr;
        }

        public Maquinaria()
        {
        }
    }
}
