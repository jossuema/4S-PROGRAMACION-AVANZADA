using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class HistorialBajaLN
    {
        public void DarDeBajaLibro(CapaEntidades.Gestion.HistorialBaja op)
        {
            try
            {
                CapaDatos.Gestion.HistorialBajaCD.DarDeBajaLibro(op);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error dar de baja libro en LN", ex);
            }
        }

        public void ModificarHistorialBaja(CapaEntidades.Gestion.HistorialBaja op)
        {
            try
            {
                CapaDatos.Gestion.HistorialBajaCD.ModificarHistorialBaja(op);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error modificar historial baja en LN", ex);
            }
        }

        public List<CapaEntidades.ClasesPersonalizadas.HistorialBajaListar> historialBajaListar()
        {
            List<CapaEntidades.ClasesPersonalizadas.HistorialBajaListar> lista = new List<CapaEntidades.ClasesPersonalizadas.HistorialBajaListar>();
            try
            {
                var listaHB = CapaDatos.Gestion.HistorialBajaCD.ListarHistorialBajasResults();
                foreach (var item in listaHB)
                {
                    var libro = CapaDatos.Gestion.LibroCD.BuscarLibro(item.id_libro).FirstOrDefault();
                    var op = new CapaEntidades.ClasesPersonalizadas.HistorialBajaListar(item.id_baja, libro.nombre, libro.estado, item.fecha_baja, item.motivo, item.decremento_stock);
                    lista.Add(op);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar historial bajas en LN", ex);
            }
        }

        public void EliminarHistorialBaja(int id)
        {
            try
            {
                CapaDatos.Gestion.HistorialBajaCD.EliminarHistorialBaja(id);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error eliminar historial baja en LN", ex);
            }
        }

        public Dictionary<int, string> ListarLibros()
        {
            Dictionary<int, string> lista = new Dictionary<int, string>();
            try
            {
                var libros = CapaDatos.Gestion.LibroCD.ListarLibroFiltro("");
                foreach (var item in libros)
                {
                    lista.Add(item.id_libro, item.id_libro + ". " + item.nombre + " Estado:" + item.estado);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PrestamoLibroLN: " + ex.Message);
            }
        }

        public CapaEntidades.Gestion.HistorialBaja BuscarHistorialBaja(int id)
        {
            try
            {
                var op = CapaDatos.Gestion.HistorialBajaCD.BuscarHistorialBaja(id);
                return new CapaEntidades.Gestion.HistorialBaja(op.id_baja, op.id_libro, op.fecha_baja, op.motivo, op.decremento_stock);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error buscar historial baja en LN", ex);
            }
        }
    }
}
