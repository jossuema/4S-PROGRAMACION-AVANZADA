using EXAMEN_1HEMI.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1HEMI.Controlador
{
    public class TListaSocios
    {
        public static List<Socio> ListaSocios = new List<Socio>();

        public static void AgregarSocio(Socio socio)
        {
            ListaSocios.Add(socio);
        }

        public static List<Socio> ObtenerSocios()
        {
            return ListaSocios;
        }

        public static Socio ObtenerSocio(string cedula)
        {
            foreach (Socio socio in ListaSocios)
            {
                if (socio.Cedula == cedula)
                {
                    return socio;
                }
            }
            return null;
        }

        public static void EliminarSocio(string cedula)
        {
            foreach (Socio socio in ListaSocios)
            {
                if (socio.Cedula == cedula)
                {
                    ListaSocios.Remove(socio);
                    break;
                }
            }
        }

        public static void ModificarSocio(Socio soc, string cedula)
        {
            foreach (Socio socio in ListaSocios)
            {
                if (socio.Cedula == cedula)
                {
                    socio.Cedula = soc.Cedula;
                    socio.Nombre = soc.Nombre;
                    socio.Apellido = soc.Apellido;
                    socio.FechaNacimiento = soc.FechaNacimiento;
                    socio.Sexo = soc.Sexo;
                    socio.EstadoCivil = soc.EstadoCivil;
                    socio.NumeroSocio = soc.NumeroSocio;
                    socio.BarcosMatricula = soc.BarcosMatricula;
                    break;
                }
            }
        }
    }
}
