using EXAMEN_PROGRAMACION_AVANZADA.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PROGRAMACION_AVANZADA.Controlador
{
    public class TListalAlquiler
    {
        public static List<AlquilerVehiculo> ListaAlquiler = new List<AlquilerVehiculo>();

        public static void Agregar(AlquilerVehiculo alquiler)
        {
            ListaAlquiler.Add(alquiler);
        }

        public static void Eliminar(AlquilerVehiculo alquiler)
        {
            ListaAlquiler.Remove(alquiler);
        }

        public static void Eliminar(int id)
        {
            var alquiler = ListaAlquiler.Where(x => x.Id == id).FirstOrDefault();
            ListaAlquiler.Remove(alquiler);
        }

        public static List<AlquilerVehiculo> Lista()
        {
            return ListaAlquiler;
        }

        public static AlquilerVehiculo Buscar(int id)
        {
            return ListaAlquiler.Where(x => x.Id == id).FirstOrDefault();
        }

        public static List<int> Ids()
        {
            return ListaAlquiler.Select(x => x.Id).ToList();
        }
    }
}
