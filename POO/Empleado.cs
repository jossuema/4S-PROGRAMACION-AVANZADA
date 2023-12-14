using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Empleado:Persona
    {
        public double Sueldo { get; set; }
        public double Anticipo { get; set; }
        public double Impuesto { get; set;}
        public double IESS { get; set; }
        

        public Empleado()
        :base(){

        }

        public Empleado(int codigo, string cedula, string nombre, string apellido, char genero, DateTime fechaNacimiento, string estado, double sueldo, double anticipo, double impuesto, double iESS)
        :base(codigo, cedula, nombre, apellido, genero, fechaNacimiento, estado){ 
            Sueldo = sueldo;
            Anticipo = anticipo;
            Impuesto = impuesto;
            IESS = iESS;
        }

        public double calcularSueldo()
        {
            double sueldo = Sueldo - Anticipo - Impuesto - IESS;
            return sueldo;
        }

        public double calcularIESS()
        {
            double iess = Sueldo * 0.0945;
            return iess;
        }

        public string imprimirEmpleado()
        {
            return $"Codigo: {Codigo} \nCedula: {Cedula}\nNombre: {Nombre}\nApellido: {Apellido}\nGenero: {Genero}\nFecha de Nacimiento: {FechaNacimiento}\nEstado: {Estado}\nSueldo: {Sueldo}\nAnticipo: {Anticipo}\nImpuesto: {Impuesto}\nIESS: {calcularIESS()}\nSueldo a cobrar: {calcularSueldo()}";
        }
    }
}
