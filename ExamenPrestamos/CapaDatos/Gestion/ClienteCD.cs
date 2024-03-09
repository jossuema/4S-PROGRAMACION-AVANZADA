using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class ClienteCD
    {
        public static List<CapaEntidad.Gestion.Cliente> ListarClientes()
        {
            using (var db = new ContrucamDataContext())
            {
                return (from c in db.Clientes
                        select new CapaEntidad.Gestion.Cliente
                        {
                            Cedula = c.cedula,
                            Nombre = c.nombre,
                            Apellido = c.apellido,
                            Edad = c.edad,
                            Sexo = c.sexo,
                        }).ToList();
            }
        }

        public static CapaEntidad.Gestion.Cliente BuscarCliente(string cedula)
        {
            using (var db = new ContrucamDataContext())
            {
                return (from c in db.Clientes
                                               where c.cedula == cedula
                                                                      select new CapaEntidad.Gestion.Cliente
                                                                      {
                            Cedula = c.cedula,
                            Nombre = c.nombre,
                            Apellido = c.apellido,
                            Edad = c.edad,
                            Sexo = c.sexo,
                        }).FirstOrDefault();
            }
        }

        public static void InsertarCliente(CapaEntidad.Gestion.Cliente cliente)
        {
            using (var db = new ContrucamDataContext())
            {
                db.Clientes.InsertOnSubmit(new Cliente
                {
                    cedula = cliente.Cedula,
                    nombre = cliente.Nombre,
                    apellido = cliente.Apellido,
                    edad = cliente.Edad,
                    sexo = cliente.Sexo,
                });
                db.SubmitChanges();
            }
        }

        public static void ActualizarCliente(CapaEntidad.Gestion.Cliente cliente)
        {
            using (var db = new ContrucamDataContext())
            {
                var c = db.Clientes.Single(x => x.cedula == cliente.Cedula);
                c.nombre = cliente.Nombre;
                c.apellido = cliente.Apellido;
                c.edad = cliente.Edad;
                c.sexo = cliente.Sexo;
                db.SubmitChanges();
            }
        }

        public static void EliminarCliente(string cedula)
        {
            using (var db = new ContrucamDataContext())
            {
                var c = db.Clientes.Single(x => x.cedula == cedula);
                db.Clientes.DeleteOnSubmit(c);
                db.SubmitChanges();
            }
        }
    }
}
