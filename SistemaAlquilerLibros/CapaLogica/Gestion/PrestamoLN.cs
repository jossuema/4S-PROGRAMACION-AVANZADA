using CapaDatos;
using CapaDatos.Gestion;
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
                List<CP_ListarPrestamosResult> listaPrestamoCD = CapaDatos.Gestion.PrestamoCD.ListarPrestamoFiltro(val);
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
                    var op = new CapaEntidades.ClasesPersonalizadas.PrestamoListar(item.id_prestamo, item.estado, item.fecha_entrega, item.fecha_tentativa, librosPrestamo, estudiante.cedula, estudiante.nombre + " " + estudiante.apellido);
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
                    var libro = LibroCD.BuscarLibro(item).FirstOrDefault();
                    var libroo = new CapaEntidades.Gestion.Libro(libro.id_libro, libro.estado, libro.anio_publicacion, libro.tipo, libro.nombre, libro.id_categoria, libro.id_editorial, libro.stock - 1);
                    LibroCD.ModificarLibro(libroo);
                    PrestamoCD.InsertarPrestamoLibro(op.Id_prestamo, item);
                    var estudiante = EstudianteCD.BuscarEstudiante(op.Id_estudiante).FirstOrDefault();
                    var Kardex = new CapaEntidades.Gestion.Kardex(0, libro.id_libro, DateTime.Now, "Salida de prestamo por prestamo a " + estudiante.nombre + " " + estudiante.apellido, 0, 1, libro.stock - 1);
                    KardexCD.InsertarKardex(Kardex);
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
                    if (item.estado == "Activo")
                    {
                        lista.Add(item.id_estudiante, item.cedula + ", " + item.nombre + " " + item.apellido);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar estudiantes en LN", ex);
            }
        }

        public Dictionary<int, string> ListaEstudiantesPendientes()
        {
            try
            {
                Dictionary<int, string> lista = new Dictionary<int, string>();
                var prestamos = CapaDatos.Gestion.PrestamoCD.ListarPrestamoFiltro("");
                foreach (var item in prestamos)
                {
                    bool ok = true;
                    foreach(var itemm in lista)
                    {
                        if(item.id_estudiante == itemm.Key)
                        {
                            ok = false;
                        }
                    }
                    if (item.estado == "En curso" &&ok)
                    {
                        var estudiante = CapaDatos.Gestion.EstudianteCD.BuscarEstudiante(item.id_estudiante).FirstOrDefault();
                        lista.Add(estudiante.id_estudiante, estudiante.cedula + ", " + estudiante.nombre + " " + estudiante.apellido);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar estudiantes pendientes en LN", ex);
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

        public List<CapaEntidades.ClasesPersonalizadas.Libro4Columnas> Lista4ColumnasLibro()
        {
            try
            {
                List<CapaEntidades.ClasesPersonalizadas.Libro4Columnas> lista = new List<CapaEntidades.ClasesPersonalizadas.Libro4Columnas>();
                List<CP_ListarLibrosResult> listaLibrosCD = CapaDatos.Gestion.LibroCD.ListarLibroFiltro("");
                foreach (CP_ListarLibrosResult item in listaLibrosCD)
                {
                    var op = new CapaEntidades.ClasesPersonalizadas.Libro4Columnas(item.id_libro, item.nombre, item.tipo, item.stock);
                    lista.Add(op);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar 4 columnas libro en LN", ex);
            }
        }

        public List<CapaEntidades.ClasesPersonalizadas.Libro4Columnas> LibrosNoDevueltosEstudiante(int idEstudiante)
        {
            try
            {
                List<CapaEntidades.ClasesPersonalizadas.Libro4Columnas> lista = new List<CapaEntidades.ClasesPersonalizadas.Libro4Columnas>();
                List<int> prestamosID = new List<int>();

                var prestamos = CapaDatos.Gestion.PrestamoCD.ListarPrestamoFiltro("");
                foreach (var item in prestamos)
                {
                    if (item.id_estudiante == idEstudiante && item.estado == "En Curso")
                    {
                        prestamosID.Add(item.id_prestamo);
                    }
                }
                var libros = CapaDatos.Gestion.PrestamoLibroCD.ListarPrestamoLibro();
                foreach (var item in libros)
                {
                    foreach (var item2 in prestamosID)
                    {
                        if (item.id_prestamo == item2)
                        {
                            var libro = CapaDatos.Gestion.LibroCD.BuscarLibro(item.id_libro).FirstOrDefault();
                            var op = new CapaEntidades.ClasesPersonalizadas.Libro4Columnas(libro.id_libro, libro.nombre, libro.tipo, libro.stock);
                            lista.Add(op);
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar libros no devueltos estudiante en LN", ex);
            }
        }

        public void DevolverLibro(int idLibro, int idEstudiante, DateTime fecha)
        {
            try
            {
                var prestamos = PrestamoCD.ListarPrestamoFiltro("");
                foreach (var item in prestamos)
                {
                    if (item.id_estudiante == idEstudiante && item.estado == "En curso")
                    {
                        var libros = CapaDatos.Gestion.PrestamoCD.ListarPrestamoLibro(item.id_prestamo);
                        var estudiante = CapaDatos.Gestion.EstudianteCD.BuscarEstudiante(idEstudiante).FirstOrDefault();
                        var estudiantee = new CapaEntidades.Gestion.Estudiante(estudiante.id_estudiante, estudiante.cedula, estudiante.nombre, estudiante.apellido, estudiante.fecha_nacimiento, estudiante.sexo, estudiante.estado_civil, "Sancionado");
                        if (fecha > item.fecha_tentativa)
                        {
                            CapaDatos.Gestion.EstudianteCD.ModificarEstudiante(estudiantee);
                        }
                        foreach (var item2 in libros)
                        {

                            var prestamo = CapaDatos.Gestion.PrestamoCD.BuscarPrestamo(item.id_prestamo);
                            var prestamoo = new CapaEntidades.Gestion.Prestamo(prestamo.id_prestamo, prestamo.id_estudiante, "Finalizado", prestamo.fecha_entrega, prestamo.fecha_tentativa, fecha);
                            CapaDatos.Gestion.PrestamoCD.ModificarPrestamo(prestamoo);
                            var libro = CapaDatos.Gestion.LibroCD.BuscarLibro(item2.id_libro).FirstOrDefault();
                            var libroo = new CapaEntidades.Gestion.Libro(libro.id_libro, libro.estado, libro.anio_publicacion, libro.tipo, libro.nombre, libro.id_categoria, libro.id_editorial, libro.stock + 1);
                            CapaDatos.Gestion.LibroCD.ModificarLibro(libroo);
                            var kardex = new CapaEntidades.Gestion.Kardex(0, item2.id_libro, DateTime.Now, "Devolucion de libro del estudiante " + estudiantee.Nombre + " " + estudiantee.Apellido, 1, 0, libro.stock + 1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error devolver libro en LN", ex);
            }
        }

        //La cantidad de préstamos realizados de libros y revistas
        public int CantidadPrestamosLibros()
        {
            try
            {
                var prestamos = CapaDatos.Gestion.PrestamoCD.ListarPrestamoFiltro("");
                int cantidadLibros = 0;
                foreach (var item in prestamos)
                {
                    var libros = CapaDatos.Gestion.PrestamoCD.ListarPrestamoLibro(item.id_prestamo);
                    foreach (var item2 in libros)
                    {
                        var libro = CapaDatos.Gestion.LibroCD.BuscarLibro(item2.id_libro).FirstOrDefault();
                        if (libro.tipo == "Libro")
                        {
                            cantidadLibros++;
                        }

                    }
                }
                return cantidadLibros;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error cantidad prestamos en LN", ex);
            }
        }

        public int CantidadPrestamosRevistas()
        {
            try
            {
                var prestamos = CapaDatos.Gestion.PrestamoCD.ListarPrestamoFiltro("");
                int cantidadRevistas = 0;
                foreach (var item in prestamos)
                {
                    var libros = CapaDatos.Gestion.PrestamoCD.ListarPrestamoLibro(item.id_prestamo);
                    foreach (var item2 in libros)
                    {
                        var libro = CapaDatos.Gestion.LibroCD.BuscarLibro(item2.id_libro).FirstOrDefault();
                        if (libro.tipo == "Revista")
                        {
                            cantidadRevistas++;
                        }
                    }
                }
                return cantidadRevistas;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error cantidad prestamos en LN", ex);
            }
        }

        public int cantidadPrestamos()
        {
            try
            {
                var prestamos = CapaDatos.Gestion.PrestamoCD.ListarPrestamoFiltro("");
                return prestamos.Count;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error cantidad prestamos en LN", ex);
            }
        }

        //Porcentaje de préstamos realizados según la categoría de libros
        public string PorcentajePrestamosLibro()
        {
            try
            {
                int totalPrestamos = cantidadPrestamos();
                int cantidadLibros = CantidadPrestamosLibros();
                int porcentaje = (cantidadLibros * 100) / totalPrestamos;
                return porcentaje + "%";
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error porcentaje prestamos categoria en LN", ex);
            }
        }

        public string PorcentajePrestamosRevista()
        {
            try
            {
                int totalPrestamos = cantidadPrestamos();
                int cantidadRevistas = CantidadPrestamosRevistas();
                int porcentaje = (cantidadRevistas * 100) / totalPrestamos;
                return porcentaje + "%";
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error porcentaje prestamos categoria en LN", ex);
            }
        }

        public string cantidadEstudiantesSancionados()
        {
            try
            {
                var estudiantes = CapaDatos.Gestion.EstudianteCD.ListarEstudianteFiltro("");
                int cantidadSancionados = 0;
                foreach (var item in estudiantes)
                {
                    if (item.estado == "Sancionado")
                    {
                        cantidadSancionados++;
                    }
                }
                return cantidadSancionados.ToString() + " estudiantes sancionados";
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error cantidad estudiantes sancionados en LN", ex);
            }
        }

        //total libros prestados de estudiantes hombres
        public int cantidadLibrosPrestadosHombres()
        {
            try
            {
                var prestamos = CapaDatos.Gestion.PrestamoCD.ListarPrestamoFiltro("");
                int cantidadLibros = 0;
                foreach (var item in prestamos)
                {
                    var estudiante = CapaDatos.Gestion.EstudianteCD.BuscarEstudiante(item.id_estudiante).FirstOrDefault();
                    if (estudiante.sexo == 'M')
                    {
                        var libros = CapaDatos.Gestion.PrestamoCD.ListarPrestamoLibro(item.id_prestamo);
                        cantidadLibros += libros.Count;
                    }
                }
                return cantidadLibros;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error cantidad libros prestados hombres en LN", ex);
            }
        }

        //total libros prestados de estudiantes mujeres
        public int cantidadLibrosPrestadosMujeres()
        {
            try
            {
                var prestamos = CapaDatos.Gestion.PrestamoCD.ListarPrestamoFiltro("");
                int cantidadLibros = 0;
                foreach (var item in prestamos)
                {
                    var estudiante = CapaDatos.Gestion.EstudianteCD.BuscarEstudiante(item.id_estudiante).FirstOrDefault();
                    if (estudiante.sexo == 'F')
                    {
                        var libros = CapaDatos.Gestion.PrestamoCD.ListarPrestamoLibro(item.id_prestamo);
                        cantidadLibros += libros.Count;
                    }
                }
                return cantidadLibros;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error cantidad libros prestados mujeres en LN", ex);
            }
        }
    }
}
