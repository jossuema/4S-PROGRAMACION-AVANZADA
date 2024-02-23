using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class PrestamoLN
    {
        public List<CapaEntidades.ClasesPersonalizadas.PrestamoListar> ListarPrestamoFiltro(string val)
        {
            try
            {
                List<CapaEntidades.ClasesPersonalizadas.PrestamoListar> lista = new List<CapaEntidades.ClasesPersonalizadas.PrestamoListar>();
                List<CapaDatos.CP_ListarPrestamosResult> listaPrestamoCD = CapaDatos.Gestion.PrestamoCD.ListarPrestamoFiltro(val);
                foreach (CP_ListarPrestamosResult item in listaPrestamoCD)
                {
                    var estudiante = CapaDatos.Gestion.EstudianteCD.BuscarEstudiante(item.id_estudiante).FirstOrDefault();
                    var libros = CapaDatos.Gestion.PrestamoCD.ListarPrestamoLibro(item.id_prestamo);
                    string librosPrestamo = "";
                    foreach (var item2 in libros)
                    {
                        var libro = CapaDatos.Gestion.LibroCD.BuscarLibro(item2.id_libro).FirstOrDefault();
                        librosPrestamo += libro.nombre + ", ";
                    }
                    var op = new CapaEntidades.ClasesPersonalizadas.PrestamoListar(item.id_prestamo, item.estado, item.fecha_entrega, item.fecha_tentativa, item.fecha_devolucion, librosPrestamo, estudiante.cedula,estudiante.nombre + " " + estudiante.apellido);
                    lista.Add(op);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar prestamo en LN", ex);
            }
        }

        public void InsertarPrestamo(CapaEntidades.Gestion.Prestamo op, List<int> codigosLibros)
        {
            try
            {
                CapaDatos.Gestion.PrestamoCD.InsertarPrestamo(op);
                foreach (var item in codigosLibros)
                {
                    CapaDatos.Gestion.PrestamoCD.InsertarPrestamoLibro(op.Id_prestamo, item);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error insertar prestamo en CD", ex);
            }
        }

        public void ModificarPrestamo(CapaEntidades.Gestion.Prestamo op, List<int> codigosLibros)
        {
            try
            {
                CapaDatos.Gestion.PrestamoCD.ModificarPrestamo(op);
                CapaDatos.Gestion.PrestamoCD.EliminarPrestamoLibro(op.Id_prestamo);
                foreach (var item in codigosLibros)
                {
                    CapaDatos.Gestion.PrestamoCD.InsertarPrestamoLibro(op.Id_prestamo, item);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error modificar prestamo en CD", ex);
            }
        }

        public void EliminarPrestamo(int id)
        {
            try
            {
                CapaDatos.Gestion.PrestamoCD.EliminarPrestamoLibro(id);
                CapaDatos.Gestion.PrestamoCD.EliminarPrestamo(id);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error eliminar prestamo en CD", ex);
            }
        }

        public Dictionary<int, string> ListaLibrosDisponibles()
        {
            try
            {
                Dictionary<int, string> lista = new Dictionary<int, string>();
                List<CapaDatos.CP_ListarLibrosDisponiblesResult> listaLibrosCD = CapaDatos.Gestion.LibroCD.ListarLibrosDisponibles();
                foreach (CP_ListarLibrosDisponiblesResult item in listaLibrosCD)
                {
                    lista.Add(item.id_libro, item.nombre);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar libros disponibles en LN", ex);
            }
        }

        public Dictionary<int, string> ListaEstudiantes()
        {
            try
            {
                Dictionary<int, string> lista = new Dictionary<int, string>();
                List<CapaDatos.CP_ListarEstudiantesResult> listaEstudiantesCD = CapaDatos.Gestion.EstudianteCD.ListarEstudianteFiltro("");
                foreach (CP_ListarEstudiantesResult item in listaEstudiantesCD)
                {
                    lista.Add(item.id_estudiante, item.cedula+", "+item.nombre+" "+item.apellido);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar estudiantes en LN", ex);
            }
        }

        public CapaEntidades.Gestion.Prestamo BuscarPrestamo(int id)
        {
            try
            {
                var prestamo = CapaDatos.Gestion.PrestamoCD.BuscarPrestamo(id);
                if (prestamo != null)
                {
                    return new CapaEntidades.Gestion.Prestamo(prestamo.id_prestamo, prestamo.id_estudiante, prestamo.estado, prestamo.fecha_entrega, prestamo.fecha_tentativa, prestamo.fecha_devolucion);
                }
                else { 
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error buscar prestamo en LN", ex);
            }
        }

        public List<int> ListaPrestamoLibros(int id)
        {
            try
            {
                List<int> lista = new List<int>();
                var libros = CapaDatos.Gestion.PrestamoCD.ListarPrestamoLibro(id);
                foreach (var item in libros)
                {
                    lista.Add(item.id_libro);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar prestamo libros en LN", ex);
            }
        }
    }
}
