using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Autor
    {
        private int id_autor;
        private string estado;
        private string nombre;
        private string apellido;
        private char sexo;
        private DateTime fecha_nacimiento;

        public Autor()
        {
        }

        public Autor(int id_autor, string estado, string nombre, string apellido, char sexo, DateTime fecha_nacimiento)
        {
            this.Id_autor = id_autor;
            this.Estado = estado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Fecha_nacimiento = fecha_nacimiento;
        }

        public int Id_autor { get => id_autor; set => id_autor = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
    }
}
