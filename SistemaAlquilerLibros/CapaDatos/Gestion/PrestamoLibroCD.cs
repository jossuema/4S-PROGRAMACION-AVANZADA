using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class PrestamoLibroCD
    {
        public static List<CP_ListarPrestamoLibroResult> ListarPrestamoLibro()
        {
            try
            {
                using (BibliotecaDataContext db = new BibliotecaDataContext())
                {
                    return db.CP_ListarPrestamoLibro(null).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PrestamoLibroCD: " + ex.Message);
            }
        }

        public static void InsertarPrestamoLibro(int idLibro, int idPrestamo)
        {
            try
            {
                using (BibliotecaDataContext db = new BibliotecaDataContext())
                {
                    db.CP_InsertarPrestamoLibro(idPrestamo, idLibro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PrestamoLibroCD: " + ex.Message);
            }
        }

        public static void EliminarPrestamoLibro(int idLibro, int idPrestamo)
        {
            try
            {
                using (BibliotecaDataContext db = new BibliotecaDataContext())
                {
                    db.CP_EliminarPrestamoYLibro(idPrestamo, idLibro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PrestamoLibroCD: " + ex.Message);
            }
        }
    }
}
