using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class PrestamoLibroLN
    {
        public List<CapaEntidades.ClasesPersonalizadas.PrestamoLibroListar> ListarPrestamoLibro()
        {
            List<CapaEntidades.ClasesPersonalizadas.PrestamoLibroListar> lista = new List<CapaEntidades.ClasesPersonalizadas.PrestamoLibroListar>();
            try
            {
                var listaPL = CapaDatos.Gestion.PrestamoLibroCD.ListarPrestamoLibro();
                foreach (var item in listaPL)
                {
                    var libro = CapaDatos.Gestion.LibroCD.BuscarLibro(item.id_libro).FirstOrDefault();
                    var prestamo = CapaDatos.Gestion.PrestamoCD.BuscarPrestamo(item.id_prestamo);

                    var op = new CapaEntidades.ClasesPersonalizadas.PrestamoLibroListar(prestamo.id_prestamo, prestamo.estado, prestamo.fecha_entrega, prestamo.fecha_devolucion, libro.id_libro, libro.estado, libro.nombre, libro.tipo);
                    lista.Add(op);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PrestamoLibroLN: " + ex.Message);
            }
        }

        public void InsertarPrestamoLibro(int idLibro, int idPrestamo)
        {
            try
            {
                CapaDatos.Gestion.PrestamoLibroCD.InsertarPrestamoLibro(idLibro, idPrestamo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PrestamoLibroLN: " + ex.Message);
            }
        }

        public void EliminarPrestamoLibro(int idLibro, int idPrestamo)
        {
            try
            {
                CapaDatos.Gestion.PrestamoLibroCD.EliminarPrestamoLibro(idLibro, idPrestamo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PrestamoLibroLN: " + ex.Message);
            }
        }

        public Dictionary<int, string> ListarPrestamo()
        {
            Dictionary<int, string> lista = new Dictionary<int, string>();
            try
            {
                var prestamos = CapaDatos.Gestion.PrestamoCD.ListarPrestamoFiltro("");
                foreach (var item in prestamos)
                {
                    var estudiante = CapaDatos.Gestion.EstudianteCD.BuscarEstudiante(item.id_estudiante).FirstOrDefault();
                    lista.Add(item.id_prestamo, item.id_prestamo+". "+estudiante.nombre + " " + estudiante.apellido + " Estado:" + estudiante.estado);   
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PrestamoLibroLN: " + ex.Message);
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
    }
}
