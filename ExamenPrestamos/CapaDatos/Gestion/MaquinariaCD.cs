using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class MaquinariaCD
    {
        public static List<CapaEntidad.Gestion.Maquinaria> ListarMaquinarias()
        {
            using(var db = new ContrucamDataContext())
            {
                return (from m in db.Maquinarias
                                               select new CapaEntidad.Gestion.Maquinaria
                                               {
                            Codigo = m.codigo,
                            Tipo = m.tipo,
                            Tarifa = (double) m.tarifa,
                            Disponible = m.disponible
                        }).ToList();
            }
        }

        public static CapaEntidad.Gestion.Maquinaria BuscarMaquinaria(string codigo)
        {
            using(var db = new ContrucamDataContext())
            {
                return (from m in db.Maquinarias
                                                                      where m.codigo == codigo
                                                                                                                                           select new CapaEntidad.Gestion.Maquinaria
                                                                                                                                           {
                            Codigo = m.codigo,
                            Tipo = m.tipo,
                            Tarifa = (double) m.tarifa,
                            Disponible = m.disponible
                        }).FirstOrDefault();
            }
        }

        public static void InsertarMaquinaria(CapaEntidad.Gestion.Maquinaria maquinaria)
        {
            using(var db = new ContrucamDataContext())
            {
                db.Maquinarias.InsertOnSubmit(new Maquinaria
                {
                    codigo = maquinaria.Codigo,
                    tipo = maquinaria.Tipo,
                    tarifa = (decimal) maquinaria.Tarifa,
                    disponible = maquinaria.Disponible

                });
                db.SubmitChanges();
            }
        }

        public static void ActualizarMaquinaria(CapaEntidad.Gestion.Maquinaria maquinaria)
        {
            using(var db = new ContrucamDataContext())
            {
                Maquinaria m = db.Maquinarias.Single(x => x.codigo == maquinaria.Codigo);
                m.tipo = maquinaria.Tipo;
                m.tarifa = (decimal) maquinaria.Tarifa;
                db.SubmitChanges();
            }
        }

        public static void EliminarMaquinaria(string codigo)
        {
            using(var db = new ContrucamDataContext())
            {
                Maquinaria m = db.Maquinarias.Single(x => x.codigo == codigo);
                db.Maquinarias.DeleteOnSubmit(m);
                db.SubmitChanges();
            }
        }

        public static List<CapaEntidad.Gestion.Maquinaria> ListarMaquinariasDisponibles()
        {
            using(var db = new ContrucamDataContext())
            {
                return (from m in db.Maquinarias
                                                                      where m.disponible == true
                                                                                                                    select new CapaEntidad.Gestion.Maquinaria
                                                                                                                    {
                            Codigo = m.codigo,
                            Tipo = m.tipo,
                            Tarifa = (double) m.tarifa,
                            Disponible = m.disponible
                        }).ToList();
            }
        }
    }
}
