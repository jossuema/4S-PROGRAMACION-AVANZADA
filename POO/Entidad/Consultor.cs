using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Consultor : Persona
    {
        public double Horas { get; set; }
        public double Costo { get; set; }


        public Consultor(int codigo, string cedula, string nombre, string apellido, char genero, DateTime fechaNacimiento, string estado, double horas, double costo)
        : base(codigo, cedula, nombre, apellido, genero, fechaNacimiento, estado)
        {
            Horas = horas;
            Costo = costo;

        }

        public double calcularSueldo()
        {
            double pago = Horas * Costo;
            return pago;
        }

        public string imprimirConsultor()
        {
            return $"Codigo: {Codigo} \nCedula: {Cedula}\nNombre: {Nombre}\nApellido: {Apellido}\nGenero: {Genero}\nFecha de Nacimiento: {FechaNacimiento}\nEstado: {Estado}\nHoras: {Horas}\nCosto: {Costo}\nSueldo a cobrar: {calcularSueldo()}";

        }
    }
}
