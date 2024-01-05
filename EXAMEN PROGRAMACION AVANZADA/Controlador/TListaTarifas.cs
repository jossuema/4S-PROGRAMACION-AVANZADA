using EXAMEN_PROGRAMACION_AVANZADA.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_PROGRAMACION_AVANZADA.Controlador
{
    public class TListaTarifas
    {
        public static List<Tarifa> ListaTarifas = new List<Tarifa> 
        {
            new Tarifa(1, 'E', 50), 
            new Tarifa(2, 'N', 80),
            new Tarifa(3, 'L', 120),
        };

        public static double getTarifaValor(char nombre)
        {
            foreach (Tarifa tarifa in ListaTarifas)
            {
                if (tarifa.Nombre == nombre)
                {
                    return tarifa.Valor;
                }
            }
            return 0;
        }
    }
}
