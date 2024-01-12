using EXAMEN_1HEMI.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1HEMI.Controlador
{
    public class TListaAlquiler
    {
        public static List<Alquiler> ListaAlquiler = new List<Alquiler>();

        public static void AgregarAlquiler(Alquiler reporte)
        {
            ListaAlquiler.Add(reporte);
        }

        public static List<Alquiler> ObtenerReportes()
        {
            return ListaAlquiler;
        }

        public static Alquiler ObtenerReporte(string cedulaConductor)
        {
            foreach (Alquiler reporte in ListaAlquiler)
            {
                if (reporte.CedulaConductor == cedulaConductor)
                {
                    return reporte;
                }
            }
            return null;
        }

        public static void EliminarReportePorConductor(string cedulaConductor)
        {
            foreach (Alquiler reporte in ListaAlquiler)
            {
                if (reporte.CedulaConductor == cedulaConductor)
                {
                    ListaAlquiler.Remove(reporte);
                }
            }
        }

        public static void EliminarReporte(int id)
        {
            foreach (Alquiler reporte in ListaAlquiler)
            {
                if (reporte.Id == id)
                {
                    ListaAlquiler.Remove(reporte);
                    break;
                }
            }
        }

        public static void ModificarAlquiler(Alquiler reporte, int id)
        {
            foreach (Alquiler reporte1 in ListaAlquiler)
            {
                if (reporte1.Id == id)
                {
                    reporte1.CedulaConductor = reporte.CedulaConductor;
                    reporte1.NumeroMatricula = reporte.NumeroMatricula;
                    reporte1.FechaSalida = reporte.FechaSalida;
                    reporte1.Destino = reporte.Destino;
                    break;
                }
            }
        }

        public static Alquiler getAlquiler(int id)
        {
            foreach (Alquiler reporte in ListaAlquiler)
            {
                if (reporte.Id == id)
                {
                    return reporte;
                }
            }
            return null;
        }

        //LINQ Total, recaudado por alquiler de los barcos a los clientes (no propietarios y no socios)
        public static double TotalRecaudado()
        {
            var sql = ListaAlquiler.Where(a => !TListaSocios.ListaSocios.Any(s => s.Cedula == a.CedulaConductor)).Sum(a => a.CostoAlquiler);
            return sql;
        }

        //LINQ barco con mas viajes
        public static List<IGrouping<int, Alquiler>> BarcoMasViajes()
        {
            var sql = ListaAlquiler.GroupBy(a => a.NumeroMatricula).OrderByDescending(a => a.Count());
            return sql.ToList();
        }
    }
}
