using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class PrestamoCD
    {
        public static List<CapaEntidad.Gestion.Prestamo> ListarPrestamos()
        {
            using(var db = new ContrucamDataContext())
            {
                return (from p in db.Prestamos
                                                                      select new CapaEntidad.Gestion.Prestamo
                                                                      {
                            Codigo = p.codigo,
                            CedulaCliente = p.id_cliente,
                            CodigoMaquinaria = p.id_maquinaria,
                            FechaEntrega = p.fecha_entrega,
                            FechaTentativa = p.fecha_tentativa,
                            FechaDevolucion = p.fecha_devolucion,
                            Estado = p.estado
                        }).ToList();
            }
        }

        public static CapaEntidad.Gestion.Prestamo BuscarPrestamo(int codigo)
        {
            using(var db = new ContrucamDataContext())
            {
                return (from p in db.Prestamos
                                                                                             where p.codigo == codigo
                                                                                                                                                                                                                                        select new CapaEntidad.Gestion.Prestamo
                                                                                                                                                                                                                                        {
                            Codigo = p.codigo,
                            CedulaCliente = p.id_cliente,
                            CodigoMaquinaria = p.id_maquinaria,
                            FechaEntrega = p.fecha_entrega,
                            FechaTentativa = p.fecha_tentativa,
                            FechaDevolucion = p.fecha_devolucion,
                            Estado = p.estado
                        }).FirstOrDefault();
            }
        }

        public static void InsertarPrestamo(CapaEntidad.Gestion.Prestamo prestamo)
        {
            using(var db = new ContrucamDataContext())
            {
                db.Prestamos.InsertOnSubmit(new Prestamo
                {
                    codigo = prestamo.Codigo,
                    id_cliente = prestamo.CedulaCliente,
                    id_maquinaria = prestamo.CodigoMaquinaria,
                    fecha_entrega = prestamo.FechaEntrega,
                    fecha_tentativa = prestamo.FechaTentativa,
                    fecha_devolucion = prestamo.FechaDevolucion,
                    estado = prestamo.Estado
                });
                db.SubmitChanges();
            }
        }

        public static void ActualizarPrestamo(CapaEntidad.Gestion.Prestamo prestamo)
        {
            using(var db = new ContrucamDataContext())
            {
                Prestamo p = db.Prestamos.Single(x => x.codigo == prestamo.Codigo);
                p.codigo = prestamo.Codigo;
                p.id_cliente = prestamo.CedulaCliente;
                p.id_maquinaria = prestamo.CodigoMaquinaria;
                p.fecha_entrega = prestamo.FechaEntrega;
                p.fecha_tentativa = prestamo.FechaTentativa;
                p.fecha_devolucion = prestamo.FechaDevolucion;
                p.estado = prestamo.Estado;
                db.SubmitChanges();
            }
        }

        public static void EliminarPrestamo(int codigo)
        {
            using(var db = new ContrucamDataContext())
            {
                Prestamo p = db.Prestamos.Single(x => x.codigo == codigo);
                db.Prestamos.DeleteOnSubmit(p);
                db.SubmitChanges();
            }
        }

        public static List<CapaEntidad.Gestion.Prestamo> ListarPrestamosAlquilados()
        {
            using(var db = new ContrucamDataContext())
            {
                return (from p in db.Prestamos
                                                                                             where p.estado == "Alquilado"
                                                                                                                                                                  select new CapaEntidad.Gestion.Prestamo
                                                                                                                                                                  {
                            Codigo = p.codigo,
                            CedulaCliente = p.id_cliente,
                            CodigoMaquinaria = p.id_maquinaria,
                            FechaEntrega = p.fecha_entrega,
                            FechaTentativa = p.fecha_tentativa,
                            FechaDevolucion = p.fecha_devolucion,
                            Estado = p.estado
                        }).ToList();
            }
        }
    }
}
