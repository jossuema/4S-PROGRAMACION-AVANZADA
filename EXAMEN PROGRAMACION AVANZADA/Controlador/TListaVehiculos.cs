using EXAMEN_PROGRAMACION_AVANZADA.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PROGRAMACION_AVANZADA.Controlador
{
    public class TListaVehiculos
    {
        public static List<Vehiculo> ListaVehiculos = new List<Vehiculo>();

        public static void Agregar(Vehiculo vehiculo)
        {
            ListaVehiculos.Add(vehiculo);
        }

        public static void Eliminar(Vehiculo vehiculo)
        {
            ListaVehiculos.Remove(vehiculo);
        }

        public static void Eliminar(string placa)
        {
            var vehiculo = ListaVehiculos.Where(x => x.Placa == placa).FirstOrDefault();
            ListaVehiculos.Remove(vehiculo);
        }

        public static List<Vehiculo> Lista()
        {
            return ListaVehiculos;
        }

        public static char getVehiculoModelo(string placa)
        {
            foreach (Vehiculo vehiculo in ListaVehiculos)
            {
                if (vehiculo.Placa == placa)
                {
                    return vehiculo.Modelo;
                }
            }
            return ' ';
        }

        public static Vehiculo Buscar(string placa)
        {
            return ListaVehiculos.Where(x => x.Placa == placa).FirstOrDefault();
        }

        public static List<string> Placas()
        {
            return ListaVehiculos.Select(x => x.Placa).ToList();
        }
    }
}
