using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Estudiante
    {
        public int Id_estudiante { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public char Sexo { get; set; }
        public string Estado_civil { get; set; }
        public string Estado { get; set; }

        public Estudiante()
        {
        }

        public Estudiante(int id_estudiante, string cedula, string nombre, string apellido, DateTime fecha_nacimiento, char sexo, string estado_civil, string estado)
        {
            this.Id_estudiante = id_estudiante;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Sexo = sexo;
            this.Estado_civil = estado_civil;
            this.Estado = estado;
        }
    }
}
