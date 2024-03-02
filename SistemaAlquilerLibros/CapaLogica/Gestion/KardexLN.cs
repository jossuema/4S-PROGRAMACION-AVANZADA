using CapaDatos;
using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class KardexLN
    {
        public List<CapaEntidades.ClasesPersonalizadas.KardexListar> ListarKardex()
        {
            List<CapaEntidades.ClasesPersonalizadas.KardexListar> listaK = new List<CapaEntidades.ClasesPersonalizadas.KardexListar>();
            CapaEntidades.ClasesPersonalizadas.KardexListar ok = null;
            try
            {
                List<CP_ListarKardexResult> auxLista = KardexCD.ListarKardexFiltro();
                foreach (CP_ListarKardexResult op in auxLista)
                {
                    var libro = LibroCD.BuscarLibro(op.id_libro).FirstOrDefault();
                    ok = new CapaEntidades.ClasesPersonalizadas.KardexListar(op.id_kardex, libro.nombre, libro.estado, op.fecha, op.detalle, op.entrada, op.salida, op.total);
                    listaK.Add(ok);
                }
                return listaK;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar kardex en LN", ex);
            }
        }

        public void InsertarKardex(CapaEntidades.Gestion.Kardex op)
        {
            try
            {
                CapaDatos.Gestion.KardexCD.InsertarKardex(op);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error insertar kardex en LN", ex);
            }
        }

        public void ModificarKardex(CapaEntidades.Gestion.Kardex op)
        {
            try
            {
                CapaDatos.Gestion.KardexCD.ModificarKardex(op);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error modificar kardex en LN", ex);
            }
        }

        public void EliminarKardex(int id)
        {
            try
            {
                CapaDatos.Gestion.KardexCD.EliminarKardex(id);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error eliminar kardex en LN", ex);
            }
        }

        public CapaEntidades.Gestion.Kardex BuscarKardex(int id)
        {
            try
            {
                var k = CapaDatos.Gestion.KardexCD.BuscarKardex(id);
                return new CapaEntidades.Gestion.Kardex(k.id_kardex, k.id_libro, k.fecha, k.detalle, k.entrada, k.salida, k.total);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error buscar kardex en LN", ex);
            }
        }

        public List<CapaEntidades.ClasesPersonalizadas.KardexListar> ListarKardexPorLibro(int id)
        {
            List<CapaEntidades.ClasesPersonalizadas.KardexListar> listaK = new List<CapaEntidades.ClasesPersonalizadas.KardexListar>();
            CapaEntidades.ClasesPersonalizadas.KardexListar ok = null;
            try
            {
                List<CP_BuscarKardexPorLibroResult> auxLista = KardexCD.ListarKardexLibro(id);
                foreach (CP_BuscarKardexPorLibroResult op in auxLista)
                {
                    var libro = LibroCD.BuscarLibro(op.id_libro).FirstOrDefault();
                    ok = new CapaEntidades.ClasesPersonalizadas.KardexListar(op.id_kardex, libro.nombre, libro.estado, op.fecha, op.detalle, op.entrada, op.salida, op.total);
                    listaK.Add(ok);
                }
                return listaK;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar kardex por libro en LN", ex);
            }
        }

        public Dictionary<int, string> LibrosCB()
        {
            try
            {
                Dictionary<int, string> lista = new Dictionary<int, string>();
                var libros = LibroCD.ListarLibroFiltro("");
                foreach (var item in libros)
                {
                    lista.Add(item.id_libro, item.nombre);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar libros en LN", ex);
            }
        }

        public int stockLibro(int id)
        {
            try
            {
                return LibroCD.BuscarLibro(id).FirstOrDefault().stock;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error stock libro en LN", ex);
            }
        }
    }
}
