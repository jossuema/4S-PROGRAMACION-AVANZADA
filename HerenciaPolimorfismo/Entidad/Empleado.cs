using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo.Entidad
{
    public abstract class Empleado
    {
        public int Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public string Estado { get; set; }

        public Empleado()
        {
        }

        public Empleado(int codigo, string cedula, string nombre, string apellido, DateTime fechaNacimiento, char sexo, string estadoCivil)
        {
            Codigo = codigo;
            Cedula = cedula;
            Nombres = nombre;
            Apellidos = apellido;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            Estado = estadoCivil;
        }

        abstract public double Salario();

        public override string ToString()
        {
            return $"Codigo: {Codigo}, Cedula: {Cedula}, Nombre: {Nombres}, Apellido: {Apellidos}, FechaNacimiento: {FechaNacimiento}, Sexo: {Sexo}, EstadoCivil: {Estado}";
        }
    }
}
