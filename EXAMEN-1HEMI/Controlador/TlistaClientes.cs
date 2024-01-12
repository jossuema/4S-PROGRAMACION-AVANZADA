using EXAMEN_1HEMI.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1HEMI.Controlador
{
    public class TlistaClientes
    {
        public static List<Cliente> ListaClientes = new List<Cliente>();

        public static void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        public static Cliente ObtenerCliente(string cedula)
        {
            return ListaClientes.Find(c => c.Cedula == cedula);
        }

        public static void EliminarCliente(string Cliente)
        {
            ListaClientes.Remove(ObtenerCliente(Cliente));
        }

        public static void ModificarCliente(string Cliente, Cliente cliente)
        {
            foreach (Cliente c in ListaClientes)
            {
                if (c.Cedula == Cliente)
                {
                    c.Cedula = cliente.Cedula;
                    c.Nombre = cliente.Nombre;
                    c.Apellido = cliente.Apellido;
                    c.FechaNacimiento = cliente.FechaNacimiento;
                    c.Sexo = cliente.Sexo;
                    c.EstadoCivil = cliente.EstadoCivil;
                }
            }
        }

        public static List<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }
    }
}
