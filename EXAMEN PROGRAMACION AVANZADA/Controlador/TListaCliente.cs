using EXAMEN_PROGRAMACION_AVANZADA.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PROGRAMACION_AVANZADA.Controlador
{
    public class TListaCliente
    {
        public static List<Cliente> ListaClientes = new List<Cliente>();

        public static void Agregar(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        public static void Eliminar(Cliente cliente)
        {
            ListaClientes.Remove(cliente);
        }

        public static void Eliminar(string cedula)
        {
            var cliente = ListaClientes.Where(x => x.Cedula == cedula).FirstOrDefault();
            ListaClientes.Remove(cliente);
        }

        public static List<Cliente> Lista()
        {
            return ListaClientes;
        }

        public static List<string> Cedulas()
        {
            return ListaClientes.Select(x => x.Cedula).ToList();
        }

        public static Cliente Buscar(string cedula)
        {
            return ListaClientes.Where(x => x.Cedula == cedula).FirstOrDefault();
        }
    }
}
