using Prueba_Practica.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Practica.Controlador
{
    public class TListaRegistros
    {
        public static List<Registro> lista = new List<Registro>();

        public static void AgregarRegistro(Registro registro)
        {
            lista.Add(registro);
        }

        public static void EliminarRegistro(string cedula, string codigo)
        {
            foreach (var item in lista)
            {
                if(item.CedulaEstudiante == cedula && item.CodigoLibro == codigo)
                {
                    lista.Remove(item);
                }
            }
        }

    }
}
